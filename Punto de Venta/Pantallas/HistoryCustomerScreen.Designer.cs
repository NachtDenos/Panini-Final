
namespace Punto_de_Venta
{
    partial class SalesReportScreen
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
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridHistoryReport = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerHistory = new System.Windows.Forms.TextBox();
            this.txtYearHistory = new System.Windows.Forms.TextBox();
            this.btnCustomerHistory = new System.Windows.Forms.Button();
            this.btnYearHistory = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistoryReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 22);
            this.label3.TabIndex = 88;
            this.label3.Text = "Cliente";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(194, 136);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 22);
            this.label12.TabIndex = 86;
            this.label12.Text = "Filtros:";
            // 
            // dataGridHistoryReport
            // 
            this.dataGridHistoryReport.AllowUserToAddRows = false;
            this.dataGridHistoryReport.AllowUserToDeleteRows = false;
            this.dataGridHistoryReport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridHistoryReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHistoryReport.Location = new System.Drawing.Point(94, 228);
            this.dataGridHistoryReport.Name = "dataGridHistoryReport";
            this.dataGridHistoryReport.ReadOnly = true;
            this.dataGridHistoryReport.Size = new System.Drawing.Size(758, 316);
            this.dataGridHistoryReport.TabIndex = 85;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(304, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(374, 44);
            this.label2.TabIndex = 84;
            this.label2.Text = "Historial del Cliente ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(554, 113);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 90;
            this.label4.Text = "Año";
            // 
            // txtCustomerHistory
            // 
            this.txtCustomerHistory.Location = new System.Drawing.Point(309, 151);
            this.txtCustomerHistory.Name = "txtCustomerHistory";
            this.txtCustomerHistory.Size = new System.Drawing.Size(123, 20);
            this.txtCustomerHistory.TabIndex = 106;
            this.txtCustomerHistory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerHistory_KeyPress);
            // 
            // txtYearHistory
            // 
            this.txtYearHistory.Location = new System.Drawing.Point(517, 151);
            this.txtYearHistory.Name = "txtYearHistory";
            this.txtYearHistory.Size = new System.Drawing.Size(123, 20);
            this.txtYearHistory.TabIndex = 107;
            this.txtYearHistory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearHistory_KeyPress);
            // 
            // btnCustomerHistory
            // 
            this.btnCustomerHistory.BackColor = System.Drawing.Color.Navy;
            this.btnCustomerHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomerHistory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomerHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCustomerHistory.Location = new System.Drawing.Point(309, 177);
            this.btnCustomerHistory.Name = "btnCustomerHistory";
            this.btnCustomerHistory.Size = new System.Drawing.Size(123, 31);
            this.btnCustomerHistory.TabIndex = 161;
            this.btnCustomerHistory.Text = "Buscar";
            this.btnCustomerHistory.UseVisualStyleBackColor = false;
            // 
            // btnYearHistory
            // 
            this.btnYearHistory.BackColor = System.Drawing.Color.Navy;
            this.btnYearHistory.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYearHistory.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearHistory.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYearHistory.Location = new System.Drawing.Point(517, 177);
            this.btnYearHistory.Name = "btnYearHistory";
            this.btnYearHistory.Size = new System.Drawing.Size(123, 31);
            this.btnYearHistory.TabIndex = 162;
            this.btnYearHistory.Text = "Buscar";
            this.btnYearHistory.UseVisualStyleBackColor = false;
            // 
            // SalesReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.btnYearHistory);
            this.Controls.Add(this.btnCustomerHistory);
            this.Controls.Add(this.txtYearHistory);
            this.Controls.Add(this.txtCustomerHistory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridHistoryReport);
            this.Controls.Add(this.label2);
            this.Name = "SalesReportScreen";
            this.Text = "Reporte de Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistoryReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridHistoryReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCustomerHistory;
        private System.Windows.Forms.TextBox txtYearHistory;
        private System.Windows.Forms.Button btnCustomerHistory;
        private System.Windows.Forms.Button btnYearHistory;
    }
}