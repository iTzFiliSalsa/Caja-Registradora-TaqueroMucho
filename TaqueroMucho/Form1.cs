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
    public partial class TaqueroMucho : Form
    {
        public SqlConnection Conexion = new SqlConnection("Server=LAPTOP-KF9P88JK\\SQLEXPRESS;DataBase=productos;Integrated Security=true");
        SqlCommand global;
        SqlDataReader lectura;
        public static double ctotal = 0.00;
        Cancelar can = new Cancelar();
        public TaqueroMucho()
        {
            InitializeComponent();
        }
        public void Ejecutar(string texto)
        {
           
            String cadena = "";
            
        }
        public void agregar(String nombre)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = "dsdsda";
            fila.Cells[1].Value = "dsdsda";
            fila.Cells[2].Value = "dsdsda";
            dataGridView1.Rows.Add(fila);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            button3.Enabled = false;
            button20.Enabled = false;
            textBox1.Text = "1";
            textBox2.Text = "1";
            textBox3.Text = "1";
            textBox4.Text = "1";
            textBox5.Text = "1";
            textBox6.Text = "1";
            textBox7.Text = "1";
            button1.BackColor = Color.FromArgb(139, 0, 0);
            button2.BackColor = Color.DimGray;
           
        }
        private void abrirForm2(object Agregar)
        {
            if (this.panel2.Controls.Count > 0)
                this.panel2.Controls.RemoveAt(0);
            Form fh = Agregar as Form;
            fh.TopLevel = false;
            fh.Dock = DockStyle.Fill;
            this.panel2.Controls.Add(fh);
            this.panel2.Tag = fh;
            fh.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            button1.BackColor=Color.FromArgb(139,0,0);
            button2.BackColor = Color.DimGray;
        }

  

        private void button2_Click(object sender, EventArgs e)
        {
            button2.BackColor = Color.FromArgb(139, 0, 0);
            button1.BackColor = Color.DimGray;
            Tacos ta = new Tacos();
            DialogResult resultado = new DialogResult();
            resultado = ta.ShowDialog();
            button1.BackColor = Color.FromArgb(139, 0, 0);
            button2.BackColor = Color.DimGray;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = DateTime.Now.ToString("hh:mm:ss");
            
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = "Combo 1";
            fila.Cells[1].Value = textBox1.Text;
            int cantidad = Convert.ToInt32(textBox1.Text);
            double total = cantidad * 35;
            fila.Cells[2].Value = total;
            dataGridView1.Rows.Add(fila);
            ctotal = ctotal + total;
            String temporal = ctotal.ToString("00.00");
            label19.Text = "$ " + temporal;
            button3.Enabled = true;
            button20.Enabled = true;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = "Combo 2";
            fila.Cells[1].Value = textBox2.Text;
            int cantidad = Convert.ToInt32(textBox2.Text);
            double total = cantidad * 35;
            fila.Cells[2].Value = total;
            dataGridView1.Rows.Add(fila);
            ctotal = ctotal + total;
            String temporal = ctotal.ToString("00.00");
            label19.Text = "$ " + temporal;
            button3.Enabled = true;
            button20.Enabled = true;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = "Combo Pareja";
            fila.Cells[1].Value = textBox3.Text;
            int cantidad = Convert.ToInt32(textBox3.Text);
            double total = cantidad * 65;
            fila.Cells[2].Value = total;
            dataGridView1.Rows.Add(fila);
            ctotal = ctotal + total;
            String temporal = ctotal.ToString("00.00");
            label19.Text = "$ " + temporal;
            button3.Enabled = true;
            button20.Enabled = true;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = "Taco Harina";
            fila.Cells[1].Value = textBox4.Text;
            int cantidad = Convert.ToInt32(textBox4.Text);
            double total = cantidad * 7;
            fila.Cells[2].Value = total;
            dataGridView1.Rows.Add(fila);
            ctotal = ctotal + total;
            String temporal = ctotal.ToString("00.00");
            label19.Text = "$ " + temporal;
            button3.Enabled = true;
            button20.Enabled = true;
        }

        private void button12_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = "Taco Maiz";
            fila.Cells[1].Value = textBox5.Text;
            int cantidad = Convert.ToInt32(textBox5.Text);
            double total = cantidad * 7;
            fila.Cells[2].Value = total;
            dataGridView1.Rows.Add(fila);
            ctotal = ctotal + total;
            String temporal = ctotal.ToString("00.00");
            label19.Text = "$ " + temporal;
            button3.Enabled = true;
            button20.Enabled = true;
        }

        private void button18_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = "Horchata Medio Litro";
            fila.Cells[1].Value = textBox7.Text;
            int cantidad = Convert.ToInt32(textBox7.Text);
            double total = cantidad * 10;
            fila.Cells[2].Value = total;
            dataGridView1.Rows.Add(fila);
            ctotal = ctotal + total;
            String temporal = ctotal.ToString("00.00");
            label19.Text = "$ " + temporal;
            button3.Enabled = true;
            button20.Enabled = true;
        }

        private void button16_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = "Horchata Litro";
            fila.Cells[1].Value = textBox7.Text;
            int cantidad = Convert.ToInt32(textBox7.Text);
            double total = cantidad * 15;
            fila.Cells[2].Value = total;
            dataGridView1.Rows.Add(fila);
            ctotal = ctotal + total;
            String temporal = ctotal.ToString("00.00");
            label19.Text = "$ " + temporal;
            button3.Enabled = true;
            button20.Enabled = true;
        }

        private void button19_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = "Jamaica Medio Litro";
            fila.Cells[1].Value = textBox6.Text;
            int cantidad = Convert.ToInt32(textBox6.Text);
            double total = cantidad * 10;
            fila.Cells[2].Value = total;
            dataGridView1.Rows.Add(fila);
            ctotal = ctotal + total;
            String temporal = ctotal.ToString("00.00");
            label19.Text = "$ " + temporal;
            button3.Enabled = true;
            button20.Enabled = true;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            DataGridViewRow fila = new DataGridViewRow();
            fila.CreateCells(dataGridView1);
            fila.Cells[0].Value = "Jamaica Litro";
            fila.Cells[1].Value = textBox6.Text;
            int cantidad = Convert.ToInt32(textBox6.Text);
            double total = cantidad * 15;
            fila.Cells[2].Value = total;
            dataGridView1.Rows.Add(fila);
            ctotal = ctotal + total;
            String temporal = ctotal.ToString("00.00");
            label19.Text = "$ " + temporal;
            button3.Enabled = true;
            button20.Enabled = true;
        }

        private void button20_Click(object sender, EventArgs e)
        {
                Conexion.Open();
                SqlCommand Agregar = new SqlCommand("insert into Venta values(@Venta,@Producto,@Cantidad,@Total)", Conexion);
                SqlCommand max = new SqlCommand("select MAX(NumeroVenta) from Venta;", Conexion);
                int idventa = (int)max.ExecuteScalar();
                try
                {
                    foreach (DataGridViewRow row in dataGridView1.Rows)
                    {

                        Agregar.Parameters.Clear();
                        Agregar.Parameters.AddWithValue("@Venta", (idventa + 1));
                        Agregar.Parameters.AddWithValue("@Producto", Convert.ToString(row.Cells[0].Value));
                        Agregar.Parameters.AddWithValue("@Cantidad", Convert.ToInt32(row.Cells[1].Value));
                        Agregar.Parameters.AddWithValue("@Total", Convert.ToDouble(row.Cells[2].Value));
                        Agregar.ExecuteNonQuery();
                    }
                }
                catch (Exception es)
                {
                    MessageBox.Show(es + "");
                }
                    Cambio c = new Cambio();
                    c.total(ctotal);
                    c.ShowDialog();
                    ctotal = 0.00;
                String temporal = ctotal.ToString("000.00");
                label19.Text = "$ " + temporal;
                textBox1.Text = "1";
                textBox2.Text = "1";
                textBox3.Text = "1";
                textBox4.Text = "1";
                textBox5.Text = "1";
                textBox6.Text = "1";
                textBox7.Text = "1";
                button3.Enabled = false;
                button20.Enabled = false;
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
                Conexion.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            DialogResult resultado = new DialogResult();
            resultado = can.ShowDialog();
            if (resultado == DialogResult.OK)
            {
                ctotal = 0.00;
                String temporal = ctotal.ToString("000.00");
                label19.Text = "$ " + temporal;
                textBox1.Text = "1";
                textBox2.Text = "1";
                textBox3.Text = "1";
                textBox4.Text = "1";
                textBox5.Text = "1";
                textBox6.Text = "1";
                button3.Enabled = false;
                button20.Enabled = false;
                textBox7.Text = "1";
                dataGridView1.Rows.Clear();
                dataGridView1.Refresh();
            }
            else
            {

            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void textBox3_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void textBox4_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void textBox5_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void textBox7_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }

        private void textBox6_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(char.IsNumber(e.KeyChar)) && (e.KeyChar != (char)Keys.Back))
            {
                e.Handled = true;
                return;
            }
        }
    }
}
