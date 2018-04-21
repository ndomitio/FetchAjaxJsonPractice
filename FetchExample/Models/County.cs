using System.Collections.Generic;

namespace FetchExample.Models
{
    public class County
    {
        public County(string name)
        {
            Name = name;
            Cities = new List<City>();
        }
        public string Name { get; set; }
        public List<City> Cities { get; set; }
    }
}