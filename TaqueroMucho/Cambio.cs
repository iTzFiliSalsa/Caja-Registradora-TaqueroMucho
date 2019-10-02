using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TaqueroMucho
{
    public partial class Cambio : Form
    {
        double tot = 0;
        public Cambio()
        {
            InitializeComponent();
        }
        public void total(double tot)
        {
            this.tot = tot;
            label1.Text = "Total: $"+tot;
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((int)e.KeyChar==(int)Keys.Enter)
            {
                double numero = Convert.ToDouble(textBox1.Text);
                double resta = numero - tot;
                label3.Text = "Cambio: $" + resta;
            }
        }

        private void Cambio_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }
    }
}
