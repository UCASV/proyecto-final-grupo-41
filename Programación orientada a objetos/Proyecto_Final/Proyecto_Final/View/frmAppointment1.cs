using Proyecto_Final.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final.View
{
    public partial class frmAppointment1 : Form
    {
        public frmAppointment1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (var db = new ProyectoFinalDBContext())
            {
                CentroVacunacion CVref = (CentroVacunacion)cmbCentroVacc.SelectedItem;
                Cita1 cita = new Cita1(txtDate.Text, txtTime.Text,CVref.Id,frmGestorLogIn.Pass,frmCitizenRegister.Pass3);
                db.Add(cita);
                db.SaveChanges();
                MessageBox.Show("Cita agendanda con exito!", "Cita1", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            this.Close();
        }

        private void frmAppointment1_Load(object sender, EventArgs e)
        {
            using(var db = new ProyectoFinalDBContext())
            {
                cmbCentroVacc.DataSource = db.CentroVacunacions.ToList();
                cmbCentroVacc.DisplayMember = "Nombre";
                cmbCentroVacc.ValueMember = "Id";
            }
        }
    }
}
