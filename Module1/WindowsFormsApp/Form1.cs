using System;
using System.Windows.Forms;
using ClassLibrary2;

namespace WindowsFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //without using Library code below
           // var message = "Hello " + textBox1.Text;

            //Using Library
            var message = HelloWorld.GetHelloWorldString(textBox1.Text);
            var title = "Demo";
            MessageBox.Show(message, title);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {           
        }
    }
}
