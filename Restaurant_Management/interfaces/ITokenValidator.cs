using Restaurant_Management.models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Restaurant_Management.interfaces
{
    interface ITokenValidator
    {
        bool IsValid(string token);
        Token token { get; set; }
    }
}
