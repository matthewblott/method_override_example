using System;
using Microsoft.AspNetCore.Mvc;

namespace method_override_example
{
  public class HomeController : Controller
  {
    public IActionResult Index() => View();
  }

}