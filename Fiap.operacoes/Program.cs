using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiap.operacoes
{
    internal class Program
    {
        static void Main()
        {


            try
            {
                Console.Write("Digite seu Nome: \n");
                String nome = Console.ReadLine();

                Console.Write("Digite um numero: \n");
                Double num1 = double.Parse(Console.ReadLine());

                Console.Write("Digite o segundo numero: \n");
                Double num2 = double.Parse(Console.ReadLine());
                

                double soma = num1 + num2;
                double sub = num1 - num2;
                double mult = num1 * num2;
                double modulo = num1 % num2;



                Console.WriteLine("Resultados das operações");
                Console.WriteLine($"O valor da soma é {soma}");
                Console.WriteLine($"O valor da sub é {sub}");
                Console.WriteLine($"O valor da multiplicacao é {mult}");
                Console.WriteLine($"O valor do modulo é {modulo}");

                
                Console.WriteLine($"Os numeros são iguais? {num1 == num2}");

                Console.WriteLine($"Os numeros são diferentes? {num1 != num2}");
                Console.WriteLine($"O primeiro numero é maior que o segundo? {num1 > num2}");

                bool ambosPositivo = num1 > 0 && num2 > 0;
                bool nenhumNegativo = !(num1 < 0 || num2 < 0);

                Console.WriteLine($"Ambos positivo: {ambosPositivo}");
                Console.WriteLine($"Nenhum Negativo: {nenhumNegativo}");


                if (Directory.Exists("D:/Fernando"))
                {
                    Console.WriteLine("Pasta Existe");
                    
                }
                else
                {
                    Console.WriteLine("Pasta não existe");
                    Directory.CreateDirectory("D:/Fernando");
                }


                Console.Write("Aperte qualquer coisa para sair... ");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

            }


            Console.ReadKey();
        }
    }
}
