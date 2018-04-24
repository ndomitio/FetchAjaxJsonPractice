using FetchExample.Models;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace FetchExample.Controllers
{
    public class CountyController : Controller
    {
        private List<County> counties = new List<County>
        {
            new County("Cuyahoga")
            {
                Cities = new List<City>
                {
                    new City("Solon"),
                    new City("Bay Village"),
                    new City("North Olmsted"),
                }
            },
            new County("Lorain")
            {
                Cities = new List<City>
                {
                    new City("Avon"),
                    new City("Elyria"),
                    new City("Oberlin"),
                }
            },
            new County ("Lucas")
            {
                Cities = new List<City>
                {
                    new City("Toledo"),
                    new City("Holland"),
                    new City("Sylvania"),
                }
            }
            
        };
        
        public JsonResult GetCounties()
        {
            var countyNames = counties.Select(c => c.Name);
            return Json(countyNames, JsonRequestBehavior.AllowGet) ;
        }
        

        public JsonResult GetCitiesInCounty(string countyName)
        {
            var county = counties.Single(c => c.Name == countyName);
            var schoolNames = county.Cities.Select(city => city.Name);
            return Json(schoolNames, JsonRequestBehavior.AllowGet);
        }

    }

    
}