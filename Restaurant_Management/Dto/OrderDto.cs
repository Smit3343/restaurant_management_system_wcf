using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Restaurant_Management.Dto
{
    [DataContract]
    public class OrderDto
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string ItemName { get; set; }
        [DataMember]
        public int ItemPrice { get; set; }
        [DataMember]
        public int ItemQuantity { get; set; }
        [DataMember]
        public int Total { get; set; }
        [DataMember]
        public string Status { get; set; }
        [DataMember]
        public DateTime Orderdate { get; set; }
    }
}