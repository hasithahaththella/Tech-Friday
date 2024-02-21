using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace WindowsFormsDotNet20
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            short number1 , number2 = 0;
            Int16.TryParse(textNum1.Text, out number1);
            Int16.TryParse(txtNum2.Text, out number2);
            MessageBox.Show((number1 + number2).ToString());
        }
    }
}
