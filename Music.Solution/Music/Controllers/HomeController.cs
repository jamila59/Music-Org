using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;  
using Music.Models;

namespace Music.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }
  }
}