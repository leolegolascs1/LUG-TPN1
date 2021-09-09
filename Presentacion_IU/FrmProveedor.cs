using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BE;
using Negocio_BLL;
namespace Presentacion_IU
{
    public partial class FrmProveedor : Form
    {
        BLL_Proveedor oBLL_Proveedor;
        BE_Proveedor oProveedor;
        public FrmProveedor()
        {
            InitializeComponent();

            oBLL_Proveedor = new BLL_Proveedor();
        }
        private void MostrarGrilla(DataGridView pGrid, object obj)
        {
            pGrid.DataSource = null;
            pGrid.DataSource = obj;
        }
        private void LLenarObjeto()
        {
            oProveedor = new BE_Proveedor();
            if (tbxNroProveedor.Text != "")
            {
                oProveedor.Codigo = int.Parse(tbxNroProveedor.Text);
            }
            oProveedor.Apellido = tbxApellido.Text;
            oProveedor.Nombre = tbxNombre.Text;
            oProveedor.RazonSocial = tbxRazonSocial.Text;
            oProveedor.CUIT = tbxCUIT.Text;
            oProveedor.CUIL = tbxCUIL.Text;
            oProveedor.EMail = tbxEmail.Text;
            oProveedor.Telefono = tbxTelefono.Text;
            oProveedor.Localidad  = tbxLocalidad.Text;
            oProveedor.Direccion = tbxDireccion.Text;
        }
        private void LimpiarCampos()
        {
            tbxNroProveedor.Text = "";
            tbxApellido.Text = "";
            tbxNombre.Text = "";
            tbxRazonSocial.Text = "";
            tbxCUIT.Text = "";
            tbxCUIL.Text = "";
            tbxEmail.Text = "";
            tbxTelefono.Text = "";
            tbxLocalidad.Text = "";
            tbxDireccion.Text = "";
        }
        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            MostrarGrilla(dtgProveedores , oBLL_Proveedor.ListarTodoTable());
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LLenarObjeto();
            oBLL_Proveedor.Guardar(oProveedor);
            LimpiarCampos();
            MostrarGrilla(dtgProveedores, oBLL_Proveedor.ListarTodoTable());
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (dtgProveedores.SelectedRows.Count > 0)
            {
           
                LLenarObjeto();

                if (oBLL_Proveedor.Guardar(oProveedor))
                {
                    MessageBox.Show("Registro Guardado Correctamente", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                LimpiarCampos();
                MostrarGrilla(dtgProveedores, oBLL_Proveedor.ListarTodoTable());
            }
            else
            {
                MessageBox.Show("Por Favor seleccione un Proveedor a modificar", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }

        private void DtgProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpiarCampos();
            DataRowView _Filaseleccion = dtgProveedores.SelectedRows[0].DataBoundItem as DataRowView;
            if (_Filaseleccion != null)
            {
                tbxNroProveedor .Text = _Filaseleccion.Row[0].ToString();
                tbxApellido.Text = _Filaseleccion.Row[1].ToString();
                tbxNombre.Text = _Filaseleccion.Row[2].ToString();
                tbxRazonSocial.Text = _Filaseleccion.Row[3].ToString();
                tbxCUIT.Text = _Filaseleccion.Row[4].ToString();
                tbxCUIL .Text = _Filaseleccion.Row[5].ToString();
                tbxEmail.Text = _Filaseleccion.Row[6].ToString();
                tbxTelefono.Text = _Filaseleccion.Row[7].ToString();
                tbxLocalidad.Text = _Filaseleccion.Row[8].ToString();
                tbxDireccion.Text = _Filaseleccion.Row[9].ToString();
           
            }
            else
            {
                MessageBox.Show("Por Favor Seleccione una Fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
