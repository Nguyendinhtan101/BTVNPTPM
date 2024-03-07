using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;
namespace MvcTAN.Controllers
{
    public class HelloWorldController : Controller
    { 
        // GET: /HelloWorld/
        public IActionReult Index()
        {
            return view();
        } 
        // GET: /HelloWorld/Welcome/ 

        public string Welcome()
        {
            return "This is the Welcome ...";
        }
    }
}
