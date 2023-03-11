
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridProduct = new System.Windows.Forms.DataGridView();
            this.btnAddDepartament = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.rbDebitCardPay = new System.Windows.Forms.CheckBox();
            this.rbCreditCardPay = new System.Windows.Forms.CheckBox();
            this.txtCreditCardPay = new System.Windows.Forms.TextBox();
            this.txtDebitCardPay = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.pbTicketSell = new System.Windows.Forms.PictureBox();
            this.btnEditDepartament = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTicketSell)).BeginInit();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(298, 129);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(310, 22);
            this.textBox1.TabIndex = 140;
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
            // dataGridProduct
            // 
            this.dataGridProduct.AllowUserToAddRows = false;
            this.dataGridProduct.AllowUserToDeleteRows = false;
            this.dataGridProduct.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridProduct.Location = new System.Drawing.Point(48, 197);
            this.dataGridProduct.Name = "dataGridProduct";
            this.dataGridProduct.ReadOnly = true;
            this.dataGridProduct.RowHeadersWidth = 51;
            this.dataGridProduct.Size = new System.Drawing.Size(333, 272);
            this.dataGridProduct.TabIndex = 141;
            // 
            // btnAddDepartament
            // 
            this.btnAddDepartament.BackColor = System.Drawing.Color.Green;
            this.btnAddDepartament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDepartament.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepartament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddDepartament.Location = new System.Drawing.Point(760, 568);
            this.btnAddDepartament.Name = "btnAddDepartament";
            this.btnAddDepartament.Size = new System.Drawing.Size(139, 51);
            this.btnAddDepartament.TabIndex = 142;
            this.btnAddDepartament.Text = "Confirmar";
            this.btnAddDepartament.UseVisualStyleBackColor = false;
            this.btnAddDepartament.Click += new System.EventHandler(this.btnAddDepartament_Click);
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
            // rbDebitCardPay
            // 
            this.rbDebitCardPay.AutoSize = true;
            this.rbDebitCardPay.Location = new System.Drawing.Point(488, 526);
            this.rbDebitCardPay.Name = "rbDebitCardPay";
            this.rbDebitCardPay.Size = new System.Drawing.Size(108, 17);
            this.rbDebitCardPay.TabIndex = 152;
            this.rbDebitCardPay.Text = "Tarjeta de Débito";
            this.rbDebitCardPay.UseVisualStyleBackColor = true;
            // 
            // rbCreditCardPay
            // 
            this.rbCreditCardPay.AutoSize = true;
            this.rbCreditCardPay.Location = new System.Drawing.Point(339, 526);
            this.rbCreditCardPay.Name = "rbCreditCardPay";
            this.rbCreditCardPay.Size = new System.Drawing.Size(110, 17);
            this.rbCreditCardPay.TabIndex = 151;
            this.rbCreditCardPay.Text = "Tarjeta de Crédito";
            this.rbCreditCardPay.UseVisualStyleBackColor = true;
            // 
            // txtCreditCardPay
            // 
            this.txtCreditCardPay.Location = new System.Drawing.Point(342, 549);
            this.txtCreditCardPay.Multiline = true;
            this.txtCreditCardPay.Name = "txtCreditCardPay";
            this.txtCreditCardPay.Size = new System.Drawing.Size(107, 22);
            this.txtCreditCardPay.TabIndex = 147;
            // 
            // txtDebitCardPay
            // 
            this.txtDebitCardPay.Location = new System.Drawing.Point(488, 548);
            this.txtDebitCardPay.Multiline = true;
            this.txtDebitCardPay.Name = "txtDebitCardPay";
            this.txtDebitCardPay.Size = new System.Drawing.Size(108, 22);
            this.txtDebitCardPay.TabIndex = 146;
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
            // pbTicketSell
            // 
            this.pbTicketSell.Image = global::Punto_de_Venta.Properties.Resources.EjemploTicket;
            this.pbTicketSell.Location = new System.Drawing.Point(526, 197);
            this.pbTicketSell.Name = "pbTicketSell";
            this.pbTicketSell.Size = new System.Drawing.Size(396, 272);
            this.pbTicketSell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTicketSell.TabIndex = 154;
            this.pbTicketSell.TabStop = false;
            // 
            // btnEditDepartament
            // 
            this.btnEditDepartament.BackColor = System.Drawing.Color.Navy;
            this.btnEditDepartament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDepartament.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDepartament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditDepartament.Location = new System.Drawing.Point(48, 568);
            this.btnEditDepartament.Name = "btnEditDepartament";
            this.btnEditDepartament.Size = new System.Drawing.Size(139, 51);
            this.btnEditDepartament.TabIndex = 157;
            this.btnEditDepartament.Text = "Extender ";
            this.btnEditDepartament.UseVisualStyleBackColor = false;
            this.btnEditDepartament.Click += new System.EventHandler(this.btnEditDepartament_Click);
            // 
            // checkOutScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.btnEditDepartament);
            this.Controls.Add(this.pbTicketSell);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.rbDebitCardPay);
            this.Controls.Add(this.rbCreditCardPay);
            this.Controls.Add(this.txtCreditCardPay);
            this.Controls.Add(this.txtDebitCardPay);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAddDepartament);
            this.Controls.Add(this.dataGridProduct);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Name = "checkOutScreen";
            this.Text = "checkOut";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbTicketSell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridProduct;
        private System.Windows.Forms.Button btnAddDepartament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox rbDebitCardPay;
        private System.Windows.Forms.CheckBox rbCreditCardPay;
        private System.Windows.Forms.TextBox txtCreditCardPay;
        private System.Windows.Forms.TextBox txtDebitCardPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.PictureBox pbTicketSell;
        private System.Windows.Forms.Button btnEditDepartament;
    }
}