namespace EF_Odev
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            txt_quantity = new TextBox();
            label2 = new Label();
            txt_productName = new TextBox();
            btn_add = new Button();
            btn_update = new Button();
            btn_delete = new Button();
            label3 = new Label();
            cmb_categories = new ComboBox();
            dgv_productList = new DataGridView();
            nmr_stock = new NumericUpDown();
            label4 = new Label();
            nmr_unitPrice = new NumericUpDown();
            label5 = new Label();
            nmr_order = new NumericUpDown();
            label6 = new Label();
            chk_discontinued = new CheckBox();
            label7 = new Label();
            cmb_supplier = new ComboBox();
            ((System.ComponentModel.ISupportInitialize)dgv_productList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmr_stock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmr_unitPrice).BeginInit();
            ((System.ComponentModel.ISupportInitialize)nmr_order).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 106);
            label1.Name = "label1";
            label1.Size = new Size(68, 20);
            label1.TabIndex = 0;
            label1.Text = "Quantity:";
            // 
            // txt_quantity
            // 
            txt_quantity.Location = new Point(167, 103);
            txt_quantity.Name = "txt_quantity";
            txt_quantity.Size = new Size(167, 27);
            txt_quantity.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 23);
            label2.Name = "label2";
            label2.Size = new Size(103, 20);
            label2.TabIndex = 0;
            label2.Text = "ProductName:";
            // 
            // txt_productName
            // 
            txt_productName.Location = new Point(122, 20);
            txt_productName.Name = "txt_productName";
            txt_productName.Size = new Size(147, 27);
            txt_productName.TabIndex = 1;
            // 
            // btn_add
            // 
            btn_add.Location = new Point(192, 214);
            btn_add.Name = "btn_add";
            btn_add.Size = new Size(120, 76);
            btn_add.TabIndex = 2;
            btn_add.Tag = "1";
            btn_add.Text = "Ekle";
            btn_add.UseVisualStyleBackColor = true;
            // 
            // btn_update
            // 
            btn_update.Location = new Point(330, 214);
            btn_update.Name = "btn_update";
            btn_update.Size = new Size(115, 76);
            btn_update.TabIndex = 2;
            btn_update.Tag = "2";
            btn_update.Text = "Güncelle";
            btn_update.UseVisualStyleBackColor = true;
            // 
            // btn_delete
            // 
            btn_delete.Location = new Point(460, 214);
            btn_delete.Name = "btn_delete";
            btn_delete.Size = new Size(125, 76);
            btn_delete.TabIndex = 2;
            btn_delete.Tag = "3";
            btn_delete.Text = "Sil";
            btn_delete.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(275, 23);
            label3.Name = "label3";
            label3.Size = new Size(83, 20);
            label3.TabIndex = 0;
            label3.Text = "Categories:";
            // 
            // cmb_categories
            // 
            cmb_categories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_categories.FormattingEnabled = true;
            cmb_categories.Location = new Point(364, 20);
            cmb_categories.Name = "cmb_categories";
            cmb_categories.Size = new Size(164, 28);
            cmb_categories.TabIndex = 3;
            
            // 
            // dgv_productList
            // 
            dgv_productList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_productList.Dock = DockStyle.Bottom;
            dgv_productList.Location = new Point(0, 318);
            dgv_productList.Name = "dgv_productList";
            dgv_productList.RowHeadersWidth = 51;
            dgv_productList.RowTemplate.Height = 29;
            dgv_productList.Size = new Size(810, 258);
            dgv_productList.TabIndex = 4;
            dgv_productList.CellMouseClick += dgv_productList_CellMouseClick;
            // 
            // nmr_stock
            // 
            nmr_stock.Location = new Point(487, 103);
            nmr_stock.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmr_stock.Name = "nmr_stock";
            nmr_stock.Size = new Size(176, 27);
            nmr_stock.TabIndex = 5;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(380, 106);
            label4.Name = "label4";
            label4.Size = new Size(101, 20);
            label4.TabIndex = 6;
            label4.Text = "Units In Stock:";
            // 
            // nmr_unitPrice
            // 
            nmr_unitPrice.Location = new Point(167, 154);
            nmr_unitPrice.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmr_unitPrice.Name = "nmr_unitPrice";
            nmr_unitPrice.Size = new Size(167, 27);
            nmr_unitPrice.TabIndex = 5;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(61, 156);
            label5.Name = "label5";
            label5.Size = new Size(75, 20);
            label5.TabIndex = 6;
            label5.Text = "Unit Price:";
            // 
            // nmr_order
            // 
            nmr_order.Location = new Point(487, 158);
            nmr_order.Maximum = new decimal(new int[] { 1000, 0, 0, 0 });
            nmr_order.Name = "nmr_order";
            nmr_order.Size = new Size(176, 27);
            nmr_order.TabIndex = 5;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(380, 161);
            label6.Name = "label6";
            label6.Size = new Size(103, 20);
            label6.TabIndex = 6;
            label6.Text = "Units In Order:";
            // 
            // chk_discontinued
            // 
            chk_discontinued.AutoSize = true;
            chk_discontinued.Location = new Point(687, 137);
            chk_discontinued.Name = "chk_discontinued";
            chk_discontinued.Size = new Size(118, 24);
            chk_discontinued.TabIndex = 7;
            chk_discontinued.Text = "Discontinued";
            chk_discontinued.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(534, 23);
            label7.Name = "label7";
            label7.Size = new Size(67, 20);
            label7.TabIndex = 0;
            label7.Text = "Supplier:";
            // 
            // cmb_supplier
            // 
            cmb_supplier.DropDownStyle = ComboBoxStyle.DropDownList;
            cmb_supplier.FormattingEnabled = true;
            cmb_supplier.Location = new Point(607, 20);
            cmb_supplier.Name = "cmb_supplier";
            cmb_supplier.Size = new Size(175, 28);
            cmb_supplier.TabIndex = 3;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(810, 576);
            Controls.Add(chk_discontinued);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(nmr_order);
            Controls.Add(nmr_unitPrice);
            Controls.Add(nmr_stock);
            Controls.Add(dgv_productList);
            Controls.Add(cmb_supplier);
            Controls.Add(cmb_categories);
            Controls.Add(btn_delete);
            Controls.Add(btn_update);
            Controls.Add(btn_add);
            Controls.Add(txt_productName);
            Controls.Add(label7);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(txt_quantity);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgv_productList).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmr_stock).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmr_unitPrice).EndInit();
            ((System.ComponentModel.ISupportInitialize)nmr_order).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox txt_quantity;
        private Label label2;
        private TextBox txt_productName;
        private Button btn_add;
        private Button btn_update;
        private Button btn_delete;
        private Label label3;
        private ComboBox cmb_categories;
        private DataGridView dgv_productList;
        private NumericUpDown nmr_stock;
        private Label label4;
        private NumericUpDown nmr_unitPrice;
        private Label label5;
        private NumericUpDown nmr_order;
        private Label label6;
        private CheckBox chk_discontinued;
        private Label label7;
        private ComboBox cmb_supplier;
    }
}
