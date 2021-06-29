using Proyecto_Final.Models;
using Proyecto_Final.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Final
{
    public partial class frmGestorLogIn : Form
    {
        public frmGestorLogIn()
        {
            InitializeComponent();
        }

        private void frmGestorLogIn_Load(object sender, EventArgs e)
        {
            var db = new ProyectoFinalDBContext();
            cmbCabin.DataSource = db.Cabinas.ToList();
            cmbCabin.DisplayMember = "Direccion";
            cmbCabin.ValueMember = "Id";
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {

            //dblogic
            using (var db = new ProyectoFinalDBContext())
            {
                List<Gestor> Ges = db.Gestors.ToList();
                bool SignIn = Ges.Any(g => g.Usuario == txtUsuarioG.Text && g.Contraseña == txtPasswordG.Text);

                if (SignIn)
                {
                    Cabina Cref = (Cabina)cmbCabin.SelectedItem;
                    DateTime t = DateTime.Now;
                    var Now = t.ToString();
                    int IdG = (from g in Ges where g.Contraseña == txtPasswordG.Text && g.Usuario == txtUsuarioG.Text select g.Id).SingleOrDefault();
                    InicioSesion Today = new InicioSesion(IdG, Cref.Id, Now);
                    db.Add(Today);
                    db.SaveChanges();
                    MessageBox.Show("Bienvenido!", "LogIn", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Pass = IdG;
                    Program.OpenfrmPreCheckOnClose = true;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrectos", "Error");
                }
            }

        }
        public static int Pass;
    }
}
