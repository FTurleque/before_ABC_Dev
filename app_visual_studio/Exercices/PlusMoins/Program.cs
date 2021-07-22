using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlusMoins
{
    class Program
    {
        static void Main(string[] args)
        {
            // Message d'acceuil
            Console.WriteLine("Jouons au plus au moins. Essaye de trouver à quel chiffre je pense (entre 1 et 100)");

            // Choix nombre aleatoire
            Random rand = new Random();
            int cible = rand.Next(1, 101);

            bool trouve = false;
            int nbEssais = 0;
            // Tant que l'utilisateur n'as pas trouvé
            while(!trouve)
            {
                // On lui demande un nombre
                Console.WriteLine("Propose un nombre");
                int proposition;

                // Si c'est un nombre correct
                if (int.TryParse(Console.ReadLine(), out proposition))
                {
                    // On incrémente son nombre d'essai
                    nbEssais++;

                    // On lui dit si c'est plus ou moins
                    if(proposition > cible)
                    {
                        Console.WriteLine("C'est moins !");
                    }
                    else if (proposition < cible)
                    {
                        Console.WriteLine("c'est plus !");
                    }
                    else
                    {
                        // S'il a trouvé : on lui affiche un message et on s'arrete
                        Console.WriteLine("Bravo tu as trouvé en " + nbEssais + "coups !");
                        trouve = true;
                    }

                }

            }


            // Fin du programme
            Console.ReadKey();
        }
    }
}
