using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassSmartMuseum
{
    public class OperaArte
    {
        public string autore { get; }
        public string descrizione { get; }
        public string nome_opera { get; }
        public OperaArte(string autore, string descrizione, string nome_opera)
        {
           this.autore= autore;
            this.descrizione= descrizione;
            this.nome_opera = nome_opera;
        }
        public override string ToString()
        {

            return $"{nome_opera} {descrizione} {autore}";
        }
    }
}
