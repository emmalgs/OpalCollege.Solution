using Microsoft.AspNetCore.Mvc;
using OpalCollege.Models;
using System.Collections.Generic;

namespace OpalCollege.Controllers
{
  public class HomeController : Controller
  {
    [HttpGet("/")]
    public ActionResult Index()
    {
      return View();
    }

    // [Route("/favorite_photos")]
    // public ActionResult FavoritePhotos()
    // {
    //   return View();
    // }
  }
}