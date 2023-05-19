
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
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridServices2CheckOut = new System.Windows.Forms.DataGridView();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
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
            this.dataGridServicesCheckOut.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridServicesCheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServicesCheckOut.Location = new System.Drawing.Point(48, 197);
            this.dataGridServicesCheckOut.Name = "dataGridServicesCheckOut";
            this.dataGridServicesCheckOut.ReadOnly = true;
            this.dataGridServicesCheckOut.RowHeadersWidth = 51;
            this.dataGridServicesCheckOut.Size = new System.Drawing.Size(117, 242);
            this.dataGridServicesCheckOut.TabIndex = 141;
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
            this.rbDebitCardCheckOut.Location = new System.Drawing.Point(803, 385);
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
            this.rbCreditCardCheckOut.Location = new System.Drawing.Point(654, 385);
            this.rbCreditCardCheckOut.Name = "rbCreditCardCheckOut";
            this.rbCreditCardCheckOut.Size = new System.Drawing.Size(110, 17);
            this.rbCreditCardCheckOut.TabIndex = 151;
            this.rbCreditCardCheckOut.Text = "Tarjeta de Crédito";
            this.rbCreditCardCheckOut.UseVisualStyleBackColor = true;
            this.rbCreditCardCheckOut.Click += new System.EventHandler(this.rbCreditCardCheckOut_Click);
            // 
            // txtCreditCardCheckOut
            // 
            this.txtCreditCardCheckOut.Location = new System.Drawing.Point(657, 408);
            this.txtCreditCardCheckOut.Multiline = true;
            this.txtCreditCardCheckOut.Name = "txtCreditCardCheckOut";
            this.txtCreditCardCheckOut.Size = new System.Drawing.Size(107, 22);
            this.txtCreditCardCheckOut.TabIndex = 147;
            this.txtCreditCardCheckOut.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditCardCheckOut_KeyPress);
            // 
            // txtDebitCardCheckOut
            // 
            this.txtDebitCardCheckOut.Location = new System.Drawing.Point(803, 407);
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
            this.label4.Location = new System.Drawing.Point(696, 344);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(169, 22);
            this.label4.TabIndex = 144;
            this.label4.Text = "Método de pago";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(424, 172);
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
            this.dataGridRoomsCheckOut.Location = new System.Drawing.Point(347, 197);
            this.dataGridRoomsCheckOut.Name = "dataGridRoomsCheckOut";
            this.dataGridRoomsCheckOut.ReadOnly = true;
            this.dataGridRoomsCheckOut.RowHeadersWidth = 51;
            this.dataGridRoomsCheckOut.Size = new System.Drawing.Size(274, 242);
            this.dataGridRoomsCheckOut.TabIndex = 159;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Navy;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button1.Location = new System.Drawing.Point(48, 445);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(117, 35);
            this.button1.TabIndex = 161;
            this.button1.Text = "Seleccionar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // dataGridServices2CheckOut
            // 
            this.dataGridServices2CheckOut.AllowUserToAddRows = false;
            this.dataGridServices2CheckOut.AllowUserToDeleteRows = false;
            this.dataGridServices2CheckOut.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridServices2CheckOut.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridServices2CheckOut.Location = new System.Drawing.Point(192, 197);
            this.dataGridServices2CheckOut.Name = "dataGridServices2CheckOut";
            this.dataGridServices2CheckOut.ReadOnly = true;
            this.dataGridServices2CheckOut.RowHeadersWidth = 51;
            this.dataGridServices2CheckOut.Size = new System.Drawing.Size(117, 242);
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
            this.label8.Location = new System.Drawing.Point(708, 258);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 30);
            this.label8.TabIndex = 164;
            this.label8.Text = "Total:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(520, 500);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 30);
            this.label9.TabIndex = 165;
            this.label9.Text = "0.00";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(520, 460);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 30);
            this.label10.TabIndex = 166;
            this.label10.Text = "0.00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(791, 258);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(59, 30);
            this.label11.TabIndex = 167;
            this.label11.Text = "0.00";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(520, 543);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(59, 30);
            this.label12.TabIndex = 169;
            this.label12.Text = "0.00";
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
            // checkOutScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.button1);
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
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridServices2CheckOut;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}