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
        int randomed;
        int nbEssais;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            NouvellePartie();
        }

        private void btnValider_Click(object sender, RoutedEventArgs e)
        {
            int pickedNum = PickANumber();

            if (pickedNum > 0)
            {
                if (pickedNum != randomed)
                {
                    pickedNum = TryAgain(pickedNum);
                    textBoxEssai.Text = string.Empty;
                }
                else
                {
                    YouWin();
                }
            }
        }

        private void btnNouvellePartie_Click(object sender, RoutedEventArgs e)
        {
            NouvellePartie();
        }
        
        void YouWin()
        {
            textBlockInfo.Text = "Bravo tu as Gagné !";
        }

        int PickANumber()
        {
            string picked = textBoxEssai.Text;

            // Vérifier la validité de la saisie avec TryParse
            int pickedNum;
            bool isNumeric = int.TryParse(picked, out pickedNum);
            if (isNumeric == false)
            {
                textBlockInfo.Text = "Oops, il ne s'agit pas d'un nombre. Essaie encore:";
            }
            else
            {
                textBlockInfo.Text = string.Empty;
            }

            return pickedNum;
        }

        void NouvellePartie()
        {
            randomed = GenereNombreAleatoire();
            textBlockInfo.Text = string.Empty;
            textBoxEssai.Text = string.Empty;
            nbEssais = 0;

            UpdateTry();
        }

        void UpdateTry()
        {
            textBlockNbEssai.Text = "Nb d'essai: " + nbEssais;
        }

        int GenereNombreAleatoire()
        {
            return new Random().Next(1, 21);
        }

        int TryAgain(int pickedNum)
        {
            if (pickedNum > randomed)
            {
                textBlockInfo.Text = "C'est moins";
            }
            else
            {
                textBlockInfo.Text = "C'est plus";
            }

            nbEssais = nbEssais + 1;
            UpdateTry();

            return pickedNum;
        }

    }
}
