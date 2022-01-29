using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CursoUdemy
{
    internal class Program
    {

        enum Menu { Soma = 1, Subtracao, Divisao, Multiplicacao, Potencia, Raiz, Fechar}
        static void Main(string[] args)
        {
            Console.WriteLine("Calculadora , Selecione uma das Opcões:");
            Console.WriteLine("1-Soma\n2-Subtracao\n3-Divisao\n4-Multiplicacao\n5-Potencia\n6-Raiz\n7-Fechar");
            Menu opcao = (Menu)int.Parse(Console.ReadLine());
            Console.WriteLine(opcao);

            Console.ReadLine();
        }
    }
}
