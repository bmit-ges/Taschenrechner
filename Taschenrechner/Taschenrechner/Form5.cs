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
    public partial class Form5 : Form
    {
        int dec;

        public Form5()
        {
            InitializeComponent();
        }

        //Schliesst bei wechsel auf andere Form die aktive Form

        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            binText.Enabled = false;
            hexText.Enabled = false;
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void wissenschaftlichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            binText.Enabled = false;
            hexText.Enabled = false;
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void hexBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            binText.Enabled = false;
            hexText.Enabled = false;
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void heToolStripMenuItem_Click(object sender, EventArgs e)
        {
            binText.Enabled = false;
            hexText.Enabled = false;
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
        }

        //Wechsel der aktiven Felder Schwarz = aktiv, Weiss = inaktiv
        private void decHexRad_CheckedChanged(object sender, EventArgs e)
        {
            hexText.Enabled = false;
            hexText.ForeColor = Color.Black;

            binText.Enabled = true;
            binText.ForeColor = Color.White;

            binText.Focus();

            clear();
        }

        //Wechsel der aktiven Felder Schwarz = aktiv, Weiss = inaktiv
        private void hexDecRad_CheckedChanged(object sender, EventArgs e)
        {
            binText.Enabled = false;
            binText.ForeColor = Color.Black;

            hexText.Enabled = true;
            hexText.ForeColor = Color.White;

            hexText.Focus();

            clear();
        }

        //Konvertierung von hex und bin
        private void convert_Click(object sender, EventArgs e)
        {


            if (hexText.Enabled == true)
            {

                try
                {
                    binText.Text = "";
                    hexText.Text = hexText.Text.Replace(" ", "");

                    //konvertiert hex zu dec
                    dec = Convert.ToInt32(hexText.Text, 16);

                    //konvertiert dec zu hex
                    binText.Text = binText.Text + Convert.ToString(dec, 2);
                }
                catch 
                {
                    MessageBox.Show("Nicht zugelassene Zeichen");
                    hexText.Text = hexText.Text;
                    binText.Text = binText.Text;
                }

            }
            else
            {
               
                hexText.Text = "";
                try
                {
                    binText.Text = binText.Text.Replace(" ", "");
                    //konvertiert bin zu hex
                    hexText.Text = hexText.Text + Convert.ToString(Convert.ToInt64(binText.Text, 2), 16).ToUpper();
                }
                catch {
                    MessageBox.Show("Nicht zugelassene Zeichen");
                    hexText.Text = hexText.Text;
                    binText.Text = binText.Text;
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
            hexText.Text = "";
            binText.Text = "";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ESPAS\n\nErstellt von: Sibylle Gehring \nAm: 17.08.2022\n\nVersion: 1.0.0");
        }
    }
}
