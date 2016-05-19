using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace multitenanat.Models
{
    public class Session
    {
        public int Id { get; set; }
        public int SessionId { get; set; }
        public string Title { get; set; }
        public string DescriptionShort { get; set; }
        public string Desription { get; set; }

        public Tenant Tenant { get; set; }

        public List<Speaker> Speakers { get; set; }
    }
}