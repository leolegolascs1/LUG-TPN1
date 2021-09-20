using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using BE;
using Negocio_BLL;
using Seguridad;
namespace Presentacion_IU
{
    public partial class FrmPassword : Form
    {
        public int CodigoPersonal;
        BLL_Personal oBLLPersonal;
        BE_Personal oBEPersonal;

        public FrmPassword()
        {      
            InitializeComponent();
            oBLLPersonal = new BLL_Personal();         
        }
        private void Limpiar()
        {
            tbxActual.Text = "";
            tbxNuevo.Text = "";
            tbxNuevoRepite.Text = "";
        }
        private void FrmPassword_Load(object sender, EventArgs e)
        {
            List<BE_Personal> lstPersonal = new List<BE_Personal>(); //Creo lista de personal
            lstPersonal = oBLLPersonal.ListarTodo(); //Traigo todo el personal
            oBEPersonal = lstPersonal.Find(x => x.Codigo == this.CodigoPersonal); //Si encuentro el personal lo cargo

            if (oBEPersonal.Password.Length > 0) //Si el pass tiene algo
            {

                tbxActual.Enabled = true; //Habilito la casilla de actual
            }
            else
            {
                tbxActual.Enabled = false; //DesHabilito casilla actual
            }
        }
        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                List<BE_Personal> lstPersonal = new List<BE_Personal>(); //Creo una lista de perssonal
                lstPersonal = oBLLPersonal.ListarTodo(); //Obtener una lista.
                oBEPersonal = lstPersonal.Find(x => x.Codigo == this.CodigoPersonal); //Traigo el personal que esta cambiando el codigo.

                if (Cls_Encriptar.Desencriptar(oBEPersonal.Password) == tbxActual.Text) //Si el password desencriptado es igual al actaul ingresado.
                {
                    if (tbxNuevo.Text == tbxNuevoRepite.Text) //Si el password nuevo es igual al que repite
                    {
                        oBLLPersonal.Guardar(Cls_Encriptar.Encriptar(tbxNuevo.Text), CodigoPersonal); //Guardo el nuevo password
                        Limpiar();
                        MessageBox.Show("Password ingresado correctamente", "Modificar Password", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("El Password NUEVO no coincide con la CONFIRMACION", "Modificar Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("El Password Actual no es el correcto", "Modificar Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            Limpiar();
        }
    }
}
