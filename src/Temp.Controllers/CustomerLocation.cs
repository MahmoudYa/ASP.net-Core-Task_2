using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Temp.Components.Security;
using Temp.Objects.Models;
using Temp.Services;

namespace Temp.Controllers
{
    [AllowUnauthorized]
    public class CustomerLocation : ServicedController<CustomerLocationService>
    {
        public CustomerLocation(CustomerLocationService customerLocationService) : base(customerLocationService) { }

        public IActionResult Index()
        {
            List<Country> countries = Service.GetCountries();
            ViewBag.countries = new SelectList(countries, "Id", "Name");
            return View();
        }

        [HttpPost]
        public JsonResult GetState(string CountryId)
        {
            List<State> states = Service.GetStates();
            List<State> StateList = states.Where(z => z.CountryId == Convert.ToInt32(CountryId)).ToList();
            return Json(new SelectList(StateList, "Id", "Name"));
        }
    }
}
