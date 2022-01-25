using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixacao.Classes.Atributos.Metodos
{
    class Retangulo
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public double Area ()
        {
            return Altura * Largura;
        }
        public double Perimetro()
        {
            return (Altura + Altura) + (Largura + Largura);
        }
        public double Diagonal()
        {
            return Math.Sqrt(Altura * Altura + Largura * Largura);

        }
       
    }
}
