using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        #region Code
        char[] characters = new char[] { 'А', 'Б', 'В', 'Г', 'Д', 'Е', 'Ж', 'З', 'И',
                                         'Й', 'К', 'Л', 'М', 'Н', 'О', 'П', 'Р', 'С',
                                         'Т', 'У', 'Ф', 'Х', 'Ц', 'Ч', 'Ш', 'Щ', 'Ы', 'Ь',
                                         'Э', 'Ю', 'Я', '1', '2', '3', '4', '5', '6', '7',
                                         '8', '9', '0' };

        string[] codeMorse = new string[] { "*–", "–***", "*––", "––*",
                                            "–**", "*", "***–", "––**",
                                            "**", "*–––", "–*–", "*–**",
                                            "––", "–*", "–––", "*––*",
                                            "*–*", "***", "–", "**–",
                                            "**–*", "****", "–*–*",
                                            "–––*", "––––", "−−*−",
                                            "−*−−", "−**−", "**−**",
                                            "**−−", "*−*−", "*−−−−",
                                            "**−−−", "***−−", "****−",
                                            "*****", "−****", "−−***",
                                            "−−−**", "−−−−*", "−−−−−" };
        #endregion
        #region TextBox
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        #endregion
        #region Label
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
        #endregion

        private void button1_Click(object sender, EventArgs e)
        {
            string input = textBox1.Text;
            input = input.ToUpper();
            string output = "";
            int index;
            foreach (char c in input)
            {
                if (c != ' ')
                {
                    index = Array.IndexOf(characters, c);
                    output += codeMorse[index] + " ";
                }
            }
            output = output.Remove(output.Length - 1);
            textBox2.Text = output;
        }
    }
}
