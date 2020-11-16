using System;

namespace conversion
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Veuillez saisir la distance à convertir en miles ou km ( unité km ou mi)");
            string Dist = Console.ReadLine().ToLower();
            double Distance;
            bool testnombre = false;
            testnombre = double.TryParse(Dist, out Distance);

            if (testnombre == true)
            {
                Distance = Distance / 1.609;

                Console.WriteLine("la distance est de :" + Math.Round(Distance, 3) + " miles");

            }

            else
            {



                string sschaine = Dist.Substring(Dist.Length - 2, 2);
                Distance = double.Parse((Dist.Substring(0, (Dist.Length - 3))));
                if (sschaine == "mi")
                {
                    Distance = Distance * 1.609;
                    Console.WriteLine("la distance est  de: " + Math.Round(Distance, 3) + " km");

                }

                else if (sschaine == "km")
                {
                    Distance = Distance / 1.609;

                    Console.WriteLine("la distance est de :" + Math.Round(Distance, 3) + " miles");
                }
                else
                {
                    Console.WriteLine("conversion impossible, unité inconnue!!");
                }
            }
        }

    }
}
