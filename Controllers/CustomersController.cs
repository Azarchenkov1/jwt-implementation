using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace WebApplicationJWT.Controllers
{
    [Route("api/[controller]")]
    public class CustomersController : Controller
    {
        [HttpGet,Authorize]
        public IEnumerable<string> Get()
        {
            return new string[] { "Azarchenkov Nikita", "Niko Dispas" };
        }
    }
}