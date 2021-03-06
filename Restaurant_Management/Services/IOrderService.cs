using Restaurant_Management.Dto;
using Restaurant_Management.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Restaurant_Management.Services
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IOrderService" in both code and config file together.
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        void PlaceOrder(Order order);
        [OperationContract]
        IEnumerable<OrderDto> GetOrders(int userId);
        [OperationContract]
        IEnumerable<OrderDtoAdmin> GetAllOrders();
        [OperationContract]
        void UpdateOrder(OrderDtoAdmin orderDto);
        [OperationContract]
        void DeleteOrder(int id);
        [OperationContract]
        OrderDtoAdmin GetOrderById(int id);
    }
}
