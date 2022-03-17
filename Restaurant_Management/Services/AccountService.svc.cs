using Restaurant_Management.Dto;
using Restaurant_Management.EncryptDecrypt;
using Restaurant_Management.interfaces;
using Restaurant_Management.models;
using Restaurant_Management.Validators;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Security.Authentication;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.ServiceModel.Web;
using System.Text;

namespace Restaurant_Management.Services
{
    public class AccountService : IAccountService
    {
        public void DeleteUser(int id)
        {
            AppDbContext context = new AppDbContext();
            User user=context.Users.Where(u => u.Id == id).FirstOrDefault();
            if (user != null)
            {
                context.Users.Remove(user);
                context.SaveChanges();
            }
            else
            {
                Exception exception = new Exception("entered id of user is not found");
                throw exception;
            }
        }

        public UserDto getUser(string email)
        {
            try
            {
                AppDbContext context = new AppDbContext();
                User user=context.Users.Where(u => u.Email==email).FirstOrDefault();
                UserDto userDto = new UserDto
                {
                    Email = user.Email,
                    Role = user.Role
                };
                return userDto;
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
                throw e;
            }
        }

        public UserDto GetUserById(int id)
        {
            AppDbContext context = new AppDbContext();
            User user=context.Users.Where(u => u.Id == id).FirstOrDefault();
            if (user != null)
            {
                UserDto userDto = new UserDto
                {
                    Id = user.Id,
                    Name = user.Name,
                    Email = user.Email,
                    Role = user.Role
                };
                return userDto;
            }
            else
            {
                Exception exception = new Exception("entered id of user is not found");
                throw exception;
            }
        }

        public UserDto GetUserByToken(string token)
        {
            try
            {
                AppDbContext context = new AppDbContext();
                DatabaseTokenValidator tokenValidator = new DatabaseTokenValidator(context);
                if(tokenValidator.IsValid(token))
                {
                    User user=context.Tokens.Where(t => t.SecureToken == token).FirstOrDefault().User;
                    UserDto userDto = new UserDto
                    {
                        Id=user.Id,
                        Email = user.Email,
                        Role = user.Role
                    };
                    return userDto;
                }
                throw new InvalidCredentialException("Invalid token");
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public IEnumerable<UserDto> GetUsers()
        {
            List<User> users;
            AppDbContext context = new AppDbContext();
            users = context.Users.ToList();
            List<UserDto>  userDtos = users
                            .Select(x => new UserDto() { Id = x.Id,Email=x.Email,Role=x.Role,Name=x.Name })
                            .ToList();
            return userDtos;

        }

        public bool isValidToken(string token)
        {
            AppDbContext dbContext = new AppDbContext();
            DatabaseTokenValidator tokenValidator = new DatabaseTokenValidator(dbContext);
            return tokenValidator.IsValid(token);

        }

        public string Login(Credentials creds)
        {
            try
            {
                AppDbContext context = new AppDbContext();
                ICredentialsValidator validator = new DatabaseCredentialsValidator(context);
                if(validator.IsValid(creds))
                {
                    return new DatabaseTokenBuilder(context).Build(creds);
                }
                throw new InvalidCredentialException("Invalid credentials");
            }
            catch(Exception e)
            {
                throw e;
            }
            
        }
        public bool Register(User user)
        {
            try
            {
                AppDbContext context = new AppDbContext();
                user.Salt = "dgsje";
                user.Role = "customer";
                user.Password = Hash.Get(user.Password + user.Salt, Hash.DefaultHashType, Hash.DefaultEncoding);
                context.Users.Add(user);
                context.SaveChanges();
                return true;
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
                        // raise a new exception nesting
                        // the current instance as InnerException
                        raise = new InvalidOperationException(message, raise);
                    }
                }
                throw raise;
            }
        }

        public void UpdateUser(UserDto user)
        {
            AppDbContext context = new AppDbContext();
            User user1 = context.Users.Where(u => u.Id == user.Id).FirstOrDefault();
            if(user1!=null)
            {
                user1.Email = user.Email;
                user1.Role = user.Role;
                user1.Name = user.Name;
                context.SaveChanges();
            }
            else
            {
                Exception exception = new Exception("entered user details is not found");
                throw exception;
            }
        }
    }
}
