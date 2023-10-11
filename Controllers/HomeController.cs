using CaronteCHK.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Microsoft.IdentityModel.Tokens;
using CaronteCHK.Models.ModelDB;

namespace CaronteCHK.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (CaronteSqlContext modelDB = new CaronteSqlContext())
            {
                var user = modelDB.Users.FirstOrDefault(i => i.UserName == "rootkit");
                Console.WriteLine(user);
            }

            return View();
        }

        [HttpPost]
        public ActionResult loginAuth(string username, string password)
        {
            try
            {
                using (CaronteSqlContext modelDB = new CaronteSqlContext())
                {
                    var user = modelDB.Users
                        .SingleOrDefault(u => u.UserName == username && u.Pass == password);

                    if (user != null)
                    {
                        return RedirectToAction("Index", "Home");
                    }

                    return View();
                }
            }
            catch (Exception ex)
            {
                return View();
            }
        }
    }
}