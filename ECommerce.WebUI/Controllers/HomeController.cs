using Microsoft.AspNetCore.Mvc;

namespace ECommerce.WebUI.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    //public string Index()
    //{
    //    HttpContext.Session.SetInt32("age", 25);
    //    HttpContext.Session.SetString("name" , "Jhon Soprano");
        

    //    return "Session Created";
    //}

    //public string GetSession()
    //{
    //    return $"Age {HttpContext.Session.GetInt32("age")}"+ $" Name{HttpContext.Session.GetString("name")}";
    //}
}
