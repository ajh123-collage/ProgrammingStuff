using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProgrammingStuff
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // char c = 'a';
            // int d = (int) c;

            // char m = 'b';
            // int n = (int)m + 5;
            // char o = (char)n;


            // float a2 = 3.54f;
            // double b2 = 2.44;
            // decimal c2 = 1.35m;


            // Person p = new Person();
            // Person p2 = new Person();


            // string s = "This is a string";
            // char c = s[0];


            // string word = "Bonjour";
            // int wordLength = word.Length;



            // string phrase = "How are you today?";
            // char first = phrase[0];
            // string firstWord = phrase.Substring(0, 3);


            // int anint = 5;
            // float aflt = 3.57f;
            // string aintStr = anint.ToString();
            // string fltStr = aflt.ToString();


            string text = "123";
            int textAsInt = Convert.ToInt32(text);
        }
    }
}
