using Restaurant_Management.Dto;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Services
{
    [ServiceContract]
    interface IItemService
    {
        [OperationContract]
        int AddItem(Item item);
        [OperationContract]
        void DeleteItem(int id);
        [OperationContract]
        Item GetItem(int id);
        [OperationContract]
        IEnumerable<Item> GetItems();
        [OperationContract]
        void UpdateItem(Item item);
        [OperationContract]
        byte[] getItemPhoto(string fileName);
        [OperationContract]
        void UploadImage(ItemImageDto imageDto);
        [OperationContract]
        IEnumerable<Item> getItemBycategory(string category);
    }
}
