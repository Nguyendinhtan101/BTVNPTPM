using FirstWebMVC.Models;
using Microsoft.AspNetCore.Mvc;

namespace FirstWebMVC.Controllers;
public class PersonController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    [HttpPost]
    public IActionResult Index(Person ps)
    {
        string Output = " Xin chao " + ps.FullName + " ma sinh vien " + ps.PersonID + " den tu " +ps.Address;
        ViewBag.thongbao = Output;
        return View();
    }
}