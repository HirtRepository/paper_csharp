using Microsoft.AspNetCore.Mvc;
using PaperUniasselvi.Models;
using System.Diagnostics;
using PaperUniasselvi.Data;

namespace PaperUniasselvi.Controllers
{
    public class HomeController : Controller
    {

        public IActionResult Index( )
        {
            return View();
        }


    }
}
