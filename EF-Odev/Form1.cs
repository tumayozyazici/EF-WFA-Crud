using EF_Odev.Models;
using System.Data;

namespace EF_Odev
{
    public partial class Form1 : Form
    {
        private readonly NorthwindContext db;
        public Form1()
        {
            InitializeComponent();
            db = new NorthwindContext();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            btn_add.Click += Click;
            btn_update.Click += Click;
            btn_delete.Click += Click;

            cmb_categories.DataSource = db.Categories.ToList();
            cmb_categories.DisplayMember = "CategoryName";
            cmb_categories.ValueMember = "CategoryId";

            cmb_supplier.DataSource = db.Suppliers.ToList();
            cmb_supplier.DisplayMember = "CompanyName";
            cmb_supplier.ValueMember = "SupplierId";

            dgv_productList.DataSource = db.Products.ToList();
        }
        private void Click(object sender, EventArgs e)
        {
            switch (((Button)sender).Tag)
            {
                case "1": ProductCreate(); break;
                case "2": ProductUpdate(); break;
                case "3": ProductDelete(); break;
                default:
                    break;
            }
            DgvFill();
        }

        private void DgvFill()
        {
            dgv_productList.DataSource = db.Products.ToList();
            dgv_productList.ClearSelection();
            Clear();
        }

        private void Clear()
        {
            foreach (Control item in this.Controls)
            {
                if (item is TextBox)
                {
                    TextBox txt = item as TextBox;
                    txt.Clear();
                }
                if (item is CheckBox)
                {
                    CheckBox chk = item as CheckBox;
                    chk.Checked = false;
                }
                if (item is NumericUpDown)
                {
                    NumericUpDown nmr = item as NumericUpDown;
                    nmr.Value = 0;
                }
                else if (item is ComboBox)
                {
                    ((ComboBox)item).SelectedIndex = -1;
                }
            }
        }

        private void ProductDelete()
        {
            Product product = db.Products.FirstOrDefault(x => x.ProductId == (int)dgv_productList.SelectedRows[0].Cells[0].Value);

            //int selectedRowIndex = dgv_productList.SelectedCells[0].RowIndex;
            //int id = (int)dgv_productList.Rows[selectedRowIndex].Cells[0].Value;
            //Product product = db.Products.Find(id);
            try
            {
                if (product != null)
                {
                    db.Products.Remove(product);
                    db.SaveChanges();
                }
            }
            catch (Exception)
            {

                throw;
            }

        }
        private void ProductUpdate()
        {
            Product product = db.Products.FirstOrDefault(x => x.ProductId == (int)dgv_productList.SelectedRows[0].Cells[0].Value);


            //int selectedRowIndex = dgv_productList.SelectedCells[0].RowIndex;
            //int id = (int)dgv_productList.Rows[selectedRowIndex].Cells[0].Value;
            //Product product = db.Products.Find(id);

            try
            {
                if (product != null && !string.IsNullOrWhiteSpace(txt_productName.Text))
                {
                    product.ProductName = txt_productName.Text.Trim();
                    product.CategoryId = (int)cmb_categories.SelectedValue;
                    product.SupplierId = (int)cmb_supplier.SelectedValue;
                    product.Discontinued = chk_discontinued.Checked ? true : false;
                    product.UnitPrice = nmr_unitPrice.Value;
                    product.UnitsInStock = (short)nmr_stock.Value;
                    product.UnitsOnOrder = (short)nmr_order.Value;
                    product.QuantityPerUnit = txt_quantity.Text.Trim();
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Ürün adý boþ geçilemez.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Veriler düzgün girilmedi");
            }
        }

        private void ProductCreate()
        {
            Product product = new Product();
            try
            {
                if (!string.IsNullOrWhiteSpace(txt_productName.Text))
                {
                    product.ProductName = txt_productName.Text;
                    product.CategoryId = (int)cmb_categories.SelectedValue;
                    product.SupplierId = (int)cmb_supplier.SelectedValue;
                    product.Discontinued = chk_discontinued.Checked ? true : false;
                    product.UnitPrice = nmr_unitPrice.Value;
                    product.UnitsInStock = (short)nmr_stock.Value;
                    product.UnitsOnOrder = (short)nmr_order.Value;
                    product.QuantityPerUnit = txt_quantity.Text;
                    db.Products.Add(product);
                    db.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Ürün adý boþ geçilemez.");
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Ekleme baþarýsýz.");
            }
        }

        private void dgv_productList_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowIndex = e.RowIndex;
            DataGridViewRow selectedRow = dgv_productList.Rows[rowIndex];
            txt_productName.Text = selectedRow.Cells["ProductName"].Value.ToString();
            cmb_supplier.SelectedValue = selectedRow.Cells["SupplierId"].Value;
            cmb_categories.SelectedValue = selectedRow.Cells["CategoryId"].Value;
            txt_quantity.Text = selectedRow.Cells["QuantityPerUnit"].Value.ToString();
            nmr_order.Value = (short)selectedRow.Cells["UnitsOnOrder"].Value;
            nmr_stock.Value = (short)selectedRow.Cells["UnitsInStock"].Value;
            nmr_unitPrice.Value = (decimal)selectedRow.Cells["UnitPrice"].Value;
            chk_discontinued.Checked = (bool)selectedRow.Cells["Discontinued"].Value ? true : false;
        }
    }
}
