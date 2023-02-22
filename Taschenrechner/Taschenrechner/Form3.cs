using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Taschenrechner
{
    public partial class Form3 : Form
    {


        public Form3()
        {
            InitializeComponent();
        }

        //Schliesst bei wechsel auf andere Form die aktive Form
        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decText.Enabled = false;
            binText.Enabled = false;
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void wissenschaftlichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decText.Enabled = false;
            binText.Enabled = false;
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void heToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decText.Enabled = false;
            binText.Enabled = false;
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
        }

        private void binHexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            decText.Enabled = false;
            binText.Enabled = false;
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
            this.Close();
        }

        //Wechsel der aktiven Felder Schwarz = aktiv, Weiss = inaktiv
        private void decBinRad_CheckedChanged(object sender, EventArgs e)
        {
            
            binText.Enabled = false;
            binText.ForeColor = Color.Black;
            
            decText.Enabled = true;
            decText.ForeColor = Color.White;

            decText.Focus();

            clear();


        }



        //Wechsel der aktiven Felder Schwarz = aktiv, Weiss = inaktiv

        private void binDecRad_CheckedChanged(object sender, EventArgs e)
        {
            
            decText.Enabled=false;
            decText.ForeColor = Color.Black;
            
            binText.Enabled = true;
            binText.ForeColor = Color.White;

            binText.Focus();

            clear();

        }

        private void convert_Click(object sender, EventArgs e)
        {

            if (decText.Enabled == true)
            {
                binText.Text = "";
                try
                {
                    decText.Text = decText.Text.Replace(" ", "");
                    //konvertiert dec zu bin
                    binText.Text = binText.Text + Convert.ToString(int.Parse(decText.Text), 2);
                }
                catch
                {
                    MessageBox.Show("Nicht zugelassene Zeichen");
                    binText.Text = binText.Text;
                    decText.Text = decText.Text;
                }


            }
            else
            {
                decText.Text = "";
                try
                {
                    binText.Text = binText.Text.Replace(" ", "");
                    //konvertiert bin zu dec
                    decText.Text = decText.Text + Convert.ToInt32(binText.Text, 2);
                }
                catch
                {
                    MessageBox.Show("Nicht zugelassene Zeichen");
                    binText.Text = binText.Text;
                    decText.Text = decText.Text;
                }
            }
        }

        //Reseted alle eingaben
        private void reset_Click(object sender, EventArgs e)
        {
            clear();

        }

        //Funktion zur Bereinugung der Eingabefelder
        private void clear()
        {
            binText.Text = "";
            decText.Text = "";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ESPAS\n\nErstellt von: Sibylle Gehring \nAm: 17.08.2022\n\nVersion: 1.0.0");
        }
    }
}
