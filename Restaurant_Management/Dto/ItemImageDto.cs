using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace Restaurant_Management.Dto
{
    [MessageContract]
    public class ItemImageDto
    {
        [MessageBodyMember]
        public int Id { get; set; }//id of item
        [MessageBodyMember]
        public Byte[] Image { get; set; }
    }
}