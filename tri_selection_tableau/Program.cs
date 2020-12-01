using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tri_selection_tableau
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez entrer le, nombre d'éléments du tableau");
           
            int dim = int.Parse(Console.ReadLine());

            int[] tabNombre = new int[dim];
            for (int  i = 0;  i < dim;  i++)//dans notre code on a fait avec la taille directement c'est la meme chose?
            {
                Console.WriteLine(" Veuillez entre le nombre numero {0}/{1} dans le tableau", (i + 1), dim);
                tabNombre[i] = int.Parse(Console.ReadLine());
            }
            
            Console.WriteLine("votre tableau est rempli, voulez vous le trier?");//(vous)
            //affichage tableau non trié
            ManipulationTab.AfficheTableau(tabNombre);
            ManipulationTab.TriTableau(ref tabNombre);
            //affichage tableau trié
            ManipulationTab.AfficheTableau(tabNombre);
       
        }
    }
    class ManipulationTab
    {
         public static void TriTableau( ref int [] _monTab)
        {
            int mini;
            int temp;
            for (int i = 0; i <_monTab.Length-1; i++)
            {
                mini = _monTab[i];
                for (int j = i+1; j < _monTab.Length; j++)
                {
                    if (_monTab[j]<mini)
                    {
                        
                        temp =_monTab[i];
                        _monTab[i] = _monTab[j];
                        _monTab[j] = temp;

                    }

                }
          }

            Console.WriteLine("Voici le  tableau trié");



        }
        public static void AfficheTableau(int[] _tab)
        {
            Console.Write("[ ");
            foreach (int element in _tab)
            {
                Console.Write(element + " ");
            }


            Console.Write(" ]");
        }



    }


}
