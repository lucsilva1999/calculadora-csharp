using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeuApp
{
    class Program
    {
        static void Main(string[] args)
        {

           Console.WriteLine("#################################");
           Console.WriteLine("##       CALCULADORA C#        ##");
           Console.WriteLine("#################################");
           Console.WriteLine("##       Escolha uma opção     ##");
           Console.WriteLine("#################################");

           Console.WriteLine("1. Soma");
           Console.WriteLine("2. Subtração");
           Console.WriteLine("3. Multiplicação");
           Console.WriteLine("4. Divisão");

           string tmp; 

           Console.WriteLine("Digite um número referente a opção desejada");
           tmp = Console.ReadLine();
           int option = int.Parse(tmp);;

           double n1, n2;
           double resultado;

           if (option == 1)
           {
               Console.WriteLine("Você escolheu a opção: 1. Soma");
               Console.WriteLine("#################################");
               Console.WriteLine("Digite o primeiro número:");
               tmp = Console.ReadLine();
               n1 = int.Parse(tmp);
               Console.WriteLine("Digite o segundo número:");
               tmp = Console.ReadLine();
               n2 = int.Parse(tmp);
               resultado = n1 + n2;
               Console.WriteLine("O resultado é:");
               Console.WriteLine(resultado);
           } else if(option == 2)
           {
               Console.WriteLine("Você escolheu a opção: 2. Subtração");
               Console.WriteLine("#################################");
               Console.WriteLine("Digite o primeiro número:");
               tmp = Console.ReadLine();
               n1 = int.Parse(tmp);
               Console.WriteLine("Digite o segundo número:");
               tmp = Console.ReadLine();
               n2 = int.Parse(tmp);
               resultado = n1 - n2;
               Console.WriteLine("O resultado é:");
               Console.WriteLine(resultado);

           } else if (option == 3)
           {
               Console.WriteLine("Você escolheu a opção: 3. Multiplicação");
               Console.WriteLine("#################################");
               Console.WriteLine("Digite o primeiro número:");
               tmp = Console.ReadLine();
               n1 = int.Parse(tmp);
               Console.WriteLine("Digite o segundo número:");
               tmp = Console.ReadLine();
               n2 = int.Parse(tmp);
               resultado = n1 * n2;
               Console.WriteLine("O resultado é:");
               Console.WriteLine(resultado);
            
           } else if (option == 4)
           {
               Console.WriteLine("Você escolheu a opção: 4. Divisão");
               Console.WriteLine("#################################");
               Console.WriteLine("Digite o primeiro número:");
               tmp = Console.ReadLine();
               n1 = int.Parse(tmp);
               Console.WriteLine("Digite o segundo número:");
               tmp = Console.ReadLine();
               n2 = int.Parse(tmp);
               resultado = n1 / n2;
               Console.WriteLine("O resultado é:");
               Console.WriteLine(resultado);

           } else {
               
               Console.WriteLine("Nenhuma opção é válida");
               Console.WriteLine("Fechando o programa");
           }
           
        }

    }
}
