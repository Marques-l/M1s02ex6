using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Text;
using System.Threading.Tasks;

namespace M1s02ex6
{
    public class Filme
    {
        public string NomeFilme { get; set; }
        public string Cartegoria { get; set; }
         public string Exibir (string nome, string tipo) {
        NomeFilme = nome; 
       Cartegoria=tipo; 
     return $"Filme: {nome}, Gênero: {tipo}"; 
   }
    }
}