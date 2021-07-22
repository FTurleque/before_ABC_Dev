using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NombreMystereConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // Génération d'un nombre aléatoire entre 1 et 20 içi.
            int randomed = new Random().Next(20) + 1;

            NouvellePartie(randomed);

            YouWin(randomed);
            Console.ReadKey();
        }

        static void YouWin(int randomed)
        {
            // on sort de la boucle quand les 2 nombres sont identique
            Console.WriteLine("Yes ! Vous avez trouvé le nombre:" + randomed);

        }

        static void NouvellePartie(int randomed)
        {
            Console.WriteLine("Saisissez un nombre entre 1 et 20:");

            int pickedNum = PickANumber();

            while (pickedNum != randomed)
            {
                if (pickedNum > randomed)
                { 
                    Console.WriteLine("It's less");
                }
                else
                {
                    Console.WriteLine("It's more");
                }

                pickedNum = PickANumber();
            }
        }

        static int PickANumber()
        {
            string picked = Console.ReadLine();

            // Vérifier la validité de la saisie avec TryParse
            int pickedNum;
            // bool isNumeric = int.TryParse(picked, out pickedNum);
            // bool isNumeric; déclaration variable
            // isNumeric = int.TryParse(picked, out pickedNum); afféctation variable

            // Puis on encadre ca dans une boucle pour r"itérer la saisie jusqu'a ce qu'elle soit valide
            while (int.TryParse(picked, out pickedNum) == false)
            {
                Console.WriteLine("Oops, il ne s'agit pas d'un nombre. Essaie encore:");
                picked = Console.ReadLine();
                //isNumeric = int.TryParse(picked, out pickedNum);
            }

            return pickedNum;
        }
    }
}
