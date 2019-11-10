using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calc1
{
    public partial class Form1 : Form
    {
        DataTable dt = new DataTable();
        bool dot = false;
        bool inputOperation = true;
        bool inputNumber = true;
        bool closingBracket = false;
        int sizeNumber = 0;
        int countOpenBracket = 0;
        int countCloseBracket = 0;
        public Form1()
        {
            InitializeComponent();
        }
        
        private void MessageLimit()
        {
            DialogResult result = MessageBox.Show(
                "The limit of the input",
                "Message of limit",
                MessageBoxButtons.OK,
                MessageBoxIcon.Warning
                );
        }
        private void Button5_Click(object sender, EventArgs e)
        {
            if (inputNumber == true)
            {
                if (sizeNumber==15)
                {
                    MessageLimit();
                    return;
                }
                textBox1.Text = textBox1.Text + '1';
                inputOperation = true;
                sizeNumber++;
            }
        }

        private void Button6_Click(object sender, EventArgs e)
        {
            if (inputNumber == true)
            {
                if (sizeNumber == 15)
                {
                    MessageLimit();
                    return;
                }
                textBox1.Text = textBox1.Text + '2';
                inputOperation = true;
                sizeNumber++;
            }
        }

        private void Button7_Click(object sender, EventArgs e)
        {
            if (inputNumber == true)
            {
                if (sizeNumber == 15)
                {
                    MessageLimit();
                    return;
                }
                textBox1.Text = textBox1.Text + '3';
                inputOperation = true;
                sizeNumber++;
            }
        }

        private void Button9_Click(object sender, EventArgs e)
        {
            if (inputNumber == true)
            {
                if (sizeNumber == 15)
                {
                    MessageLimit();
                    return;
                }
                textBox1.Text = textBox1.Text + '4';
                inputOperation = true;
                sizeNumber++;
            }
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            if (inputNumber == true)
            {
                if (sizeNumber == 15)
                {
                    MessageLimit();
                    return;
                }
                textBox1.Text = textBox1.Text + '5';
                inputOperation = true;
                sizeNumber++;
            }
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            if (inputNumber == true)
            {
                if (sizeNumber == 15)
                {
                    MessageLimit();
                    return;
                }
                textBox1.Text = textBox1.Text + '6';
                inputOperation = true;
            }
        }

        private void Button13_Click(object sender, EventArgs e)
        {
            if (inputNumber == true)
            {
                if (sizeNumber == 15)
                {
                    MessageLimit();
                    return;
                }
                textBox1.Text = textBox1.Text + '7';
                inputOperation = true;
                sizeNumber++;
            }
        }

        private void Button14_Click(object sender, EventArgs e)
        {
            if (inputNumber == true)
            {
                if (sizeNumber == 15)
                {
                    MessageLimit();
                    return;
                }
                textBox1.Text = textBox1.Text + '8';
                inputOperation = true;
                sizeNumber++;
            }
        }

        private void Button15_Click(object sender, EventArgs e)
        {
            if (inputNumber == true)
            {
                if (sizeNumber == 15)
                {
                    MessageLimit();
                    return;
                }
                textBox1.Text = textBox1.Text + '9';
                inputOperation = true;
                sizeNumber++;
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if (inputNumber == true)
            {
                if (sizeNumber == 15)
                {
                    MessageLimit();
                    return;
                }
                textBox1.Text = textBox1.Text + '0';
                inputOperation = true;
                sizeNumber++;
                int lenght = textBox1.Text.Length - 1;
                if (lenght == 0)
                {
                    return;
                }
                string text = textBox1.Text;
                if (text[lenght-1]=='+'|| text[lenght - 1] == '-' || text[lenght - 1] == '*' || text[lenght - 1] == '/' )
                {
                    inputNumber = false;
                }
            }
        }

        private void Button17_Click(object sender, EventArgs e)
        {
            textBox1.Clear();
            dot = false;
            inputOperation = true;
            inputNumber = true;
            closingBracket = false;
            sizeNumber = 0;

        }

        private void Button18_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            if (lenght==-1)
            {
                return;
            }
            string text = textBox1.Text;
            textBox1.Clear();
            for (int i = 0; i < lenght; i++)
            {
                textBox1.Text = textBox1.Text + text[i];
            }
            if (text[lenght]=='+'|| text[lenght] == '-' || text[lenght] == '*' || text[lenght] == '/')
            {
                inputOperation = true;
            }
            if (text[lenght] == '.')
            {
                dot = false;
            }
            if (lenght != 0 && text[lenght-1]=='.')
            {
                dot = true;
            }
            if (lenght==1 && text[lenght-1]=='0')
            {
                inputNumber = false;
            }else if(text[lenght] == '0'&& (text[lenght-1] == '+' || text[lenght-1] == '-' || text[lenght-1] == '*' || text[lenght-1] == '/'))
            {
                inputNumber = false;
            }
        }

        private void Button4_Click(object sender, EventArgs e)
        {
            if (inputOperation == true)
            {
                textBox1.Text = textBox1.Text + '+';
                inputOperation = false;
                dot = false;
                sizeNumber = 0;
                inputNumber = true;
            }
        }

        private void Button8_Click(object sender, EventArgs e)
        {
            if (inputOperation == true)
            {
                textBox1.Text = textBox1.Text + '-';
                inputOperation = false;
                dot = false;
                sizeNumber = 0;
                inputNumber = true;
            }
            
        }

        private void Button12_Click(object sender, EventArgs e)
        {
            if (inputOperation == true)
            {
                textBox1.Text = textBox1.Text + '*';
                inputOperation = false;
                dot = false;
                sizeNumber = 0;
                inputNumber = true;
            }
        }

        private void Button16_Click(object sender, EventArgs e)
        {
            if (inputOperation == true)
            {
                textBox1.Text = textBox1.Text + '/';
                inputOperation = false;
                dot = false;
                sizeNumber = 0;
                inputNumber = true;
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            if (CheckLastOperation(text[lenght])==true)
            {
                return;
            }else if (dot != true)
            {
                textBox1.Text = textBox1.Text + '.';
                dot = true;
                inputOperation = false;
                inputNumber = true;
            }
            
        }
        private void Error()
        {
            string answearInTextBox = "Error!";
            textBox1.Text = answearInTextBox;
            DialogResult result = MessageBox.Show(
                "Error!",
                "Error Message",
                MessageBoxButtons.OK,
                MessageBoxIcon.Error
                );
            if (result == DialogResult.OK || result == DialogResult.Cancel)
            {
                inputNumber = false;
            }
            return;
        }
        private bool CheckOperation()
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            if (text[lenght]=='+'|| text[lenght] == '-'||text[lenght] == '*'|| text[lenght] == '/')
            {
                Error();
                return true;
            }
            return false;
        }
        private void Button3_Click(object sender, EventArgs e)
        {
            if (countCloseBracket!=countOpenBracket)
            {
                Error();
                Button17_Click(sender, e);
                return;
            }
            if (CheckOperation()==true)
            {
                Button17_Click(sender, e);
                return;
            }
            if (closingBracket==true)
            {
                Error();
                Button17_Click(sender, e);
                return;
            }
            var ans = dt.Compute(textBox1.Text, "");
            textBox1.Clear();
            string answearInTextBox = ans.ToString();
            if (answearInTextBox== "∞")
            {
                Error();
                Button17_Click(sender, e);
                return;
            }
            answearInTextBox = answearInTextBox.Replace(',', '.');
            textBox1.Text = answearInTextBox;
        }

        private bool CheckBracket()
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            string alf = "0123456789";
            if (alf.IndexOf(text[lenght])!=-1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        private bool CheckLastOperation(char lastChar)
        {
            string opertaionAlf = "+-*/";
            if (opertaionAlf.IndexOf(lastChar)!=-1)
            {
                return true;
            }
            return false;    
        }
        private void Button19_Click(object sender, EventArgs e)
        {
            int lenght = textBox1.Text.Length - 1;
            string text = textBox1.Text;
            if (lenght != -1 && text[lenght] == '.')
            {
                return;
            }
            if (countOpenBracket==0)
            {
                textBox1.Text = textBox1.Text + "(";
                countOpenBracket++;
            }
            else if (countOpenBracket>countCloseBracket)
            {
                if (CheckLastOperation(text[lenght])==true)
                {
                    textBox1.Text = textBox1.Text + "(";
                    countOpenBracket++;
                }
                else if (CheckBracket()==true||text[lenght]==')')
                {
                    textBox1.Text = textBox1.Text + ")";
                    countCloseBracket++;
                }
                else if (text[lenght] == '(')
                {
                    textBox1.Text = textBox1.Text + "(";
                    countOpenBracket++;
                }
            }
            else
            {
                textBox1.Text = textBox1.Text + "(";
                countOpenBracket++;
            }
        }
    }
}
