using System;
using System.Windows.Forms;
using Module_1_SampleLibrary;

namespace Module1_WinFormsApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            // Method intentionally left empty.
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //without using Library code below
            //string message = "Hello " + textBox1.Text;

            //Using Library
            string message = HelloWorld.GetHelloWorldString(textBox1.Text);
            string title = "Demo";
            MessageBox.Show(message, title);
        }
    }
}
