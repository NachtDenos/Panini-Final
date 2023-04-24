
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
            this.label6 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCodeReservCancel = new System.Windows.Forms.TextBox();
            this.btnConfirmCancel = new System.Windows.Forms.Button();
            this.dtpDateCancel = new System.Windows.Forms.DateTimePicker();
            this.dataGridCancel = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCancel)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(295, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cancelaciones";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(360, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Código de la reservación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(360, 210);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Fecha de la cancelación";
            // 
            // txtCodeReservCancel
            // 
            this.txtCodeReservCancel.Location = new System.Drawing.Point(333, 153);
            this.txtCodeReservCancel.Multiline = true;
            this.txtCodeReservCancel.Name = "txtCodeReservCancel";
            this.txtCodeReservCancel.Size = new System.Drawing.Size(287, 22);
            this.txtCodeReservCancel.TabIndex = 54;
            this.txtCodeReservCancel.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeReservCancel_KeyPress);
            // 
            // btnConfirmCancel
            // 
            this.btnConfirmCancel.BackColor = System.Drawing.Color.Green;
            this.btnConfirmCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmCancel.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmCancel.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmCancel.Location = new System.Drawing.Point(743, 542);
            this.btnConfirmCancel.Name = "btnConfirmCancel";
            this.btnConfirmCancel.Size = new System.Drawing.Size(161, 61);
            this.btnConfirmCancel.TabIndex = 55;
            this.btnConfirmCancel.Text = "Confirmar";
            this.btnConfirmCancel.UseVisualStyleBackColor = false;
            this.btnConfirmCancel.Click += new System.EventHandler(this.addDiscountBtton_Click);
            // 
            // dtpDateCancel
            // 
            this.dtpDateCancel.Location = new System.Drawing.Point(333, 253);
            this.dtpDateCancel.Name = "dtpDateCancel";
            this.dtpDateCancel.Size = new System.Drawing.Size(287, 20);
            this.dtpDateCancel.TabIndex = 41;
            // 
            // dataGridCancel
            // 
            this.dataGridCancel.AllowUserToAddRows = false;
            this.dataGridCancel.AllowUserToDeleteRows = false;
            this.dataGridCancel.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridCancel.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCancel.Location = new System.Drawing.Point(178, 309);
            this.dataGridCancel.Name = "dataGridCancel";
            this.dataGridCancel.ReadOnly = true;
            this.dataGridCancel.RowHeadersWidth = 51;
            this.dataGridCancel.Size = new System.Drawing.Size(582, 201);
            this.dataGridCancel.TabIndex = 162;
            // 
            // DiscountsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.dataGridCancel);
            this.Controls.Add(this.btnConfirmCancel);
            this.Controls.Add(this.txtCodeReservCancel);
            this.Controls.Add(this.dtpDateCancel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "DiscountsScreen";
            this.Text = "Descuentos";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCancel)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodeReservCancel;
        private System.Windows.Forms.Button btnConfirmCancel;
        private System.Windows.Forms.DateTimePicker dtpDateCancel;
        private System.Windows.Forms.DataGridView dataGridCancel;
    }
}