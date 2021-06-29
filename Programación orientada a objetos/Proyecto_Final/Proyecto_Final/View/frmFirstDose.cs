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
    public partial class frmFirstDose : Form
    {
        public frmFirstDose()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (Form newWindow = new frmSecondaryEffect())
            {
                using(var db = new ProyectoFinalDBContext())
                {
                    List<Cita1> Appointment = db.Cita1s.ToList();
                    List<Ciudadano> Cit = db.Ciudadanos.ToList();
                    int IDS = (from q in Cit where q.Dui == txtDui.Text select q.Id).SingleOrDefault();
                    bool Find = Appointment.Any(c => c.IdCiudadano == IDS);
                    if (Find)
                    {
                        Vacuna Vref = (Vacuna)cmbVaccine.SelectedItem;
                        EfectoSecundario Eref = (EfectoSecundario)cmbEfecto.SelectedItem;

                        Dosi dosis = new Dosi(txtDateWait.Text, txtTimeWait.Text, txtDate.Text, txtTime.Text, Vref.Id);
                        db.Add(dosis);
                        db.SaveChanges();
                        Vacunacion proceso = new Vacunacion(IDS, dosis.Id);
                        db.Add(proceso);
                        db.SaveChanges();
                        DosisxEfectoSecundario dosisxefecto = new DosisxEfectoSecundario(dosis.Id, Eref.Id);
                        db.Add(dosisxefecto);
                        db.SaveChanges();

                        MessageBox.Show("Usted ha recibido su primera dosis!", "Dosis1", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        //Pass = IDS;
                        //List<Dosi> Dosiss = db.Doses.ToList();
                        //Pass2 = (from q in Dosiss select q.Id).Max();
                        //newWindow.ShowDialog();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("No hay ninguna cita agendada para este usuario", "Error");
                    }
                }
                
            }
        }
        public static int Pass;
        public static int Pass2;
    

        private void frmFirstDose_Load(object sender, EventArgs e)
        {
            using(var db = new ProyectoFinalDBContext())
            {
                cmbVaccine.DataSource = db.Vacunas.ToList();
                cmbVaccine.DisplayMember = "Nombre";
                cmbVaccine.ValueMember = "Id";

                cmbEfecto.DataSource = db.EfectoSecundarios.ToList();
                cmbEfecto.DisplayMember = "Nombre";
                cmbEfecto.ValueMember = "Id";
            }
            
        }
    }
}
