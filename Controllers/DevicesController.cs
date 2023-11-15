using Microsoft.AspNetCore.Mvc;
using SeniorProject.Models;
using SeniorProject.Services;
using System.Diagnostics;

namespace SeniorProject.Controllers
{
    public class DevicesController : Controller
    {
        public IActionResult Devices()
        {
            //using this file for implementing a better code structure rather than hard-coding it here
            HardCodedSampleDataRepository repository = new HardCodedSampleDataRepository();

            return View(repository.AllProducts());
        }
        public IActionResult EditDevice()
        {
            return View();
        }

        public IActionResult AddDevice()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
