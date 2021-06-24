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
    public partial class frmGestorLogIn : Form
    {
        public frmGestorLogIn()
        {
            InitializeComponent();
        }

        private void btnEnterUser_Click(object sender, EventArgs e)
        {
            var db = new ProyectoFinalContext();

            Gestor Gref = (Gestor)cmbUsuario.SelectedItem;

            List<Gestor> gestores = db.Gestors.ToList();
            List<Gestor> gestor = gestores
                .Where(g => g.Id == Gref.Id &&
                        g.Contraseña == txtPassword.Text).ToList();

            if (gestor.Count() > 0)
            {
                MessageBox.Show("Inicion de sesion exitoso", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                var ventana = new frmPrechequeo();
                this.Hide();
                ventana.ShowDialog();
            }
            else
                MessageBox.Show("Contraseña incorrecta", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Error);

            //using (var db = new ProyectoFinalContext())
            //{

            //    var g = db.Gestors.ToList();
            //    g.ForEach(g =>
            //    {
            //        if (txtPassword.Text == g.Contraseña || txtUser.Text == g.CorreoInstitucional)
            //        {
            //            MessageBox.Show("Inicio de sesión", "Inicio de sesion exitoso");
            //            Open_Prechequeo();
            //            this.Close();
            //        }
            //        else
            //        {
            //            MessageBox.Show("Inicio de sesión", "Usuario o contraseña incorrecta");
            //        }
            //    });

            //}
        }
        public static void Open_Prechequeo()
        {
            var newWindow = new frmPrechequeo();
            newWindow.ShowDialog();
        }

        private void frmGestorLogIn_Load(object sender, EventArgs e)
        {
            var db = new ProyectoFinalContext();
            cmbUsuario.DataSource = db.Gestors.ToList();
            cmbUsuario.DisplayMember = "Nombre";
            cmbUsuario.ValueMember = "Id";
        }
    }
}
