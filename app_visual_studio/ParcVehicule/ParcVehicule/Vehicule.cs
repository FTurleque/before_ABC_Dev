using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcVehicule
{
    public abstract class Vehicule
    {
        protected string immatriculation;
        protected string marque;
        protected string couleur;

        public string Immatriculation { get => immatriculation; }

        // Constructeur
        public Vehicule(string _imm, string _marque, string _couleur)
        {
            Immatriculation = _imm;
            marque = _marque;
            couleur = _couleur;
        }

        public override string ToString()
        {
            return "Véhicule " + Immatriculation + " (" + marque + " ," + couleur + ")";
        }
    }
}
