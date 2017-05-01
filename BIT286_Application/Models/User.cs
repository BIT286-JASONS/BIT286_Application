using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BIT286_Application.Models
{
    public class User
    {
        public int ID { get; set; }
        public string UserName { get; set; }
        public string Password { get; set; }
        public bool Teacher { get; set; }
        public string Class {get; set;}
    }
}