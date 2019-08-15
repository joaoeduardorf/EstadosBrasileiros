using EstadosBrasileiros;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace WebApiDotnetFramework.Controllers
{
    public class EstadosController : ApiController
    {
        [HttpGet]
        public IEnumerable<Estado> Get()
        {
            return Estado.Estados.ToList();
        }

        public Estado Get(string sigla)
        {
            return Estado.Estados.FirstOrDefault(f => f.Sigla.Equals(sigla));
        }
    }
}
