using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cv1_podleZadani
{
    class Program
    {
        static void funkceRodneCislo()
        {
            Console.WriteLine("Příklad 3 RČ");
            StringBuilder rcBuilder = new StringBuilder("911213/1234");
            StringBuilder mesic = new StringBuilder();
            mesic.Append(rcBuilder[2]);
            mesic.Append(rcBuilder[3]);
            if (int.Parse(mesic.ToString()) - 50 >= 0)
            {
                Console.WriteLine(rcBuilder.Append(" je žena"));
            }
            else
            {
                Console.WriteLine(rcBuilder.Append(" je muž"));
            }
            Console.WriteLine("");
            Console.WriteLine("*********************");
        }

        static void Main(string[] args)
        {
            /*  pr 1 formatovani adresy */
            Console.WriteLine("Příklad 1 adresa");
            Console.Write("Josef");
            Console.Write(" ");
            Console.Write("Novák");
            Console.Write('\n');
            Console.WriteLine("Jindřišská 16");
            Console.WriteLine("111 50, Praha 1");
            Console.WriteLine("*********************");


            /* pr 2 abeceda */
            Console.WriteLine("Příklad 2 abeceda");
            for (int i = 97; i < 97 + 26; i++)
            {
                Console.Write((char)i + " ");
            }
            Console.WriteLine("");
            Console.WriteLine("*********************");

            /* pr 3 Rč */
            funkceRodneCislo();

            /* pr 4 hadani cisel*/
            Random rnd = new Random();
            int cislo = rnd.Next(101);
            int zadano;
            int pocetPokusu = 10;
            bool vyhral = true;
            do
            {
                Console.WriteLine("Zadej tvuj odhad: ");
                int.TryParse(Console.ReadLine(), out zadano);

                if(zadano < cislo)
                {
                    Console.WriteLine("Cislo je moc male");
                }
                if(zadano > cislo)
                {
                    Console.WriteLine("Cislo je moc velke");
                }
                pocetPokusu--;
                if(pocetPokusu == 0)
                {
                    Console.WriteLine("Prohral jsi!");
         
                    break;
                }
                if(zadano == cislo)
                {
                    vyhral = true;
                }
            } while (cislo != zadano);
           
        }
    }
}
