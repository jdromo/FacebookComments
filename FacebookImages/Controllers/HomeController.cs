using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace FacebookImages.Controllers
{
    public class HomeController : Controller
    {
   
    public IActionResult Index(string id)
    {
      if(id == null)
      {
        ViewData["Message"] = "/images/ImagenInicio.png";
            ViewData["Title"] = "TAR";
      }
      else
      {
        id = id.ToLower();
        switch (id)
        {
          case "guadalajara":
            ViewData["Message"] = "/images/Guadalajara.png";
            ViewData["Title"] = "Guadalajara";
            break;
          case "monterrey":
            ViewData["Message"] = "/images/Monterrey.jpg";
            ViewData["Title"] = "Monterrey";
            break;
          case "oaxaca":
            ViewData["Message"] = "/images/Oaxaca.jpg";
            ViewData["Title"] = "Oaxaca";
            break;
          case "queretaro":
            ViewData["Message"] = "/images/Queretaro.jpg";
            ViewData["Title"] = "Queretaro";
            break;
          default:
            ViewData["Message"] = "/images/ImagenInicio.png";
            ViewData["Title"] = "TAR";
            break;
        }
      }
      return View();
    }

    public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
