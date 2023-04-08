
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
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Ciudad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Tipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Personas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Código = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.checkIn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CheckOut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Estatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Anticipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Hospedaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Servicios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCustomerHistory = new System.Windows.Forms.TextBox();
            this.txtYearHistory = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHistoryReport)).BeginInit();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(336, 136);
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
            this.dataGridHistoryReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Nombre,
            this.Ciudad,
            this.Hotel,
            this.Tipo,
            this.numero,
            this.Personas,
            this.Código,
            this.fecha,
            this.checkIn,
            this.CheckOut,
            this.Estatus,
            this.Anticipo,
            this.Hospedaje,
            this.Servicios,
            this.Total});
            this.dataGridHistoryReport.Location = new System.Drawing.Point(94, 228);
            this.dataGridHistoryReport.Name = "dataGridHistoryReport";
            this.dataGridHistoryReport.ReadOnly = true;
            this.dataGridHistoryReport.Size = new System.Drawing.Size(758, 316);
            this.dataGridHistoryReport.TabIndex = 85;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.ReadOnly = true;
            // 
            // Ciudad
            // 
            this.Ciudad.HeaderText = "Ciudad";
            this.Ciudad.Name = "Ciudad";
            this.Ciudad.ReadOnly = true;
            // 
            // Hotel
            // 
            this.Hotel.HeaderText = "Hotel";
            this.Hotel.Name = "Hotel";
            this.Hotel.ReadOnly = true;
            // 
            // Tipo
            // 
            this.Tipo.HeaderText = "Tipo Habitación";
            this.Tipo.Name = "Tipo";
            this.Tipo.ReadOnly = true;
            // 
            // numero
            // 
            this.numero.HeaderText = "Número Habitación";
            this.numero.Name = "numero";
            this.numero.ReadOnly = true;
            // 
            // Personas
            // 
            this.Personas.HeaderText = "Personas Hospedadas";
            this.Personas.Name = "Personas";
            this.Personas.ReadOnly = true;
            // 
            // Código
            // 
            this.Código.HeaderText = "Código R.";
            this.Código.Name = "Código";
            this.Código.ReadOnly = true;
            // 
            // fecha
            // 
            this.fecha.HeaderText = "Fecha R.";
            this.fecha.Name = "fecha";
            this.fecha.ReadOnly = true;
            // 
            // checkIn
            // 
            this.checkIn.HeaderText = "CheckIn";
            this.checkIn.Name = "checkIn";
            this.checkIn.ReadOnly = true;
            // 
            // CheckOut
            // 
            this.CheckOut.HeaderText = "CheckOut";
            this.CheckOut.Name = "CheckOut";
            this.CheckOut.ReadOnly = true;
            // 
            // Estatus
            // 
            this.Estatus.HeaderText = "Estatus R.";
            this.Estatus.Name = "Estatus";
            this.Estatus.ReadOnly = true;
            // 
            // Anticipo
            // 
            this.Anticipo.HeaderText = "Anticipo";
            this.Anticipo.Name = "Anticipo";
            this.Anticipo.ReadOnly = true;
            // 
            // Hospedaje
            // 
            this.Hospedaje.HeaderText = "Monto Hospedaje";
            this.Hospedaje.Name = "Hospedaje";
            this.Hospedaje.ReadOnly = true;
            // 
            // Servicios
            // 
            this.Servicios.HeaderText = "Monto Servicios";
            this.Servicios.Name = "Servicios";
            this.Servicios.ReadOnly = true;
            // 
            // Total
            // 
            this.Total.HeaderText = "Total Factura";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
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
            this.label4.Location = new System.Drawing.Point(569, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(49, 22);
            this.label4.TabIndex = 90;
            this.label4.Text = "Año";
            // 
            // txtCustomerHistory
            // 
            this.txtCustomerHistory.Location = new System.Drawing.Point(312, 174);
            this.txtCustomerHistory.Name = "txtCustomerHistory";
            this.txtCustomerHistory.Size = new System.Drawing.Size(123, 20);
            this.txtCustomerHistory.TabIndex = 106;
            this.txtCustomerHistory.TextChanged += new System.EventHandler(this.txtVentaCajaReport_TextChanged);
            this.txtCustomerHistory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVentaCajaReport_KeyPress);
            // 
            // txtYearHistory
            // 
            this.txtYearHistory.Location = new System.Drawing.Point(520, 174);
            this.txtYearHistory.Name = "txtYearHistory";
            this.txtYearHistory.Size = new System.Drawing.Size(134, 20);
            this.txtYearHistory.TabIndex = 107;
            this.txtYearHistory.TextChanged += new System.EventHandler(this.txtVentaDepaReport_TextChanged);
            // 
            // SalesReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.txtYearHistory);
            this.Controls.Add(this.txtCustomerHistory);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridHistoryReport);
            this.Controls.Add(this.label2);
            this.Name = "SalesReportScreen";
            this.Text = "Reporte de Ventas";
            this.Load += new System.EventHandler(this.SalesReportScreen_Load);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn Ciudad;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn Tipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Personas;
        private System.Windows.Forms.DataGridViewTextBoxColumn Código;
        private System.Windows.Forms.DataGridViewTextBoxColumn fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkIn;
        private System.Windows.Forms.DataGridViewTextBoxColumn CheckOut;
        private System.Windows.Forms.DataGridViewTextBoxColumn Estatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn Anticipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Hospedaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn Servicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
    }
}