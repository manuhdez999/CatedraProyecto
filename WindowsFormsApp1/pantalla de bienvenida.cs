using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class pantalla_de_bienvenida : MetroFramework.Forms.MetroForm
    {
        public pantalla_de_bienvenida()
        {
            InitializeComponent();
        }

        private void pantalla_de_bienvenida_Load(object sender, EventArgs e)
        {

        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            pantalla_de_bienvenida pb = new pantalla_de_bienvenida();
            pb.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
    }
}
