using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Restaurant_Management.models
{
    [DataContract]
    public class Order
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public int ItemId { get; set; }
        [DataMember]
        public int  UserId { get; set; }
        public DateTime OrderDate { get; set; }
        [DataMember]
        public int Quantity { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public Item Item { get; set; }
        [DataMember]
        public User user { get; set; }
    }
}