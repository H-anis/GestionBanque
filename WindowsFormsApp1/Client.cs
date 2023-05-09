using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace WindowsFormsApp1
{
    [Serializable]
    public class Client
    {
        int num;
        string nom;
        string prenom;
        private string adresse;
        private List<Compte> comptes = new List<Compte>();

        public Client(int num, string nom, string prenom, string ad)
        {
            this.num = num;
            this.nom = nom;
            this.prenom = prenom;
            this.adresse = ad;
        }

        public string Prenom { get => prenom; }
        public string Adresse { get => adresse; set => adresse = value; }
        public string Nom { get => nom; }
        public int Num { get => num; }
        internal List<Compte> Comptes { get => comptes; }

        public override string ToString()
        {
            return ( this.nom + " " + this.prenom + " " + this.adresse);
        }

        public void setAdresse(string uneAdresse)
        {
            this.adresse = uneAdresse;
        }

        public string getAdresse()
        {
            return( this.adresse);
        }

        public string getNom()
        {
            return (this.nom);
        }

        public string getPrenom()
        {
            return (this.prenom);
        }
    }
}