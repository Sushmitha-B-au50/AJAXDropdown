using AjaxDropdown.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AjaxDropdown.Controllers
{
    public class DDController : Controller
    {
        // GET: DD
        public ActionResult Index()
        {
            trainingEntities data = new trainingEntities();
            ViewBag.CountryList = new SelectList(GetCountryList(), "CountryID", " Name");
            return View();
        }
        public List<Country> GetCountryList()
        {
            trainingEntities data = new trainingEntities();
            List<Country> countries = data.Countries.ToList();
            return countries;
        }
        public ActionResult GetStatesList(int CountryID)
        {
            trainingEntities data = new trainingEntities();
            List<State> selectList = data.States.Where(x => x.CountryID == CountryID).ToList();
            ViewBag.stateslist = new SelectList(selectList, "StatesID", "StateName");
            return PartialView("Displaystates");
        }
        public ActionResult GetCityList(int StatesID)
        {
            trainingEntities data = new trainingEntities();
            List<City> selectList = data.Cities.Where(x => x.StatesID == StatesID).ToList();
            ViewBag.Citieslist = new SelectList(selectList, "CityID", "CityName");
            return PartialView("Displaycities");
        }
    }
}
    