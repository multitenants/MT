using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace multitenanat.Models
{
    public class Tenant
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Domain { get; set; }
        public bool Default { get; set; }
    }
}