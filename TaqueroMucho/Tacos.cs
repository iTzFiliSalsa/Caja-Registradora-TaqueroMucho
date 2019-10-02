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
    
    public partial class Tacos : Form
    {
        public SqlConnection Conexion = new SqlConnection("Server=LAPTOP-KF9P88JK\\SQLEXPRESS;DataBase=productos;Integrated Security=true");
        SqlCommand global;
        DateTime fechaactual = DateTime.Today;
        SqlDataReader lectura;
        public Tacos()
        {
            InitializeComponent();
        }

        private void Tacos_Load(object sender, EventArgs e)
        {
            Conexion.Open();
            /////////
            SqlCommand cantidadcombo1 = new SqlCommand("SELECT SUM(cantidad) from Venta where producto='Combo 1';", Conexion);
            string idventa = Convert.ToString(cantidadcombo1.ExecuteScalar());
            venco1.Text = "Vendidos: " + idventa;
            SqlCommand combo1 = new SqlCommand("SELECT SUM(total) from Venta where producto='Combo 1';", Conexion);
            string totalcombo1 = Convert.ToString(combo1.ExecuteScalar());
            ganco1.Text = "Ganancias: $" + totalcombo1;
            //////////
            SqlCommand cantidadcombo2 = new SqlCommand("SELECT SUM(cantidad) from Venta where producto='Combo 2';", Conexion);
            string cantcom2 = Convert.ToString(cantidadcombo2.ExecuteScalar());
            label5.Text = "Vendidos: " + cantcom2;
            SqlCommand combo2 = new SqlCommand("SELECT SUM(total) from Venta where producto='Combo 2';", Conexion);
            string totalcombo2 = Convert.ToString(combo2.ExecuteScalar());
            label4.Text = "Ganancias: $" + totalcombo2;
            //////////////
            SqlCommand cantidadcombo3 = new SqlCommand("SELECT SUM(cantidad) from Venta where producto='Combo Pareja';", Conexion);
            string cantcom3 = Convert.ToString(cantidadcombo3.ExecuteScalar());
            label8.Text = "Vendidos: " + cantcom3;
            SqlCommand combo3 = new SqlCommand("SELECT SUM(total) from Venta where producto='Combo Pareja';", Conexion);
            string totalcombo3 = Convert.ToString(combo3.ExecuteScalar());
            label7.Text = "Ganancias: $" + totalcombo3;
            /////////////////
            SqlCommand Harina = new SqlCommand("SELECT SUM(cantidad) from Venta where producto='Taco Harina';", Conexion);
            string cantharina = Convert.ToString(Harina.ExecuteScalar());
            label14.Text = "Vendidos: " + cantharina;
            SqlCommand totHarina = new SqlCommand("SELECT SUM(total) from Venta where producto='Taco Harina';", Conexion);
            string totalharina = Convert.ToString(totHarina.ExecuteScalar());
            label13.Text = "Ganancias: $" + totalharina;
            /////////////////
            SqlCommand Maiz = new SqlCommand("SELECT SUM(cantidad) from Venta where producto='Taco Maiz';", Conexion);
            string cantmaiz = Convert.ToString(Maiz.ExecuteScalar());
            label11.Text = "Vendidos: " + cantmaiz;
            SqlCommand totMaiz = new SqlCommand("SELECT SUM(total) from Venta where producto='Taco Maiz';", Conexion);
            string totalmaiz = Convert.ToString(totMaiz.ExecuteScalar());
            label10.Text = "Ganancias: $" + totalmaiz;
            ///////////////////////////
            SqlCommand horchata = new SqlCommand("SELECT SUM(cantidad) from Venta where producto='Horchata Medio Litro';", Conexion);
            string mhorchata = Convert.ToString(horchata.ExecuteScalar());
            label20.Text = "Vendidos 1/2 litro: " + mhorchata;
            SqlCommand tothorchata = new SqlCommand("SELECT SUM(total) from Venta where producto='Horchata Medio Litro';", Conexion);
            string totalhor = Convert.ToString(tothorchata.ExecuteScalar());
            label19.Text = "Ganancias 1/2 litro: $" + totalhor;
            SqlCommand horchatal = new SqlCommand("SELECT SUM(cantidad) from Venta where producto='Horchata Litro';", Conexion);
            string mhorchatal = Convert.ToString(horchatal.ExecuteScalar());
            label23.Text = "Vendidos litro: " + mhorchatal;
            SqlCommand tothorchatal = new SqlCommand("SELECT SUM(total) from Venta where producto='Horchata Litro';", Conexion);
            string totalhorl = Convert.ToString(tothorchatal.ExecuteScalar());
            label22.Text = "Ganancias litro: $" + totalhorl;
            //////////////////////////////////
            SqlCommand jamaica = new SqlCommand("SELECT SUM(cantidad) from Venta where producto='Jamaica Medio Litro';", Conexion);
            string mjamaica = Convert.ToString(jamaica.ExecuteScalar());
            label25.Text = "Vendidos 1/2 litro: " + mjamaica;
            SqlCommand totjamaica = new SqlCommand("SELECT SUM(total) from Venta where producto='Jamaica Medio Litro';", Conexion);
            string totaljamaica = Convert.ToString(totjamaica.ExecuteScalar());
            label24.Text = "Ganancias 1/2 litro: $" + totaljamaica;
            SqlCommand jamaical = new SqlCommand("SELECT SUM(cantidad) from Venta where producto='Jamaica Litro';", Conexion);
            string mjamaical = Convert.ToString(jamaical.ExecuteScalar());
            label17.Text = "Vendidos litro: " + mjamaical;
            SqlCommand totjamaical = new SqlCommand("SELECT SUM(total) from Venta where producto='Jamaica Litro';", Conexion);
            string totaljamaical = Convert.ToString(totjamaical.ExecuteScalar());
            label16.Text = "Ganancias litro: $" + totaljamaical;
            //////////////////////////
            SqlCommand gananciastotales = new SqlCommand("SELECT SUM(total) from Venta;", Conexion);
            string totalganancias = Convert.ToString(gananciastotales.ExecuteScalar());
            label26.Text = "$" + totalganancias+".00";
            Conexion.Close();
        }
    }
}
