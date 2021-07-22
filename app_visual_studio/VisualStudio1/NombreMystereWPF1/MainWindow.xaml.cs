using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace NombreMystereWPF
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        int Randomed;
        int NbEssais;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NouvellePartie();
        }

        private void btValider_Click(object sender, RoutedEventArgs e)
        {
            int pickedNum = PickANumber();

            if (pickedNum >= 0)
            {
                // A vous : Tant qu’on n’a pas trouvé on recommence
                // Trouvez la condition qui permet de refaire un essai de devinette
                if (pickedNum != Randomed)
                {
                    TryAgain(pickedNum);
                }
                else
                {
                    YouWin();
                }
            }
        }

        int PickANumber()
        {
            string picked = tbEssai.Text;

            // Vérifier la validité de la saisie avec TryParse
            int pickedNum;
            bool isNumeric = int.TryParse(picked, out pickedNum);
            if (isNumeric == false)
            {
                // A VOUS : Trouvez le code à écrire ici
                tbInfo.Text = "Ceci n'est pas un nombre... ";
                pickedNum = -1;
            }
            else
            {
                tbInfo.Text = "";

            }
            tbEssai.Text = "";

            return pickedNum;
        }

        private void btNouvellePartie_Click(object sender, RoutedEventArgs e)
        {
            NouvellePartie();
        }

        void NouvellePartie()
        {
            Randomed = GenereNombreAleatoire();
            tbInfo.Text = "";
            tbEssai.Text = "";
            NbEssais = 0;
            UpdateTry();
            btValider.IsEnabled = true;

        }

        void TryAgain(int pickedNum)
        {
            if ((pickedNum < 1) || (pickedNum > 20))
            {
                tbInfo.Text = "Ce nombre n'est pas valide : il doit être entre 1 et 20";
            }
            else
            {
                // A Vous : On aide l’utilisateur : on lui indique si c’est plus ou moins
                if (pickedNum > Randomed)
                {
                    tbInfo.Text = "C'est moins";
                }
                else
                {
                    tbInfo.Text = "C'est plus";
                }

                NbEssais = NbEssais + 1;
                UpdateTry();

            }
        }

        void UpdateTry()
        {
            tbNbEssais.Text = "Nb Essai : " + NbEssais;
        }

        void YouWin()
        {
            tbInfo.Text = "C'est gagné ! Bravo !";
            btValider.IsEnabled = false;

        }

        int GenereNombreAleatoire()
        {
            return new Random().Next(1, 21);
        }
    }
}
