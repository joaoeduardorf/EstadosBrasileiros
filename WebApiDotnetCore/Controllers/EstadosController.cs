using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using EstadosBrasileiros;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApiDotnetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class EstadosController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<Estado>> Get()
        {
            return Estado.Estados.ToList();
        }

        [HttpGet("{sigla}")]
        public ActionResult<Estado> Get(string sigla)
        {
            return Estado.Estados.FirstOrDefault(f => f.Sigla.Equals(sigla));
        }
    }
}