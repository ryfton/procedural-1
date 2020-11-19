using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace jeu_0_1_2
{
    class Program
    {
        static void Main(string[] args)
        {       //instanciation de l'objet Random
            //Random aleas = new Random();
            int NbMachine;

            int NbUtilisateur, Diff;
            int ScoreUtilisateur;
            int ScoreBot;
            bool continuer = false;
            string rep;

            do
            {
                ScoreUtilisateur = 0;

                ScoreBot = 0;

                do
                {
                    bool Nb_ok=false;

                    do
                    {
                        Console.Write("veuillez choisir un chiffre parmis : 0 - 1 - 2:  \n Taper un nombre négatif pour arrêter la partie :");
                        Nb_ok = int.TryParse(Console.ReadLine(), out NbUtilisateur);



                    } while (Nb_ok == false || NbUtilisateur > 3);
                
                        

                    
                  
                    NbMachine = (new Random()).Next(0, 3);
                    Diff = NbUtilisateur - NbMachine;
                    Diff = Math.Abs(Diff);
                    switch (Diff)
                    {
                        case 2:
                            if (NbUtilisateur > NbMachine)
                            {
                                ScoreUtilisateur++;
                                Console.WriteLine("Vous marquez un 1 point \n score joueur:{0} \n score machine: {1} ",ScoreUtilisateur,ScoreBot );
                               
                            }
                            else
                            {
                                ScoreBot++;
                                Console.WriteLine("La machine marque un point \n score joueur:{0} \n score machine: {1} ", ScoreUtilisateur, ScoreBot);
                               
                            }
                            break;



                        case 1:
                            if (NbUtilisateur < NbMachine)
                            {
                                ScoreUtilisateur++;
                                Console.WriteLine("Vous marquez un 1 point \n score joueur:{0} \n score machine: {1} ", ScoreUtilisateur, ScoreBot);
                               
                            }
                            else
                            {
                                ScoreBot++;
                                Console.WriteLine("La machine marque un point \n score joueur:{0} \n score machine: {1} ", ScoreUtilisateur, ScoreBot);
                              
                            }
                            break;

                        case 0:
                            Console.WriteLine("exaequo aucun joueur ne marque de point...\n score joueur:{0} \n score machine: {1} ", ScoreUtilisateur, ScoreBot);



                            break;

                        default:

                            break;
                    }




                } while (NbUtilisateur >= 0 && ScoreUtilisateur < 10 && ScoreBot < 10);
                if (NbUtilisateur < 0)
                {
                    Console.WriteLine("Vous avez arrêté le jeu!! \n votre score est de :{0} et le score de la machine est : {1}",ScoreUtilisateur, ScoreBot);
                }
                else if (ScoreUtilisateur == 10)
                {
                    Console.WriteLine("Bravo vous avez gagné vous avez!!");
                    Console.WriteLine("votre score est de :{0: #,###} et le score de la machine est : {1}", ScoreUtilisateur, ScoreBot);
                }
                else
                {
                    Console.WriteLine(" La machine gagne!! Essayez encore!!");

                    Console.WriteLine("votre score est de :{0: #,###} et le score de la machine est : {1}", ScoreUtilisateur, ScoreBot);

                }


                Console.WriteLine("Voulez vous rejouer OUI/NON?");
                rep = Console.ReadLine().ToUpper();
                if (rep == "OUI")
                {
                    continuer = true;
                }
                else
                {
                    continuer = false;
                }

            } while (continuer == true);

            Console.WriteLine("Jeu terminé!!");
            Console.ReadKey();

        }
    }
}
