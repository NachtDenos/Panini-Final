
namespace Punto_de_Venta.Pantallas
{
    partial class checkOutScreen
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
            this.txtCodeCheckOut = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridServicesCheckOut = new System.Windows.Forms.DataGridView();
            this.btnConfirmCheckOut = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbDebitCardCheckOut = new System.Windows.Forms.CheckBox();
            this.rbCreditCardCheckOut = new System.Windows.Forms.CheckBox();
            this.txtCreditCardCheckOut = new System.Windows.Forms.TextBox();
            this.txtDebitCardCheckOut = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbBillCheckOut = new System.Windows.Forms.PictureBox();
            this.btnExtendCheckOut = new System.Windows.Forms.Button();
            this.btnSearchCheckOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServicesCheckOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBillCheckOut)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 44);
            this.label2.TabIndex = 138;
            this.label2.Text = "Check Out";
            // 
            // txtCodeCheckOut
            // 
            this.txtCodeCheckOut.Location = new System.Drawing.Point(298, 129);
            this.txtCodeCheckOut.Multiline = true;
            this.txtCodeCheckOut.Name = "txtCodeCheckOut";
            this.txtCodeCheckOut.Size = new System.Drawing.Size(310, 22);
            this.txtCodeCheckOut.TabIndex = 140;
            this.txtCodeCheckOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeCheckOut_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(294, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 22);
            this.label3.TabIndex = 139;
            this.label3.Text = "Ingresa el Código de reservación";
            // 
            // dataGridServicesCheckOut
            // 
            this.dataGridServicesCheckOut.AllowUserToAddRows = false;
            this.dataGridServicesCheckOut.AllowUserToDeleteRows = false;
            this.dataGridServicesCheckOut.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridServicesCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServicesCheckOut.Location = new System.Drawing.Point(48, 197);
            this.dataGridServicesCheckOut.Name = "dataGridServicesCheckOut";
            this.dataGridServicesCheckOut.ReadOnly = true;
            this.dataGridServicesCheckOut.RowHeadersWidth = 51;
            this.dataGridServicesCheckOut.Size = new System.Drawing.Size(333, 272);
            this.dataGridServicesCheckOut.TabIndex = 141;
            // 
            // btnConfirmCheckOut
            // 
            this.btnConfirmCheckOut.BackColor = System.Drawing.Color.Green;
            this.btnConfirmCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmCheckOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmCheckOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmCheckOut.Location = new System.Drawing.Point(760, 568);
            this.btnConfirmCheckOut.Name = "btnConfirmCheckOut";
            this.btnConfirmCheckOut.Size = new System.Drawing.Size(139, 51);
            this.btnConfirmCheckOut.TabIndex = 142;
            this.btnConfirmCheckOut.Text = "Confirmar";
            this.btnConfirmCheckOut.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 22);
            this.label1.TabIndex = 143;
            this.label1.Text = "Servicios adicionales usados";
            // 
            // rbDebitCardCheckOut
            // 
            this.rbDebitCardCheckOut.AutoSize = true;
            this.rbDebitCardCheckOut.Location = new System.Drawing.Point(488, 526);
            this.rbDebitCardCheckOut.Name = "rbDebitCardCheckOut";
            this.rbDebitCardCheckOut.Size = new System.Drawing.Size(108, 17);
            this.rbDebitCardCheckOut.TabIndex = 152;
            this.rbDebitCardCheckOut.Text = "Tarjeta de Débito";
            this.rbDebitCardCheckOut.UseVisualStyleBackColor = true;
            this.rbDebitCardCheckOut.Click += new System.EventHandler(this.rbDebitCardCheckOut_Click);
            // 
            // rbCreditCardCheckOut
            // 
            this.rbCreditCardCheckOut.AutoSize = true;
            this.rbCreditCardCheckOut.Location = new System.Drawing.Point(339, 526);
            this.rbCreditCardCheckOut.Name = "rbCreditCardCheckOut";
            this.rbCreditCardCheckOut.Size = new System.Drawing.Size(110, 17);
            this.rbCreditCardCheckOut.TabIndex = 151;
            this.rbCreditCardCheckOut.Text = "Tarjeta de Crédito";
            this.rbCreditCardCheckOut.UseVisualStyleBackColor = true;
            this.rbCreditCardCheckOut.Click += new System.EventHandler(this.rbCreditCardCheckOut_Click);
            // 
            // txtCreditCardCheckOut
            // 
            this.txtCreditCardCheckOut.Location = new System.Drawing.Point(342, 549);
            this.txtCreditCardCheckOut.Multiline = true;
            this.txtCreditCardCheckOut.Name = "txtCreditCardCheckOut";
            this.txtCreditCardCheckOut.Size = new System.Drawing.Size(107, 22);
            this.txtCreditCardCheckOut.TabIndex = 147;
            this.txtCreditCardCheckOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditCardCheckOut_KeyPress);
            // 
            // txtDebitCardCheckOut
            // 
            this.txtDebitCardCheckOut.Location = new System.Drawing.Point(488, 548);
            this.txtDebitCardCheckOut.Multiline = true;
            this.txtDebitCardCheckOut.Name = "txtDebitCardCheckOut";
            this.txtDebitCardCheckOut.Size = new System.Drawing.Size(108, 22);
            this.txtDebitCardCheckOut.TabIndex = 146;
            this.txtDebitCardCheckOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDebitCardCheckOut_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(381, 485);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 22);
            this.label4.TabIndex = 144;
            this.label4.Text = "Método de pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(676, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(87, 22);
            this.label5.TabIndex = 153;
            this.label5.Text = "Factura ";
            // 
            // pbBillCheckOut
            // 
            this.pbBillCheckOut.Image = global::Punto_de_Venta.Properties.Resources.EjemploTicket;
            this.pbBillCheckOut.Location = new System.Drawing.Point(526, 197);
            this.pbBillCheckOut.Name = "pbBillCheckOut";
            this.pbBillCheckOut.Size = new System.Drawing.Size(396, 272);
            this.pbBillCheckOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbBillCheckOut.TabIndex = 154;
            this.pbBillCheckOut.TabStop = false;
            // 
            // btnExtendCheckOut
            // 
            this.btnExtendCheckOut.BackColor = System.Drawing.Color.Navy;
            this.btnExtendCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnExtendCheckOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtendCheckOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnExtendCheckOut.Location = new System.Drawing.Point(48, 568);
            this.btnExtendCheckOut.Name = "btnExtendCheckOut";
            this.btnExtendCheckOut.Size = new System.Drawing.Size(139, 51);
            this.btnExtendCheckOut.TabIndex = 157;
            this.btnExtendCheckOut.Text = "Extender ";
            this.btnExtendCheckOut.UseVisualStyleBackColor = false;
            this.btnExtendCheckOut.Click += new System.EventHandler(this.btnEditDepartament_Click);
            // 
            // btnSearchCheckOut
            // 
            this.btnSearchCheckOut.BackColor = System.Drawing.Color.Navy;
            this.btnSearchCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchCheckOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchCheckOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchCheckOut.Location = new System.Drawing.Point(404, 157);
            this.btnSearchCheckOut.Name = "btnSearchCheckOut";
            this.btnSearchCheckOut.Size = new System.Drawing.Size(98, 35);
            this.btnSearchCheckOut.TabIndex = 158;
            this.btnSearchCheckOut.Text = "Buscar";
            this.btnSearchCheckOut.UseVisualStyleBackColor = false;
            this.btnSearchCheckOut.Click += new System.EventHandler(this.btnSearchCheckOut_Click);
            // 
            // checkOutScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.btnSearchCheckOut);
            this.Controls.Add(this.btnExtendCheckOut);
            this.Controls.Add(this.pbBillCheckOut);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbDebitCardCheckOut);
            this.Controls.Add(this.rbCreditCardCheckOut);
            this.Controls.Add(this.txtCreditCardCheckOut);
            this.Controls.Add(this.txtDebitCardCheckOut);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmCheckOut);
            this.Controls.Add(this.dataGridServicesCheckOut);
            this.Controls.Add(this.txtCodeCheckOut);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "checkOutScreen";
            this.Text = "checkOut";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServicesCheckOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbBillCheckOut)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodeCheckOut;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridServicesCheckOut;
        private System.Windows.Forms.Button btnConfirmCheckOut;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox rbDebitCardCheckOut;
        private System.Windows.Forms.CheckBox rbCreditCardCheckOut;
        private System.Windows.Forms.TextBox txtCreditCardCheckOut;
        private System.Windows.Forms.TextBox txtDebitCardCheckOut;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbBillCheckOut;
        private System.Windows.Forms.Button btnExtendCheckOut;
        private System.Windows.Forms.Button btnSearchCheckOut;
    }
}