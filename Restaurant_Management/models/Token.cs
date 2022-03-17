using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Restaurant_Management.models
{
    [DataContract]
    public class Token
    {
        [Key]
        public int Id { get; set; }
        [DataMember]
        public string SecureToken { get; set; }
        public int UserId { get; set; }
        public System.DateTime CreateDate { get; set; }

        public virtual User User { get; set; }
    }
}