using CheckAPI.Models;
using Microsoft.AspNetCore.Mvc;

namespace CheckAPI.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class WellcomController : Controller
    {
        [HttpGet]
        public ActionResult<string> Index()
        {
            return "核酸检测登记系统API已启动！";
        }
    }
}
