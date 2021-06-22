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
    public partial class frmProcesoVacunacion : Form
    {
        public frmProcesoVacunacion()
        {
            InitializeComponent();
        }

        private void frmProcesoVacunacion_Load(object sender, EventArgs e)
        {
            var db = new ProyectoFinalContext();
            cmbVacunador.DataSource = db.Vacunadors.ToList();
            cmbVacunador.DisplayMember = "Nombre";
            cmbVacunador.ValueMember = "Id";

            cmbEfecto.DataSource = db.EfectoSecundarios.ToList();
            cmbEfecto.DisplayMember = "Nombre";
            cmbEfecto.ValueMember = "Id";
        }

        private void btnAceptar_Click(object sender, EventArgs e)
        {
            // Creando variables de referencia
            Vacunador Vref = (Vacunador)cmbVacunador.SelectedItem;
            EfectoSecundario ESref = (EfectoSecundario)cmbEfecto.SelectedItem;

            // Accediendo a la base de datos
            var db = new ProyectoFinalContext();

            // Mediante las variables de referencia se obtienen los datos almacenados en la base
            Vacunador Vdb = db.Set<Vacunador>()
                .SingleOrDefault(v => v.Id == Vref.Id);

            EfectoSecundario ESdb = db.Set<EfectoSecundario>()
                .SingleOrDefault(es => es.Id == ESref.Id);

            Usuario Udb = db.Set<Usuario>()
                .SingleOrDefault(u => u.Dui == txtDUI.Text);

            // Se guardan los datos de la vacuna
            Vacuna v = new Vacuna(txtFechaEspera.Text, txtHoraEspera.Text, txtFechaVacunacion.Text, txtHoraVacunacion.Text, Udb.Id);
            db.Add(v);
            db.SaveChanges();

            // Se guardan los datos de la vacuna aplicada
            AplicarVacuna ap = new AplicarVacuna(Vdb.Id, v.Id);
            db.Add(ap);
            db.SaveChanges();

            //EfectoSecundario es = new EfectoSecundario(ESdb.Nombre, v.Id);
            //db.Add(es);
            //db.SaveChanges();

            // Mensaje de confirmacion
            MessageBox.Show("Usted ha recibido su primera dosis!", "Dosis 1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void frmProcesoVacunacion_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
        }
    }
}
