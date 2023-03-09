
namespace Punto_de_Venta
{
    partial class InventaryScreen
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.btnAddDepartament = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 44);
            this.label2.TabIndex = 96;
            this.label2.Text = "Check In";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(310, 156);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 22);
            this.textBox1.TabIndex = 136;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 22);
            this.label3.TabIndex = 135;
            this.label3.Text = "Ingresa el Código de reservación";
            // 
            // dataGridProduct
            // 
            this.dataGridProduct.AllowUserToAddRows = false;
            this.dataGridProduct.AllowUserToDeleteRows = false;
            this.dataGridProduct.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduct.Location = new System.Drawing.Point(244, 205);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.ReadOnly = true;
            this.dataGridProduct.RowHeadersWidth = 51;
            this.dataGridProduct.Size = new System.Drawing.Size(452, 313);
            this.dataGridProduct.TabIndex = 134;
            // 
            // btnAddDepartament
            // 
            this.btnAddDepartament.BackColor = System.Drawing.Color.Green;
            this.btnAddDepartament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDepartament.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepartament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddDepartament.Location = new System.Drawing.Point(399, 542);
            this.btnAddDepartament.Name = "btnAddDepartament";
            this.btnAddDepartament.Size = new System.Drawing.Size(139, 51);
            this.btnAddDepartament.TabIndex = 137;
            this.btnAddDepartament.Text = "Confirmar";
            this.btnAddDepartament.UseVisualStyleBackColor = false;
            // 
            // InventaryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.btnAddDepartament);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridProduct);
            this.Controls.Add(this.label2);
            this.Name = "InventaryScreen";
            this.Text = "Inventario";
            this.Load += new System.EventHandler(this.InventaryScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.Button btnAddDepartament;
    }
}