using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fourchette
{
    class Program
    {
        static void Main(string[] args)
        {
            Random aleas = new Random();
            int Nbmachine, Nbutilisateur;
            Nbmachine = aleas.Next(0, 101);
            int min = 0;
            int max = 100;
            int compteur = 0;
            do
            {
                Console.WriteLine("Veuillez entrer un nombre entre " + min + " et " + max);
                Nbutilisateur = int.Parse(Console.ReadLine());
                if (Nbutilisateur > Nbmachine)
                {
                    Console.WriteLine("le nombre est  trop grand!");
                    max = Nbutilisateur;
                    compteur++;
                }
                else if (Nbutilisateur < Nbmachine)
                {
                    Console.WriteLine("le nombre est trop petit!");
                    min = Nbutilisateur;
                    compteur++;

                }
                else {
                    compteur++;
                   
                }



            } while (Nbmachine!=Nbutilisateur);
            Console.WriteLine(" Bravo vous avez trouvez le  nombre machine : " + Nbutilisateur + " en " + compteur + " coups");


            Console.ReadKey();
            

        }
    }
}
