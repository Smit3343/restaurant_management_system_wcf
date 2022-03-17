using Restaurant_Management.EncryptDecrypt;
using Restaurant_Management.models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;

namespace Restaurant_Management
{
    public class UserInitializer : DropCreateDatabaseAlways<AppDbContext>
    {
        protected override void Seed(AppDbContext context)
        {
            User user = new User()
            {
                Id = 1,
                Name = "admin",
                Email = "admin@gmail.com",
                Password = Hash.Get("admin" + "eght", Hash.DefaultHashType, Hash.DefaultEncoding),
                Role="admin",
                Salt="eght"
            };
            context.Users.Add(user);
            context.SaveChanges();
            string imagePath = Directory.GetCurrentDirectory() + @"/images/";
            if (!Directory.Exists(imagePath))
            {
                Directory.CreateDirectory(imagePath);
            }
            base.Seed(context);
        }
    }
}