using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace M1s02ex6
{
    public class Filme
    {
        public string NomeFilme { get; set; }
        public string Cartegoria { get; set; }
        public string  Info()
        {
              return NomeFilme+ " " + Cartegoria;
        }
    }
}