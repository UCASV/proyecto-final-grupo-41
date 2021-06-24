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

            cmbLugar.DataSource = db.CentroVacunacions.ToList();
            cmbLugar.DisplayMember = "Nombre";
            cmbLugar.ValueMember = "Id";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            bool validaciones =
                txtDUI.Text.Length == 10 &&
                txtFecha.Text.Length == 10 &&
                txtHora.Text.Length == 5;

            if (validaciones)
            {
                // Creando variables de referencia
                Gestor Gref = (Gestor)cmbGestor.SelectedItem;
                CentroVacunacion CVref = (CentroVacunacion)cmbLugar.SelectedItem;

                // Accediendo a la base de datos
                var db = new ProyectoFinalContext();

                // Mediante las variables de referencia se obtienen los datos almacenados en la base
                Gestor Gdb = db.Set<Gestor>()
                    .SingleOrDefault(g => g.Id == Gref.Id);

                CentroVacunacion CVdb = db.Set<CentroVacunacion>()
                    .SingleOrDefault(c => c.Id == CVref.Id);

                Usuario Udb = db.Set<Usuario>()
                    .SingleOrDefault(u => u.Dui == txtDUI.Text);

                // Se guardan los datos de la cita (se agenda la cita)
                Citum c = new Citum(txtFecha.Text, txtHora.Text, Gdb.Id, Udb.Id, CVdb.Id);
                db.Add(c);
                db.SaveChanges();

                // Mensaje de confirmacion
                MessageBox.Show("Cita agendada exitosamente!", "Cita1", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Regresando al formulario de prechequeo
                frmPrechequeo ventana = new frmPrechequeo();
                this.Hide();
                ventana.ShowDialog();
            }
            else
                MessageBox.Show("Los datos ingresados no son validos!", "Cita1", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void frmCita1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
