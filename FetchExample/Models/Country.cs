using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FetchExample.Models
{
    public class Country
    {
        public Country(string name)
        {
            Name = name;
        }
        public string Name { get; set; }
    }
}