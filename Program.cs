using System;
using System.Globalization;

namespace Fixacao.Classes.Atributos.Metodos
{
    class Program
    {
        static void Main(string[] args)
        {
            //    Pessoa p1 = new Pessoa();
            //    Pessoa p2 = new Pessoa();

            //    Console.WriteLine("Dados da primeira pessoa:");
            //    Console.Write("Nome: ");
            //    p1.Nome = Console.ReadLine();
            //    Console.Write("Idade: ");
            //    p1.Idade = int.Parse(Console.ReadLine());

            //    Console.WriteLine("Dados da segunda pessoa:");
            //    Console.Write("Nome: ");
            //    p2.Nome = Console.ReadLine();
            //    Console.Write("Idade: ");
            //    p2.Idade = int.Parse(Console.ReadLine());

            //    if(p1.Idade > p2.Idade)
            //    {
            //        Console.WriteLine($"{p1.Nome} é mais velho(a)");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"{p2.Nome} é mias velho");
            //    }

            //------------------------------------------------------------------------------------

            //Funcionario f1 = new Funcionario();
            //Funcionario f2 = new Funcionario();


            //Console.WriteLine("Dados do primeiro funcionário: ");
            //Console.Write("Nome: ");
            //f1.Nome = Console.ReadLine();
            //Console.Write("Salario: ");
            //f1.Salario =double.Parse(Console.ReadLine());

            //Console.WriteLine("Dados do segundo funcionário: ");
            //Console.Write("Nome: ");
            //f2.Nome = Console.ReadLine();
            //Console.Write("Salario: ");
            //f2.Salario = double.Parse(Console.ReadLine());

            //double mediaSalario = (f1.Salario + f2.Salario) / 2;

            //Console.Write($"Media salarial: {mediaSalario.ToString("F2")}");

            //-----------------------------------------------------------------------

            //Retangulo ret = new Retangulo();


            //Console.WriteLine("Entre a largura e altura do retângulo: ");
            //ret.Altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
            //ret.Largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            //Console.WriteLine($"Area = " + ret.Area());
            //Console.WriteLine($"Perimetro = " + ret.Perimetro());
            //Console.WriteLine($"Diagonal = " + ret.Diagonal());

            //--------------------------------------------------------------------------
            //Funcionarios func = new Funcionarios();

            //Console.WriteLine("Entre com os dados do funcionario: ");
            //Console.Write("Nome: ");
            //func.Nome = Console.ReadLine();
            //Console.Write("Salario bruto: ");
            //func.SalarioBruto = double.Parse(Console.ReadLine());
            //Console.Write("Imposto: ");
            //func.Imposto = double.Parse(Console.ReadLine());
            //Console.WriteLine();

            //Console.WriteLine("Funcionario"+ func);
            //Console.WriteLine();

            //Console.Write("Digite a porcentagem para aumentar o salário: ");
            //double porcentagem = double.Parse(Console.ReadLine());
            //func.AumentoSalario(porcentagem);
            //Console.WriteLine();

            //Console.Write("Dados atualizados: " + func);

            //--------------------------------------------------------------------------
            Aluno x = new Aluno();

            Console.WriteLine("Entre com o nome do aluno:");
            x.Nome = Console.ReadLine();
            Console.WriteLine("Entre com as 3 notas do aluno: ");
            x.Nota1 = double.Parse(Console.ReadLine());
            x.Nota2 = double.Parse(Console.ReadLine());
            x.Nota3 = double.Parse(Console.ReadLine());

            Console.WriteLine("NOTA FINAL " + x.NotaFinal());

            if(x.Aprovado())
            {
                Console.WriteLine("APROVADO");
            }
            else
            {
                Console.WriteLine("REPROVADO");
                Console.WriteLine("FALTARAM " + x.NotaRestante() + " PONTOS");
            }



        }
    }
}
