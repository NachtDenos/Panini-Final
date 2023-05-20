
namespace Punto_de_Venta
{
    partial class ReturnScreen
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
            this.txtYearSalesR = new System.Windows.Forms.TextBox();
            this.txtCitySalesR = new System.Windows.Forms.TextBox();
            this.txtHotelSalesR = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCountrySalesR = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridSalesReport = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCountryReportSales = new System.Windows.Forms.Button();
            this.btnYearReportSales = new System.Windows.Forms.Button();
            this.btnCityReportSales = new System.Windows.Forms.Button();
            this.btnHotelReportSales = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYearSalesR
            // 
            this.txtYearSalesR.Location = new System.Drawing.Point(342, 160);
            this.txtYearSalesR.Name = "txtYearSalesR";
            this.txtYearSalesR.Size = new System.Drawing.Size(123, 20);
            this.txtYearSalesR.TabIndex = 134;
            this.txtYearSalesR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearSalesR_KeyPress);
            // 
            // txtCitySalesR
            // 
            this.txtCitySalesR.Location = new System.Drawing.Point(511, 160);
            this.txtCitySalesR.Name = "txtCitySalesR";
            this.txtCitySalesR.Size = new System.Drawing.Size(123, 20);
            this.txtCitySalesR.TabIndex = 133;
            this.txtCitySalesR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCitySalesR_KeyPress);
            // 
            // txtHotelSalesR
            // 
            this.txtHotelSalesR.Location = new System.Drawing.Point(683, 160);
            this.txtHotelSalesR.Name = "txtHotelSalesR";
            this.txtHotelSalesR.Size = new System.Drawing.Size(123, 20);
            this.txtHotelSalesR.TabIndex = 132;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(381, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 22);
            this.label5.TabIndex = 131;
            this.label5.Text = "Año";
            // 
            // txtCountrySalesR
            // 
            this.txtCountrySalesR.Location = new System.Drawing.Point(166, 160);
            this.txtCountrySalesR.Name = "txtCountrySalesR";
            this.txtCountrySalesR.Size = new System.Drawing.Size(123, 20);
            this.txtCountrySalesR.TabIndex = 130;
            this.txtCountrySalesR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCountrySalesR_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(533, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 129;
            this.label4.Text = "Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 125);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 128;
            this.label3.Text = "País";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(78, 143);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 22);
            this.label12.TabIndex = 127;
            this.label12.Text = "Filtros:";
            // 
            // dataGridSalesReport
            // 
            this.dataGridSalesReport.AllowUserToAddRows = false;
            this.dataGridSalesReport.AllowUserToDeleteRows = false;
            this.dataGridSalesReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSalesReport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridSalesReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSalesReport.Location = new System.Drawing.Point(166, 238);
            this.dataGridSalesReport.Name = "dataGridSalesReport";
            this.dataGridSalesReport.ReadOnly = true;
            this.dataGridSalesReport.Size = new System.Drawing.Size(640, 361);
            this.dataGridSalesReport.TabIndex = 126;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(321, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(351, 44);
            this.label2.TabIndex = 125;
            this.label2.Text = "Reporte de Ventas";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(712, 125);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 124;
            this.label1.Text = "Hotel";
            // 
            // btnCountryReportSales
            // 
            this.btnCountryReportSales.BackColor = System.Drawing.Color.Navy;
            this.btnCountryReportSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCountryReportSales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountryReportSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCountryReportSales.Location = new System.Drawing.Point(166, 186);
            this.btnCountryReportSales.Name = "btnCountryReportSales";
            this.btnCountryReportSales.Size = new System.Drawing.Size(123, 31);
            this.btnCountryReportSales.TabIndex = 159;
            this.btnCountryReportSales.Text = "Buscar";
            this.btnCountryReportSales.UseVisualStyleBackColor = false;
            this.btnCountryReportSales.Click += new System.EventHandler(this.btnCountryReportSales_Click);
            // 
            // btnYearReportSales
            // 
            this.btnYearReportSales.BackColor = System.Drawing.Color.Navy;
            this.btnYearReportSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYearReportSales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearReportSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYearReportSales.Location = new System.Drawing.Point(342, 186);
            this.btnYearReportSales.Name = "btnYearReportSales";
            this.btnYearReportSales.Size = new System.Drawing.Size(123, 31);
            this.btnYearReportSales.TabIndex = 160;
            this.btnYearReportSales.Text = "Buscar";
            this.btnYearReportSales.UseVisualStyleBackColor = false;
            this.btnYearReportSales.Click += new System.EventHandler(this.btnYearReportSales_Click);
            // 
            // btnCityReportSales
            // 
            this.btnCityReportSales.BackColor = System.Drawing.Color.Navy;
            this.btnCityReportSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCityReportSales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCityReportSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCityReportSales.Location = new System.Drawing.Point(511, 186);
            this.btnCityReportSales.Name = "btnCityReportSales";
            this.btnCityReportSales.Size = new System.Drawing.Size(123, 31);
            this.btnCityReportSales.TabIndex = 161;
            this.btnCityReportSales.Text = "Buscar";
            this.btnCityReportSales.UseVisualStyleBackColor = false;
            this.btnCityReportSales.Click += new System.EventHandler(this.btnCityReportSales_Click);
            // 
            // btnHotelReportSales
            // 
            this.btnHotelReportSales.BackColor = System.Drawing.Color.Navy;
            this.btnHotelReportSales.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotelReportSales.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotelReportSales.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHotelReportSales.Location = new System.Drawing.Point(683, 186);
            this.btnHotelReportSales.Name = "btnHotelReportSales";
            this.btnHotelReportSales.Size = new System.Drawing.Size(123, 31);
            this.btnHotelReportSales.TabIndex = 162;
            this.btnHotelReportSales.Text = "Buscar";
            this.btnHotelReportSales.UseVisualStyleBackColor = false;
            this.btnHotelReportSales.Click += new System.EventHandler(this.btnHotelReportSales_Click);
            // 
            // ReturnScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(950, 631);
            this.Controls.Add(this.btnHotelReportSales);
            this.Controls.Add(this.btnCityReportSales);
            this.Controls.Add(this.btnYearReportSales);
            this.Controls.Add(this.btnCountryReportSales);
            this.Controls.Add(this.txtYearSalesR);
            this.Controls.Add(this.txtCitySalesR);
            this.Controls.Add(this.txtHotelSalesR);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCountrySalesR);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridSalesReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReturnScreen";
            this.Text = "ReturnScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalesReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtYearSalesR;
        private System.Windows.Forms.TextBox txtCitySalesR;
        private System.Windows.Forms.TextBox txtHotelSalesR;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCountrySalesR;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridSalesReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCountryReportSales;
        private System.Windows.Forms.Button btnYearReportSales;
        private System.Windows.Forms.Button btnCityReportSales;
        private System.Windows.Forms.Button btnHotelReportSales;
    }
}