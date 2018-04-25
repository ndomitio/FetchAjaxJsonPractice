using FetchExample.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace FetchExample.Controllers
{
    public class ContinentController : Controller
    {
        private List<Continent> continents = new List<Continent>
        {
            new Continent("North America")
            {
                Countries = new List<Country>
                {
                    new Country("United States"),
                    new Country("Canada"),
                    new Country("Mexico"),
                }
            },
            new Continent("Asia")
            {
                Countries = new List<Country>
                {
                    new Country("South Korea"),
                    new Country("China"),
                    new Country("Japan"),
                }
            },
            new Continent("Europe")
            {
                Countries = new List<Country>
                {
                    new Country("England"),
                    new Country("France"),
                    new Country("Italy"),
                }
            }

        };

        public JsonResult GetContinents()
        {
            var continentNames = continents.Select(c => c.Name);
            return Json(continentNames, JsonRequestBehavior.AllowGet);
        }


        public JsonResult GetCountriesInContinent(string continentName)
        {
            var continent = continents.Single(c => c.Name == continentName);
            var schoolNamez = continent.Countries.Select(country => country.Name);
            return Json(schoolNamez, JsonRequestBehavior.AllowGet);
        }

    }

    
}