using Restaurant_Management.Dto;
using Restaurant_Management.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.Services
{
    [ServiceContract]
    interface IAccountService
    {
        [OperationContract]
        string Login(Credentials creds);
        [OperationContract]
        bool Register(User user);
        [OperationContract]
        UserDto getUser(string email);
        [OperationContract]
        UserDto GetUserByToken(string token);
        [OperationContract]
        bool isValidToken(string token);
        [OperationContract]
        IEnumerable<UserDto> GetUsers();
        [OperationContract]
        void UpdateUser(UserDto user);
        [OperationContract]
        void DeleteUser(int id);
        [OperationContract]
        UserDto GetUserById(int id);

     }
}
