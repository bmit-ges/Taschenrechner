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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        //Schliesst bei wechsel auf andere Form die aktive Form
        private void toolStripMenuItem6_Click(object sender, EventArgs e)
        {
            decText.Enabled = false;
            hexText.Enabled = false;
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem5_Click(object sender, EventArgs e)
        {
            decText.Enabled = false;
            hexText.Enabled = false;
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            decText.Enabled = false;
            hexText.Enabled = false;
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            decText.Enabled = false;
            hexText.Enabled = false;
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
            this.Close();
        }

        //Wechsel der aktiven Felder Schwarz = aktiv, Weiss = inaktiv
        private void decHexRad_CheckedChanged(object sender, EventArgs e)
        {
            hexText.Enabled = false;
            hexText.ForeColor = Color.Black;

            decText.Enabled = true;
            decText.ForeColor = Color.White;

            decText.Focus();

            clear();
        }

        //Wechsel der aktiven Felder Schwarz = aktiv, Weiss = inaktiv
        private void hexDecRad_CheckedChanged(object sender, EventArgs e)
        {
            decText.Enabled = false;
            decText.ForeColor = Color.Black;

            hexText.Enabled = true;
            hexText.ForeColor = Color.White;

            hexText.Focus();

            clear();
        }

        //Konvertierung von hex und dec
        private void convert_Click(object sender, EventArgs e)
        {
    

            if (hexText.Enabled == true)
            {
                decText.Text = "";
                hexText.Text = hexText.Text.Replace(" ","");

                try
                {
                    //konvertiert hex zu dec

                    decText.Text = decText.Text + Convert.ToInt32(hexText.Text, 16);
                }
                catch
                {

                    MessageBox.Show("Nicht zugelassene Zeichen");
                    hexText.Text = hexText.Text;
                    decText.Text = decText.Text;
                }
                

               
            }
            else
            {
                hexText.Text = "";
                decText.Text = decText.Text.Replace(" ", "");

                try 
                {
                   
                    //konvertiert dec zu hex

                    hexText.Text = hexText.Text + int.Parse(decText.Text).ToString("X").ToUpper();
                }
                catch
                {
                    MessageBox.Show("Nicht zugelassene Zeichen");
                    hexText.Text = hexText.Text;
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
            hexText.Text = "";
            decText.Text = "";
        }

        private void toolStripMenuItem9_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ESPAS\n\nErstellt von: Sibylle Gehring \nAm: 17.08.2022\n\nVersion: 1.0");
        }
    }
}
