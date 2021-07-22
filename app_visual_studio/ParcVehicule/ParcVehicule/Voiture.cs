using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcVehicule
{
    public class Voiture : Vehicule
    {
        protected int nbPortes;

        public Voiture(String _imm, String _marque, String _couleur, int _nbPortes) : base(_imm, _marque, _couleur)
        {
            nbPortes = _nbPortes;
        }

        public override string ToString()
        {
            return base.ToString() + " : voiture avec " + nbPortes + " portes";
        }
    }
}
