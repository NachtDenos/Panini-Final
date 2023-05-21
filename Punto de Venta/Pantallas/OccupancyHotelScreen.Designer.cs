
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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtHotelOccupancy = new System.Windows.Forms.TextBox();
            this.txtCityOccupancy = new System.Windows.Forms.TextBox();
            this.txtYearOccupancy = new System.Windows.Forms.TextBox();
            this.dataGridOccupancyReport2 = new System.Windows.Forms.DataGridView();
            this.btnCountryOcup = new System.Windows.Forms.Button();
            this.btnYearOcup = new System.Windows.Forms.Button();
            this.btnCityOcup = new System.Windows.Forms.Button();
            this.btnHotelOcup = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOccupancyReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridOccupancyReport2)).BeginInit();
            this.SuspendLayout();
            // 
            // txtCountryOccupancy
            // 
            this.txtCountryOccupancy.Location = new System.Drawing.Point(147, 152);
            this.txtCountryOccupancy.Name = "txtCountryOccupancy";
            this.txtCountryOccupancy.Size = new System.Drawing.Size(123, 20);
            this.txtCountryOccupancy.TabIndex = 116;
            this.txtCountryOccupancy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCountryOccupancy_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(514, 117);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 22);
            this.label4.TabIndex = 113;
            this.label4.Text = "Ciudad";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(191, 117);
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
            this.dataGridOccupancyReport.Location = new System.Drawing.Point(147, 219);
            this.dataGridOccupancyReport.Name = "dataGridOccupancyReport";
            this.dataGridOccupancyReport.ReadOnly = true;
            this.dataGridOccupancyReport.Size = new System.Drawing.Size(640, 265);
            this.dataGridOccupancyReport.TabIndex = 110;
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
            this.label1.Location = new System.Drawing.Point(693, 117);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(57, 22);
            this.label1.TabIndex = 108;
            this.label1.Text = "Hotel";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(362, 117);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 22);
            this.label5.TabIndex = 119;
            this.label5.Text = "Año";
            // 
            // txtHotelOccupancy
            // 
            this.txtHotelOccupancy.Location = new System.Drawing.Point(664, 152);
            this.txtHotelOccupancy.Name = "txtHotelOccupancy";
            this.txtHotelOccupancy.Size = new System.Drawing.Size(123, 20);
            this.txtHotelOccupancy.TabIndex = 120;
            // 
            // txtCityOccupancy
            // 
            this.txtCityOccupancy.Location = new System.Drawing.Point(492, 152);
            this.txtCityOccupancy.Name = "txtCityOccupancy";
            this.txtCityOccupancy.Size = new System.Drawing.Size(123, 20);
            this.txtCityOccupancy.TabIndex = 121;
            this.txtCityOccupancy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCityOccupancy_KeyPress);
            // 
            // txtYearOccupancy
            // 
            this.txtYearOccupancy.Location = new System.Drawing.Point(323, 152);
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
            this.dataGridOccupancyReport2.Location = new System.Drawing.Point(147, 503);
            this.dataGridOccupancyReport2.Name = "dataGridOccupancyReport2";
            this.dataGridOccupancyReport2.ReadOnly = true;
            this.dataGridOccupancyReport2.Size = new System.Drawing.Size(640, 116);
            this.dataGridOccupancyReport2.TabIndex = 123;
            // 
            // btnCountryOcup
            // 
            this.btnCountryOcup.BackColor = System.Drawing.Color.Navy;
            this.btnCountryOcup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCountryOcup.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCountryOcup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCountryOcup.Location = new System.Drawing.Point(147, 178);
            this.btnCountryOcup.Name = "btnCountryOcup";
            this.btnCountryOcup.Size = new System.Drawing.Size(123, 31);
            this.btnCountryOcup.TabIndex = 162;
            this.btnCountryOcup.Text = "Buscar";
            this.btnCountryOcup.UseVisualStyleBackColor = false;
            this.btnCountryOcup.Click += new System.EventHandler(this.btnCountryOcup_Click);
            // 
            // btnYearOcup
            // 
            this.btnYearOcup.BackColor = System.Drawing.Color.Navy;
            this.btnYearOcup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnYearOcup.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnYearOcup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnYearOcup.Location = new System.Drawing.Point(323, 178);
            this.btnYearOcup.Name = "btnYearOcup";
            this.btnYearOcup.Size = new System.Drawing.Size(123, 31);
            this.btnYearOcup.TabIndex = 163;
            this.btnYearOcup.Text = "Buscar";
            this.btnYearOcup.UseVisualStyleBackColor = false;
            this.btnYearOcup.Click += new System.EventHandler(this.btnYearOcup_Click);
            // 
            // btnCityOcup
            // 
            this.btnCityOcup.BackColor = System.Drawing.Color.Navy;
            this.btnCityOcup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCityOcup.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCityOcup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnCityOcup.Location = new System.Drawing.Point(492, 178);
            this.btnCityOcup.Name = "btnCityOcup";
            this.btnCityOcup.Size = new System.Drawing.Size(123, 31);
            this.btnCityOcup.TabIndex = 164;
            this.btnCityOcup.Text = "Buscar";
            this.btnCityOcup.UseVisualStyleBackColor = false;
            this.btnCityOcup.Click += new System.EventHandler(this.btnCityOcup_Click);
            // 
            // btnHotelOcup
            // 
            this.btnHotelOcup.BackColor = System.Drawing.Color.Navy;
            this.btnHotelOcup.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnHotelOcup.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHotelOcup.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnHotelOcup.Location = new System.Drawing.Point(664, 178);
            this.btnHotelOcup.Name = "btnHotelOcup";
            this.btnHotelOcup.Size = new System.Drawing.Size(123, 31);
            this.btnHotelOcup.TabIndex = 165;
            this.btnHotelOcup.Text = "Buscar";
            this.btnHotelOcup.UseVisualStyleBackColor = false;
            this.btnHotelOcup.Click += new System.EventHandler(this.btnHotelOcup_Click);
            // 
            // CashRegisterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.btnHotelOcup);
            this.Controls.Add(this.btnCityOcup);
            this.Controls.Add(this.btnYearOcup);
            this.Controls.Add(this.btnCountryOcup);
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
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtHotelOccupancy;
        private System.Windows.Forms.TextBox txtCityOccupancy;
        private System.Windows.Forms.TextBox txtYearOccupancy;
        private System.Windows.Forms.DataGridView dataGridOccupancyReport2;
        private System.Windows.Forms.Button btnCountryOcup;
        private System.Windows.Forms.Button btnYearOcup;
        private System.Windows.Forms.Button btnCityOcup;
        private System.Windows.Forms.Button btnHotelOcup;
    }
}