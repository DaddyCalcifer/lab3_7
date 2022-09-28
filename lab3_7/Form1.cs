using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lab3_7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void do_button_Click(object sender, EventArgs e)
        {
            numericUpDown1.Value = Convert.ToDecimal(delete_numbers(Convert.ToDouble(numericUpDown1.Value)));
        }
        public double delete_numbers(double n)
        {
            string tempo = n.ToString();

            if (del0.Checked) tempo = tempo.Replace("0", "");
            if (del1.Checked) tempo = tempo.Replace("1", "");
            if (del2.Checked) tempo = tempo.Replace("2", "");
            if (del3.Checked) tempo = tempo.Replace("3", "");
            if (del4.Checked) tempo = tempo.Replace("4", "");
            if (del5.Checked) tempo = tempo.Replace("5", "");
            if (del6.Checked) tempo = tempo.Replace("6", "");
            if (del7.Checked) tempo = tempo.Replace("7", "");
            if (del8.Checked) tempo = tempo.Replace("8", "");
            if (del9.Checked) tempo = tempo.Replace("9", "");

            return Convert.ToDouble(tempo);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
