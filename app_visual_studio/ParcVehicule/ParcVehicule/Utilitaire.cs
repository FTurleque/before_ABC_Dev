using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ParcVehicule
{
    public class Utilitaire : Vehicule
    {
        // Volume utile
        protected int volume;

        public Utilitaire(String _imm, String _marque, String _couleur, int _volume) : base(_imm, _marque, _couleur)
        {
            volume = _volume;
        }

        public override string ToString()
        {
            return base.ToString() + " : utilitaire de " + volume + " m3";
        }
    }
}
