using ProyectoFinal.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal
{
    public partial class frmPrechequeo : Form
    {
        public frmPrechequeo()
        {
            InitializeComponent();
        }

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            frmFormulario ventana = new frmFormulario();
            this.Hide();
            ventana.ShowDialog();
        }

        private void btnPaso2_Click(object sender, EventArgs e)
        {
            frmProcesoVacunacion ventana = new frmProcesoVacunacion();
            this.Hide();
            ventana.ShowDialog();
        }

        private void frmPrechequeo_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
