using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tri_a_bulle_tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Combien d'éléments souhaitez-vous dans le tableau?");
            int nbrecase = int.Parse(Console.ReadLine());
            int[] tabNombre = new int[nbrecase];
            for (int i = 0; i < nbrecase; i++)
            {
                Console.WriteLine("Veuillez saisir le nombre numero: {0}/{1}", i + 1, nbrecase);
                tabNombre[i] = int.Parse(Console.ReadLine());
            }
            //fonction qui affiche le tableau...


            ManipulationTableau.AfficherTab(tabNombre);

            Console.ReadKey();

        }

    }
    class ManipulationTableau
    {
        public static void AfficherTab(int[] _tab)
        {
            Console.Write("[ ");
            foreach (int element in _tab)
            {
                Console.Write(element + " ");
            }
            Console.Write(" ] \n");
        }
            
            
    }
}
