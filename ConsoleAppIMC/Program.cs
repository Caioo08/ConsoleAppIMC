using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAppIMC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Qual o seu peso: ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Qual a sua altura: ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);

            if(imc <= 16.9) { 
                Console.Write("Você está muito abaixo do peso " + imc);
            }else if (imc <= 18.4)
            {
                Console.Write("Você está abaixo do peso: " + imc);
            }else if(imc <= 24.9)
            {
                Console.Write("Você está no peso normal: " + imc);
            }else if(imc <= 29.9)
            {
                Console.Write("Você está acima do peso: " + imc);
            }else if(imc <= 34.9)
            {
                Console.Write("Você está com Obesidade Grau I: " + imc);
            }else if(imc < 40)
            {
                Console.Write("Você está com Obesidade Grau II: " + imc);
            }
            else if(imc >= 40)
            {
                Console.Write("Você está com obesidade Grau III: " + imc);
            }
            Console.ReadKey();
        }
    }
}
