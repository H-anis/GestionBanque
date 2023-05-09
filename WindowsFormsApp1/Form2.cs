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
    public partial class Form2 : Form
    {
        Client c;
        Form1 f;
        public Form2(Client unClient, Form1 unFormulaire)
        {
            this.c = unClient;
            this.f = unFormulaire;
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            label1.Text = c.getNom();
            label2.Text = c.getPrenom();
            label3.Text = c.getAdresse();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            c.setAdresse(textBox1.Text);
            f.RefreshLB();
            this.Close();
        }
    }
}
