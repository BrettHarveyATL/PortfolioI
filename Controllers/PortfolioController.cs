using Microsoft.AspNetCore.Mvc;

namespace Portfolio.Controllers
{
    public class PortfolioController : Controller
    {
        [HttpGet("")]
        public string Index()
        {
            return "This is Index!";
        }

        [HttpGet("projects")]
        public string Project()
        {
            return "These are my projects";
        }

        [HttpGet("contact")]
        public string Contact()
        {
            return "This is my contact";
        }
    }
}