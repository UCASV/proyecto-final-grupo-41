using ProyectoFinal.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoFinal.View
{
    public partial class frmFormulario : Form
    {
        public frmFormulario()
        {
            InitializeComponent();
        }

        private void frmFormulario_Load(object sender, EventArgs e)
        {
            var db = new ProyectoFinalContext();
            cmbInstitucion.DataSource = db.InstitucionEsencials.ToList();
            cmbInstitucion.DisplayMember = "Nombre";
            cmbInstitucion.ValueMember = "Id";

            cmbEnfermedad.DataSource = db.EnfermedadCronicas.ToList();
            cmbEnfermedad.DisplayMember = "Nombre";
            cmbEnfermedad.ValueMember = "Id";
        }

        private void btnGuardarDatos_Click(object sender, EventArgs e)
        {
            InstitucionEsencial IEref = (InstitucionEsencial)cmbInstitucion.SelectedItem;
            EnfermedadCronica ECref = (EnfermedadCronica)cmbEnfermedad.SelectedItem;

            var db = new ProyectoFinalContext();

            InstitucionEsencial IEdb = db.Set<InstitucionEsencial>()
                .SingleOrDefault(i => i.Id == IEref.Id);

            EnfermedadCronica ECdb = db.Set<EnfermedadCronica>()
                .SingleOrDefault(e => e.Id == ECref.Id);

            //Usuario u = new Usuario(txtDui.Text, txtDireccion.Text, txtCorreo.Text, txtNombre.Text, txtTelefono.Text, ECdb, IEref);
            //db.Add(u);
            //db.SaveChanges();

            MessageBox.Show("Usuario registrado exitosamente!", "Formulario", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmFormulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
