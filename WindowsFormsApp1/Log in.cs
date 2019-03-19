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
using System.Configuration;
namespace WindowsFormsApp1
{
    public partial class Form1 : MetroFramework.Forms.MetroForm
    {
       // revisar porque no acepta el login

        public Form1()
        {
            InitializeComponent();
        }

        //SqlConnection cone = new SqlConnection(@"Data Source = DESKTOP; Initial Catalog = Conchas_la_5; Integrated Security = True");
        conexion cone = new conexion();
        public void logins(string usuario, string codigo)

        {
            try
            {
                //cone.Open();
                cone.openDataBase();
                SqlCommand cmd = new SqlCommand("SELECT Nombre, Cargo FROM  empleado WHERE usuario =@usuario and  codigo=@codigo ",cone.conexionBaseDatos);
                cmd.Parameters.AddWithValue("usuario", usuario);
                cmd.Parameters.AddWithValue("codigo", codigo);
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                sda.Fill(dt);

                if(dt.Rows.Count == 1)
                {
                    this.Hide();
                    MessageBox.Show("Usuario encontrado!");
                    pantalla_principal pp = new pantalla_principal();
                    if (dt.Rows[0][1].ToString() == "Administrador")
                    {
                        pp.Show();
                        //this.Close();
                    }

                       // debemos crear un form de acceso de meseros y una de admin
                    else if(dt.Rows[0][1].ToString() == "Mesero/a")
                    {
                        pp.Show();
                        //this.Close();
                    }
                }
                else
                {
                    MessageBox.Show("Usuario y/o Contraseña incorrectos");
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                //cone.Close();
                cone.closeDatabase();
            }

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Focus();
            txtusuario.Focus();
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void metroLabel2_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            pantalla_principal pp = new pantalla_principal();
            pp.Show();
            this.Close();
        }

        private void btningresar_Click(object sender, EventArgs e)
        {
            logins(this.txtusuario.Text, this.txtcodigo.Text);
        }
    }
}
