using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Suma.Controllers
{
    public class SumaController : Controller
    {
        [HttpPost]
        [Route("suma")]
        public int suma([FromHeader] int numa, [FromHeader] int numb)
        {
            return numa + numb;
        }

        [HttpGet]
        [Route("suma")]
        public int suma2(int numa, int numb)
        {
            return numa + numb;
        }
    }
}