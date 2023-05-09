using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
	[Serializable]
	public abstract class Compte
	{
		private int num;
		private Client proprio;
		private double solde;


		public Compte(int n, Client c)
        {
            num = n;
            solde = 0;
            proprio = c;
        }


		public int Numero
		{
			get
			{ return num; }
		}



		public string Description
		{
			get => num + " " + proprio + " " + solde + "€";
		}

		public Client Proprio { get => proprio; }

		public virtual void crediter(double mont)
		{
			solde = solde + mont;
		}

		public abstract bool setDecouvert(int unDecouvert);
		public virtual bool débiter(double mont)
		{
			if (solde - mont < 0)
			{
				return false;
			}
			else
			{
				solde = solde - mont;
				return true;
			}
		}

		public Client getClient()
        {
			return (this.proprio);
        }

		public double getSolde()
        {
			return (this.solde);
        }

	}


}
