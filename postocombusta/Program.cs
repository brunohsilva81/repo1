using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace postocombusta
{
    class Program
    {
        static void Main(string[] args)


        {


            double a = 2.90;
            double g = 3.30;

            // Console.WriteLine("Menu: \a 1- alcool \b 2 - gasolina");

            Console.WriteLine("Quantos litros vc vai querer?");
            int quantid = int.Parse(Console.ReadLine());

            Console.WriteLine("Digite 1 para Alcool e 2 para Gas");
            int tipo = int.Parse(Console.ReadLine());

           if (tipo == 1 && quantid <= 20) ;
            double desconto1 = (((a * 20) * 3) / 100);
            Console.WriteLine("O valor com desconto eh de " + desconto1);
            Console.ReadLine();
            else
            if (tipo == 1 && quantid > 20) ;
            double desconto2 = (((a * 20) * 500) / 100);
            Console.WriteLine("O valor com desconto eh de " + desconto2);
            Console.ReadLine();

            




            /*  int opcao = Convert.ToInt32(Console.ReadLine());
              switch (opcao)
              {

                  case 1:
                      Console.WriteLine()
              }    */



        }
    }
}
