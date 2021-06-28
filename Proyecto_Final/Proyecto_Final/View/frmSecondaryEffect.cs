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
    public partial class frmSecondaryEffect : Form
    {
        public frmSecondaryEffect()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            using(Form newWindow = new frmAppointment2())
            {
                using(var db = new ProyectoFinalDBContext())
                {
                    EfectoSecundario IEref = (EfectoSecundario)cmbEffects.SelectedItem;
                    DosisxEfectoSecundario Effect = new DosisxEfectoSecundario(frmFirstDose.Pass2, frmFirstDose.Pass2);
                    db.Add(Effect);
                    db.SaveChanges();
                }
                newWindow.ShowDialog();
                this.Close();
            }
        }

        private void frmSecondaryEffect_Load(object sender, EventArgs e)
        {

            using(var db = new ProyectoFinalDBContext())
            {
                cmbEffects.DataSource = db.EfectoSecundarios.ToList();
                cmbEffects.DisplayMember = "Nombre";
                cmbEffects.ValueMember = "Id";
            }
            
        }
    }
}
