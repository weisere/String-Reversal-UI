using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace String_Reversal
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public string reversed;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void Reverse_Click(object sender, EventArgs e)
        {
            Stack<char> charStack = new Stack<char>();

            // Push each character of the input string onto the stack
            foreach (char c in ReversableString.Text)
            {
                charStack.Push(c);
            }

            // Pop characters from the stack to form the reversed string
            char[] reversedChars = new char[ReversableString.Text.Length];
            int index = 0;
            while (charStack.Count > 0)
            {
                reversedChars[index++] = charStack.Pop();
            }

            // Form the reversed string from the character array
            string reversedString = new string(reversedChars);
            DisplayOfReverse.Text = reversedString;

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void ReversableString_TextChanged(object sender, EventArgs e)
        {

        }

        private void DisplayOfReverse_Click(object sender, EventArgs e)
        {
            
        }
    }
}
