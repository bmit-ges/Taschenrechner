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
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();

        }

        //Schliesst bei wechsel auf andere Form die aktive Form
        #region
        private void wissenschaftlichToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }

        private void decBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void decHexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
        }

        private void hexBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
            this.Close();
        }
        #endregion
        float solution;
        float f1;
        float f2;
        int op;
        int opdelcount;
        string historyString1;
        string historyString2;
        string fullHistoryString;
        List<String> historyList = new List<string>(){ };
        Boolean resetCurrent;
        Boolean check;

        //Ausrechnung
        #region

        private void equals_Click(object sender, EventArgs e)
        {
            calculation();
        }

        #endregion
        //Eingabe Manuell
        #region
        private void num1_Click(object sender, EventArgs e)
        {
            if (resetCurrent == true)
            {
                current.Text = "";
                current.Text = num1.Text;
                resetCurrent = false;
            }
            else
            {
                current.Text = current.Text + num1.Text;
                checking();
            }

        }

        private void num2_Click(object sender, EventArgs e)
        {
            if (resetCurrent == true)
            {
                current.Text = "";
                current.Text = num2.Text;
                resetCurrent = false;
            }
            else
            {
                current.Text = current.Text + num2.Text;
                checking();
            }

        }

        private void num3_Click(object sender, EventArgs e)
        {
            if (resetCurrent == true)
            {
                current.Text = "";
                current.Text = num3.Text;
                resetCurrent = false;
            }
            else
            {
                current.Text = current.Text + num3.Text;
                checking();
            }

        }

        private void num4_Click(object sender, EventArgs e)
        {
            if (resetCurrent == true)
            {
                current.Text = "";
                current.Text = num4.Text;
                resetCurrent = false;
            }
            else
            {
                current.Text = current.Text + num4.Text;
                checking();
            }

        }

        private void num5_Click(object sender, EventArgs e)
        {
            if (resetCurrent == true)
            {
                current.Text = "";
                current.Text = num5.Text;
                resetCurrent = false;
            }
            else
            {
                current.Text = current.Text + num5.Text;
            }

        }

        private void num6_Click(object sender, EventArgs e)
        {
            if (resetCurrent == true)
            {
                current.Text = "";
                current.Text = num6.Text;
                resetCurrent = false;
            }
            else
            {
                current.Text = current.Text + num6.Text;
                checking();
            }

        }

        private void num7_Click(object sender, EventArgs e)
        {
            if (resetCurrent == true)
            {
                current.Text = "";
                current.Text = num7.Text;
                resetCurrent = false;
            }
            else
            {
                current.Text = current.Text + num7.Text;
                checking();
            }

        }

        private void num8_Click(object sender, EventArgs e)
        {
            if (resetCurrent == true)
            {
                current.Text = "";
                current.Text = num8.Text;
                resetCurrent = false;
            }
            else
            {
                current.Text = current.Text + num8.Text;
                checking();
            }

        }

        private void num9_Click(object sender, EventArgs e)
        {

            if (resetCurrent == true)
            {
                current.Text = "";
                current.Text = num9.Text;
                resetCurrent = false;
            }
            else
            {
                current.Text = current.Text + num9.Text;
                checking();
            }

;
        }
        private void num11_Click(object sender, EventArgs e)
        {
            if (resetCurrent == true)
            {
                current.Text = "";
                current.Text = num11.Text;
                resetCurrent = false;
            }
            else
            {
                current.Text = current.Text + num11.Text;
                checking();
            }

        }

        //Eingabe Sonderzeichen
        private void num10_Click(object sender, EventArgs e)
        {
            if (resetCurrent == true)
            {
                current.Text = "";
                resetCurrent = false;
            }
            else if (current.Text.Length >= 1 && !(current.Text.Contains(".")))
            {
                current.Text = current.Text + num10.Text;
                checking();
            }

        }

        //Operator Eingabe
        private void op1_Click(object sender, EventArgs e)
        {
            checking();
            previous.Text = current.Text + op1.Text;
            opdelcount = 1;
            current.Text = "";
        }

        private void op2_Click(object sender, EventArgs e)
        {
            checking();
            previous.Text = current.Text + op2.Text;
            opdelcount = 1;
            op = 2;
            current.Text = "";
        }

        private void op3_Click(object sender, EventArgs e)
        {
            checking();
            previous.Text = current.Text + op3.Text;
            opdelcount = 1;
            op = 3;
            current.Text = "";
        }

        private void op4_Click(object sender, EventArgs e)
        {
            checking();
            previous.Text = current.Text + op4.Text;
            opdelcount = 1;
            op = 4;
            current.Text = "";
        }

        //Löscht alles
        private void allClear_Click(object sender, EventArgs e)
        {
            check = false;
            current.Text = "";
            previous.Text = "";

        }

        //Löscht das letzte Zeichen
        private void del_Click(object sender, EventArgs e)
        {
            if(current.Text.Length >= 1)
            {
                current.Text = current.Text.Remove(current.Text.Length - 1);
            }
            
        }
        #endregion

        //Tastatur eingabe
        #region
        private void numKeys(object sender, KeyEventArgs e)

        {

          
            if (e.KeyCode == Keys.NumPad1)
            {
                if (resetCurrent == true)
                {
                    current.Text = "";
                    current.Text = num1.Text;
                    resetCurrent = false;
                }
                else
                {
                    current.Text = current.Text + num1.Text;
                    checking();
                }
            }
            else if (e.KeyCode == Keys.NumPad2)
            {
                if (resetCurrent == true)
                {
                    current.Text = "";
                    current.Text = num2.Text;
                    resetCurrent = false;
                }
                else
                {
                    current.Text = current.Text + num2.Text;
                    checking();
                }

            }
            else if (e.KeyCode == Keys.NumPad3)
            {
                if (resetCurrent == true)
                {
                    current.Text = "";
                    current.Text = num3.Text;
                    resetCurrent = false;
                }
                else
                {
                    current.Text = current.Text + num3.Text;
                    checking();
                }
            }
            else if (e.KeyCode == Keys.NumPad4)
            {
                if (resetCurrent == true)
                {
                    current.Text = "";
                    current.Text = num4.Text;
                    resetCurrent = false;
                }
                else
                {
                    current.Text = current.Text + num4.Text;
                    checking();
                }
            }
            else if (e.KeyCode == Keys.NumPad5)
            {
                if (resetCurrent == true)
                {
                    current.Text = "";
                    current.Text = num5.Text;
                    resetCurrent = false;
                }
                else
                {
                    current.Text = current.Text + num5.Text;
                    checking();
                }
            }
            else if (e.KeyCode == Keys.NumPad6)
            {
                if (resetCurrent == true)
                {
                    current.Text = "";
                    current.Text = num6.Text;
                    resetCurrent = false;
                }
                else
                {
                    current.Text = current.Text + num6.Text;
                    checking();
                }
            }
            else if (e.KeyCode == Keys.NumPad7)
            {
                if (resetCurrent == true)
                {
                    current.Text = "";
                    current.Text = num7.Text;
                    resetCurrent = false;
                }
                else
                {
                    current.Text = current.Text + num7.Text;
                    checking();
                }
            }
            else if (e.KeyCode == Keys.NumPad8)
            {
                if (resetCurrent == true)
                {
                    current.Text = "";
                    current.Text = num8.Text;
                    resetCurrent = false;
                }
                else
                {
                    current.Text = current.Text + num8.Text;
                    checking();
                }
            }
            else if (e.KeyCode == Keys.NumPad9)
            {
                if (resetCurrent == true)
                {
                    current.Text = "";
                    current.Text = num9.Text;
                    resetCurrent = false;
                }
                else
                {
                    current.Text = current.Text + num9.Text;
                    checking();
                }
            }
            else if (e.KeyCode == Keys.NumPad0)
            {
                current.Text = current.Text + num11.Text;
                checking();
            }

            else if (e.KeyCode == Keys.Divide)
            {
                previous.Text = current.Text + op1.Text;
                op = 1;
                opdelcount = 1;
                current.Text = "";
                checking();
            }
            else if (e.KeyCode == Keys.Decimal)
            {
                if (resetCurrent == true)
                {
                    current.Text = "";
                    resetCurrent = false;
                }
                else if (current.Text.Length >= 1 && !(current.Text.Contains(".")))
                {
                    current.Text = current.Text + num10.Text;
                    checking();
                }

            }
            else if (e.KeyCode == Keys.Multiply)
            {
                previous.Text = current.Text + op2.Text;
                op = 2;
                opdelcount = 1;
                current.Text = "";
                checking();
            }
            else if (e.KeyCode == Keys.Back)
            {
                if (current.Text.Length >= 1)
                {
                    current.Text = current.Text.Remove(current.Text.Length - 1);
                }
            }
            else if (e.KeyCode == Keys.Add)
            {
                previous.Text = current.Text + op3.Text;
                opdelcount = 1;
                op = 3;
                current.Text = "";
                checking();
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                previous.Text = current.Text + op4.Text;
                opdelcount = 1;
                op = 4;
                current.Text = "";
                checking();
            }
            else if (e.KeyCode == Keys.Delete)
            {
                current.Text = current.Text.Remove(current.Text.Length - 1);
            }
            else if (e.KeyCode == Keys.Enter)
            {
                calculation();
            }
        }
        #endregion
        private void checking()
        {
            if (check == true)
            {
                current.Text = solution.ToString();
            }
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clearHistory_Click(object sender, EventArgs e)
        {
            history.Text = "";

            historyList.Clear();
            String[] historyArray = historyList.ToArray();
            Array.Clear(historyArray, 0, historyArray.Length);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ESPAS\n\nErstellt von: Sibylle Gehring \nAm: 17.08.2022\n\nVersion: 1.0");
        }

        private void calculation()
        {
            try
            {
                check = true;

                if (opdelcount == 1)
                {
                    previous.Text = previous.Text.Remove(previous.Text.Length - 1);
                    opdelcount--;
                }


                f2 = float.Parse(previous.Text);
                f1 = float.Parse(current.Text);

                historyString2 = previous.Text;
                historyString1 = current.Text;

                if (op == 1)
                {
                    if (f1 == 0)
                    {
                        MessageBox.Show("Can't divide by 0, please clear.", "Error");

                    }
                    else
                    {
                        solution = f2 / f1;
                        fullHistoryString = historyString2 + " / " + historyString1;
                    }
                    check = false;


                }
                else if (op == 2)
                {
                    solution = f1 * f2;
                    fullHistoryString = historyString1 + " * " + historyString2;
                    check = false;

                }
                else if (op == 3)
                {
                    solution = f2 + f1;
                    fullHistoryString = historyString1 + " + " + historyString2;
                    check = false;

                }
                else if (op == 4)
                {
                    solution = f2 - f1;
                    fullHistoryString = historyString1 + " - " + historyString2;
                    check = false;


                }
                previous.Text = "";
                current.Text = solution.ToString();

                history.Text = "";
                historyList.Add(fullHistoryString + "\n" + solution.ToString());
                String[] historyArray = historyList.ToArray();
                for (int i = 0; i < historyArray.Length; i++)
                {
                    history.Text = history.Text + historyArray[i] + "\n\n";
                }
                resetCurrent = true;


            }
            catch
            {
                MessageBox.Show("Nicht zugelassene Zeichen");
                current.Text = current.Text;
                previous.Text = previous.Text;
                check = false;
            }
        }
    }
}

