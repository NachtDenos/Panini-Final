
namespace Punto_de_Venta
{
    partial class CashRegisterScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashRegisterScreen));
            this.txtCountryOccupancy = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridOccupancyReport = new System.Windows.Forms.DataGridView();
            this.city = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NameHotel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.typeRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.numRoom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocupation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clientes = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHotelOccupancy = new System.Windows.Forms.TextBox();
            this.txtCityOccupancy = new System.Windows.Forms.TextBox();
            this.txtYearOccupancy = new System.Windows.Forms.TextBox();
            this.dataGridOccupancyReport2 = new System.Windows.Forms.DataGridView();
            this.city2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nameHotel2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ocupacion2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOccupancyReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOccupancyReport2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCountryOccupancy
            // 
            this.txtCountryOccupancy.Location = new System.Drawing.Point(147, 183);
            this.txtCountryOccupancy.Name = "txtCountryOccupancy";
            this.txtCountryOccupancy.Size = new System.Drawing.Size(123, 20);
            this.txtCountryOccupancy.TabIndex = 116;
            this.txtCountryOccupancy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCountryOccupancy_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 148);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 113;
            this.label4.Text = "Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 148);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(44, 22);
            this.label3.TabIndex = 112;
            this.label3.Text = "País";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(59, 148);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 22);
            this.label12.TabIndex = 111;
            this.label12.Text = "Filtros:";
            // 
            // dataGridOccupancyReport
            // 
            this.dataGridOccupancyReport.AllowUserToAddRows = false;
            this.dataGridOccupancyReport.AllowUserToDeleteRows = false;
            this.dataGridOccupancyReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOccupancyReport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridOccupancyReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOccupancyReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.city,
            this.NameHotel,
            this.date,
            this.typeRoom,
            this.numRoom,
            this.ocupation,
            this.clientes});
            this.dataGridOccupancyReport.Location = new System.Drawing.Point(147, 219);
            this.dataGridOccupancyReport.Name = "dataGridOccupancyReport";
            this.dataGridOccupancyReport.ReadOnly = true;
            this.dataGridOccupancyReport.Size = new System.Drawing.Size(640, 265);
            this.dataGridOccupancyReport.TabIndex = 110;
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
            // typeRoom
            // 
            this.typeRoom.HeaderText = "Tipo de Habitación";
            this.typeRoom.Name = "typeRoom";
            this.typeRoom.ReadOnly = true;
            // 
            // numRoom
            // 
            this.numRoom.HeaderText = "Cantidad de Habitaciones";
            this.numRoom.Name = "numRoom";
            this.numRoom.ReadOnly = true;
            // 
            // ocupation
            // 
            this.ocupation.HeaderText = "Ocupación";
            this.ocupation.Name = "ocupation";
            this.ocupation.ReadOnly = true;
            // 
            // clientes
            // 
            this.clientes.HeaderText = "Personas Hospedadas";
            this.clientes.Name = "clientes";
            this.clientes.ReadOnly = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(170, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(602, 44);
            this.label2.TabIndex = 109;
            this.label2.Text = "Reporte de Ocupación por hotel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(693, 148);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 108;
            this.label1.Text = "Hotel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 148);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 22);
            this.label5.TabIndex = 119;
            this.label5.Text = "Año";
            // 
            // txtHotelOccupancy
            // 
            this.txtHotelOccupancy.Location = new System.Drawing.Point(664, 183);
            this.txtHotelOccupancy.Name = "txtHotelOccupancy";
            this.txtHotelOccupancy.Size = new System.Drawing.Size(123, 20);
            this.txtHotelOccupancy.TabIndex = 120;
            // 
            // txtCityOccupancy
            // 
            this.txtCityOccupancy.Location = new System.Drawing.Point(492, 183);
            this.txtCityOccupancy.Name = "txtCityOccupancy";
            this.txtCityOccupancy.Size = new System.Drawing.Size(123, 20);
            this.txtCityOccupancy.TabIndex = 121;
            this.txtCityOccupancy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCityOccupancy_KeyPress);
            // 
            // txtYearOccupancy
            // 
            this.txtYearOccupancy.Location = new System.Drawing.Point(323, 183);
            this.txtYearOccupancy.Name = "txtYearOccupancy";
            this.txtYearOccupancy.Size = new System.Drawing.Size(123, 20);
            this.txtYearOccupancy.TabIndex = 122;
            this.txtYearOccupancy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearOccupancy_KeyPress);
            // 
            // dataGridOccupancyReport2
            // 
            this.dataGridOccupancyReport2.AllowUserToAddRows = false;
            this.dataGridOccupancyReport2.AllowUserToDeleteRows = false;
            this.dataGridOccupancyReport2.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridOccupancyReport2.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridOccupancyReport2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridOccupancyReport2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.city2,
            this.nameHotel2,
            this.date2,
            this.ocupacion2});
            this.dataGridOccupancyReport2.Location = new System.Drawing.Point(147, 503);
            this.dataGridOccupancyReport2.Name = "dataGridOccupancyReport2";
            this.dataGridOccupancyReport2.ReadOnly = true;
            this.dataGridOccupancyReport2.Size = new System.Drawing.Size(640, 116);
            this.dataGridOccupancyReport2.TabIndex = 123;
            // 
            // city2
            // 
            this.city2.HeaderText = "Ciudad";
            this.city2.Name = "city2";
            this.city2.ReadOnly = true;
            // 
            // nameHotel2
            // 
            this.nameHotel2.HeaderText = "Nombre del Hotel";
            this.nameHotel2.Name = "nameHotel2";
            this.nameHotel2.ReadOnly = true;
            // 
            // date2
            // 
            this.date2.HeaderText = "Año-Mes";
            this.date2.Name = "date2";
            this.date2.ReadOnly = true;
            // 
            // ocupacion2
            // 
            this.ocupacion2.HeaderText = "Porcentaje de Ocupación";
            this.ocupacion2.Name = "ocupacion2";
            this.ocupacion2.ReadOnly = true;
            // 
            // CashRegisterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.dataGridOccupancyReport2);
            this.Controls.Add(this.txtYearOccupancy);
            this.Controls.Add(this.txtCityOccupancy);
            this.Controls.Add(this.txtHotelOccupancy);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCountryOccupancy);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridOccupancyReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CashRegisterScreen";
            this.Text = "CashRegisterScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOccupancyReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOccupancyReport2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCountryOccupancy;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridOccupancyReport;
        private System.Windows.Forms.DataGridViewTextBoxColumn city;
        private System.Windows.Forms.DataGridViewTextBoxColumn NameHotel;
        private System.Windows.Forms.DataGridViewTextBoxColumn date;
        private System.Windows.Forms.DataGridViewTextBoxColumn typeRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn numRoom;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocupation;
        private System.Windows.Forms.DataGridViewTextBoxColumn clientes;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHotelOccupancy;
        private System.Windows.Forms.TextBox txtCityOccupancy;
        private System.Windows.Forms.TextBox txtYearOccupancy;
        private System.Windows.Forms.DataGridView dataGridOccupancyReport2;
        private System.Windows.Forms.DataGridViewTextBoxColumn city2;
        private System.Windows.Forms.DataGridViewTextBoxColumn nameHotel2;
        private System.Windows.Forms.DataGridViewTextBoxColumn date2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ocupacion2;
    }
}