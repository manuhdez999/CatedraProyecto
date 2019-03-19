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
    public partial class pantalla_principal : MetroFramework.Forms.MetroForm
    {
        public pantalla_principal()
        {
            InitializeComponent();
        }

        private void pantalla_principal_Load(object sender, EventArgs e)
        {

        }

        private void facturasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void acercaDeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            acerca_de ad = new acerca_de();
            ad.Show();
            this.Hide();

        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Registrar_usuario ru = new Registrar_usuario();
            ru.Show();
            this.Hide();
        }

        private void mesasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Mesas me = new Mesas();
            me.Show();
            this.Close();

        }

        private void metroPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
