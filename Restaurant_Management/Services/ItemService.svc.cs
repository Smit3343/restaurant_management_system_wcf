using Restaurant_Management.Dto;
using Restaurant_Management.models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web;

namespace Restaurant_Management.Services
{
    public class ItemService : IItemService
    {
        string path = @"D:\document\project\Restaurant Management\Restaurant_Management\Restaurant_Management\images";
        public int AddItem(Item item)
        {
            AppDbContext dbContext = new AppDbContext();
            try
            {
                Item item1=dbContext.Items.Add(item);
                dbContext.SaveChanges();
                return item1.Id;
            }
            catch (System.Data.Entity.Validation.DbEntityValidationException dbEx)
            {
                Exception raise = dbEx;
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        string message = string.Format("{0}:{1}",
                            validationErrors.Entry.Entity.ToString(),
                            validationError.ErrorMessage);
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }

        public void DeleteItem(int id)
        {
            AppDbContext dbContext = new AppDbContext();
            Item item = dbContext.Items.Where<Item>(i => i.Id == id).FirstOrDefault();
            if(item!=null)
            {
                dbContext.Items.Remove(item);
                dbContext.SaveChanges();
            }
            else
            {
                Exception exception = new Exception("entered id of item is not found");
                throw exception;
            }
        }

        public Item GetItem(int id)
        {
            AppDbContext dbContext = new AppDbContext();
            Item item=dbContext.Items.Where<Item>(i => i.Id == id).FirstOrDefault();
            if(item!=null)
            {
                return item;
            }
            else
            {
                Exception exception = new Exception("entered id of item is not found");
                throw exception;
            }
        }

        public IEnumerable<Item> getItemBycategory(string category)
        {
            AppDbContext dbContext = new AppDbContext();
            List<Item> items=dbContext.Items.Where(i => i.Category.Equals(category, StringComparison.CurrentCultureIgnoreCase)).ToList();
            if(items!=null)
            {
                return items;
            }
            else
            {
                Exception exception = new Exception("entered category of item is not found");
                throw exception;
            }
        }

        public byte[] getItemPhoto(string fileName)
        {
            FileStream fileStream = null;
            BinaryReader reader = null;
            string imagePath;
            byte[] imageBytes;
            try
            {
                imagePath = String.Format(@"{0}\{1}", path, fileName);
                if (File.Exists(imagePath))
                {
                    fileStream = new FileStream(imagePath, FileMode.Open, FileAccess.Read);
                    reader = new BinaryReader(fileStream);

                    imageBytes = reader.ReadBytes((int)fileStream.Length);
                    return imageBytes;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public IEnumerable<Item> GetItems()
        {
            List<Item> items;
            AppDbContext dbContext = new AppDbContext();
            items = dbContext.Items.ToList<Item>();
            return items;
        }


        public void UpdateItem(Item item)
        {
            AppDbContext dbContext = new AppDbContext();
            Item item1=dbContext.Items.Where<Item>(i => i.Id == item.Id).FirstOrDefault();
            if (item1 != null)
            {
                item1.Name = item.Name;
                item1.Price = item.Price;
                item1.Category = item.Category;
                item1.Description = item.Description;
                dbContext.SaveChanges();
            }
            else
            {
                Exception exception = new Exception("entered item details is not found");
                throw exception;
            }
            
        }

        public void UploadImage(ItemImageDto imageDto)
        {
            FileStream fileStream = null;
            BinaryWriter writer = null;
            string filePath;

            AppDbContext dbContext = new AppDbContext();
            try
            {
                Item item = dbContext.Items.Where(i => i.Id == imageDto.Id).FirstOrDefault();
                if(item==null)
                {
                    Exception exception = new Exception("entered id of item is not found");
                    throw exception;
                }
                string fileName = Guid.NewGuid().ToString()+".jpeg";
                filePath = String.Format(@"{0}\{1}", path, fileName);
                item.ImagePath = fileName;
                dbContext.SaveChanges();
                fileStream = File.Open(filePath, FileMode.Create);
                writer = new BinaryWriter(fileStream);
                writer.Write(imageDto.Image);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                if (fileStream != null)
                    fileStream.Close();
                if (writer != null)
                    writer.Close();
            }
        }

    }
}
