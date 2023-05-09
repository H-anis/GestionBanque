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
    public class CompteEpargne : Compte
    {
        private int num;
        private Client proprio;
        private double solde;
        private double revenu;
        private double taux = 1;

        public void RefreshRevenu()
        {
            revenu = solde * taux / 100;
        }

        public CompteEpargne(int n, Client c) : base(n, c)
        {
            this.num = n;
            this.proprio = c;
            this.solde = 0;
            this.revenu = 0;
        }

        public override bool setDecouvert(int unDecouvert)
        {
            return (false);
        }

        public override string ToString()
        {
            return (this.num + " " + this.proprio + " " + this.solde + " " + this.revenu);
        }

        public override void crediter(double mont)
        {
            solde = solde + mont;
            RefreshRevenu();
        }

        public override bool débiter(double mont)
        {
            if (solde - mont < 0)
            {
                return false;
            }
            else
            {
                solde = solde - mont;
                RefreshRevenu();
                return true;
            }
        }
    }
}
