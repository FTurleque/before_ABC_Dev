using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcVehicule
{
    class Program
    {
        static List<Vehicule> listeVehicules;

        static void Main(string[] args)
        {
            listeVehicules = new List<Vehicule>();

            int choix = AfficherMenu();

            while (choix != 5)
            {
                switch (choix)
                {
                    case 1:
                        // afficher la liste
                        AfficherListe();
                        break;
                    case 2:
                        // Ajouter une voiture
                        AjouterVoiture();
                        break;
                    case 3:
                        // Ajouter un utilitaire
                        AjouterUtilitaire();
                        break;
                    case 4:
                        // supprimmé véhicule
                        SupprimerVehicule();
                        break;
                }

                choix = AfficherMenu();
            }
        }

        private static void SupprimerVehicule()
        {
            Console.WriteLine("Suppression d'un véhicule à partire de son immatriculation");

            Console.Write(" Immatriculation ? ");
            String immatriculation = Console.ReadLine();

            int index = ChercherVehicule(immatriculation);

            if (index >= 0)
            {
                listeVehicules.RemoveAt(index);
                Console.WriteLine("Véhicule supprimé ! \n");
            }
            else
            {
                Console.WriteLine("Désolé, pas de véhicule correspondant !")
            }
        }

        private static int ChercherVehicule(string immatriculation)
        {
            int index = -1;
            foreach (Vehicule v in listeVehicules)
            {
                if(v.Immatriculation.Equals(immatriculation))
                {
                    return listeVehicules.IndexOf(v);
                }
            }
            return -1;
        }

        private static void AjouterUtilitaire()
        {
            Console.WriteLine("Ajouter un utilitaire : ");

            Console.Write(" Immatriculation ? ");
            String imm = Console.ReadLine();

            Console.Write(" Couleur ? ");
            String couleur = Console.ReadLine();

            Console.Write(" Marque ? ");
            String marque = Console.ReadLine();

            Console.Write(" Volume utile ? ");
            int volume = LireEntier();

            Utilitaire utilitaire = new Utilitaire(imm, marque, couleur, volume);
            listeVehicules.Add(utilitaire);

            Console.WriteLine("\n");

            // Sauvegarder les info

        }

        private static void AjouterVoiture()
        {
            Console.WriteLine("Ajouter une voiture : ");

            Console.Write(" Immatriculation ? ");
            String imm = Console.ReadLine();

            Console.Write(" Couleur ? ");
            String couleur = Console.ReadLine();

            Console.Write(" Marque ? ");
            String marque = Console.ReadLine();

            Console.Write(" Nombre de portes ? ");
            int nbPortes = LireEntier();

            Voiture voiture = new Voiture(imm, marque, couleur, nbPortes);
            listeVehicules.Add(voiture);

            Console.WriteLine("\n");
        }

        private static int LireEntier()
        {
            while (true)
            {
                int entier;
                if (int.TryParse(Console.ReadLine(), out entier))
                {
                    return entier;
                }
            }
        }

        private static void AfficherListe()
        {
            Console.WriteLine("Liste de véhicules :");
            foreach (Vehicule v in listeVehicules)
            {
                Console.WriteLine(v);
            }
            Console.WriteLine("\n");
        }

        private static int AfficherMenu()
        {
            while (true)
            {
                Console.WriteLine("Gestion d'un parc de véhicules");
                Console.WriteLine("Actuellement, il y a " + listeVehicules.Count + " véhicules dans le parc");

                Console.WriteLine("1 : afficher la liste de véhicules");
                Console.WriteLine("2 : ajouter une voiture");
                Console.WriteLine("3 : ajouter un utilitaire");
                Console.WriteLine("4 : supprimer un véhicule");
                Console.WriteLine("5 : quitter");

                String reponse = Console.ReadLine();
                int choix;

                if (int.TryParse(reponse, out choix))
                {
                    if (choix > 0 && choix <= 5)
                    {
                        return choix;
                    }
                }
            }
        }
    }
}
