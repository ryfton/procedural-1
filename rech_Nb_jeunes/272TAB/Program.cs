using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _272TAB
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] personnes = new int[20];
            for (int i = 0; i < personnes.Length; i++)
            {
                Console.WriteLine("Veuillez saisir l'âge de la personne n° :" + (i + 1));
                personnes[i] = int.Parse(Console.ReadLine());
            }
            int NBmoinsvingt=0;
            int NBvingt = 0;
            foreach (int age in personnes)
            {
                if (age<20)
                {
                    NBmoinsvingt++;
                }
                if (age == 20)
                {
                    NBvingt++;
                }
            }
            if (NBmoinsvingt==0)
            {
                Console.WriteLine("Toutes les personnes (20) ont plus de 20 ans !");
            }
            else if (NBmoinsvingt==personnes.Length)
            {
                Console.WriteLine("Toutes les personnes (20) ont moins de 20 ans !");
            }
            else
            { int NBplusvingt = 20 - NBmoinsvingt - NBvingt;

                Console.WriteLine("Nous avons {0} personnes de moins de vingt ans \n Nous avons {1} personnes de plus de vingt ans et \n Nous avons {2} personnes de vingt ans", NBmoinsvingt, NBplusvingt, NBvingt);
            }
            Console.ReadKey();
        }
    }
}
