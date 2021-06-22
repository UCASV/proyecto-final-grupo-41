using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoFinal.Model;

namespace ProyectoFinal.View
{
    public partial class frmCita1 : Form
    {
        public frmCita1()
        {
            InitializeComponent();
        }

        private void frmCita1_Load(object sender, EventArgs e)
        {
            var db = new ProyectoFinalContext();
            cmbGestor.DataSource = db.Gestors.ToList();
            cmbGestor.DisplayMember = "Nombre";
            cmbGestor.ValueMember = "Id";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            Gestor Gref = (Gestor)cmbGestor.SelectedItem;

            var db = new ProyectoFinalContext();

            Gestor Gdb = db.Set<Gestor>()
                .SingleOrDefault(g => g.Id == Gref.Id);
            Usuario Udb = db.Set<Usuario>()
                .SingleOrDefault(u => u.Dui == txtDUI.Text);

            //Citum c = new Citum(txtFecha.Text, txtHora.Text, txtLugar.Text, Gdb.Id, Udb.Id);
            //db.Add(c);
            //db.SaveChanges();
            MessageBox.Show("Cita agendada exitosamente!", "Cita1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void frmCita1_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
