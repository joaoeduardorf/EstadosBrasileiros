using EstadosBrasileiros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleDotnetFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Estados por estado");
            ImprimirEstado(Estado.ACRE);
            ImprimirEstado(Estado.ALAGOAS);
            ImprimirEstado(Estado.AMAPA);
            ImprimirEstado(Estado.AMAZONAS);
            ImprimirEstado(Estado.BAHIA);
            ImprimirEstado(Estado.CEARA);
            ImprimirEstado(Estado.DISTRITOFEDERAL);
            ImprimirEstado(Estado.ESPIRITOSANTO);
            ImprimirEstado(Estado.GOIAS);
            ImprimirEstado(Estado.MARANHAO);
            ImprimirEstado(Estado.MATOGROSSO);
            ImprimirEstado(Estado.MATOGROSSODOSUL);
            ImprimirEstado(Estado.MINASGERAIS);
            ImprimirEstado(Estado.PARA);
            ImprimirEstado(Estado.PARAIBA);
            ImprimirEstado(Estado.PARANA);
            ImprimirEstado(Estado.PERNAMBUCO);
            ImprimirEstado(Estado.PIAUI);
            ImprimirEstado(Estado.RIODEJANEIRO);
            ImprimirEstado(Estado.RIOGRANDEDONORTE);
            ImprimirEstado(Estado.RIOGRANDEDOSUL);
            ImprimirEstado(Estado.RONDONIA);
            ImprimirEstado(Estado.RORAIMA);
            ImprimirEstado(Estado.SANTACATARINA);
            ImprimirEstado(Estado.SAOPAULO);
            ImprimirEstado(Estado.SERGIPE);
            ImprimirEstado(Estado.TOCANTINS);

            Console.WriteLine();
            Console.WriteLine("Estados da lista");
            foreach (Estado estado in Estado.Estados)
            {
                ImprimirEstado(estado);
            }

            Console.ReadKey();
        }

        static void ImprimirEstado(Estado estado) => Console.WriteLine(string.Format("{0} - {1}", estado.Nome, estado.Sigla));
    }
}
