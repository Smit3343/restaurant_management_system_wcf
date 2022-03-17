﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Restaurant_Management_Client.ItemServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ItemServiceReference.IItemService")]
    public interface IItemService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/AddItem", ReplyAction="http://tempuri.org/IItemService/AddItemResponse")]
        int AddItem(Restaurant_Management.Item item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/AddItem", ReplyAction="http://tempuri.org/IItemService/AddItemResponse")]
        System.Threading.Tasks.Task<int> AddItemAsync(Restaurant_Management.Item item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/DeleteItem", ReplyAction="http://tempuri.org/IItemService/DeleteItemResponse")]
        void DeleteItem(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/DeleteItem", ReplyAction="http://tempuri.org/IItemService/DeleteItemResponse")]
        System.Threading.Tasks.Task DeleteItemAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/GetItem", ReplyAction="http://tempuri.org/IItemService/GetItemResponse")]
        Restaurant_Management.Item GetItem(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/GetItem", ReplyAction="http://tempuri.org/IItemService/GetItemResponse")]
        System.Threading.Tasks.Task<Restaurant_Management.Item> GetItemAsync(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/GetItems", ReplyAction="http://tempuri.org/IItemService/GetItemsResponse")]
        Restaurant_Management.Item[] GetItems();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/GetItems", ReplyAction="http://tempuri.org/IItemService/GetItemsResponse")]
        System.Threading.Tasks.Task<Restaurant_Management.Item[]> GetItemsAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/UpdateItem", ReplyAction="http://tempuri.org/IItemService/UpdateItemResponse")]
        void UpdateItem(Restaurant_Management.Item item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/UpdateItem", ReplyAction="http://tempuri.org/IItemService/UpdateItemResponse")]
        System.Threading.Tasks.Task UpdateItemAsync(Restaurant_Management.Item item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/getItemPhoto", ReplyAction="http://tempuri.org/IItemService/getItemPhotoResponse")]
        byte[] getItemPhoto(string fileName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/getItemPhoto", ReplyAction="http://tempuri.org/IItemService/getItemPhotoResponse")]
        System.Threading.Tasks.Task<byte[]> getItemPhotoAsync(string fileName);
        
        // CODEGEN: Generating message contract since the operation UploadImage is neither RPC nor document wrapped.
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/UploadImage", ReplyAction="http://tempuri.org/IItemService/UploadImageResponse")]
        Restaurant_Management_Client.ItemServiceReference.UploadImageResponse UploadImage(Restaurant_Management_Client.ItemServiceReference.ItemImageDto request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/UploadImage", ReplyAction="http://tempuri.org/IItemService/UploadImageResponse")]
        System.Threading.Tasks.Task<Restaurant_Management_Client.ItemServiceReference.UploadImageResponse> UploadImageAsync(Restaurant_Management_Client.ItemServiceReference.ItemImageDto request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/getItemBycategory", ReplyAction="http://tempuri.org/IItemService/getItemBycategoryResponse")]
        Restaurant_Management.Item[] getItemBycategory(string category);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IItemService/getItemBycategory", ReplyAction="http://tempuri.org/IItemService/getItemBycategoryResponse")]
        System.Threading.Tasks.Task<Restaurant_Management.Item[]> getItemBycategoryAsync(string category);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(WrapperName="ItemImageDto", WrapperNamespace="http://tempuri.org/", IsWrapped=true)]
    public partial class ItemImageDto {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=0)]
        public int Id;
        
        [System.ServiceModel.MessageBodyMemberAttribute(Namespace="http://tempuri.org/", Order=1)]
        public byte[] Image;
        
        public ItemImageDto() {
        }
        
        public ItemImageDto(int Id, byte[] Image) {
            this.Id = Id;
            this.Image = Image;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class UploadImageResponse {
        
        public UploadImageResponse() {
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IItemServiceChannel : Restaurant_Management_Client.ItemServiceReference.IItemService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ItemServiceClient : System.ServiceModel.ClientBase<Restaurant_Management_Client.ItemServiceReference.IItemService>, Restaurant_Management_Client.ItemServiceReference.IItemService {
        
        public ItemServiceClient() {
        }
        
        public ItemServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ItemServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ItemServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ItemServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int AddItem(Restaurant_Management.Item item) {
            return base.Channel.AddItem(item);
        }
        
        public System.Threading.Tasks.Task<int> AddItemAsync(Restaurant_Management.Item item) {
            return base.Channel.AddItemAsync(item);
        }
        
        public void DeleteItem(int id) {
            base.Channel.DeleteItem(id);
        }
        
        public System.Threading.Tasks.Task DeleteItemAsync(int id) {
            return base.Channel.DeleteItemAsync(id);
        }
        
        public Restaurant_Management.Item GetItem(int id) {
            return base.Channel.GetItem(id);
        }
        
        public System.Threading.Tasks.Task<Restaurant_Management.Item> GetItemAsync(int id) {
            return base.Channel.GetItemAsync(id);
        }
        
        public Restaurant_Management.Item[] GetItems() {
            return base.Channel.GetItems();
        }
        
        public System.Threading.Tasks.Task<Restaurant_Management.Item[]> GetItemsAsync() {
            return base.Channel.GetItemsAsync();
        }
        
        public void UpdateItem(Restaurant_Management.Item item) {
            base.Channel.UpdateItem(item);
        }
        
        public System.Threading.Tasks.Task UpdateItemAsync(Restaurant_Management.Item item) {
            return base.Channel.UpdateItemAsync(item);
        }
        
        public byte[] getItemPhoto(string fileName) {
            return base.Channel.getItemPhoto(fileName);
        }
        
        public System.Threading.Tasks.Task<byte[]> getItemPhotoAsync(string fileName) {
            return base.Channel.getItemPhotoAsync(fileName);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Restaurant_Management_Client.ItemServiceReference.UploadImageResponse Restaurant_Management_Client.ItemServiceReference.IItemService.UploadImage(Restaurant_Management_Client.ItemServiceReference.ItemImageDto request) {
            return base.Channel.UploadImage(request);
        }
        
        public void UploadImage(int Id, byte[] Image) {
            Restaurant_Management_Client.ItemServiceReference.ItemImageDto inValue = new Restaurant_Management_Client.ItemServiceReference.ItemImageDto();
            inValue.Id = Id;
            inValue.Image = Image;
            Restaurant_Management_Client.ItemServiceReference.UploadImageResponse retVal = ((Restaurant_Management_Client.ItemServiceReference.IItemService)(this)).UploadImage(inValue);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Restaurant_Management_Client.ItemServiceReference.UploadImageResponse> Restaurant_Management_Client.ItemServiceReference.IItemService.UploadImageAsync(Restaurant_Management_Client.ItemServiceReference.ItemImageDto request) {
            return base.Channel.UploadImageAsync(request);
        }
        
        public System.Threading.Tasks.Task<Restaurant_Management_Client.ItemServiceReference.UploadImageResponse> UploadImageAsync(int Id, byte[] Image) {
            Restaurant_Management_Client.ItemServiceReference.ItemImageDto inValue = new Restaurant_Management_Client.ItemServiceReference.ItemImageDto();
            inValue.Id = Id;
            inValue.Image = Image;
            return ((Restaurant_Management_Client.ItemServiceReference.IItemService)(this)).UploadImageAsync(inValue);
        }
        
        public Restaurant_Management.Item[] getItemBycategory(string category) {
            return base.Channel.getItemBycategory(category);
        }
        
        public System.Threading.Tasks.Task<Restaurant_Management.Item[]> getItemBycategoryAsync(string category) {
            return base.Channel.getItemBycategoryAsync(category);
        }
    }
}