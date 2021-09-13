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
    public partial class FrmArticuloMateriaPrima : Form
    {
        BE_Materiales oMateriales;
        BLL_Material oBLLMaterial;
        
        public FrmArticuloMateriaPrima()
        {
            InitializeComponent();
            oMateriales = new BE_Materiales();
            oBLLMaterial = new BLL_Material();

        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            LLenarObjeto();
            oBLLMaterial.Guardar(oMateriales);
            LimpiarCampos();
            MostrarGrilla(dtgMateriales, oBLLMaterial.ListarTodoTable());
        }
        private void BtnModificar_Click(object sender, EventArgs e)
        {
            if (dtgMateriales.SelectedRows.Count > 0)
            {
                LLenarObjeto();

                if (oBLLMaterial.Guardar(oMateriales))
                {
                    MessageBox.Show("Registro Guardado Correctamente", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }
                LimpiarCampos();
                MostrarGrilla(dtgMateriales , oBLLMaterial.ListarTodoTable());
            }
            else
            {
                MessageBox.Show("Por Favor seleccione un personal a modificar", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {

        }

        private void FrmArticuloMateriaPrima_Load(object sender, EventArgs e)
        {
            CargaCombo();
            MostrarGrilla(dtgMateriales, oBLLMaterial.ListarTodoTable());
        }
        private void LimpiarCampos()
        {
            tbxCodigo.Text = "";
            tbxDescripcionArt.Text = "";
            cbxMaterial.SelectedItem = null;
        }
        private void MostrarGrilla(DataGridView pGrid, object obj)
        {
            pGrid.DataSource = null;
            pGrid.DataSource = obj;
        }
        private void CargaCombo()
        {
            cbxMaterial.Items.Add("Hierro");
            cbxMaterial.Items.Add("Aluminio");
            cbxMaterial.Items.Add("Aleación");
            cbxMaterial.SelectedIndex = 0;
        }
        private void LLenarObjeto()
        {
            if (tbxCodigo.Text != "")
            {
                oMateriales.Codigo = int.Parse(tbxCodigo.Text);
            }
            oMateriales.Descripcion_material  = tbxDescripcionArt.Text;
            oMateriales.Material  = cbxMaterial.Text;
        }

        private void DtgMateriales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpiarCampos();
            DataRowView _Filaseleccion = dtgMateriales.SelectedRows[0].DataBoundItem as DataRowView;
            if (_Filaseleccion != null)
            {
                tbxCodigo.Text = _Filaseleccion.Row[0].ToString();
                tbxDescripcionArt.Text = _Filaseleccion.Row[1].ToString();
                cbxMaterial.Text = _Filaseleccion.Row[2].ToString();
            }
            else
            {
                MessageBox.Show("Por Favor Seleccione una Fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
    }
}
