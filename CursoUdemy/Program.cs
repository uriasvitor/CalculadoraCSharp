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
            bool fechar = false;
            while (!fechar)
            {
                Console.WriteLine("Calculadora , Selecione uma das Opcões:");
                Console.WriteLine("1-Soma\n2-Subtracao\n3-Divisao\n4-Multiplicacao\n5-Potencia\n6-Raiz\n7-Fechar");
                Menu opcao = (Menu)int.Parse(Console.ReadLine());
                Console.WriteLine(opcao);
                Console.Clear();

                 switch (opcao)
                 {
                    case Menu.Fechar:
                       fechar = true;
                       break;
                    case Menu.Soma:
                       soma();
                       break;
                    case Menu.Subtracao:
                       subtracao();
                       break;
                    case Menu.Divisao:
                       divisao();
                       break;
                    case Menu.Multiplicacao:
                       multiplicacao();
                       break;
                    case Menu.Potencia:
                       potencia();
                       break;
                    case Menu.Raiz:
                       raiz();
                       break;
                    default:
                        Console.WriteLine("Você tem que digitar um numero");
                        break;

                 }
            }
            
             void soma()
            {
                Console.WriteLine("Soma dois numeros :");
                Console.WriteLine("Digite o primeiro numero: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                int b = int.Parse(Console.ReadLine());
                float resultado = a + b;
                Console.WriteLine($"Resultado é: {resultado} ");
                Console.WriteLine("Aperte ENTER para Voltar para o menu ");
                Console.ReadLine();
            }

            void subtracao()
            {
                Console.WriteLine("Soma dois numeros :");
                Console.WriteLine("Digite o primeiro numero: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                int b = int.Parse(Console.ReadLine());
                float resultado = a - b;
                Console.WriteLine($"Resultado é: {resultado} ");
                Console.WriteLine("Aperte ENTER para Voltar para o menu ");
                Console.ReadLine();
            }

            void divisao()
            {
                Console.WriteLine("Soma dois numeros :");
                Console.WriteLine("Digite o primeiro numero: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                int b = int.Parse(Console.ReadLine());
                float resultado = (a/b);
                Console.WriteLine($"Resultado é: {resultado} ");
                Console.WriteLine("Aperte ENTER para Voltar para o menu ");
                Console.ReadLine();
            }

            void multiplicacao()
            {
                Console.WriteLine("Soma dois numeros :");
                Console.WriteLine("Digite o primeiro numero: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o segundo numero: ");
                int b = int.Parse(Console.ReadLine());
                float resultado = a * b;
                Console.WriteLine($"Resultado é: {resultado} ");
                Console.WriteLine("Aperte ENTER para Voltar para o menu ");
                Console.ReadLine();
            }

            void potencia()
            {
                Console.WriteLine("Soma dois numeros :");
                Console.WriteLine("Digite a base: ");
                int a = int.Parse(Console.ReadLine());
                Console.WriteLine("Digite o expoente: ");
                int b = int.Parse(Console.ReadLine());
                double resultado = Math.Pow(a,b);
                Console.WriteLine($"Resultado é: {resultado} ");
                Console.WriteLine("Aperte ENTER para Voltar para o menu ");
                Console.ReadLine();
            }

            void raiz()
            {
                Console.WriteLine("Digite o numero: ");
                int a = int.Parse(Console.ReadLine());
                double resultado = Math.Sqrt(a);
                Console.WriteLine($"Resultado é: {resultado} ");
                Console.WriteLine("Aperte ENTER para Voltar para o menu ");
                Console.ReadLine();
            }
        }

        
    }
}
