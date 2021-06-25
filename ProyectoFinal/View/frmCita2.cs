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
    public partial class frmCita2 : Form
    {
        public frmCita2()
        {
            InitializeComponent();
        }

        private void frmCita2_Load(object sender, EventArgs e)
        {
            using (var db = new ProyectoFinalContext())
            {
                cmbGestor.DataSource = db.Gestors.ToList();
                cmbGestor.DisplayMember = "Nombre";
                cmbGestor.ValueMember = "Id";

                cmbLugar.DataSource = db.CentroVacunacions.ToList();
                cmbLugar.DisplayMember = "Nombre";
                cmbLugar.ValueMember = "Id";
            }
        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            using (var db = new ProyectoFinalContext())
            {
               
                bool validaciones =
                txtDUI.Text.Length == 10 &&
                txtFecha.Text.Length == 10 &&
                txtHora.Text.Length == 5;

                if (validaciones)
                {
                    Gestor Gref = (Gestor)cmbGestor.SelectedItem;
                    CentroVacunacion CVref = (CentroVacunacion)cmbLugar.SelectedItem;

                   // Mediante las variables de referencia se obtienen los datos almacenados en la base
                    Gestor Gdb = db.Set<Gestor>()
                        .SingleOrDefault(g => g.Id == Gref.Id);

                    CentroVacunacion CVdb = db.Set<CentroVacunacion>()
                        .SingleOrDefault(c => c.Id == CVref.Id);

                    Usuario Udb = db.Set<Usuario>()
                        .SingleOrDefault(u => u.Dui == txtDUI.Text);

                    var Cit = db.Cita.ToList();



                    // Se guardan los datos de la cita (se agenda la cita)
                    Citum c = new Citum(null, null, txtFecha.Text, txtHora.Text, Gdb.Id, Udb.Id, CVdb.Id);
                    var query = from date in db.Cita
                                join person in db.Usuarios on date.IdUsuario equals person.Id
                                where person.Dui == txtDUI.Text
                                select db.Add(c);
                    db.SaveChanges();

                    // Mensaje de confirmacion
                    MessageBox.Show("Cita agendada exitosamente!", "Cita2", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // Regresando al formulario de prechequeo
                    frmPrechequeo ventana = new frmPrechequeo();
                    this.Hide();
                    ventana.ShowDialog();
                }
                else
                    MessageBox.Show("Los datos ingresados no son validos!", "Cita2", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void frmCita1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
    

