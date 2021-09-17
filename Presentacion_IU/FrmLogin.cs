using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.Windows.Forms;
using Negocio_BLL;
using BE;
namespace Presentacion_IU
{
    public partial class FrmLogin : Form
    {
        BE_Login oBELogin;
        BLL_Personal oBLLPersonal;

        public FrmLogin()
        {
            InitializeComponent();
            oBELogin = new BE_Login();
            oBLLPersonal = new BLL_Personal();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {

        }
        private void btnAceptar_Click(object sender, EventArgs e)
        {
            oBELogin.Usuario = tbxUsuario.Text;
            oBELogin.Contrasenia = tbxPassword.Text;

            ValidarUsuario();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
        private void Limpiar() 
        {
            tbxPassword.Text = "";
            tbxUsuario.Text = "";
        }
       private void ValidarUsuario() 
       {
            List<BE_Personal> _lstPersonal = new List<BE_Personal>();
            _lstPersonal = oBLLPersonal.ListarTodo();

            if(_lstPersonal.Exists(x => x.Apellido == oBELogin.Usuario && x.Password == oBELogin.Contrasenia)) 
            {
                FrmPrincipal oFrmPrincipal = new FrmPrincipal();
                oFrmPrincipal.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Usuario o Password incorrecto!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            
       }
    }
}
