using sistemaRestaurante.controlador;
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
    public partial class Mesas : MetroFramework.Forms.MetroForm
    {
        int libres = 0;
        int ocupadas = 0;
        public Mesas()
        {
            InitializeComponent();
        }

        
        private void Mesas_Load(object sender, EventArgs e)
        {

        }

        private void metroTextBox1_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel3_Click(object sender, EventArgs e)
        {

        }

        private void metroLabel4_Click(object sender, EventArgs e)
        {

        }

        private void pnlLiberar_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtreservadas_Click(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click(object sender, EventArgs e)
        {

        }

        private void metroPanel2_Paint(object sender, PaintEventArgs e)
        {
        }


        private void metroButton2_Click_1(object sender, EventArgs e)
        {

        }

        private void metroButton2_Click_2(object sender, EventArgs e)
        {

        }

        private void btnLiberar_Click(object sender, EventArgs e)
        {
            libres = 0;
            ocupadas = 0;
            mesa _mesa = new mesa();

            controlMesa cm = new controlMesa();


            _mesa.Id = int.Parse(cbLiberarMesas.SelectedValue.ToString());

            cm.liberarMesa(_mesa);
            pintarMesas();
            txtlibres.Text = libres + "";
            txtOcupadas.Text = ocupadas + "";
            pnlLiberar.Visible = false;
        }
        private void mesas_Load(object sender, EventArgs e)
        {


            btncolor1.BackColor = Color.Lime;
            btncolor2.BackColor = Color.Red;

            txtTotalMesas.Text = "12";


            pintarMesas();
            txtlibres.Text = libres + "";
            txtOcupadas.Text = ocupadas + "";
            //  MessageBox.Show(arraymesas[i] +" "+ i);

        }
        public void pintarMesas()
        {
            string[] arraymesas = new string[28];

            controlMesa mesa = new controlMesa();
            arraymesas = mesa.seleccionarStatusMesa();

            //mesa 1
            if (arraymesas[0] == "libre")
            {
                m1.BackColor = Color.Lime;
                libres++;

            }
            if (arraymesas[0] == "ocupada")
            {
                m1.BackColor = Color.Red;
                ocupadas++;
            }


            //mesa 2
            if (arraymesas[1] == "libre")
            {
                m2.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[1] == "ocupada")
            {
                m2.BackColor = Color.Red;
                ocupadas++;
            }


            //mesa 3
            if (arraymesas[2] == "libre")
            {
                m3.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[2] == "ocupada")
            {
                m3.BackColor = Color.Red;
                ocupadas++;
            }

            //mesa 4
            if (arraymesas[3] == "libre")
            {
                m4.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[3] == "ocupada")
            {
                m4.BackColor = Color.Red;
                ocupadas++;
            }

            //mesa 5
            if (arraymesas[4] == "libre")
            {
                m5.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[4] == "ocupada")
            {
                m5.BackColor = Color.Red;
                ocupadas++;
            }

            //mesa 6
            if (arraymesas[5] == "libre")
            {
                m6.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[5] == "ocupada")
            {
                m6.BackColor = Color.Red;
                ocupadas++;
            }

            //mesa 7
            if (arraymesas[6] == "libre")
            {
                m7.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[6] == "ocupada")
            {
                m7.BackColor = Color.Red;
                ocupadas++;
            }

            //mesa 8
            if (arraymesas[7] == "libre")
            {
                m8.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[7] == "ocupada")
            {
                m8.BackColor = Color.Red;
                ocupadas++;
            }
            //mesa 9
            if (arraymesas[8] == "libre")
            {
                m9.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[8] == "ocupada")
            {
                m9.BackColor = Color.Red;
                ocupadas++;
            }
            //mesa 10
            if (arraymesas[9] == "libre")
            {
                m10.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[9] == "ocupada")
            {
                m10.BackColor = Color.Red;
                ocupadas++;

            }
            //mesa 11
            if (arraymesas[10] == "libre")
            {
                m11.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[10] == "ocupada")
            {
                m11.BackColor = Color.Red;
                ocupadas++;
            }

            //  mesa 12
            if (arraymesas[11] == "libre")
            {
                m12.BackColor = Color.Lime;
                libres++;
            }
            if (arraymesas[11] == "ocupada")
            {
                m12.BackColor = Color.Red;
                ocupadas++;

            }
            //mesa 13
            if (arraymesas[12] == "libre")
            {
                m1.BackColor = Color.Lime;
                libres++;

            }
            if (arraymesas[12] == "ocupada")
            {
                m1.BackColor = Color.Red;
                ocupadas++;
            }
            //mesa 14
            if (arraymesas[13] == "libre")
            {
                m1.BackColor = Color.Lime;
                libres++;

            }
            if (arraymesas[13] == "ocupada")
            {
                m1.BackColor = Color.Red;
                ocupadas++;
            }
            //mesa 15
            if (arraymesas[14] == "libre")
            {
                m1.BackColor = Color.Lime;
                libres++;

            }
            if (arraymesas[14] == "ocupada")
            {
                m1.BackColor = Color.Red;
                ocupadas++;
            }
            //mesa 16
            if (arraymesas[15] == "libre")
            {
                m1.BackColor = Color.Lime;
                libres++;

            }
            if (arraymesas[15] == "ocupada")
            {
                m1.BackColor = Color.Red;
                ocupadas++;
            }
            //mesa 17
            if (arraymesas[16] == "libre")
            {
                m1.BackColor = Color.Lime;
                libres++;

            }
            if (arraymesas[16] == "ocupada")
            {
                m1.BackColor = Color.Red;
                ocupadas++;
            }
            //mesa 18
            if (arraymesas[17] == "libre")
            {
                m1.BackColor = Color.Lime;
                libres++;

            }
            if (arraymesas[17] == "ocupada")
            {
                m1.BackColor = Color.Red;
                ocupadas++;
            }
            //mesa 19
            if (arraymesas[18] == "libre")
            {
                m1.BackColor = Color.Lime;
                libres++;

            }
            if (arraymesas[18] == "ocupada")
            {
                m1.BackColor = Color.Red;
                ocupadas++;
            }

            //mesa 20
            if (arraymesas[19] == "libre")
            {
                m1.BackColor = Color.Lime;
                libres++;

            }
            if (arraymesas[19] == "ocupada")
            {
                m1.BackColor = Color.Red;
                ocupadas++;
            }

            //mesa 21
            if (arraymesas[20] == "libre")
            {
                m1.BackColor = Color.Lime;
                libres++;

            }
            if (arraymesas[20] == "ocupada")
            {
                m1.BackColor = Color.Red;
                ocupadas++;
            }

            //mesa 22
            if (arraymesas[21] == "libre")
            {
                m1.BackColor = Color.Lime;
                libres++;

            }
            if (arraymesas[21] == "ocupada")
            {
                m1.BackColor = Color.Red;
                ocupadas++;
            }

            //mesa 23
            if (arraymesas[22] == "libre")
            {
                m1.BackColor = Color.Lime;
                libres++;

            }
            if (arraymesas[22] == "ocupada")
            {
                m1.BackColor = Color.Red;
                ocupadas++;
            }

            //mesa 24
            if (arraymesas[23] == "libre")
            {
                m1.BackColor = Color.Lime;
                libres++;

            }
            if (arraymesas[23] == "ocupada")
            {
                m1.BackColor = Color.Red;
                ocupadas++;
            }

            //mesa 25
            if (arraymesas[24] == "libre")
            {
                m1.BackColor = Color.Lime;
                libres++;

            }
            if (arraymesas[24] == "ocupada")
            {
                m1.BackColor = Color.Red;
                ocupadas++;
            }

            //mesa 26
            if (arraymesas[25] == "libre")
            {
                m1.BackColor = Color.Lime;
                libres++;

            }
            if (arraymesas[25] == "ocupada")
            {
                m1.BackColor = Color.Red;
                ocupadas++;
            }

            //mesa 27
            if (arraymesas[26] == "libre")
            {
                m1.BackColor = Color.Lime;
                libres++;

            }
            if (arraymesas[26] == "ocupada")
            {
                m1.BackColor = Color.Red;
                ocupadas++;
            }

            //mesa 28
            if (arraymesas[27] == "libre")
            {
                m1.BackColor = Color.Lime;
                libres++;

            }
            if (arraymesas[27] == "ocupada")
            {
                m1.BackColor = Color.Red;
                ocupadas++;
            }
        }

        private void metroButton2_Click_3(object sender, EventArgs e)
        {

        }

        private void cbLiberarMesas_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void administrarMesasToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }
    }
}


 
