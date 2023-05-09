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
    public partial class Form1 : Form
    {

        Form2 form2;
        Client michel;
        Client toto;
        Compte c1;
        Compte c2;
        Compte c3;
        List<Compte> lcBanque;

        public Form1()
        {
            InitializeComponent();
        }

        public void RefreshLB()
        {
            listBox1.DataSource = null;
            listBox1.DataSource = lcBanque;
        }

        private void sauvegarde()
        {
            FileStream stream = new FileStream("data", FileMode.Create);
            BinaryFormatter serializer = new BinaryFormatter();
            serializer.Serialize(stream, lcBanque);
            stream.Close();
        }

        private void chargement()
        {
            if(File.Exists("data"))
            {
                BinaryFormatter deserializer = new BinaryFormatter();
                FileStream stream = new FileStream("data", FileMode.Open);
                lcBanque = (List<Compte>)deserializer.Deserialize(stream);
                stream.Close();
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            chargement();

            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;

            RefreshLB();

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            lcBanque[listBox1.SelectedIndex].débiter(Convert.ToDouble(textBox1.Text));

            RefreshLB();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void crediterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = true;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void debiterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            lcBanque[listBox1.SelectedIndex].crediter(Convert.ToDouble(textBox2.Text));

            RefreshLB();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            lcBanque[listBox1.SelectedIndex].setDecouvert(Convert.ToInt32(textBox3.Text));

            RefreshLB();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            lcBanque[listBox1.SelectedIndex].getClient().setAdresse((textBox4.Text));

            RefreshLB();
        }

        private void decouvertToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = true;
            groupBox4.Visible = false;
        }

        private void adresseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            groupBox2.Visible = false;
            groupBox3.Visible = false;
            groupBox4.Visible = false;

            form2 = new Form2(lcBanque[listBox1.SelectedIndex].getClient(), this);
            form2.Show();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            sauvegarde();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
