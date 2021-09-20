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
using Seguridad;
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
            try
            {
                if (tbxUsuario.Text.Length > 0 || tbxPassword.Text.Length > 0) //Si no estan vacios los dos campos d usuario y pass
                {
                    if (tbxUsuario.Text.Length > 0) //Si no esta vacio usuario
                    {
                        if (tbxPassword.Text.Length > 0) //Si no  esta vacio pass
                        {
                            oBELogin.Usuario = tbxUsuario.Text;
                            oBELogin.Contrasenia = tbxPassword.Text;
                            ValidarUsuario(); //Valido
                        }
                        else
                        {
                            MessageBox.Show("Por favor ingrese una contrasena!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                    }
                    else
                    {
                        MessageBox.Show("Por favor ingrese un usuario!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Por favor ingrese un usuario y contrasena!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
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

            if(CL_Validar.EsNumerico(tbxUsuario.Text)) //Valido que el usuario se numerico
            {
                BE_Personal oBEPersonal = _lstPersonal.Find(x => x.Codigo == int.Parse(tbxUsuario.Text)); //Se busca el personal que coincide con el codigo ingresado

                if(oBEPersonal != null) //Si encuentro personal
                {
                    if (Cls_Encriptar.Desencriptar(oBEPersonal.Password) == tbxPassword.Text && oBEPersonal != null) //Si el pass es igual al desencriptado y encontro el usuario 
                    {
                        FrmPrincipal oFrmPrincipal = new FrmPrincipal();
                        oFrmPrincipal.Show();
                        this.Hide();
                        MessageBox.Show("Bienvenido " + oBEPersonal.ToString(), "Atención", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Usuario o Password incorrecto!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Usuario o Password incorrecto!", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

            }
       }
    }
}
