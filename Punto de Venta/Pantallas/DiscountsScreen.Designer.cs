
namespace Punto_de_Venta
{
    partial class DiscountsScreen
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
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridDiscounts = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.dtpInDiscounts = new System.Windows.Forms.DateTimePicker();
            this.dtpOutDiscounts = new System.Windows.Forms.DateTimePicker();
            this.btnEditDiscounts = new System.Windows.Forms.Button();
            this.txtDiscountDiscount = new System.Windows.Forms.TextBox();
            this.addDiscountBtton = new System.Windows.Forms.Button();
            this.DeleteDiscountBtton = new System.Windows.Forms.Button();
            this.cbProductDiscount = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiscounts)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(354, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(229, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "Descuentos";
            // 
            // dataGridDiscounts
            // 
            this.dataGridDiscounts.AllowUserToAddRows = false;
            this.dataGridDiscounts.AllowUserToDeleteRows = false;
            this.dataGridDiscounts.AllowUserToResizeColumns = false;
            this.dataGridDiscounts.AllowUserToResizeRows = false;
            this.dataGridDiscounts.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridDiscounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDiscounts.Location = new System.Drawing.Point(270, 113);
            this.dataGridDiscounts.Name = "dataGridDiscounts";
            this.dataGridDiscounts.ReadOnly = true;
            this.dataGridDiscounts.RowHeadersWidth = 51;
            this.dataGridDiscounts.Size = new System.Drawing.Size(643, 474);
            this.dataGridDiscounts.TabIndex = 6;
            this.dataGridDiscounts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDiscounts_CellClick);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 113);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Descuento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(35, 177);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Fechas del Descuento:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(35, 210);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 22);
            this.label3.TabIndex = 38;
            this.label3.Text = "Inicia";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(35, 259);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 22);
            this.label4.TabIndex = 39;
            this.label4.Text = "Finaliza";
            // 
            // dtpInDiscounts
            // 
            this.dtpInDiscounts.Location = new System.Drawing.Point(39, 238);
            this.dtpInDiscounts.Name = "dtpInDiscounts";
            this.dtpInDiscounts.Size = new System.Drawing.Size(200, 20);
            this.dtpInDiscounts.TabIndex = 40;
            // 
            // dtpOutDiscounts
            // 
            this.dtpOutDiscounts.Location = new System.Drawing.Point(39, 287);
            this.dtpOutDiscounts.Name = "dtpOutDiscounts";
            this.dtpOutDiscounts.Size = new System.Drawing.Size(200, 20);
            this.dtpOutDiscounts.TabIndex = 41;
            // 
            // btnEditDiscounts
            // 
            this.btnEditDiscounts.BackColor = System.Drawing.Color.Navy;
            this.btnEditDiscounts.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDiscounts.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDiscounts.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditDiscounts.Location = new System.Drawing.Point(88, 478);
            this.btnEditDiscounts.Name = "btnEditDiscounts";
            this.btnEditDiscounts.Size = new System.Drawing.Size(139, 51);
            this.btnEditDiscounts.TabIndex = 53;
            this.btnEditDiscounts.Text = "Editar";
            this.btnEditDiscounts.UseVisualStyleBackColor = false;
            this.btnEditDiscounts.Click += new System.EventHandler(this.btnEditDiscounts_Click);
            // 
            // txtDiscountDiscount
            // 
            this.txtDiscountDiscount.Location = new System.Drawing.Point(39, 153);
            this.txtDiscountDiscount.Multiline = true;
            this.txtDiscountDiscount.Name = "txtDiscountDiscount";
            this.txtDiscountDiscount.Size = new System.Drawing.Size(200, 22);
            this.txtDiscountDiscount.TabIndex = 54;
            this.txtDiscountDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscountDiscount_KeyPress);
            // 
            // addDiscountBtton
            // 
            this.addDiscountBtton.BackColor = System.Drawing.Color.Green;
            this.addDiscountBtton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDiscountBtton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDiscountBtton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addDiscountBtton.Location = new System.Drawing.Point(88, 420);
            this.addDiscountBtton.Name = "addDiscountBtton";
            this.addDiscountBtton.Size = new System.Drawing.Size(139, 51);
            this.addDiscountBtton.TabIndex = 55;
            this.addDiscountBtton.Text = "Agregar";
            this.addDiscountBtton.UseVisualStyleBackColor = false;
            this.addDiscountBtton.Click += new System.EventHandler(this.addDiscountBtton_Click);
            // 
            // DeleteDiscountBtton
            // 
            this.DeleteDiscountBtton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.DeleteDiscountBtton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.DeleteDiscountBtton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DeleteDiscountBtton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteDiscountBtton.Location = new System.Drawing.Point(88, 535);
            this.DeleteDiscountBtton.Name = "DeleteDiscountBtton";
            this.DeleteDiscountBtton.Size = new System.Drawing.Size(139, 51);
            this.DeleteDiscountBtton.TabIndex = 56;
            this.DeleteDiscountBtton.Text = "Eliminar";
            this.DeleteDiscountBtton.UseVisualStyleBackColor = false;
            this.DeleteDiscountBtton.Click += new System.EventHandler(this.DeleteDiscountBtton_Click);
            // 
            // cbProductDiscount
            // 
            this.cbProductDiscount.FormattingEnabled = true;
            this.cbProductDiscount.Location = new System.Drawing.Point(39, 335);
            this.cbProductDiscount.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cbProductDiscount.Name = "cbProductDiscount";
            this.cbProductDiscount.Size = new System.Drawing.Size(200, 21);
            this.cbProductDiscount.TabIndex = 57;
            this.cbProductDiscount.Text = "Seleccione";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(35, 308);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(95, 22);
            this.label5.TabIndex = 58;
            this.label5.Text = "Producto";
            // 
            // DiscountsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cbProductDiscount);
            this.Controls.Add(this.DeleteDiscountBtton);
            this.Controls.Add(this.addDiscountBtton);
            this.Controls.Add(this.txtDiscountDiscount);
            this.Controls.Add(this.btnEditDiscounts);
            this.Controls.Add(this.dtpOutDiscounts);
            this.Controls.Add(this.dtpInDiscounts);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.dataGridDiscounts);
            this.Controls.Add(this.label2);
            this.Name = "DiscountsScreen";
            this.Text = "Descuentos";
            this.Load += new System.EventHandler(this.DiscountsScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDiscounts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridDiscounts;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker dtpInDiscounts;
        private System.Windows.Forms.DateTimePicker dtpOutDiscounts;
        private System.Windows.Forms.Button btnEditDiscounts;
        private System.Windows.Forms.TextBox txtDiscountDiscount;
        private System.Windows.Forms.Button addDiscountBtton;
        private System.Windows.Forms.Button DeleteDiscountBtton;
        private System.Windows.Forms.ComboBox cbProductDiscount;
        private System.Windows.Forms.Label label5;
    }
}