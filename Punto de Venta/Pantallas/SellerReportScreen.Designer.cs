
namespace Punto_de_Venta
{
    partial class SellerReportScreen
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
            this.dtpSellerReport2 = new System.Windows.Forms.DateTimePicker();
            this.dtpSellerReport1 = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridSellerReport = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCasherReport = new System.Windows.Forms.TextBox();
            this.txtDepaCasherReport = new System.Windows.Forms.TextBox();
            this.btnFiltroFechaCajeros = new System.Windows.Forms.Button();
            this.lblUtilidadCajero = new System.Windows.Forms.Label();
            this.lblVentaCajero = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSellerReport)).BeginInit();
            this.SuspendLayout();
            // 
            // dtpSellerReport2
            // 
            this.dtpSellerReport2.Location = new System.Drawing.Point(782, 162);
            this.dtpSellerReport2.Name = "dtpSellerReport2";
            this.dtpSellerReport2.Size = new System.Drawing.Size(110, 20);
            this.dtpSellerReport2.TabIndex = 104;
            // 
            // dtpSellerReport1
            // 
            this.dtpSellerReport1.Location = new System.Drawing.Point(621, 162);
            this.dtpSellerReport1.Name = "dtpSellerReport1";
            this.dtpSellerReport1.Size = new System.Drawing.Size(110, 20);
            this.dtpSellerReport1.TabIndex = 103;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(361, 130);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(148, 22);
            this.label4.TabIndex = 100;
            this.label4.Text = "Departamento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(86, 130);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 22);
            this.label3.TabIndex = 99;
            this.label3.Text = "Cajero";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(38, 96);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(62, 22);
            this.label12.TabIndex = 98;
            this.label12.Text = "Filtros:";
            // 
            // dataGridSellerReport
            // 
            this.dataGridSellerReport.AllowUserToAddRows = false;
            this.dataGridSellerReport.AllowUserToDeleteRows = false;
            this.dataGridSellerReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridSellerReport.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridSellerReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridSellerReport.Location = new System.Drawing.Point(147, 233);
            this.dataGridSellerReport.Name = "dataGridSellerReport";
            this.dataGridSellerReport.ReadOnly = true;
            this.dataGridSellerReport.Size = new System.Drawing.Size(640, 319);
            this.dataGridSellerReport.TabIndex = 97;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(295, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(367, 44);
            this.label2.TabIndex = 96;
            this.label2.Text = "Reporte de Cajeros";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(661, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 22);
            this.label1.TabIndex = 95;
            this.label1.Text = "Rango de fechas";
            // 
            // txtCasherReport
            // 
            this.txtCasherReport.Location = new System.Drawing.Point(76, 165);
            this.txtCasherReport.Name = "txtCasherReport";
            this.txtCasherReport.Size = new System.Drawing.Size(123, 20);
            this.txtCasherReport.TabIndex = 105;
            this.txtCasherReport.TextChanged += new System.EventHandler(this.txtCasherReport_TextChanged);
            // 
            // txtDepaCasherReport
            // 
            this.txtDepaCasherReport.Location = new System.Drawing.Point(361, 165);
            this.txtDepaCasherReport.Name = "txtDepaCasherReport";
            this.txtDepaCasherReport.Size = new System.Drawing.Size(148, 20);
            this.txtDepaCasherReport.TabIndex = 106;
            this.txtDepaCasherReport.TextChanged += new System.EventHandler(this.txtDepaCasherReport_TextChanged);
            // 
            // btnFiltroFechaCajeros
            // 
            this.btnFiltroFechaCajeros.BackColor = System.Drawing.Color.Navy;
            this.btnFiltroFechaCajeros.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFiltroFechaCajeros.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltroFechaCajeros.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFiltroFechaCajeros.Location = new System.Drawing.Point(719, 188);
            this.btnFiltroFechaCajeros.Name = "btnFiltroFechaCajeros";
            this.btnFiltroFechaCajeros.Size = new System.Drawing.Size(81, 28);
            this.btnFiltroFechaCajeros.TabIndex = 107;
            this.btnFiltroFechaCajeros.Text = "Filtrar";
            this.btnFiltroFechaCajeros.UseVisualStyleBackColor = false;
            this.btnFiltroFechaCajeros.Click += new System.EventHandler(this.btnFiltroFechaCajeros_Click);
            // 
            // lblUtilidadCajero
            // 
            this.lblUtilidadCajero.AutoSize = true;
            this.lblUtilidadCajero.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUtilidadCajero.Location = new System.Drawing.Point(493, 588);
            this.lblUtilidadCajero.Name = "lblUtilidadCajero";
            this.lblUtilidadCajero.Size = new System.Drawing.Size(75, 22);
            this.lblUtilidadCajero.TabIndex = 118;
            this.lblUtilidadCajero.Text = "$ 00.00";
            // 
            // lblVentaCajero
            // 
            this.lblVentaCajero.AutoSize = true;
            this.lblVentaCajero.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblVentaCajero.Location = new System.Drawing.Point(320, 588);
            this.lblVentaCajero.Name = "lblVentaCajero";
            this.lblVentaCajero.Size = new System.Drawing.Size(75, 22);
            this.lblVentaCajero.TabIndex = 117;
            this.lblVentaCajero.Text = "$ 00.00";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(493, 555);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(82, 22);
            this.label7.TabIndex = 116;
            this.label7.Text = "Utilidad:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(320, 555);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 22);
            this.label6.TabIndex = 115;
            this.label6.Text = "Venta:";
            // 
            // SellerReportScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.lblUtilidadCajero);
            this.Controls.Add(this.lblVentaCajero);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnFiltroFechaCajeros);
            this.Controls.Add(this.txtDepaCasherReport);
            this.Controls.Add(this.txtCasherReport);
            this.Controls.Add(this.dtpSellerReport2);
            this.Controls.Add(this.dtpSellerReport1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridSellerReport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "SellerReportScreen";
            this.Text = "Reporte por cajero";
            this.Load += new System.EventHandler(this.SellerReportScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridSellerReport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtpSellerReport2;
        private System.Windows.Forms.DateTimePicker dtpSellerReport1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridSellerReport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCasherReport;
        private System.Windows.Forms.TextBox txtDepaCasherReport;
        private System.Windows.Forms.Button btnFiltroFechaCajeros;
        private System.Windows.Forms.Label lblUtilidadCajero;
        private System.Windows.Forms.Label lblVentaCajero;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}