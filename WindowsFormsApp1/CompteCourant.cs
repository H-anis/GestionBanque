using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WindowsFormsApp1
{
    [Serializable]
    public class CompteCourant : Compte
    {

        private int num;
        private Client proprio;
        private double solde;
        private double decouvert;

        public CompteCourant(int n, Client c) : base(n, c)
        {
            this.num = n;
            this.proprio = c;
            this.solde = 0;
            this.decouvert = 0;
        }

        public override string ToString()
        {
            return (this.num + " " + this.proprio + "" + this.solde + " " + this.decouvert);
        }

        public double Decouvert { get => decouvert; set => decouvert = value; }

        public override bool setDecouvert(int unDecouvert)
        {
            if (-unDecouvert > solde)
            { return false; }
            else { this.decouvert = unDecouvert; return true; }

        }

        public override bool débiter(double mont)
        {
            if (solde - mont < -decouvert)
            {
                return false;
            }
            else
            {
                solde = solde - mont;
                return true;
            }
        }
    }
}
