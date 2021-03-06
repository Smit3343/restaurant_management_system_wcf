//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant_Management_Client.AccountServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="AccountServiceReference.IAccountService")]
    public interface IAccountService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/Login", ReplyAction="http://tempuri.org/IAccountService/LoginResponse")]
        string Login(Restaurant_Management.models.Credentials creds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/Login", ReplyAction="http://tempuri.org/IAccountService/LoginResponse")]
        System.Threading.Tasks.Task<string> LoginAsync(Restaurant_Management.models.Credentials creds);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/Register", ReplyAction="http://tempuri.org/IAccountService/RegisterResponse")]
        bool Register(Restaurant_Management.models.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/Register", ReplyAction="http://tempuri.org/IAccountService/RegisterResponse")]
        System.Threading.Tasks.Task<bool> RegisterAsync(Restaurant_Management.models.User user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/getUser", ReplyAction="http://tempuri.org/IAccountService/getUserResponse")]
        Restaurant_Management.Dto.UserDto getUser(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/getUser", ReplyAction="http://tempuri.org/IAccountService/getUserResponse")]
        System.Threading.Tasks.Task<Restaurant_Management.Dto.UserDto> getUserAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetUserByToken", ReplyAction="http://tempuri.org/IAccountService/GetUserByTokenResponse")]
        Restaurant_Management.Dto.UserDto GetUserByToken(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetUserByToken", ReplyAction="http://tempuri.org/IAccountService/GetUserByTokenResponse")]
        System.Threading.Tasks.Task<Restaurant_Management.Dto.UserDto> GetUserByTokenAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/isValidToken", ReplyAction="http://tempuri.org/IAccountService/isValidTokenResponse")]
        bool isValidToken(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/isValidToken", ReplyAction="http://tempuri.org/IAccountService/isValidTokenResponse")]
        System.Threading.Tasks.Task<bool> isValidTokenAsync(string token);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetUsers", ReplyAction="http://tempuri.org/IAccountService/GetUsersResponse")]
        Restaurant_Management.Dto.UserDto[] GetUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetUsers", ReplyAction="http://tempuri.org/IAccountService/GetUsersResponse")]
        System.Threading.Tasks.Task<Restaurant_Management.Dto.UserDto[]> GetUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/UpdateUser", ReplyAction="http://tempuri.org/IAccountService/UpdateUserResponse")]
        void UpdateUser(Restaurant_Management.Dto.UserDto user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/UpdateUser", ReplyAction="http://tempuri.org/IAccountService/UpdateUserResponse")]
        System.Threading.Tasks.Task UpdateUserAsync(Restaurant_Management.Dto.UserDto user);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/DeleteUser", ReplyAction="http://tempuri.org/IAccountService/DeleteUserResponse")]
        void DeleteUser(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/DeleteUser", ReplyAction="http://tempuri.org/IAccountService/DeleteUserResponse")]
        System.Threading.Tasks.Task DeleteUserAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetUserById", ReplyAction="http://tempuri.org/IAccountService/GetUserByIdResponse")]
        Restaurant_Management.Dto.UserDto GetUserById(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IAccountService/GetUserById", ReplyAction="http://tempuri.org/IAccountService/GetUserByIdResponse")]
        System.Threading.Tasks.Task<Restaurant_Management.Dto.UserDto> GetUserByIdAsync(int id);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IAccountServiceChannel : Restaurant_Management_Client.AccountServiceReference.IAccountService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class AccountServiceClient : System.ServiceModel.ClientBase<Restaurant_Management_Client.AccountServiceReference.IAccountService>, Restaurant_Management_Client.AccountServiceReference.IAccountService {
        
        public AccountServiceClient() {
        }
        
        public AccountServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AccountServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string Login(Restaurant_Management.models.Credentials creds) {
            return base.Channel.Login(creds);
        }
        
        public System.Threading.Tasks.Task<string> LoginAsync(Restaurant_Management.models.Credentials creds) {
            return base.Channel.LoginAsync(creds);
        }
        
        public bool Register(Restaurant_Management.models.User user) {
            return base.Channel.Register(user);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterAsync(Restaurant_Management.models.User user) {
            return base.Channel.RegisterAsync(user);
        }
        
        public Restaurant_Management.Dto.UserDto getUser(string email) {
            return base.Channel.getUser(email);
        }
        
        public System.Threading.Tasks.Task<Restaurant_Management.Dto.UserDto> getUserAsync(string email) {
            return base.Channel.getUserAsync(email);
        }
        
        public Restaurant_Management.Dto.UserDto GetUserByToken(string token) {
            return base.Channel.GetUserByToken(token);
        }
        
        public System.Threading.Tasks.Task<Restaurant_Management.Dto.UserDto> GetUserByTokenAsync(string token) {
            return base.Channel.GetUserByTokenAsync(token);
        }
        
        public bool isValidToken(string token) {
            return base.Channel.isValidToken(token);
        }
        
        public System.Threading.Tasks.Task<bool> isValidTokenAsync(string token) {
            return base.Channel.isValidTokenAsync(token);
        }
        
        public Restaurant_Management.Dto.UserDto[] GetUsers() {
            return base.Channel.GetUsers();
        }
        
        public System.Threading.Tasks.Task<Restaurant_Management.Dto.UserDto[]> GetUsersAsync() {
            return base.Channel.GetUsersAsync();
        }
        
        public void UpdateUser(Restaurant_Management.Dto.UserDto user) {
            base.Channel.UpdateUser(user);
        }
        
        public System.Threading.Tasks.Task UpdateUserAsync(Restaurant_Management.Dto.UserDto user) {
            return base.Channel.UpdateUserAsync(user);
        }
        
        public void DeleteUser(int id) {
            base.Channel.DeleteUser(id);
        }
        
        public System.Threading.Tasks.Task DeleteUserAsync(int id) {
            return base.Channel.DeleteUserAsync(id);
        }
        
        public Restaurant_Management.Dto.UserDto GetUserById(int id) {
            return base.Channel.GetUserById(id);
        }
        
        public System.Threading.Tasks.Task<Restaurant_Management.Dto.UserDto> GetUserByIdAsync(int id) {
            return base.Channel.GetUserByIdAsync(id);
        }
    }
}
