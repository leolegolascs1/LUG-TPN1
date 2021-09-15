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
namespace Presentacion_IU
{
    public partial class FrmGenerarOrdenCompra : Form
    {
        BLL_OrdenCompra oBLLOrdenCompra;
        BE_OrdenCompra oBEOrdenCompra;
        BE_DetalleCompra oBEDetalleCompra;


        List<BE_Proveedor> _lstProveedores;
        List<BE_Personal> _lstPersonal;
        List<BE_Materiales> _lstMateriales;

        public FrmGenerarOrdenCompra()
        {
            InitializeComponent();
            _lstProveedores = new List<BE_Proveedor>();
            _lstPersonal = new List<BE_Personal>();
            _lstMateriales = new List<BE_Materiales>();

            oBLLOrdenCompra = new BLL_OrdenCompra();
            oBEOrdenCompra = new BE_OrdenCompra();
            oBEDetalleCompra = new BE_DetalleCompra();
        }
        private void FrmGenerarOrdenCompra_Load(object sender, EventArgs e)
        {
            _lstProveedores = oBLLOrdenCompra.ListarTodoProveedor(); //Lleno lista de proveedores
            _lstPersonal = oBLLOrdenCompra.ListarTodoPersonal(); //lleno lista personal
            _lstMateriales = oBLLOrdenCompra.ListarTodoMaterial();

            CargaCombo();
            MostrarGrilla(dtgOrdenesCompra, oBLLOrdenCompra.ListarTodoOrdenCompra());
        }
        private void CargaCombo()
        {
            cbxProveedor.DataSource = _lstProveedores;
            cbxProveedor.DisplayMember = "RazonSocial";
            cbxProveedor.ValueMember = "Codigo";
            cbxProveedor.SelectedItem = null;

            cbxPersonal.DataSource = _lstPersonal;
            cbxPersonal.DisplayMember = "Nombre";
            cbxPersonal.ValueMember = "Codigo";
            cbxPersonal.SelectedItem = null;

            cbxItems.DataSource = _lstMateriales;
            cbxItems.DisplayMember = "Descripcion_Material";
            cbxItems.ValueMember = "Codigo";
            cbxItems.SelectedItem = null;
        }
        private void BtnAgregar_Click(object sender, EventArgs e)
        {

            BE_OrdenCompra _Filaseleccion = dtgOrdenesCompra.CurrentRow.DataBoundItem as BE_OrdenCompra;
            if (_Filaseleccion != null)
            {
                oBEDetalleCompra.NroItem = int.Parse(cbxItems.SelectedValue.ToString());
                oBEDetalleCompra.NroOrden = int.Parse(_Filaseleccion.Codigo.ToString());
                oBEDetalleCompra.Descripcion = cbxItems.Text;
                oBEDetalleCompra.Cantidad = int.Parse(tbxCantidad.Text);
            }

            oBLLOrdenCompra.Guardar(oBEDetalleCompra);
            LimpiarCampos();

        }
        private void BtnGenerarOrden_Click(object sender, EventArgs e)
        {
            LLenarObjeto();
            oBLLOrdenCompra.Guardar(oBEOrdenCompra);
            LimpiarCampos();
            MostrarGrilla(dtgOrdenesCompra, oBLLOrdenCompra.ListarTodoTable());
        }
        private void LLenarObjeto()
        {
            if (tbxNroOrden.Text != "")
            {
                oBEOrdenCompra.Codigo = int.Parse(tbxNroOrden.Text);
            }
            oBEOrdenCompra.Fecha = dtpFechaOrden.Value;
            BE_Proveedor _AuxProveedor = _lstProveedores.Find(x => x.Codigo == int.Parse(cbxProveedor.SelectedValue.ToString()));
            oBEOrdenCompra.Proveedor = _AuxProveedor;

            BE_Personal _AuxPersonal = _lstPersonal.Find(x => x.Codigo == int.Parse(cbxPersonal.SelectedValue.ToString()));
            oBEOrdenCompra.Personal = _AuxPersonal;
        }
        private void LimpiarCampos()
        {
            tbxNroOrden .Text = "";
            dtpFechaOrden.Value = DateTime.Today;
            cbxPersonal.SelectedItem = null;
            cbxProveedor .SelectedItem = null;
        }
        private void MostrarGrilla(DataGridView pGrid, object obj)
        {
            pGrid.DataSource = null;
            pGrid.DataSource = obj;
        }

        private void DtgOrdenesCompra_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpiarCampos();
            BE_OrdenCompra _Filaseleccion = dtgOrdenesCompra.CurrentRow.DataBoundItem as BE_OrdenCompra;
            if (_Filaseleccion != null)
            {
                tbxNroOrden.Text = _Filaseleccion.Codigo.ToString();
            }
            else
            {
                MessageBox.Show("Por Favor Seleccione una Fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
