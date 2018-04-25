using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace FetchExample.Models
{
    public class Continent
    {
        public Continent(string name)
        {
            Name = name;
            Countries = new List<Country>();
        }
        public string Name { get; set; }
        public List<Country> Countries { get; set; }
    }
}