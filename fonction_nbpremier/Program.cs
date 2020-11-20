using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace nbrepremier
{
    class Program
    {
        static void Main(string[] args)
        { 
            double Nbut;

            bool test;
            Console.WriteLine("Veuillez saisir un nombre entier positif!!");
            Nbut = double.Parse(Console.ReadLine());
            test= calcul.nombrepremier(Nbut);

            if ( test== true)
            {
                Console.WriteLine("le nombre saisie par l'utilisateur {0:#,###} est premier", Nbut);
            }
            else
            {
                Console.WriteLine("le nombre saisie par l'utilisateur {0:#,###} n'est pas premier", Nbut);
                List<int> resultat = calcul.RechercheDiv(Nbut);
                Console.Write("Les diviseurs sont : ");
                for (int i = 0; i < resultat.Count; i++)
                {
                    Console.Write(resultat[i] + " ");
                }
            }
            Console.ReadKey();

        }
    }

    class calcul
    {
       public static bool nombrepremier(double _Nbutilisateur)

        {
            double reste;
            int Diviseur = 2;
            bool Premier = true;
            double Limite = Math.Sqrt(_Nbutilisateur);

            do
            {
                reste = _Nbutilisateur % Diviseur;
                if (reste == 0)
                {
                    Premier = false;
                    break;
                }
                Diviseur++;
            } while (Diviseur <= Limite);

            return Premier;

        }
        public static List<int> RechercheDiv( double _nbutilisateur )
        {
            double reste;
            int Diviseur = 2;
            List<int> diviseurs = new List<int>();
            bool test;
            test = nombrepremier(_nbutilisateur);
            if (test == true)
            {
                Console.WriteLine("Il n'y a pas de diviseurs");
            }
            else
            {
                do
                {
                    reste = _nbutilisateur % Diviseur;
                    if (reste == 0)
                    {
                        diviseurs.Add(Diviseur);

                        
                    }
                    Diviseur++;
                }
                while (Diviseur < _nbutilisateur);
            }
            return diviseurs;
            
        }

    }
   
}
