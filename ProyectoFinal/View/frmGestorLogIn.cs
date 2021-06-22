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
            using(var db = new ProyectoFinalContext())
            { 
                var g = db.Gestors.ToList();
                g.ForEach(g =>
                {
                    if(txtPassword.Text == g.Contraseña||txtUser.Text == g.CorreoInstitucional)
                    {
                        MessageBox.Show("Inicio de sesión", "Inicio de sesion exitoso");
                        Open_Prechequeo();
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Inicio de sesión", "Usuario o contraseña incorrecta");
                    }
                });
                
            }
        }
        public static void Open_Prechequeo()
        {
            var newWindow = new frmPrechequeo();
            newWindow.ShowDialog();
        }
    }
}
