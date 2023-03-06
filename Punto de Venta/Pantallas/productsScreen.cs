using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Punto_de_Venta
{
    //NOTAS: LO DE FECHA DE CAMBIO NO SE SI CAMBIARLO, AHORITA LO VEMOS
    public partial class productsScreen : Form
    {
        int indexBox, indexBox2;
        bool selection = false;
        bool selection2 = false;
        bool selection3 = false;
        bool bandera;
        int productSelection;
        Procedures proc1 = new Procedures();
        public productsScreen()
        {
            InitializeComponent();
            btnEditProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            dataGridProduct.ClearSelection();
            //cbActiveProduct.DropDownStyle = ComboBoxStyle.DropDownList;
            //dataGridProduct.Rows[0].Cells[0].Value = "B312";
            //dataGridProduct.Rows[0].Cells[1].Value = "Salmón";
            //dataGridProduct.Rows[0].Cells[2].Value = "Pescado importado";
            //dataGridProduct.Rows[0].Cells[3].Value = "Mariscos";
            //dataGridProduct.Rows[0].Cells[4].Value = "Kilogramo";
            //dataGridProduct.Rows[0].Cells[5].Value = "50.00";
            //dataGridProduct.Rows[0].Cells[6].Value = "60.00";
            //dataGridProduct.Rows[0].Cells[7].Value = "09/09/2022";
            //dataGridProduct.Rows[0].Cells[8].Value = "50";
            //dataGridProduct.Rows[0].Cells[9].Value = "10";
            //dataGridProduct.Rows[0].Cells[10].Value = "No aplica";
            //dataGridProduct.Rows[0].Cells[11].Value = "Si";
        }
        //txtActiveProduct
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            if (txtIdProduct.TextLength == 0 || txtNameProduct.TextLength == 0 || txtDesProduct.TextLength == 0 ||
                txtCostProduct.TextLength == 0 || txtPriceProduct.TextLength == 0 || txtExistenceProduct.TextLength == 0 || txtReOrdProduct.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dateValidFuture(dtpDateProduct.Value.Date) == false)
            {
                MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selection == false || selection2 == false || selection3 == false)
            {
                if (selection == false)
                    MessageBox.Show("Seleccione un campo de Departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if(selection2 == false)
                    MessageBox.Show("Seleccione una Unidad de Medida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if(selection3 == false)
                    MessageBox.Show("Seleccione si es activo o no", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Para solo usar dos decimales en costo
            string id = txtIdProduct.Text;
            int CodProducto;
            Int32.TryParse(id, out CodProducto);          
            string exiss = txtExistenceProduct.Text;
            int exxistencia;
            Int32.TryParse(exiss, out exxistencia);

            string ptReOrden = txtReOrdProduct.Text;
            int reOrder;
            Int32.TryParse(ptReOrden, out reOrder);

            
            //string ptReOrden = txtReOrdProduct.Text;
            //int reOrder;
            //Int32.TryParse(ptReOrden, out reOrder);

            string cost = txtCostProduct.Text;

            float costTemp = Convert.ToSingle(cost);
            string costDecimal = costTemp.ToString("0.##");
            float costFloat = Convert.ToSingle(costDecimal);
            //Para precio
            string prec = txtPriceProduct.Text;
            float precTemp = Convert.ToSingle(prec);
            string precDecimal = precTemp.ToString("0.##");
            float precFloat = Convert.ToSingle(precDecimal);
            Procedures proc = new Procedures();
            int ajajaja = Convert.ToInt32(cbDepartamentProduct.SelectedValue);
            int uniMedida = Convert.ToInt32(cbMeasureProduct.SelectedValue);
            DateTime fechaAlta = DateTime.Parse(dtpDateProduct.Text);
            //DateTime fechaCambio = DateTime.Parse(dtpChangeDateProduct.Text);
            var Variable = proc.InsertarProductos(CodProducto, txtNameProduct.Text, txtDesProduct.Text, uniMedida, fechaAlta, 
                exxistencia, reOrder, cbActiveProduct.Text, costFloat, precFloat, ajajaja);
            if (Variable)
            {
                MessageBox.Show("Inserccion Realizada con Exito", "Exito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridProduct.DataSource = proc.ListarProductos();
                clearTxt();
            }
            else
                MessageBox.Show("No se realizo la inserccion", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            dataGridProduct.DataSource = proc.ListarProductos();
        }

        private void txtIdProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void txtExistenceProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        private void txtCostProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtCostProduct.Text);
        }

        private void txtReOrdProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            onlyNumbers(sender, e);
        }

        public bool onlyNumbers(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 32 && e.KeyChar <= 47) || (e.KeyChar >= 58 && e.KeyChar <= 255))
            {
                MessageBox.Show("Solo se aceptan números en este campo", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                e.Handled = true;
                return false;
            }
            return true;
        }
        private bool dateValidFuture(DateTime fecha)
        {
            DateTime hoy = DateTime.Today;
            if (fecha > hoy)
            {
                return false;
            }
            return true;
        }

        private void btnEditProduct_Click(object sender, EventArgs e)
        {
            if (txtIdProduct.TextLength == 0 || txtNameProduct.TextLength == 0 || txtDesProduct.TextLength == 0 ||
                txtCostProduct.TextLength == 0 || txtPriceProduct.TextLength == 0 || txtExistenceProduct.TextLength == 0 || txtReOrdProduct.TextLength == 0)
            {
                MessageBox.Show("Faltan campos por llenar", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            if (dateValidFuture(dtpDateProduct.Value.Date) == false)
            {
                MessageBox.Show("Fecha no valida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (selection == false || selection2 == false || selection3 == false)
            {
                if (selection == false)
                    MessageBox.Show("Seleccione un campo de Departamento", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (selection2 == false)
                    MessageBox.Show("Seleccione una Unidad de Medida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                else if (selection3 == false)
                    MessageBox.Show("Seleccione una Unidad de Medida", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            //Para solo usar dos decimales en costo
            string cost = txtCostProduct.Text;
            float costTemp = Convert.ToSingle(cost);
            string costDecimal = costTemp.ToString("0.##");
            float costFloat = Convert.ToSingle(costDecimal);
            //Para precio
            string prec2 = txtPriceProduct.Text;
            float precTemp = Convert.ToSingle(prec2);
            string precDecimal = precTemp.ToString("0.##");
            float precFloat = Convert.ToSingle(precDecimal);
            Procedures proc = new Procedures();

            string id = txtIdProduct.Text;
            int CodProducto;
            Int32.TryParse(id, out CodProducto);
            string exiss = txtExistenceProduct.Text;
            int exxistencia;
            Int32.TryParse(exiss, out exxistencia);

            string idProdu = txtIdProduct.Text;
            int idIntPro;
            Int32.TryParse(idProdu, out idIntPro);

            string ptReOrden = txtReOrdProduct.Text;
            int reOrder;
            Int32.TryParse(ptReOrden, out reOrder);
            DateTime fechaCambio = DateTime.Parse(dtpDateProduct.Text);
            int Arsene = Convert.ToInt32(cbDepartamentProduct.SelectedValue);
            int uniMedida = Convert.ToInt32(cbMeasureProduct.SelectedValue);
            var LaGuerraDeLasGalaxias = proc.ActualizarProductos(idIntPro, txtNameProduct.Text, txtDesProduct.Text, uniMedida, fechaCambio, exxistencia, reOrder, cbActiveProduct.Text, costFloat, precFloat, Arsene); ;
            if (LaGuerraDeLasGalaxias)
            {
                MessageBox.Show("Actualizacion de producto exitosa", "Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridProduct.DataSource = proc.ListarProductos();
                clearTxt();
            }
            else
            {
                MessageBox.Show("ACTUALIZACION FALLIDA", "NO ACTUALIZADO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            limpiarDataGrid();
        }

        private void cbDepartamentProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexBox = cbDepartamentProduct.SelectedIndex;
            selection = true;
        }

        private void cbMeasureProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            indexBox2 = cbMeasureProduct.SelectedIndex;
            selection2 = true;
        }

        private void txtPriceProduct_KeyPress(object sender, KeyPressEventArgs e)
        {
            onePoint(e, txtPriceProduct.Text);
        }

        private void dataGridProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                
                dataGridProduct.AllowUserToOrderColumns = false;
                if (dataGridProduct.Rows[e.RowIndex].Cells[e.ColumnIndex].Value != null)
                {
                    string idProductoData;
                    int eseId;
                    idProductoData = dataGridProduct.CurrentRow.Cells["Codigo"].Value.ToString();
                    Int32.TryParse(idProductoData, out eseId);
                    productSelection = eseId;
                    txtIdProduct.Text = dataGridProduct.Rows[e.RowIndex].Cells["Codigo"].Value.ToString();
                    txtNameProduct.Text = dataGridProduct.Rows[e.RowIndex].Cells["Nombre Producto"].Value.ToString();
                    txtDesProduct.Text = dataGridProduct.Rows[e.RowIndex].Cells["Descripción"].Value.ToString();
                    txtPriceProduct.Text = dataGridProduct.Rows[e.RowIndex].Cells["Precio Unitario"].Value.ToString();
                    txtCostProduct.Text = dataGridProduct.Rows[e.RowIndex].Cells["Costo"].Value.ToString();
                    txtExistenceProduct.Text = dataGridProduct.Rows[e.RowIndex].Cells["Stock"].Value.ToString();
                    txtReOrdProduct.Text = dataGridProduct.Rows[e.RowIndex].Cells["Punto de Reorden"].Value.ToString();
                    cbDepartamentProduct.Text = dataGridProduct.Rows[e.RowIndex].Cells["Departamento"].Value.ToString();
                    cbMeasureProduct.Text = dataGridProduct.Rows[e.RowIndex].Cells["Unidad de Medida"].Value.ToString();
                    cbActiveProduct.Text = dataGridProduct.Rows[e.RowIndex].Cells["Activo"].Value.ToString();
                    dtpDateProduct.Text = dataGridProduct.Rows[e.RowIndex].Cells["Fecha de Alta"].Value.ToString();
                    dataGridProduct.CurrentRow.Selected = true;
                    dtpChangeDateProduct.Enabled = true;
                    dtpDateProduct.Enabled = false;
                    btnEditProduct.Enabled = true;
                    btnDeleteProduct.Enabled = true;
                    txtIdProduct.Enabled = false;
                    btnAddProduct.Enabled = false;
                }
            }
            catch (Exception ArgumentOutOfRangeException)
            {

            }
        }

        private void onePoint(KeyPressEventArgs e, String cadena)
        {
            int cont = 0;
            String caracter = "";
            for(int i = 0; i < cadena.Length; i++)
            {
                caracter = cadena.Substring(i, 1);
                if(caracter == ".")
                {
                    cont++;
                }
            }
            if(cont == 0)
            {
                bandera = true;
                if (e.KeyChar.ToString().Equals(".") && bandera)
                {
                    bandera = false;
                    e.Handled = false;
                }
                else if (Char.IsDigit(e.KeyChar))
                    e.Handled = false;
                else if (Char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
            else
            {
                bandera = false;
                e.Handled = true;
                if (Char.IsDigit(e.KeyChar))
                    e.Handled = false;
                else if (Char.IsControl(e.KeyChar))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }

        private void productsScreen_Load(object sender, EventArgs e)
        {
            Procedures instancia = new Procedures();
            ListarDepartamentos();
            ListarUnidadesMedida();
            dataGridProduct.DataSource = instancia.ListarProductos();
            dataGridProduct.Columns["Costo"].DefaultCellStyle.Format = "C2";
            dataGridProduct.Columns["Precio Unitario"].DefaultCellStyle.Format = "C2";
        }

        private void btnDeleteProduct_Click(object sender, EventArgs e)
        {
            Procedures proc = new Procedures();
            var eliminado = proc.BajaProductos(productSelection);
            if(eliminado == true)
            {
                MessageBox.Show("Se elimino el producto con exito", "Exíto", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridProduct.DataSource = proc.ListarProductos();
                clearTxt();
            }
            else
            {
                MessageBox.Show("NO se elimino el producto", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            limpiarDataGrid();
        }

        private void cbActiveProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            //indexBox2 = cbMeasureProduct.SelectedIndex;
            selection3 = true;
        }

        //Lorem ipsum, tulius alterus aerrebius maximus
        private void ListarDepartamentos()
        {
            Procedures usuarioObj = new Procedures();
            cbDepartamentProduct.DataSource = usuarioObj.ListarDepartamentosCb();
            cbDepartamentProduct.DisplayMember = "nombreDep";
            cbDepartamentProduct.ValueMember = "idDepa";//Valor real de l combox
        }

        private void ListarUnidadesMedida()
        {
            Procedures usuarioObj = new Procedures();
            cbMeasureProduct.DataSource = usuarioObj.ListarUnidadesMedidaCb();
            cbMeasureProduct.DisplayMember = "unidadMedida";
            cbMeasureProduct.ValueMember = "idMedida";//Valor real de l combox
        }

        private void limpiarDataGrid()
        {
            dataGridProduct.ClearSelection();
            txtIdProduct.Enabled = true;
            dtpDateProduct.Enabled = true;
            dtpChangeDateProduct.Enabled = false;
            btnEditProduct.Enabled = false;
            btnDeleteProduct.Enabled = false;
            btnAddProduct.Enabled = true;
        }

        private void txtFilterProduct_TextChanged(object sender, EventArgs e)
        {
            if (txtFilterProduct.Text != "")
            {
                dataGridProduct.DataSource = proc1.filtroScreenProduct(txtFilterProduct.Text);
            }
            else
            {
                dataGridProduct.DataSource = proc1.ListarProductos();
            }
        }

        private void clearTxt()
        {
            txtIdProduct.Text = "";
            txtNameProduct.Text = "";
            txtDesProduct.Text = "";
            cbDepartamentProduct.Text = "Seleccionar";
            cbMeasureProduct.Text = "Seleccionar";
            txtCostProduct.Text = "";
            txtPriceProduct.Text = "";
            dtpDateProduct.Text = "";
            txtExistenceProduct.Text = "";
            txtReOrdProduct.Text = "";
            dtpChangeDateProduct.Text = "";
            cbActiveProduct.Text = "Seleccionar";
            
        }
    }
}
