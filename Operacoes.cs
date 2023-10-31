using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Threading.Tasks;

namespace Calculadora
{
    public class Operacoes
    {
        public int x,y,resp;
        
        public void Menu()
        {
            Console.WriteLine("***** calculadora do Scottiere*****************");
            Console.WriteLine("***** matematica basica para ensino fundamental");
            Console.WriteLine(" ***** primeira opção é uma adição ************");
            Console.WriteLine("********Segunda opção é uma subtração*************");
            Console.WriteLine("********Terceira opção é uma multiplicação********");
            Console.WriteLine("******** Quarta opção é uma  divisão **************");
            
        }
        public void Somar()
        {
            
            Console.WriteLine("Informe o numero x ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numero y");
            y = int.Parse(Console.ReadLine());
            this.resp = x+y;
           Console.WriteLine("a resposta da soma é "+resp);
        }

      public void Subtrair()
      {
        Console.WriteLine("Informe o numero x ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numero y");
            y = int.Parse(Console.ReadLine());
            this.resp = x-y;
           Console.WriteLine("a resposta da subtração é "+resp);
      }
       public void Multiplicar()
       {
                Console.WriteLine("Informe o numero x ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numero y");
            y = int.Parse(Console.ReadLine());
            this.resp = x*y;
           Console.WriteLine("a resposta da multiplicação é "+resp);
       }

        public void Dividir()
        {
             Console.WriteLine("Informe o numero x ");
            x = int.Parse(Console.ReadLine());
            Console.WriteLine("Informe o numero y");
            y = int.Parse(Console.ReadLine());
            this.resp = x/y;
           Console.WriteLine("a resposta da divisão é "+resp);
        }

    }
}