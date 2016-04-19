using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication3.Models
{
    public class addDatabase
    {
        public string database_type { get; set; }
        public string user { get; set; }
        public string pass { get; set; }
        public string server { get; set; }
        public string protocol { get; set; }
        public string port { get; set; }
        public string alias { get; set; }
        public string nombre { get; set; }
    }
}