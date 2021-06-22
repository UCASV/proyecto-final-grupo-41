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
            bool validaciones =
                txtCorreo.Text.Length <= 50 &&
                txtDireccion.Text.Length <= 50 &&
                txtDui.Text.Length == 10 &&
                txtNombre.Text.Length <= 50 &&
                txtTelefono.Text.Length == 12;

            if (validaciones)
            {
                // Creando variables de referencia
                InstitucionEsencial IEref = (InstitucionEsencial)cmbInstitucion.SelectedItem;
                EnfermedadCronica ECref = (EnfermedadCronica)cmbEnfermedad.SelectedItem;

                // Accediendo a la base de datos
                var db = new ProyectoFinalContext();

                // Mediante las variables de referencia se obtienen los datos almacenados en la base
                InstitucionEsencial IEdb = db.Set<InstitucionEsencial>()
                    .SingleOrDefault(i => i.Id == IEref.Id);

                EnfermedadCronica ECdb = db.Set<EnfermedadCronica>()
                    .SingleOrDefault(e => e.Id == ECref.Id);

                // Se guardan los datos del ciudadano/usuario
                Usuario u = new Usuario(txtDui.Text, txtDireccion.Text, txtCorreo.Text, txtNombre.Text, txtTelefono.Text, IEdb.Id, ECdb.Id);
                db.Add(u);
                db.SaveChanges();

                // Mensaje de confirmacion
                MessageBox.Show("Usuario registrado exitosamente!", "Formulario", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();

                // Se procede a agendar la cita1
                frmCita1 ventana = new frmCita1();
                ventana.ShowDialog();
            }
            else
                MessageBox.Show("Los datos ingresados no son validos!", "Formulario", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmFormulario_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
