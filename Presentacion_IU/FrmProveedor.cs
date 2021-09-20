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

        private void FrmProveedor_Load(object sender, EventArgs e)
        {
            MostrarGrilla(dtgProveedores , oBLL_Proveedor.ListarTodo()); //Cargo el grid con el listado de proveedores
        }
        private void DtgProveedores_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                LimpiarCampos();
                BE_Proveedor _Filaseleccion = dtgProveedores.SelectedRows[0].DataBoundItem as BE_Proveedor; //Selecciono el objeto del grid
                if (_Filaseleccion != null) //Si hay una seleccion cargo los datos.
                {
                    tbxNroProveedor.Text = _Filaseleccion.Codigo.ToString();
                    tbxApellido.Text = _Filaseleccion.Apellido;
                    tbxNombre.Text = _Filaseleccion.Nombre;
                    tbxRazonSocial.Text = _Filaseleccion.RazonSocial;
                    tbxCUIT.Text = _Filaseleccion.CUIT;
                    tbxEmail.Text = _Filaseleccion.EMail;
                    tbxTelefono.Text = _Filaseleccion.Telefono;
                    tbxLocalidad.Text = _Filaseleccion.Localidad;
                    tbxDireccion.Text = _Filaseleccion.Direccion;
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
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                //Verifico que los datos enten cargados
                if (tbxApellido.Text.Length > 0 || tbxNombre.Text.Length > 0 || tbxRazonSocial.Text.Length > 0 || tbxCUIT.Text.Length > 0 || tbxEmail.Text.Length > 0 || tbxTelefono.Text.Length > 0 || tbxLocalidad.Text.Length > 0 || tbxDireccion.Text.Length > 0)
                {
                    LLenarObjeto();
                    if (oBLL_Proveedor.Guardar(oProveedor)) //Guardo el objeto cargado, si es ok muestro msj
                    {
                        MessageBox.Show("Registro Guardado Correctamente", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                    LimpiarCampos();
                    MostrarGrilla(dtgProveedores, oBLL_Proveedor.ListarTodo()); //Muestro listado proveedor.
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
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbxNroProveedor.Text.Length > 0) //Si esta cargado el codigo en el tbx
                {
                    DialogResult dialogResult = MessageBox.Show("Desea ELIMINAR el Proveedor Nº" + tbxNroProveedor.Text + "?", "Eliminar", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes) //Si se quiere eliminar
                    {
                        LLenarObjetoBaja(); 
                        oBLL_Proveedor.Baja(oProveedor); //Envio el proveedor a dar de baja.
                        LimpiarCampos();
                        MostrarGrilla(dtgProveedores, oBLL_Proveedor.ListarTodo()); //Muestro proveedor
                        MessageBox.Show("Proveedor Eliminado Correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void MostrarGrilla(DataGridView pGrid, object obj)
        {
            pGrid.DataSource = null;
            pGrid.DataSource = obj;
            pGrid.AutoResizeColumns(); // Ajusto columnas
            pGrid.AllowUserToResizeColumns = false; //Trabo las columnas
            pGrid.AllowUserToResizeRows = false; //Trabo las filas
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
            oProveedor.EMail = tbxEmail.Text;
            oProveedor.Telefono = tbxTelefono.Text;
            oProveedor.Localidad = tbxLocalidad.Text;
            oProveedor.Direccion = tbxDireccion.Text;
        }
        private void LLenarObjetoBaja()
        {
            oProveedor = new BE_Proveedor();
            if (tbxNroProveedor.Text != "")
            {
                oProveedor.Codigo = int.Parse(tbxNroProveedor.Text);
            }
        }
        private void LimpiarCampos()
        {
            tbxNroProveedor.Text = "";
            tbxApellido.Text = "";
            tbxNombre.Text = "";
            tbxRazonSocial.Text = "";
            tbxCUIT.Text = "";
            tbxEmail.Text = "";
            tbxTelefono.Text = "";
            tbxLocalidad.Text = "";
            tbxDireccion.Text = "";
        }
    }
}
