
namespace Punto_de_Venta
{
    partial class TicketReportScreen
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
            this.dataGridTicketReport = new System.Windows.Forms.DataGridView();
            this.txtIdProduct = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnAddProduct = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTicketReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(310, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(289, 44);
            this.label2.TabIndex = 85;
            this.label2.Text = "Activar Usuario";
            // 
            // dataGridTicketReport
            // 
            this.dataGridTicketReport.AllowUserToAddRows = false;
            this.dataGridTicketReport.AllowUserToDeleteRows = false;
            this.dataGridTicketReport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridTicketReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridTicketReport.Location = new System.Drawing.Point(40, 234);
            this.dataGridTicketReport.Name = "dataGridTicketReport";
            this.dataGridTicketReport.ReadOnly = true;
            this.dataGridTicketReport.RowHeadersWidth = 51;
            this.dataGridTicketReport.Size = new System.Drawing.Size(845, 299);
            this.dataGridTicketReport.TabIndex = 99;
            // 
            // txtIdProduct
            // 
            this.txtIdProduct.Location = new System.Drawing.Point(339, 115);
            this.txtIdProduct.Multiline = true;
            this.txtIdProduct.Name = "txtIdProduct";
            this.txtIdProduct.Size = new System.Drawing.Size(546, 22);
            this.txtIdProduct.TabIndex = 101;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(36, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(297, 22);
            this.label1.TabIndex = 100;
            this.label1.Text = "Ingrese la contraseña temporal";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(308, 198);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(291, 22);
            this.label3.TabIndex = 102;
            this.label3.Text = "Seleccione el usuario a Activar";
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.BackColor = System.Drawing.Color.Green;
            this.btnAddProduct.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddProduct.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddProduct.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddProduct.Location = new System.Drawing.Point(746, 556);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(139, 51);
            this.btnAddProduct.TabIndex = 103;
            this.btnAddProduct.Text = "Activar";
            this.btnAddProduct.UseVisualStyleBackColor = false;
            // 
            // TicketReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdProduct);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridTicketReport);
            this.Controls.Add(this.label2);
            this.Name = "TicketReportScreen";
            this.Text = "Consulta de Recibos";
            this.Load += new System.EventHandler(this.TicketReportScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridTicketReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridTicketReport;
        private System.Windows.Forms.TextBox txtIdProduct;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnAddProduct;
    }
}