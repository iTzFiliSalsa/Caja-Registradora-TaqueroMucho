using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace TaqueroMucho
{
    public partial class Combos : Form
    {
        public SqlConnection Conexion = new SqlConnection("Server=LAPTOP-KF9P88JK\\SQLEXPRESS;DataBase=Papeleria;Integrated Security=true");
        SqlCommand global;
        SqlDataReader lectura;
        public Combos()
        {
            InitializeComponent();
        }
        public void Ejecutar(string texto)
        {
            String Text = texto;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            TaqueroMucho f = new TaqueroMucho();
            f.agregar("combo1");
            f.Show();
        }
    }
}
