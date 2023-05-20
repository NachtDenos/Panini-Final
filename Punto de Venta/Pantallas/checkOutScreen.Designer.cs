
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
            this.btnExtendCheckOut = new System.Windows.Forms.Button();
            this.btnSearchCheckOut = new System.Windows.Forms.Button();
            this.dataGridRoomsCheckOut = new System.Windows.Forms.DataGridView();
            this.btnSelectServicesCheckOut = new System.Windows.Forms.Button();
            this.dataGridServices2CheckOut = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.labelServices = new System.Windows.Forms.Label();
            this.labelHospedaje = new System.Windows.Forms.Label();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelAnticipo = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.btnConfirmServicesCheckOut = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServicesCheckOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoomsCheckOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServices2CheckOut)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(356, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(214, 44);
            this.label2.TabIndex = 138;
            this.label2.Text = "Check Out";
            // 
            // txtCodeCheckOut
            // 
            this.txtCodeCheckOut.Location = new System.Drawing.Point(316, 92);
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
            this.label3.Location = new System.Drawing.Point(312, 67);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 22);
            this.label3.TabIndex = 139;
            this.label3.Text = "Ingresa el Código de reservación";
            // 
            // dataGridServicesCheckOut
            // 
            this.dataGridServicesCheckOut.AllowUserToAddRows = false;
            this.dataGridServicesCheckOut.AllowUserToDeleteRows = false;
            this.dataGridServicesCheckOut.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridServicesCheckOut.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridServicesCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServicesCheckOut.Location = new System.Drawing.Point(39, 196);
            this.dataGridServicesCheckOut.Name = "dataGridServicesCheckOut";
            this.dataGridServicesCheckOut.ReadOnly = true;
            this.dataGridServicesCheckOut.RowHeadersWidth = 51;
            this.dataGridServicesCheckOut.Size = new System.Drawing.Size(157, 242);
            this.dataGridServicesCheckOut.TabIndex = 141;
            this.dataGridServicesCheckOut.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridServicesCheckOut_CellClick);
            // 
            // btnConfirmCheckOut
            // 
            this.btnConfirmCheckOut.BackColor = System.Drawing.Color.Green;
            this.btnConfirmCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmCheckOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmCheckOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmCheckOut.Location = new System.Drawing.Point(772, 554);
            this.btnConfirmCheckOut.Name = "btnConfirmCheckOut";
            this.btnConfirmCheckOut.Size = new System.Drawing.Size(139, 51);
            this.btnConfirmCheckOut.TabIndex = 142;
            this.btnConfirmCheckOut.Text = "Confirmar";
            this.btnConfirmCheckOut.UseVisualStyleBackColor = false;
            this.btnConfirmCheckOut.Click += new System.EventHandler(this.btnConfirmCheckOut_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 172);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(264, 22);
            this.label1.TabIndex = 143;
            this.label1.Text = "Servicios adicionales usados";
            // 
            // rbDebitCardCheckOut
            // 
            this.rbDebitCardCheckOut.AutoSize = true;
            this.rbDebitCardCheckOut.Location = new System.Drawing.Point(810, 394);
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
            this.rbCreditCardCheckOut.Location = new System.Drawing.Point(661, 394);
            this.rbCreditCardCheckOut.Name = "rbCreditCardCheckOut";
            this.rbCreditCardCheckOut.Size = new System.Drawing.Size(110, 17);
            this.rbCreditCardCheckOut.TabIndex = 151;
            this.rbCreditCardCheckOut.Text = "Tarjeta de Crédito";
            this.rbCreditCardCheckOut.UseVisualStyleBackColor = true;
            this.rbCreditCardCheckOut.Click += new System.EventHandler(this.rbCreditCardCheckOut_Click);
            // 
            // txtCreditCardCheckOut
            // 
            this.txtCreditCardCheckOut.Location = new System.Drawing.Point(664, 417);
            this.txtCreditCardCheckOut.Multiline = true;
            this.txtCreditCardCheckOut.Name = "txtCreditCardCheckOut";
            this.txtCreditCardCheckOut.Size = new System.Drawing.Size(107, 22);
            this.txtCreditCardCheckOut.TabIndex = 147;
            this.txtCreditCardCheckOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditCardCheckOut_KeyPress);
            // 
            // txtDebitCardCheckOut
            // 
            this.txtDebitCardCheckOut.Location = new System.Drawing.Point(810, 416);
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
            this.label4.Location = new System.Drawing.Point(703, 353);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 22);
            this.label4.TabIndex = 144;
            this.label4.Text = "Método de pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(441, 172);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(108, 22);
            this.label5.TabIndex = 153;
            this.label5.Text = "Hospedaje";
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
            this.btnSearchCheckOut.Location = new System.Drawing.Point(416, 120);
            this.btnSearchCheckOut.Name = "btnSearchCheckOut";
            this.btnSearchCheckOut.Size = new System.Drawing.Size(98, 35);
            this.btnSearchCheckOut.TabIndex = 158;
            this.btnSearchCheckOut.Text = "Buscar";
            this.btnSearchCheckOut.UseVisualStyleBackColor = false;
            this.btnSearchCheckOut.Click += new System.EventHandler(this.btnSearchCheckOut_Click);
            // 
            // dataGridRoomsCheckOut
            // 
            this.dataGridRoomsCheckOut.AllowUserToAddRows = false;
            this.dataGridRoomsCheckOut.AllowUserToDeleteRows = false;
            this.dataGridRoomsCheckOut.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridRoomsCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRoomsCheckOut.Location = new System.Drawing.Point(364, 197);
            this.dataGridRoomsCheckOut.Name = "dataGridRoomsCheckOut";
            this.dataGridRoomsCheckOut.ReadOnly = true;
            this.dataGridRoomsCheckOut.RowHeadersWidth = 51;
            this.dataGridRoomsCheckOut.Size = new System.Drawing.Size(274, 242);
            this.dataGridRoomsCheckOut.TabIndex = 159;
            // 
            // btnSelectServicesCheckOut
            // 
            this.btnSelectServicesCheckOut.BackColor = System.Drawing.Color.Navy;
            this.btnSelectServicesCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectServicesCheckOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectServicesCheckOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectServicesCheckOut.Location = new System.Drawing.Point(48, 445);
            this.btnSelectServicesCheckOut.Name = "btnSelectServicesCheckOut";
            this.btnSelectServicesCheckOut.Size = new System.Drawing.Size(117, 35);
            this.btnSelectServicesCheckOut.TabIndex = 161;
            this.btnSelectServicesCheckOut.Text = "Seleccionar";
            this.btnSelectServicesCheckOut.UseVisualStyleBackColor = false;
            this.btnSelectServicesCheckOut.Click += new System.EventHandler(this.btnSelectServicesCheckOut_Click);
            // 
            // dataGridServices2CheckOut
            // 
            this.dataGridServices2CheckOut.AllowUserToAddRows = false;
            this.dataGridServices2CheckOut.AllowUserToDeleteRows = false;
            this.dataGridServices2CheckOut.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridServices2CheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServices2CheckOut.Location = new System.Drawing.Point(207, 197);
            this.dataGridServices2CheckOut.Name = "dataGridServices2CheckOut";
            this.dataGridServices2CheckOut.ReadOnly = true;
            this.dataGridServices2CheckOut.RowHeadersWidth = 51;
            this.dataGridServices2CheckOut.Size = new System.Drawing.Size(141, 242);
            this.dataGridServices2CheckOut.TabIndex = 160;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(390, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 30);
            this.label6.TabIndex = 162;
            this.label6.Text = "Servicios:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(367, 460);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(147, 30);
            this.label7.TabIndex = 163;
            this.label7.Text = "Hospedaje:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(702, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 30);
            this.label8.TabIndex = 164;
            this.label8.Text = "Total:";
            // 
            // labelServices
            // 
            this.labelServices.AutoSize = true;
            this.labelServices.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelServices.Location = new System.Drawing.Point(520, 500);
            this.labelServices.Name = "labelServices";
            this.labelServices.Size = new System.Drawing.Size(59, 30);
            this.labelServices.TabIndex = 165;
            this.labelServices.Text = "0.00";
            // 
            // labelHospedaje
            // 
            this.labelHospedaje.AutoSize = true;
            this.labelHospedaje.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelHospedaje.Location = new System.Drawing.Point(520, 460);
            this.labelHospedaje.Name = "labelHospedaje";
            this.labelHospedaje.Size = new System.Drawing.Size(59, 30);
            this.labelHospedaje.TabIndex = 166;
            this.labelHospedaje.Text = "0.00";
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(785, 258);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(59, 30);
            this.labelTotal.TabIndex = 167;
            this.labelTotal.Text = "0.00";
            // 
            // labelAnticipo
            // 
            this.labelAnticipo.AutoSize = true;
            this.labelAnticipo.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAnticipo.Location = new System.Drawing.Point(520, 543);
            this.labelAnticipo.Name = "labelAnticipo";
            this.labelAnticipo.Size = new System.Drawing.Size(59, 30);
            this.labelAnticipo.TabIndex = 169;
            this.labelAnticipo.Text = "0.00";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(394, 543);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(120, 30);
            this.label13.TabIndex = 168;
            this.label13.Text = "Anticipo:";
            // 
            // btnConfirmServicesCheckOut
            // 
            this.btnConfirmServicesCheckOut.BackColor = System.Drawing.Color.Green;
            this.btnConfirmServicesCheckOut.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmServicesCheckOut.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmServicesCheckOut.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmServicesCheckOut.Location = new System.Drawing.Point(216, 445);
            this.btnConfirmServicesCheckOut.Name = "btnConfirmServicesCheckOut";
            this.btnConfirmServicesCheckOut.Size = new System.Drawing.Size(116, 35);
            this.btnConfirmServicesCheckOut.TabIndex = 170;
            this.btnConfirmServicesCheckOut.Text = "Confirmar";
            this.btnConfirmServicesCheckOut.UseVisualStyleBackColor = false;
            this.btnConfirmServicesCheckOut.Click += new System.EventHandler(this.btnConfirmServicesCheckOut_Click);
            // 
            // checkOutScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.btnConfirmServicesCheckOut);
            this.Controls.Add(this.labelAnticipo);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.labelTotal);
            this.Controls.Add(this.labelHospedaje);
            this.Controls.Add(this.labelServices);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.btnSelectServicesCheckOut);
            this.Controls.Add(this.dataGridServices2CheckOut);
            this.Controls.Add(this.dataGridRoomsCheckOut);
            this.Controls.Add(this.btnSearchCheckOut);
            this.Controls.Add(this.btnExtendCheckOut);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoomsCheckOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridServices2CheckOut)).EndInit();
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
        private System.Windows.Forms.Button btnExtendCheckOut;
        private System.Windows.Forms.Button btnSearchCheckOut;
        private System.Windows.Forms.DataGridView dataGridRoomsCheckOut;
        private System.Windows.Forms.Button btnSelectServicesCheckOut;
        private System.Windows.Forms.DataGridView dataGridServices2CheckOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label labelServices;
        private System.Windows.Forms.Label labelHospedaje;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.Label labelAnticipo;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Button btnConfirmServicesCheckOut;
    }
}