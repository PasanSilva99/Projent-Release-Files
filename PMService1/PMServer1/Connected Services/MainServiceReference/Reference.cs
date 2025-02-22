﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PMServer1.MainServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MainServiceReference.IMainService")]
    public interface IMainService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/IntializeDatabaseService", ReplyAction="http://tempuri.org/IMainService/IntializeDatabaseServiceResponse")]
        void IntializeDatabaseService();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/IntializeDatabaseService", ReplyAction="http://tempuri.org/IMainService/IntializeDatabaseServiceResponse")]
        System.Threading.Tasks.Task IntializeDatabaseServiceAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/GetSqliteVersion", ReplyAction="http://tempuri.org/IMainService/GetSqliteVersionResponse")]
        void GetSqliteVersion();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/GetSqliteVersion", ReplyAction="http://tempuri.org/IMainService/GetSqliteVersionResponse")]
        System.Threading.Tasks.Task GetSqliteVersionAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/SetUserStatus", ReplyAction="http://tempuri.org/IMainService/SetUserStatusResponse")]
        bool SetUserStatus(PMService1.Model.User user, PMService1.Status status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/SetUserStatus", ReplyAction="http://tempuri.org/IMainService/SetUserStatusResponse")]
        System.Threading.Tasks.Task<bool> SetUserStatusAsync(PMService1.Model.User user, PMService1.Status status);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/GetUserStatus", ReplyAction="http://tempuri.org/IMainService/GetUserStatusResponse")]
        System.Nullable<PMService1.Status> GetUserStatus(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/GetUserStatus", ReplyAction="http://tempuri.org/IMainService/GetUserStatusResponse")]
        System.Threading.Tasks.Task<System.Nullable<PMService1.Status>> GetUserStatusAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/RegisterUser", ReplyAction="http://tempuri.org/IMainService/RegisterUserResponse")]
        bool RegisterUser(string email, string name, byte[] imageBuffer, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/RegisterUser", ReplyAction="http://tempuri.org/IMainService/RegisterUserResponse")]
        System.Threading.Tasks.Task<bool> RegisterUserAsync(string email, string name, byte[] imageBuffer, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/FetchUsers", ReplyAction="http://tempuri.org/IMainService/FetchUsersResponse")]
        PMService1.Model.User[] FetchUsers();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/FetchUsers", ReplyAction="http://tempuri.org/IMainService/FetchUsersResponse")]
        System.Threading.Tasks.Task<PMService1.Model.User[]> FetchUsersAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/ValidateUser", ReplyAction="http://tempuri.org/IMainService/ValidateUserResponse")]
        bool ValidateUser(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/ValidateUser", ReplyAction="http://tempuri.org/IMainService/ValidateUserResponse")]
        System.Threading.Tasks.Task<bool> ValidateUserAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/IsUserRegistered", ReplyAction="http://tempuri.org/IMainService/IsUserRegisteredResponse")]
        bool IsUserRegistered(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/IsUserRegistered", ReplyAction="http://tempuri.org/IMainService/IsUserRegisteredResponse")]
        System.Threading.Tasks.Task<bool> IsUserRegisteredAsync(string email);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/GetUser", ReplyAction="http://tempuri.org/IMainService/GetUserResponse")]
        PMService1.Model.User GetUser(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/GetUser", ReplyAction="http://tempuri.org/IMainService/GetUserResponse")]
        System.Threading.Tasks.Task<PMService1.Model.User> GetUserAsync(string email, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/UpdateUser", ReplyAction="http://tempuri.org/IMainService/UpdateUserResponse")]
        bool UpdateUser(PMService1.Model.User loggedUser, PMService1.Model.User tempUser, byte[] image);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/UpdateUser", ReplyAction="http://tempuri.org/IMainService/UpdateUserResponse")]
        System.Threading.Tasks.Task<bool> UpdateUserAsync(PMService1.Model.User loggedUser, PMService1.Model.User tempUser, byte[] image);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/RequestUserImage", ReplyAction="http://tempuri.org/IMainService/RequestUserImageResponse")]
        byte[] RequestUserImage(string username);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IMainService/RequestUserImage", ReplyAction="http://tempuri.org/IMainService/RequestUserImageResponse")]
        System.Threading.Tasks.Task<byte[]> RequestUserImageAsync(string username);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IMainServiceChannel : PMServer1.MainServiceReference.IMainService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class MainServiceClient : System.ServiceModel.ClientBase<PMServer1.MainServiceReference.IMainService>, PMServer1.MainServiceReference.IMainService {
        
        public MainServiceClient() {
        }
        
        public MainServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public MainServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MainServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public MainServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void IntializeDatabaseService() {
            base.Channel.IntializeDatabaseService();
        }
        
        public System.Threading.Tasks.Task IntializeDatabaseServiceAsync() {
            return base.Channel.IntializeDatabaseServiceAsync();
        }
        
        public void GetSqliteVersion() {
            base.Channel.GetSqliteVersion();
        }
        
        public System.Threading.Tasks.Task GetSqliteVersionAsync() {
            return base.Channel.GetSqliteVersionAsync();
        }
        
        public bool SetUserStatus(PMService1.Model.User user, PMService1.Status status) {
            return base.Channel.SetUserStatus(user, status);
        }
        
        public System.Threading.Tasks.Task<bool> SetUserStatusAsync(PMService1.Model.User user, PMService1.Status status) {
            return base.Channel.SetUserStatusAsync(user, status);
        }
        
        public System.Nullable<PMService1.Status> GetUserStatus(string email) {
            return base.Channel.GetUserStatus(email);
        }
        
        public System.Threading.Tasks.Task<System.Nullable<PMService1.Status>> GetUserStatusAsync(string email) {
            return base.Channel.GetUserStatusAsync(email);
        }
        
        public bool RegisterUser(string email, string name, byte[] imageBuffer, string password) {
            return base.Channel.RegisterUser(email, name, imageBuffer, password);
        }
        
        public System.Threading.Tasks.Task<bool> RegisterUserAsync(string email, string name, byte[] imageBuffer, string password) {
            return base.Channel.RegisterUserAsync(email, name, imageBuffer, password);
        }
        
        public PMService1.Model.User[] FetchUsers() {
            return base.Channel.FetchUsers();
        }
        
        public System.Threading.Tasks.Task<PMService1.Model.User[]> FetchUsersAsync() {
            return base.Channel.FetchUsersAsync();
        }
        
        public bool ValidateUser(string email, string password) {
            return base.Channel.ValidateUser(email, password);
        }
        
        public System.Threading.Tasks.Task<bool> ValidateUserAsync(string email, string password) {
            return base.Channel.ValidateUserAsync(email, password);
        }
        
        public bool IsUserRegistered(string email) {
            return base.Channel.IsUserRegistered(email);
        }
        
        public System.Threading.Tasks.Task<bool> IsUserRegisteredAsync(string email) {
            return base.Channel.IsUserRegisteredAsync(email);
        }
        
        public PMService1.Model.User GetUser(string email, string password) {
            return base.Channel.GetUser(email, password);
        }
        
        public System.Threading.Tasks.Task<PMService1.Model.User> GetUserAsync(string email, string password) {
            return base.Channel.GetUserAsync(email, password);
        }
        
        public bool UpdateUser(PMService1.Model.User loggedUser, PMService1.Model.User tempUser, byte[] image) {
            return base.Channel.UpdateUser(loggedUser, tempUser, image);
        }
        
        public System.Threading.Tasks.Task<bool> UpdateUserAsync(PMService1.Model.User loggedUser, PMService1.Model.User tempUser, byte[] image) {
            return base.Channel.UpdateUserAsync(loggedUser, tempUser, image);
        }
        
        public byte[] RequestUserImage(string username) {
            return base.Channel.RequestUserImage(username);
        }
        
        public System.Threading.Tasks.Task<byte[]> RequestUserImageAsync(string username) {
            return base.Channel.RequestUserImageAsync(username);
        }
    }
}
