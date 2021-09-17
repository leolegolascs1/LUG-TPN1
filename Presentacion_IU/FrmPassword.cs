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

        private void FrmPassword_Load(object sender, EventArgs e)
        {

            List<BE_Personal> lstPersonal = new List<BE_Personal>();
            lstPersonal = oBLLPersonal.ListarTodo();

            oBEPersonal = lstPersonal.Find(x => x.Codigo == this.CodigoPersonal);
            
            MessageBox.Show(this.CodigoPersonal.ToString());

            if (oBEPersonal.Password.Length > 0)
            {

                tbxActual.Enabled = false;
            }
            else
            {
                tbxActual.Enabled = true;
            }

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            Cls_Encriptar.Encriptar(tbxNuevo.Text);
     
   
        }
    }
}
