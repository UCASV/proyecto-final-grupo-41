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
    public partial class frmCitizenRegister : Form
    {
        public frmCitizenRegister()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            using (Form newWindow = new frmAppointment1())
            {
                using (var db = new ProyectoFinalDBContext())
                {
                    
                    InstitucionEsencial IEref = (InstitucionEsencial)cmbCitizen.SelectedItem;
                    EnfermedadCronica ECref = (EnfermedadCronica)cmbDisease.SelectedItem;
                    Ciudadano Person = new Ciudadano(txtDui.Text,txtDirection.Text, txtEmail.Text, txtName.Text,txtTelefono.Text, IEref.Id,ECref.Id);
                    db.Add(Person);
                    db.SaveChanges();
                    Pass3 = Person.Id;
                }
                    newWindow.ShowDialog();
                this.Hide();
            }
        }
        public static int Pass3;
       



        private void frmCitizenRegister_Load(object sender, EventArgs e)
        {
            using (var db = new ProyectoFinalDBContext())
            {
                cmbCitizen.DataSource = db.InstitucionEsencials.ToList();
                cmbCitizen.DisplayMember = "Nombre";
                cmbCitizen.ValueMember = "Id";

                cmbDisease.DataSource = db.EnfermedadCronicas.ToList();
                cmbDisease.DisplayMember = "Nombre";
                cmbDisease.ValueMember = "Id";

            }
        }
    }
}
