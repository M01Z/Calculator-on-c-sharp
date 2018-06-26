using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace M01Z
{
    public partial class M01Z : Form
    {
        double value1 = 0;
        string operation = null;
        bool operation_pressed = false;

        public M01Z()
        {
            InitializeComponent();
        }

        private void button(object sender, EventArgs e)
        {
            if ((Screen.Text == "0")||(operation_pressed))
                Screen.Clear();

            operation_pressed = false;
            Button b = (Button)sender;
            Screen.Text = Screen.Text + b.Text;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            Screen.Text = "0";
            value1 = 0;
            equation.Text = "";
        }

        private void operator_click(object sender, EventArgs e)
        {
            Button b = (Button)sender;
            operation = b.Text;
            value1 = double.Parse(Screen.Text);
            operation_pressed = true;

            equation.Text = value1 + " " + operation;
        
        }

        private void button15_Click(object sender, EventArgs e)
        {
            equation.Text = "";
            if(operation=="+")
                Screen.Text = (value1 + double.Parse(Screen.Text)).ToString();
            if (operation == "-")
                Screen.Text = (value1 - double.Parse(Screen.Text)).ToString();
            if (operation == "*")
                Screen.Text = (value1 * double.Parse(Screen.Text)).ToString();
            if (operation == "/")
                Screen.Text = (value1 / double.Parse(Screen.Text)).ToString();
        }

    }
}
