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
        private void FrmArticuloMateriaPrima_Load(object sender, EventArgs e)
        {
            CargaCombo();
            MostrarGrilla(dtgMateriales, oBLLMaterial.ListarTodo());
        }
        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (tbxDescripcionArt.Text.Length > 0 || cbxMaterial.SelectedItem != null)
            {
                LLenarObjeto();
                if (oBLLMaterial.Guardar(oMateriales))
                {
                    MessageBox.Show("Registro Guardado Correctamente", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
                LimpiarCampos();
                MostrarGrilla(dtgMateriales, oBLLMaterial.ListarTodo());
            }
            else
            {
                MessageBox.Show("Por Favor Ingrese todos los datos!", "Modificar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            if (tbxCodigo.Text.Length > 0)
            {
                DialogResult dialogResult = MessageBox.Show("Desea ELIMINAR el Articulo Nº" + tbxCodigo.Text + "'-"+ tbxDescripcionArt +"'", "Eliminar", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    LLenarObjeto();
                    oBLLMaterial.Baja(oMateriales);
                    MostrarGrilla(dtgMateriales, oBLLMaterial.ListarTodo());
                    MessageBox.Show("Personal Eliminado Correctamente", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Seleccione un personal para eliminar", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }
        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            LimpiarCampos();
        }
        private void DtgMateriales_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            LimpiarCampos();
            BE_Materiales _Filaseleccion = dtgMateriales.SelectedRows[0].DataBoundItem as BE_Materiales;
            if (_Filaseleccion != null)
            {
                tbxCodigo.Text = _Filaseleccion.Codigo.ToString();
                tbxDescripcionArt.Text = _Filaseleccion.Descripcion_material;
                cbxMaterial.Text = _Filaseleccion.Material;
            }
            else
            {
                MessageBox.Show("Por Favor Seleccione una Fila", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
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
            pGrid.AutoResizeColumns();
            pGrid.AllowUserToResizeColumns = false;
            pGrid.AllowUserToResizeRows = false;
        }
        private void CargaCombo()
        {
            cbxMaterial.Items.Add("Hierro");
            cbxMaterial.Items.Add("Aluminio");
            cbxMaterial.Items.Add("Aleación");    
            cbxMaterial.SelectedItem = null;
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
    }
}
