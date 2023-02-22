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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        //Schliesst bei wechsel auf andere Form die aktive Form
        #region
        private void standartToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }

        private void hexBinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }

        private void heToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
        }

        private void binHexToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form5 f5 = new Form5();
            f5.ShowDialog();
            this.Close();
        }
        #endregion

        float f1;
        float f2;
        float solution;
        int op;
        int opdelcount;
        string historyString1;
        string historyString2;
        string fullHistoryString;
        List<String> historyList = new List<string>() { };
        Boolean resetCurrent;
        Boolean operator5;
        Boolean check;
        Boolean bracketCheckRight;
        Boolean bracketCheckLeft;

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
            if(resetCurrent == true)
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

        //Reseted alle Eingaben
        private void allClear_Click(object sender, EventArgs e)
        {
            current.Text = "";
            previous.Text = "";
        }

        //Löscht das letzte Zeichen
        private void del_Click(object sender, EventArgs e)
        {
            if (current.Text.Length >= 1)
            {
                current.Text = current.Text.Remove(current.Text.Length - 1);
            }
        }

        //Verhalten bei Operatoren Eingabe


        private void op1_Click(object sender, EventArgs e)
        {
            if (current.Text.Contains("(") || current.Text.Contains(")"))
            {
                current.Text = current.Text + op1.Text;
            }
            else
            {
                
                previous.Text = current.Text + op1.Text;
                op = 1;
                opdelcount = 1;
                current.Text = "";

            }
                    
        }

        private void op2_Click(object sender, EventArgs e)
        {
            if (current.Text.Contains("(") || current.Text.Contains(")"))
            {
                current.Text = current.Text + op2.Text;
            }
            else
            {

                previous.Text = current.Text + op2.Text;
                current.Text = "";
                op = 2;
                opdelcount = 1;
                current.Text = "";
            }

        }
        
        private void op3_Click(object sender, EventArgs e)
        {

            if (current.Text.Contains("(") || current.Text.Contains(")"))
            {
                current.Text = current.Text + op3.Text;
            }
            else
            {

                previous.Text = current.Text + op3.Text;
                op = 3;
                opdelcount = 1;
                current.Text = "";
            }
        }

        private void op4_Click(object sender, EventArgs e)
        {
            if (current.Text.Contains("(") || current.Text.Contains(")"))
            {
                current.Text = current.Text + op4.Text;
            }
            else
            {
                
                previous.Text = current.Text + op4.Text;
                op = 4;
                opdelcount = 1;
                current.Text = "";
            }
        }

        //wissenschaftliche operatoren
        private void wop1_Click(object sender, EventArgs e)
        {
            fullHistoryString = current.Text + " ^ " + current.Text;
            double convertcurrent = Convert.ToDouble(current.Text);
            current.Text = Convert.ToString(convertcurrent * convertcurrent);

            historyList.Add(fullHistoryString + "\n" + current.Text);

            history.Text = "";

            String[] historyArray = historyList.ToArray();
            for (int i = 0; i<historyArray.Length; i++)
            {
                history.Text = history.Text + historyArray[i] + "\n\n";
            }
            bracketCheckLeft = false;
            bracketCheckRight = false;
            check = false;
            resetCurrent = true;

        }

        private void wop2_Click(object sender, EventArgs e)
        {
            double convertcurrent =  Convert.ToDouble(current.Text);
            current.Text = Convert.ToString(Math.Sqrt(convertcurrent));
        }

        private void wop3_Click(object sender, EventArgs e)
        {

            if (resetCurrent == true)
            {
                current.Text = "";
                resetCurrent = false;
            }
            else
            {

                previous.Text = current.Text + "^";
                op = 5;
                operator5 = true;
                opdelcount = 1;
                current.Text = "";
            }


        }

        private void wop4_Click(object sender, EventArgs e)
        {
            if (resetCurrent == true)
            {
                current.Text = "";
                resetCurrent = false;
            }
            else
            {
                fullHistoryString =  current.Text + " ^ 10";
                double convertcurrent = Convert.ToDouble(current.Text);
                current.Text = Convert.ToString(Math.Pow(10, convertcurrent));

                
                history.Text = "";
                historyList.Add(fullHistoryString + "\n" + current.Text);
                String[] historyArray = historyList.ToArray();
                for (int i = 0; i < historyArray.Length; i++)
                {
                    history.Text = history.Text + historyArray[i] + "\n\n";
                }
                bracketCheckLeft = false;
                bracketCheckRight = false;
                check = false;
                resetCurrent = true;
            }

        }

        private void wop5_Click(object sender, EventArgs e)
        {
            current.Text = current.Text + Math.PI.ToString();
        }

        private void wop6_Click(object sender, EventArgs e)
        {
            if (resetCurrent == true)
            {
                current.Text = "";
                resetCurrent = false;
            }
            else
            {
                historyList.Add("!" + current.Text);
                String[] historyArray = historyList.ToArray();

                for (int i = 0; i < historyArray.Length; i++)
                {
                    history.Text = history.Text + historyArray[i] + "\n\n";
                }

                double j, fact = 1, number;
                number = int.Parse(current.Text);
                for (j = 1; j <= number; j++)
                {
                    fact = fact * j;
                }
                current.Text = Convert.ToString(fact);
                bracketCheckLeft = false;
                bracketCheckRight = false;
                check = false;
                resetCurrent = true;
            }
            
        }

        private void wop7_Click(object sender, EventArgs e)
        {

            if (resetCurrent == true)
            {
                current.Text = "";
                resetCurrent = false;
            }
            else
            {
                fullHistoryString = "Log " + current.Text;
                double convertcurrent = Convert.ToDouble(current.Text);
                current.Text = Convert.ToString(Math.Log10(convertcurrent));


                history.Text = "";
                historyList.Add(fullHistoryString + "\n" + current.Text);
                String[] historyArray = historyList.ToArray();
                for (int i = 0; i < historyArray.Length; i++)
                {
                    history.Text = history.Text + historyArray[i] + "\n\n";
                }
                resetCurrent = true;
                bracketCheckLeft = false;
                bracketCheckRight = false;
                check = false;
            }


        }

        private void wop8_Click(object sender, EventArgs e)
        {

                previous.Text = current.Text + "%";
                current.Text = "";
                op = 6;
            

        }

        private void wop9_Click(object sender, EventArgs e)
        {


            current.Text = current.Text + " (";
            

        }

        private void wop10_Click(object sender, EventArgs e)
        {


            current.Text = current.Text + ") ";
          
        }

        private void wop16_Click(object sender, EventArgs e)
        {

            string s = current.Text;

            if (s.Contains("-"))
            {
                
                current.Text = s.Remove(0, 1);
            }
            else
            {
                current.Text = "-" + current.Text;
            }
        }
        #endregion

        //Eingabe Numpad
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
            else if (e.KeyCode == Keys.Back)
            {


                if (current.Text.Length >= 1)
                {
                    current.Text = current.Text.Remove(current.Text.Length - 1);
                }
                

            }
            else if (e.KeyCode == Keys.Divide)
            {
                if (current.Text.Contains("(") || current.Text.Contains(")"))
                {
                    current.Text = current.Text + op1.Text;
                }
                else
                {

                    previous.Text = current.Text + op1.Text;
                    op = 1;
                    opdelcount = 1;
                    current.Text = "";
                }
            }
            else if (e.KeyCode == Keys.Multiply)
            {
                if (current.Text.Contains("(") || current.Text.Contains(")"))
                {
                    current.Text = current.Text + op2.Text;
                }
                else
                {


                    previous.Text = current.Text + op2.Text;
                    op = 2;
                    opdelcount = 1;
                    current.Text = "";
                }
            }
            else if (e.KeyCode == Keys.Add)
            {
                if (current.Text.Contains("(") || current.Text.Contains(")"))
                {
                    current.Text = current.Text + op3.Text;
                }
                else
                {


                    previous.Text = current.Text + op3.Text;
                    op = 3;
                    opdelcount = 1;
                    current.Text = "";
                }
            }
            else if (e.KeyCode == Keys.Subtract)
            {
                if (current.Text.Contains("(") || current.Text.Contains(")"))
                {
                    current.Text = current.Text + op4.Text;
                }
                else
                {


                    previous.Text = current.Text + op4.Text;
                    op = 4;
                    opdelcount = 1;
                    current.Text = "";
                }
            }
            else if (e.KeyCode == Keys.Enter)
            {

                previous.Text = current.Text.Replace(" ", ""); ;

                current.Text = calculationBrackets(current.Text);

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

        private void clearHistory_Click(object sender, EventArgs e)
        {

            history.Text = "";

            historyList.Clear();
            String[] historyArray = historyList.ToArray();
            Array.Clear(historyArray, 0, historyArray.Length);
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("ESPAS\n\nErstellt von: Sibylle Gehring \nAm: 17.08.2022\n\nVersion: 1.0.0");
        }

        private void bracketCheck(object sender, KeyEventArgs e)
        {
            if(current.Text.Contains("(") && !current.Text.Contains(")"))
            {

                current.Text = current.Text + previous.Text;
                equals.Enabled = false;
                if (e.KeyCode == Keys.Enter)
                {
                    e.SuppressKeyPress = false;
                }


            }
        }
        private static string calculationBrackets(string input)
        {
            List<string> toCalculate = new List<string>();
            List<string> results = new List<string>();
            string[] trims = input.Split(' ');

            //replace the "(" and add the parts to "toCalculate" list
            for (int i = 0; i < trims.Length; i++)
            {
                if (trims[i].Contains("(") || trims[i].Contains(")"))
                {
                    var newTrim = trims[i].Replace("(", "");
                    newTrim = newTrim.Replace(")", "");
                    trims.SetValue(newTrim, i);
                    toCalculate.Add(trims[i]);
                }
            }

            //replace the brackets with _
            foreach (string trim in trims)
            {
                if (input.Contains("(" + trim + ")"))
                {
                    input = input.Replace("(" + trim + ")", "_");
                }
            }

            //makes the calculation
            foreach (String calculation in toCalculate)
            {
                var result = new DataTable().Compute(calculation, null).ToString();
                results.Add(result);
            }

            //add the results back to the string
            while (input.Contains("_"))
            {
                for (int i = 0; i < results.Count; i++)
                {
                    int underscoreIndex = input.IndexOf("_");
                    if (underscoreIndex != -1)
                    { // underscore found in input string
                        input = input.Remove(underscoreIndex, 1).Insert(underscoreIndex, results[i]);
                        results.RemoveAt(i);
                        break; // break out of loop after replacing first underscore
                    }
                }
            }

            return new DataTable().Compute(input, null).ToString();
        }


        private void calculation()
        {
            try
            {

                check = true;
                if (current.Text.Contains("(") || current.Text.Contains(")"))
                {

                    check = false;

                    previous.Text = current.Text.Replace(" ", ""); ;

                    current.Text = calculationBrackets(current.Text);
                    

                    historyList.Add(previous.Text + "\n" + current.Text);

                }
                else if (bracketCheckLeft == false && bracketCheckRight == false && operator5 == false)
                {

                    if (opdelcount == 1)
                    {
                        previous.Text = previous.Text.Remove(previous.Text.Length - 1);
                        opdelcount--;
                    }
                    f2 = float.Parse(previous.Text);
                    f1 = float.Parse(current.Text);

                    historyString1 = previous.Text;
                    historyString2 = current.Text;


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
                            check = false; 

                        }
                    }
                    else if (op == 2)
                    {
                        solution = f1 * f2;
                        fullHistoryString = historyString2 + " * " + historyString1;
                        check = false;

                    }
                    else if (op == 3)
                    {
                        solution = f2 + f1;
                        fullHistoryString = historyString2 + " + " + historyString1;
                        check = false;

                    }
                    else if (op == 4)
                    {
                        solution = f2 - f1;
                        fullHistoryString = historyString1 + " - " + historyString2;
                        check = false;


                    }

                    else if (op == 6)
                    {
                        solution = f1 % f2;
                        fullHistoryString = historyString2 + " % " + historyString1;
                        check = false;

                    }

                    previous.Text = "";
                    current.Text = solution.ToString();

                    historyList.Add(fullHistoryString + "\n" + solution.ToString());
                }
                else if (operator5 == true)
                {
                    fullHistoryString = previous.Text + " ^ " + current.Text;

                    double convertedprevious = Convert.ToDouble(previous.Text);
                    double convertcurrent = Convert.ToDouble(current.Text);
                    double result = Math.Pow(convertedprevious, convertcurrent);

                    current.Text = Convert.ToString(result);
                    previous.Text = "";
                    historyList.Add(fullHistoryString + "\n" + current.Text);
                    bracketCheckLeft = false;
                    bracketCheckRight = false;
                    check = false;
                    operator5 = false;
                }
                history.Text = "";
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
