using Microsoft.Data.SqlClient;
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
    public partial class frmPreCheck : Form
    {
        public frmPreCheck()
        {
            InitializeComponent();
        }

        private void frmPreCheck_Load(object sender, EventArgs e)
        {
            tbcPreCheck.Appearance = TabAppearance.FlatButtons;
            tbcPreCheck.ItemSize = new Size(0, 1);
            tbcPreCheck.SizeMode = TabSizeMode.Fixed;
            tbcPreCheck.TabStop = false;
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            tbcPreCheck.SelectedIndex = 1;
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            tbcPreCheck.SelectedIndex = 2;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnStartVaccProc_Click(object sender, EventArgs e)
        {
            using (Form newWindow = new frmCitizenRegister())
            {
                newWindow.ShowDialog();
            }
        }

        private void btnContinueVaccProcc_Click(object sender, EventArgs e)
        {
            using(Form newWindow = new frmFirstDose())
            {
                newWindow.ShowDialog();
            }
        }

        private void btnFinishVaccProcc_Click(object sender, EventArgs e)
        {
            using(Form newWindow = new frmSecondDose())
            {
                newWindow.ShowDialog();
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            using(var db = new ProyectoFinalDBContext())
            {
                List<Cita1> Cit = db.Cita1s.ToList();
                List<Dosi> Dosi = db.Doses.ToList();
                List<Ciudadano> Us = db.Ciudadanos.ToList();
                var queue =
                    (from us in Us
                     join cit in Cit
                     on us.Id equals cit.IdCiudadano into joint
                     from q in joint.DefaultIfEmpty()
                     where us.Dui == txtSearchCitizen.Text
                     select new

                     {
                         Nombre = us.Nombre,
                         Dui = us.Dui,
                         FechaCita1 = $"{q.Fecha} {q.Hora}"
                     }).ToList();
                dgvSingleSearch.DataSource = queue;
            }
        }
    }
}
