using Microsoft.AspNetCore.Mvc;



namespace E_Commerce.Controllers
{
    [ApiController]
    [Route("[controller]")]

    public class HomeController : Controller
    {
        public string []employees = { "geeta","seeta","ram" };
        [HttpGet]
        
        public string [] myemployees()
        {
            return employees;
        }

         
    }
}
