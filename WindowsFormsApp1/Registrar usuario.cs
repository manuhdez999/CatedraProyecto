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


namespace WindowsFormsApp1
{
    public partial class Registrar_usuario : MetroFramework.Forms.MetroForm
    {
private string cargo;

        public Registrar_usuario()
        {
            InitializeComponent();
        }

        private void Registrar_usuario_Load(object sender, EventArgs e)
        {

        }

        private void metroComboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void metroButton2_Click(object sender, EventArgs e)
        {
            pantalla_principal pb = new pantalla_principal();
            pb.Show();
            this.Hide();


        }

        private void metroButton1_Click(object sender, EventArgs e)
        {

            //SqlConnection cone = new SqlConnection("Data Source=VICENTE;Initial Catalog=;Integrated Security=True");


            SqlConnection cone = new SqlConnection(@"Data Source = VICENTE; Initial Catalog = Conchas_la_5; Integrated Security = True");

            if (txtnombre.Text == "" || txtapellido.Text == "" || txtcodigo.Text == "" || txtedad.Text == "" || txtusuario.Text =="")
            {
                MessageBox.Show("No se permiten espacios vacios");
            }
            else
            {
                try
                {
                    cone.Open();
                    string cadena;
                    // revisar los combobox para poder seleccionar datos de cargos...
                    string id;
                    if (cmbtipodeusuario.SelectedIndex == 0)
                    {
                        cargo = "Administrador";
                       
                    }
                    else if (cmbtipodeusuario.SelectedIndex == 1)
                    {
                        cargo = "Mesero/a";
                    }
                    else
                    {
                        MessageBox.Show("Seleccione un tipo de usuario" + cmbtipodeusuario.SelectedIndex);
                    }
                    cadena = "INSERT INTO dbo.Empleado(id_empleado, Nombre, Apellido,edad, usuario, codigo, Cargo) values('"+ this.txtnombre.Text + "','" + this.txtnombre.Text + "','" + this.txtapellido.Text + "'," + this.txtedad.Text + ",'" + this.txtusuario.Text + "','" + this.txtcodigo.Text + "','" + this.cargo + "')";
                    MessageBox.Show(cadena);
                    SqlCommand cmd = new SqlCommand(cadena, cone);
                    cmd.ExecuteNonQuery();

                   

                    MessageBox.Show("Registro Guardado con Éxito");
                    
                    cone.Close();
                }
                catch(SqlException ex)
                {
                    MessageBox.Show("Error SQL");
                    MessageBox.Show(ex.Message);

                }
                catch
                {
                    MessageBox.Show("Datos correctos");
                }
            finally{
                MessageBox.Show("Hicimos contacto");
            }




            }
        }
    } }
    
