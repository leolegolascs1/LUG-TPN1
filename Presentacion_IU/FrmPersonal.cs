using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio_BLL;
using BE;
using BE.Vistas;
using Microsoft.VisualBasic;
namespace Presentacion_IU
{
 
    public partial class FrmPersonal : Form
    {     
        BE_Personal oPersonal;
        BLL_Personal oBLLPersonal;
        VistaPersonal oVista;
        public FrmPersonal()
        {
            InitializeComponent();

            oBLLPersonal = new BLL_Personal();
            oVista = new VistaPersonal();
          
        }
        private void FrmPersonal_Load(object sender, EventArgs e)
        {
            CargaCombo();
            MostrarGrilla(dtgPersonal, oVista.CargarGridVista(oBLLPersonal.ListarTodo()));
        }
        private void CargaCombo() 
        {
            cbxTipoEmpleado.Items.Add("Administrador");
            cbxTipoEmpleado.Items.Add("Mostrador");
            cbxTipoEmpleado.Items.Add("Fabrica");
            cbxTipoEmpleado.SelectedIndex = 0;
        }
        private void CreoTipoEmpleado() 
        {
            if (cbxTipoEmpleado.Text == "Mostrador")
            {
                oPersonal = new BE_PersonalMostrador();
            }
            else if (cbxTipoEmpleado.Text == "Fabrica")
            {
                oPersonal = new BE_PersonalFabrica();
            }
            else if (cbxTipoEmpleado.Text == "Administrador")
            {
                oPersonal = new BE_PersonalAdministrador();
            }
        }
        private void LLenarObjeto() 
        {
            if(tbxNroEmpleado.Text != "") 
            {
               oPersonal.Codigo = int.Parse(tbxNroEmpleado.Text);
            }
            oPersonal.Apellido = tbxApellido.Text;
            oPersonal.Nombre  = tbxNombre.Text;
            oPersonal.Documento = int.Parse(tbxDocumento.Text);
        }
        private void LimpiarCampos() 
        {
            tbxNroEmpleado.Text = "";
            tbxApellido.Text = "";
            tbxNombre.Text = "";
            tbxDocumento.Text = "";
            cbxTipoEmpleado.SelectedItem = null;
        }
        private void MostrarGrilla(DataGridView pGrid, object obj) 
        {
            pGrid.DataSource = null;
            pGrid.DataSource = obj;
            pGrid.AutoResizeColumns();
            pGrid.AllowUserToResizeColumns = false;
            pGrid.AllowUserToResizeRows = false;
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxApellido.Text.Length > 0 || tbxNombre.Text.Length > 0 || tbxDocumento.Text.Length > 0 || cbxTipoEmpleado.SelectedItem == null)
                {
                    CreoTipoEmpleado();
                    LLenarObjeto();
                    if (oBLLPersonal.Guardar(oPersonal))
                    {
                        MessageBox.Show("Registro Guardado Correctamente", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    LimpiarCampos();
                    MostrarGrilla(dtgPersonal, oBLLPersonal.ListarTodo());
                }
                else
                {
                    MessageBox.Show("Por Favor Ingrese todos los datos!", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxNroEmpleado.Text.Length > 0)
                {
                    DialogResult dialogResult = MessageBox.Show("Desea ELIMINAR el Personal Nº" + tbxNroEmpleado.Text + "?", "Eliminar", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        CreoTipoEmpleado();
                        LLenarObjeto();

                        oBLLPersonal.Baja(oPersonal);
                        MostrarGrilla(dtgPersonal, oBLLPersonal.ListarTodo());
                        MessageBox.Show("Personal Eliminado Correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("Seleccione un personal para eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }   
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void dtgPersonal_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LimpiarCampos();
                VistaPersonal _Filaseleccion = dtgPersonal.SelectedRows[0].DataBoundItem as VistaPersonal;

                if (_Filaseleccion != null)
                {
                    tbxNroEmpleado.Text = _Filaseleccion.Codigo.ToString();
                    tbxApellido.Text = _Filaseleccion.Apellido;
                    tbxNombre.Text = _Filaseleccion.Nombre;
                    tbxDocumento.Text = _Filaseleccion.Documento.ToString();
                    cbxTipoEmpleado.Text = _Filaseleccion.Rol;
                }
                else
                {
                    MessageBox.Show("Por Favor Seleccione una Fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void BtnGenerarPass_Click(object sender, EventArgs e)
        {
            try
            {
                using (FrmPassword oFrmPassword = new FrmPassword())
                {
                    if (tbxNroEmpleado.Text.Length > 0)
                    {
                        oFrmPassword.CodigoPersonal = int.Parse(tbxNroEmpleado.Text);
                        DialogResult dr = oFrmPassword.ShowDialog();
                    }
                    else
                    {
                        MessageBox.Show("Primero seleccione el Personal requerido", "Contrasenas", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

    }
}
