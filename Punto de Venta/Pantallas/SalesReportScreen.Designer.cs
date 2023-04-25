
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
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hospedaje = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.servicios = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSalesReport)).BeginInit();
            this.SuspendLayout();
            // 
            // txtYearSalesR
            // 
            this.txtYearSalesR.Location = new System.Drawing.Point(342, 178);
            this.txtYearSalesR.Name = "txtYearSalesR";
            this.txtYearSalesR.Size = new System.Drawing.Size(123, 20);
            this.txtYearSalesR.TabIndex = 134;
            this.txtYearSalesR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearSalesR_KeyPress);
            // 
            // txtCitySalesR
            // 
            this.txtCitySalesR.Location = new System.Drawing.Point(511, 178);
            this.txtCitySalesR.Name = "txtCitySalesR";
            this.txtCitySalesR.Size = new System.Drawing.Size(123, 20);
            this.txtCitySalesR.TabIndex = 133;
            this.txtCitySalesR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCitySalesR_KeyPress);
            // 
            // txtHotelSalesR
            // 
            this.txtHotelSalesR.Location = new System.Drawing.Point(683, 178);
            this.txtHotelSalesR.Name = "txtHotelSalesR";
            this.txtHotelSalesR.Size = new System.Drawing.Size(123, 20);
            this.txtHotelSalesR.TabIndex = 132;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(381, 143);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 22);
            this.label5.TabIndex = 131;
            this.label5.Text = "Año";
            // 
            // txtCountrySalesR
            // 
            this.txtCountrySalesR.Location = new System.Drawing.Point(166, 178);
            this.txtCountrySalesR.Name = "txtCountrySalesR";
            this.txtCountrySalesR.Size = new System.Drawing.Size(123, 20);
            this.txtCountrySalesR.TabIndex = 130;
            this.txtCountrySalesR.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCountrySalesR_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(533, 143);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 129;
            this.label4.Text = "Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(210, 143);
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
            this.dataGridSalesReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.city,
            this.NameHotel,
            this.date,
            this.hospedaje,
            this.servicios,
            this.total});
            this.dataGridSalesReport.Location = new System.Drawing.Point(166, 238);
            this.dataGridSalesReport.Name = "dataGridSalesReport";
            this.dataGridSalesReport.ReadOnly = true;
            this.dataGridSalesReport.Size = new System.Drawing.Size(640, 361);
            this.dataGridSalesReport.TabIndex = 126;
            // 
            // city
            // 
            this.city.HeaderText = "Ciudad";
            this.city.Name = "city";
            this.city.ReadOnly = true;
            // 
            // NameHotel
            // 
            this.NameHotel.HeaderText = "Nombre del Hotel";
            this.NameHotel.Name = "NameHotel";
            this.NameHotel.ReadOnly = true;
            // 
            // date
            // 
            this.date.HeaderText = "Año-Mes";
            this.date.Name = "date";
            this.date.ReadOnly = true;
            // 
            // hospedaje
            // 
            this.hospedaje.HeaderText = "Ingresos Hospedaje";
            this.hospedaje.Name = "hospedaje";
            this.hospedaje.ReadOnly = true;
            // 
            // servicios
            // 
            this.servicios.HeaderText = "Ingresos Servicios";
            this.servicios.Name = "servicios";
            this.servicios.ReadOnly = true;
            // 
            // total
            // 
            this.total.HeaderText = "Ingresos Totales";
            this.total.Name = "total";
            this.total.ReadOnly = true;
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
            this.label1.Location = new System.Drawing.Point(712, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 124;
            this.label1.Text = "Hotel";
            // 
            // ReturnScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(950, 631);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn hospedaje;
        private System.Windows.Forms.DataGridViewTextBoxColumn servicios;
        private System.Windows.Forms.DataGridViewTextBoxColumn total;
    }
}