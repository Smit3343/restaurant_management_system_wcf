using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Restaurant_Management.models
{
    [DataContract]
    public class User
    {
        [Key]
        [DataMember]
        public int Id { get; set; }
        [Required]
        [DataMember]
        public string Name { get; set; }
        [Required]
        [DataMember]
        public string Password { get; set; }
        [EmailAddress]
        [Required]
        [DataMember]
        [MaxLength(450)]
        public string Email { get; set; }
        [Required]
        [DataMember]
        public string Role { get; set; }
        public string Salt { get; set; }
        public virtual ICollection<Token> Tokens { get; set; }
    }
}