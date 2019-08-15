using System;
using System.Collections.Generic;

namespace EstadosBrasileiros
{
    public class Estado
    {
        /// <summary>
        /// Nome do estado
        /// </summary>
        public string Nome { get; private set; }

        /// <summary>
        /// Sigla do estado
        /// </summary>
        public string Sigla { get; private set; }

        /// <summary>
        /// Construtor
        /// </summary>
        /// <param name="nome"></param>
        /// <param name="sigla"></param>
        private Estado(string nome, string sigla) => (Nome, Sigla) = (nome, sigla);

        /// <summary>
        ///Nome: Acre, Sigla: AC
        /// </summary>
        public static readonly Estado ACRE = new Estado("Acre", "AC");

        /// <summary>
        /// Nome: Alagoas, Sigla: AL
        /// </summary>
        public static readonly Estado ALAGOAS = new Estado("Alagoas", "AL");

        /// <summary>
        /// Nome: Amapá, Sigla: AP
        /// </summary>
        public static readonly Estado AMAPA = new Estado("Amapá", "AP");

        /// <summary>
        /// Nome: Amazonas, Sigla: AM
        /// </summary>
        public static readonly Estado AMAZONAS = new Estado("Amazonas", "AM");

        /// <summary>
        /// Nome: Bahia, Sigla: BA
        /// </summary>
        public static readonly Estado BAHIA = new Estado("Bahia", "BA");

        /// <summary>
        /// Nome: Ceará, Sigla: CE
        /// </summary>
        public static readonly Estado CEARA = new Estado("Ceará", "CE");

        /// <summary>
        /// Nome: Distrito Federal, Sigla: DF
        /// </summary>
        public static readonly Estado DISTRITOFEDERAL = new Estado("Distrito Federal", "DF");

        /// <summary>
        /// Nome: Espírito Santo, Sigla: ES
        /// </summary>
        public static readonly Estado ESPIRITOSANTO = new Estado("Espírito Santo", "ES");

        /// <summary>
        /// Nome: Goiás, Sigla: GO
        /// </summary>
        public static readonly Estado GOIAS = new Estado("Goiás", "GO");

        /// <summary>
        /// Nome: Maranhão, Sigla: MA
        /// </summary>
        public static readonly Estado MARANHAO = new Estado("Maranhão", "MA");

        /// <summary>
        /// Nome: Mato Grosso, Sigla: MT
        /// </summary>
        public static readonly Estado MATOGROSSO = new Estado("Mato Grosso", "MT");

        /// <summary>
        /// Nome: Mato Grosso do Sul, Sigla: MS
        /// </summary>
        public static readonly Estado MATOGROSSODOSUL = new Estado("Mato Grosso do Sul", "MS");

        /// <summary>
        /// Nome: Minas Gerais, Sigla: MG
        /// </summary>
        public static readonly Estado MINASGERAIS = new Estado("Minas Gerais", "MG");

        /// <summary>
        /// Nome: Pará, Sigla: PA
        /// </summary>
        public static readonly Estado PARA = new Estado("Pará", "PA");

        /// <summary>
        /// Nome: Paraíba, Sigla: PB
        /// </summary>
        public static readonly Estado PARAIBA = new Estado("Paraíba", "PB");

        /// <summary>
        /// Nome: Paraná, Sigla: PR
        /// </summary>
        public static readonly Estado PARANA = new Estado("Paraná", "PR");

        /// <summary>
        /// Nome: Pernambuco, Sigla: PE
        /// </summary>
        public static readonly Estado PERNAMBUCO = new Estado("Pernambuco", "PE");

        /// <summary>
        /// Nome: Piauí, Sigla: PI
        /// </summary>
        public static readonly Estado PIAUI = new Estado("Piauí", "PI");

        /// <summary>
        /// Nome: Rio de Janeiro, Sigla: RJ
        /// </summary>
        public static readonly Estado RIODEJANEIRO = new Estado("Rio de Janeiro", "RJ");

        /// <summary>
        /// Nome: Rio Grande do Norte, Sigla: RN
        /// </summary>
        public static readonly Estado RIOGRANDEDONORTE = new Estado("Rio Grande do Norte", "RN");

        /// <summary>
        /// Nome: Rio Grande do Sul, Sigla: RS
        /// </summary>
        public static readonly Estado RIOGRANDEDOSUL = new Estado("Rio Grande do Sul", "RS");

        /// <summary>
        /// Nome Rondônia, Silga: RO
        /// </summary>
        public static readonly Estado RONDONIA = new Estado("Rondônia", "RO");

        /// <summary>
        /// Nome: Roraima, Sigla: RO
        /// </summary>
        public static readonly Estado RORAIMA = new Estado("Roraima", "RR");

        /// <summary>
        /// Nome: Santa Catarina, Sigla: SC
        /// </summary>
        public static readonly Estado SANTACATARINA = new Estado("Santa Catarina", "SC");

        /// <summary>
        /// Nome: São Paulo, Sigla: SP
        /// </summary>
        public static readonly Estado SAOPAULO = new Estado("São Paulo", "SP");

        /// <summary>
        /// Nome: Sergipe, Sigla: SE
        /// </summary>
        public static readonly Estado SERGIPE = new Estado("Sergipe", "SE");

        /// <summary>
        /// Nome: Tocantins, Sigla: TO
        /// </summary>
        public static readonly Estado TOCANTINS = new Estado("Tocantins", "TO");


        public static IEnumerable<Estado> Estados
        {
            get
            {
                yield return ACRE;
                yield return ALAGOAS;
                yield return AMAPA;
                yield return AMAZONAS;
                yield return BAHIA;
                yield return CEARA;
                yield return DISTRITOFEDERAL;
                yield return ESPIRITOSANTO;
                yield return GOIAS;
                yield return MARANHAO;
                yield return MATOGROSSO;
                yield return MATOGROSSODOSUL;
                yield return MINASGERAIS;
                yield return PARA;
                yield return PARAIBA;
                yield return PARANA;
                yield return PERNAMBUCO;
                yield return PIAUI;
                yield return RIODEJANEIRO;
                yield return RIOGRANDEDONORTE;
                yield return RIOGRANDEDOSUL;
                yield return RONDONIA;
                yield return RORAIMA;
                yield return SANTACATARINA;
                yield return SAOPAULO;
                yield return SERGIPE;
                yield return TOCANTINS;
            }
        }
    }
}
