using Restaurant_Management.Dto;
using Restaurant_Management.EncryptDecrypt;
using Restaurant_Management.interfaces;
using Restaurant_Management.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Restaurant_Management.Validators
{
    public class DatabaseCredentialsValidator : ICredentialsValidator
    {
        private readonly AppDbContext _context;
        public DatabaseCredentialsValidator(AppDbContext context)
        {
            _context = context;
        }
        public bool IsValid(Credentials cred)
        {
            User user= _context.Users.SingleOrDefault(x => x.Email.Equals(cred.Email, StringComparison.CurrentCultureIgnoreCase));
            return user != null && Hash.Compare(cred.Password, user.Salt, user.Password,
                Hash.DefaultHashType, Hash.DefaultEncoding);
        }
    }
}