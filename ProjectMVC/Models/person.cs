using Microsoft.AspNetCore.SignalR;
using Microsoft.Net.Http.Headers;

namespace FirstWebMVC.Models
{
    public class Person
    {
      public string PersonID { get; set; }
      public string FullName { get; set; }
      public string Address { get; set; }
    }
}