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
    public class OrderService : IOrderService
    {
        public void DeleteOrder(int id)
        {
            AppDbContext dbContext = new AppDbContext();
            Order order=dbContext.Orders.Where(o => o.Id == id).FirstOrDefault();
            if(order!=null)
            {

            dbContext.Orders.Remove(order);
            dbContext.SaveChanges();
            }
            else
            {
                Exception exception = new Exception("entered id of order is not found");
                throw exception;
            }
}

        public IEnumerable<OrderDtoAdmin> GetAllOrders()
        {
            AppDbContext dbContext = new AppDbContext();
            IEnumerable<OrderDtoAdmin> orderDtos = (from o in dbContext.Orders
                                                    join i in dbContext.Items
                                                    on o.ItemId equals i.Id
                                                    select new OrderDtoAdmin
                                                    {
                                                        Id = o.Id,
                                                        UserId=o.UserId,
                                                        ItemId=i.Id,
                                                        ItemName = i.Name,
                                                        ItemPrice = i.Price,
                                                        ItemQuantity = o.Quantity,
                                                        Total = i.Price * o.Quantity,
                                                        Status = o.Status,
                                                        Orderdate = o.OrderDate
                                                    });
            return orderDtos;
        }

        public OrderDtoAdmin GetOrderById(int id)
        {
            AppDbContext dbContext = new AppDbContext();
            IQueryable<Order> orders = dbContext.Orders.Where(o => o.Id==id);
            OrderDtoAdmin orderDtos = (from o in orders
                                                    join i in dbContext.Items
                                                    on o.ItemId equals i.Id
                                                    select new OrderDtoAdmin
                                                    {
                                                        Id = o.Id,
                                                        UserId = o.UserId,
                                                        ItemId = i.Id,
                                                        ItemName = i.Name,
                                                        ItemPrice = i.Price,
                                                        ItemQuantity = o.Quantity,
                                                        Total = i.Price * o.Quantity,
                                                        Status = o.Status,
                                                        Orderdate = o.OrderDate
                                                    }).FirstOrDefault();
            return orderDtos;
        }

        public IEnumerable<OrderDto> GetOrders(int userId)
        {
            AppDbContext dbContext = new AppDbContext();
            IQueryable<Order> orders = dbContext.Orders.Where(o => o.UserId == userId);
            IEnumerable<OrderDto> orderDtos = (from o in orders
                          join i in dbContext.Items
                          on o.ItemId equals i.Id
                          select new OrderDto
                          {
                              Id = o.Id,
                              ItemName = i.Name,
                              ItemPrice = i.Price,
                              ItemQuantity = o.Quantity,
                              Total = i.Price * o.Quantity,
                              Status = o.Status,
                              Orderdate = o.OrderDate
                          });
            return orderDtos;
        }

        public void PlaceOrder(Order order)
        {
            AppDbContext dbContext = new AppDbContext();
            order.OrderDate = DateTime.Now;
            order.Status = "Pending";
            dbContext.Orders.Add(order);
            dbContext.SaveChanges();
        }

        public void UpdateOrder(OrderDtoAdmin orderDto)
        {
            AppDbContext dbContext = new AppDbContext();
            Order order = dbContext.Orders.Where(o => o.Id == orderDto.Id).FirstOrDefault();
            if (order != null)
            {
                order.Quantity = orderDto.ItemQuantity;
                    order.Status = orderDto.Status;
                dbContext.SaveChanges();
            }
            else
            {
                Exception exception = new Exception("entered order details is not found");
                throw exception;
            }
        }
    }
}
