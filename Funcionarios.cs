using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fixacao.Classes.Atributos.Metodos
{
    class Funcionarios
    {
        public string Nome { get; set; }
        public double  SalarioBruto { get; set; }
        public double Imposto { get; set; }

        public double SalarioLiquido()
        {
            return SalarioBruto - Imposto;
        }
        public void AumentoSalario(double porcentagem)
        {
            SalarioBruto = (SalarioBruto * porcentagem / 100) + SalarioBruto;
             
        }
        public override string ToString()
        {
            return Nome + ", R$ " + SalarioLiquido();
        }
    }
}
