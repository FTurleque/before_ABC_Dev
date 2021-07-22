using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Morpion
{
    class Program
    {
        enum EtatCase
        {
            Vide,
            Rond,
            Croix
        }

        static EtatCase[,] grille; //grille de 3*3 cases
        static Random generateur; // générateur aléatoire
         
        static void Main(string[] args)
        {
            // Message d'aceuil
            Console.WriteLine("Bienvenue dans le jeu du Morpion\n");

            // Initialiser toutes les variables
            bool finDeJeu = false;
            grille = new EtatCase[3, 3];
            int nbVide = 9;
            generateur = new Random();

            // Afficher la grille
            AfficherGrille();

            
            // Boucle principale
            while(!finDeJeu)
            {
                // Jeu de l'utilisateur
                ChoisirCaseUtilisateur();
                nbVide--;

                // Affichage de la grille
                AfficherGrille();

                // Jeu gagnant ?
                bool gagne = JeuGagnant(EtatCase.Croix);
                if (gagne)
                {
                    finDeJeu = true;
                    Console.WriteLine("Bravo vous avez gagné !");
                }
                // jeu de l'ordinateur
                if (!finDeJeu && nbVide > 0)
                {
                    choisirCaseOrdinateur();
                    nbVide--;
                
                    // Affichage grille
                    Console.WriteLine("L'ordinateur à joué :");
                    AfficherGrille();

                    // Jeu gagnant ? 
                    if (JeuGagnant(EtatCase.Rond))
                    {
                        finDeJeu = true;
                        Console.WriteLine("Dommage, l'ordinateur à gagné :(");
                    }

                }
                // Match nul ?
                if (nbVide == 0)
                {
                    Console.WriteLine("Match nul !");
                    finDeJeu = true;
                }

            }

            // Fin du jeu
            Console.WriteLine("Appuyer sur une touche pour fermer ...");
            Console.ReadKey();
        }

        private static bool JeuGagnant(EtatCase etatCase)
        {
            // Cas d'une ligne
            for (int ligne = 0; ligne < 3; ligne++)
            {
                if (grille[ligne, 0] == etatCase && grille[ligne, 1] == etatCase && grille[ligne, 2] == etatCase)
                {
                    return true;
                }
            }
            // Cas d'une colonne
            for (int colonne = 0; colonne < 3; colonne++)
            {
                if (grille[0, colonne] == etatCase && grille[1, colonne] == etatCase && grille[2, colonne] == etatCase)
                {
                    return true;
                }
            }
            // Cas des diagonales
            if (grille[0, 0] == etatCase && grille[1, 1] == etatCase && grille[2, 2] == etatCase)
            {
                return true;
            }
            if (grille[2, 0] == etatCase && grille[1, 1] == etatCase && grille[0, 2] == etatCase)
            {
                return true;
            }

            // Par défaut, on à pas gagné
            return false;
        }

        private static void choisirCaseOrdinateur()
        {
            // on boucle jusqu'à un choix corrext
            bool choixOK = false;

            while(!choixOK)
            {
                // Choix des coordonnées
                int ligne = generateur.Next(0, 3);
                int colonne = generateur.Next(0, 3);
                if (grille[ligne, colonne] == EtatCase.Vide)
                {
                    grille[ligne, colonne] = EtatCase.Rond;
                    choixOK = true;
                }
            }

        }


        /// <summary>
        /// Permet à l'utilisateur de choisir sa case, qui doit être libre et y mettre une croix
        /// </summary>
        private static void ChoisirCaseUtilisateur()
        {
            // On boucle jusqu'à un choix correct
            bool choixOK = false;

            while (!choixOK)
            {
                // Message
                Console.WriteLine("Donnez votre choix de case");

                // Recuperation de la reponse
                String reponse = Console.ReadLine();
                int choix;

                // Convertion vers entier, compris entre 0 et 8
                if (int.TryParse(reponse, out choix) && choix >= 0 && choix <= 8)
                {
                    // Case vide ?
                    int ligne = choix / 3;
                    int colonne = choix % 3;

                    if (grille [ligne, colonne] == EtatCase.Vide)
                    {
                        // Choix ok, je valide
                        grille[ligne, colonne] = EtatCase.Croix;
                        choixOK = true;
                    }
                }
            }
        }


        /// <summary>
        /// Affiche la grille du Morpion
        /// </summary>

        private static void AfficherGrille()
        {
            string dessinGrille = "\n";

            // Treait du haut
            dessinGrille += "*******\n";

            // Pour chaque ligne
            for (int ligne = 0; ligne < 3; ligne++)
            {
                dessinGrille += "|";
                // Pour chaque colonne
                for (int colonne = 0; colonne < 3; colonne++)
                {
                    switch(grille[ligne, colonne])
                    {
                        case EtatCase.Vide:
                            dessinGrille += ligne * 3 + colonne;
                            break;
                        case EtatCase.Croix:
                            dessinGrille += "X";
                            break;
                        case EtatCase.Rond:
                            dessinGrille += "O";
                            break;
                    }
                    dessinGrille += "|";
                }
                dessinGrille += "\n*******\n";
            }
            // Affichage en console
            Console.WriteLine(dessinGrille);
        }
    }
}
