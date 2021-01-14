using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WEB_suma.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class Suma_Controller : Controller
    {
        [HttpGet]

        public int Suma(int num1, int num2)
        {

        return num1 + num2;

        }

    }
}
