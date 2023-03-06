
namespace Punto_de_Venta
{
    partial class productsScreen
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtFilterProduct = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.btnDeleteProduct = new System.Windows.Forms.Button();
            this.btnEditProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.txtReOrdProduct = new System.Windows.Forms.TextBox();
            this.txtPriceProduct = new System.Windows.Forms.TextBox();
            this.txtCostProduct = new System.Windows.Forms.TextBox();
            this.txtDesProduct = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtIdProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtExistenceProduct = new System.Windows.Forms.TextBox();
            this.dtpDateProduct = new System.Windows.Forms.DateTimePicker();
            this.cbDepartamentProduct = new System.Windows.Forms.ComboBox();
            this.cbMeasureProduct = new System.Windows.Forms.ComboBox();
            this.dtpChangeDateProduct = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.txtNameProduct = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.cbActiveProduct = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilterProduct
            // 
            this.txtFilterProduct.Location = new System.Drawing.Point(640, 85);
            this.txtFilterProduct.Multiline = true;
            this.txtFilterProduct.Name = "txtFilterProduct";
            this.txtFilterProduct.Size = new System.Drawing.Size(146, 22);
            this.txtFilterProduct.TabIndex = 54;
            this.txtFilterProduct.TextChanged += new System.EventHandler(this.txtFilterProduct_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(579, 85);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 22);
            this.label12.TabIndex = 53;
            this.label12.Text = "Filtro:";
            // 
            // btnDeleteProduct
            // 
            this.btnDeleteProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteProduct.Location = new System.Drawing.Point(768, 536);
            this.btnDeleteProduct.Name = "btnDeleteProduct";
            this.btnDeleteProduct.Size = new System.Drawing.Size(139, 51);
            this.btnDeleteProduct.TabIndex = 51;
            this.btnDeleteProduct.Text = "Eliminar";
            this.btnDeleteProduct.UseVisualStyleBackColor = false;
            this.btnDeleteProduct.Click += new System.EventHandler(this.btnDeleteProduct_Click);
            // 
            // btnEditProduct
            // 
            this.btnEditProduct.BackColor = System.Drawing.Color.Navy;
            this.btnEditProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditProduct.Location = new System.Drawing.Point(613, 536);
            this.btnEditProduct.Name = "btnEditProduct";
            this.btnEditProduct.Size = new System.Drawing.Size(139, 51);
            this.btnEditProduct.TabIndex = 50;
            this.btnEditProduct.Text = "Editar";
            this.btnEditProduct.UseVisualStyleBackColor = false;
            this.btnEditProduct.Click += new System.EventHandler(this.btnEditProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Green;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddProduct.Location = new System.Drawing.Point(455, 536);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(139, 51);
            this.btnAddProduct.TabIndex = 49;
            this.btnAddProduct.Text = "Agregar";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // txtReOrdProduct
            // 
            this.txtReOrdProduct.Location = new System.Drawing.Point(261, 485);
            this.txtReOrdProduct.Multiline = true;
            this.txtReOrdProduct.Name = "txtReOrdProduct";
            this.txtReOrdProduct.Size = new System.Drawing.Size(146, 22);
            this.txtReOrdProduct.TabIndex = 45;
            this.txtReOrdProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtReOrdProduct_KeyPress);
            // 
            // txtPriceProduct
            // 
            this.txtPriceProduct.Location = new System.Drawing.Point(261, 349);
            this.txtPriceProduct.Multiline = true;
            this.txtPriceProduct.Name = "txtPriceProduct";
            this.txtPriceProduct.Size = new System.Drawing.Size(146, 22);
            this.txtPriceProduct.TabIndex = 44;
            this.txtPriceProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPriceProduct_KeyPress);
            // 
            // txtCostProduct
            // 
            this.txtCostProduct.Location = new System.Drawing.Point(261, 306);
            this.txtCostProduct.Multiline = true;
            this.txtCostProduct.Name = "txtCostProduct";
            this.txtCostProduct.Size = new System.Drawing.Size(146, 22);
            this.txtCostProduct.TabIndex = 43;
            this.txtCostProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCostProduct_KeyPress);
            // 
            // txtDesProduct
            // 
            this.txtDesProduct.Location = new System.Drawing.Point(261, 146);
            this.txtDesProduct.Multiline = true;
            this.txtDesProduct.Name = "txtDesProduct";
            this.txtDesProduct.Size = new System.Drawing.Size(146, 51);
            this.txtDesProduct.TabIndex = 40;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(147, 438);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(98, 22);
            this.label11.TabIndex = 39;
            this.label11.Text = "Existencia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(106, 349);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(139, 22);
            this.label10.TabIndex = 38;
            this.label10.Text = "Precio unitario";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(106, 393);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(139, 22);
            this.label9.TabIndex = 37;
            this.label9.Text = "Fecha de alta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(67, 485);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(178, 22);
            this.label7.TabIndex = 35;
            this.label7.Text = "Punto de Reorden";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(182, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 22);
            this.label6.TabIndex = 34;
            this.label6.Text = "Costo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(63, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 22);
            this.label5.TabIndex = 33;
            this.label5.Text = "Unidad de medida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(97, 216);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 32;
            this.label4.Text = "Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(129, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Descripción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(364, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(198, 44);
            this.label2.TabIndex = 30;
            this.label2.Text = "Productos";
            // 
            // txtIdProduct
            // 
            this.txtIdProduct.Location = new System.Drawing.Point(261, 71);
            this.txtIdProduct.Multiline = true;
            this.txtIdProduct.Name = "txtIdProduct";
            this.txtIdProduct.Size = new System.Drawing.Size(146, 22);
            this.txtIdProduct.TabIndex = 29;
            this.txtIdProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdProduct_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(47, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(198, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Código de Producto";
            // 
            // txtExistenceProduct
            // 
            this.txtExistenceProduct.Location = new System.Drawing.Point(261, 438);
            this.txtExistenceProduct.Multiline = true;
            this.txtExistenceProduct.Name = "txtExistenceProduct";
            this.txtExistenceProduct.Size = new System.Drawing.Size(146, 22);
            this.txtExistenceProduct.TabIndex = 55;
            this.txtExistenceProduct.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtExistenceProduct_KeyPress);
            // 
            // dtpDateProduct
            // 
            this.dtpDateProduct.Location = new System.Drawing.Point(261, 395);
            this.dtpDateProduct.Name = "dtpDateProduct";
            this.dtpDateProduct.Size = new System.Drawing.Size(146, 20);
            this.dtpDateProduct.TabIndex = 56;
            // 
            // cbDepartamentProduct
            // 
            this.cbDepartamentProduct.FormattingEnabled = true;
            this.cbDepartamentProduct.Items.AddRange(new object[] {
            "Frutería",
            "Carnes",
            "Lacteos",
            "Bebidas"});
            this.cbDepartamentProduct.Location = new System.Drawing.Point(261, 217);
            this.cbDepartamentProduct.Name = "cbDepartamentProduct";
            this.cbDepartamentProduct.Size = new System.Drawing.Size(146, 21);
            this.cbDepartamentProduct.TabIndex = 57;
            this.cbDepartamentProduct.Text = "Seleccionar";
            this.cbDepartamentProduct.SelectedIndexChanged += new System.EventHandler(this.cbDepartamentProduct_SelectedIndexChanged);
            // 
            // cbMeasureProduct
            // 
            this.cbMeasureProduct.FormattingEnabled = true;
            this.cbMeasureProduct.Location = new System.Drawing.Point(261, 260);
            this.cbMeasureProduct.Name = "cbMeasureProduct";
            this.cbMeasureProduct.Size = new System.Drawing.Size(146, 21);
            this.cbMeasureProduct.TabIndex = 58;
            this.cbMeasureProduct.Text = "Seleccionar";
            this.cbMeasureProduct.SelectedIndexChanged += new System.EventHandler(this.cbMeasureProduct_SelectedIndexChanged);
            // 
            // dtpChangeDateProduct
            // 
            this.dtpChangeDateProduct.Enabled = false;
            this.dtpChangeDateProduct.Location = new System.Drawing.Point(261, 531);
            this.dtpChangeDateProduct.Name = "dtpChangeDateProduct";
            this.dtpChangeDateProduct.Size = new System.Drawing.Size(146, 20);
            this.dtpChangeDateProduct.TabIndex = 60;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(72, 529);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(173, 22);
            this.label8.TabIndex = 59;
            this.label8.Text = "Fecha de cambio";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(83, 579);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(162, 22);
            this.label13.TabIndex = 61;
            this.label13.Text = "Producto Activo";
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AllowUserToAddRows = false;
            this.dataGridProduct.AllowUserToDeleteRows = false;
            this.dataGridProduct.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduct.Location = new System.Drawing.Point(455, 120);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.ReadOnly = true;
            this.dataGridProduct.RowHeadersWidth = 51;
            this.dataGridProduct.Size = new System.Drawing.Size(452, 389);
            this.dataGridProduct.TabIndex = 98;
            this.dataGridProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridProduct_CellClick);
            // 
            // txtNameProduct
            // 
            this.txtNameProduct.Location = new System.Drawing.Point(261, 108);
            this.txtNameProduct.Multiline = true;
            this.txtNameProduct.Name = "txtNameProduct";
            this.txtNameProduct.Size = new System.Drawing.Size(146, 22);
            this.txtNameProduct.TabIndex = 100;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(47, 108);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(204, 22);
            this.label14.TabIndex = 99;
            this.label14.Text = "Nombre de Producto";
            // 
            // cbActiveProduct
            // 
            this.cbActiveProduct.FormattingEnabled = true;
            this.cbActiveProduct.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbActiveProduct.Location = new System.Drawing.Point(261, 579);
            this.cbActiveProduct.Name = "cbActiveProduct";
            this.cbActiveProduct.Size = new System.Drawing.Size(146, 21);
            this.cbActiveProduct.TabIndex = 101;
            this.cbActiveProduct.Text = "Seleccionar";
            this.cbActiveProduct.SelectedIndexChanged += new System.EventHandler(this.cbActiveProduct_SelectedIndexChanged);
            // 
            // productsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.cbActiveProduct);
            this.Controls.Add(this.txtNameProduct);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.dataGridProduct);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.dtpChangeDateProduct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbMeasureProduct);
            this.Controls.Add(this.cbDepartamentProduct);
            this.Controls.Add(this.dtpDateProduct);
            this.Controls.Add(this.txtExistenceProduct);
            this.Controls.Add(this.txtFilterProduct);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnDeleteProduct);
            this.Controls.Add(this.btnEditProduct);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.txtReOrdProduct);
            this.Controls.Add(this.txtPriceProduct);
            this.Controls.Add(this.txtCostProduct);
            this.Controls.Add(this.txtDesProduct);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIdProduct);
            this.Controls.Add(this.label1);
            this.Name = "productsScreen";
            this.Text = "Products";
            this.Load += new System.EventHandler(this.productsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtFilterProduct;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button btnDeleteProduct;
        private System.Windows.Forms.Button btnEditProduct;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.TextBox txtReOrdProduct;
        private System.Windows.Forms.TextBox txtPriceProduct;
        private System.Windows.Forms.TextBox txtCostProduct;
        private System.Windows.Forms.TextBox txtDesProduct;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtIdProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtExistenceProduct;
        private System.Windows.Forms.DateTimePicker dtpDateProduct;
        private System.Windows.Forms.ComboBox cbMeasureProduct;
        private System.Windows.Forms.DateTimePicker dtpChangeDateProduct;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.TextBox txtNameProduct;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.ComboBox cbActiveProduct;
        private System.Windows.Forms.ComboBox cbDepartamentProduct;
    }
}