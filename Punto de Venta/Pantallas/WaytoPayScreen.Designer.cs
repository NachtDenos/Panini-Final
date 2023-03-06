
namespace Punto_de_Venta
{
    partial class WaytoPayScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WaytoPayScreen));
            this.dataGridWayToPay = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCashPay = new System.Windows.Forms.TextBox();
            this.txtDebitCardPay = new System.Windows.Forms.TextBox();
            this.txtCreditCardPay = new System.Windows.Forms.TextBox();
            this.txtCheckPay = new System.Windows.Forms.TextBox();
            this.txtVoucherPay = new System.Windows.Forms.TextBox();
            this.txtOtherPay = new System.Windows.Forms.TextBox();
            this.btnPayPay = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbCreditCardPay = new System.Windows.Forms.CheckBox();
            this.rbDebitCardPay = new System.Windows.Forms.CheckBox();
            this.rbCashPay = new System.Windows.Forms.CheckBox();
            this.rbCheckPay = new System.Windows.Forms.CheckBox();
            this.rbOtherPay = new System.Windows.Forms.CheckBox();
            this.rbVouchersPay = new System.Windows.Forms.CheckBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.totalblwaytopay = new System.Windows.Forms.Label();
            this.finalPaylbl = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWayToPay)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridWayToPay
            // 
            this.dataGridWayToPay.AllowUserToAddRows = false;
            this.dataGridWayToPay.AllowUserToDeleteRows = false;
            this.dataGridWayToPay.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridWayToPay.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridWayToPay.Location = new System.Drawing.Point(109, 95);
            this.dataGridWayToPay.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridWayToPay.Name = "dataGridWayToPay";
            this.dataGridWayToPay.ReadOnly = true;
            this.dataGridWayToPay.RowHeadersWidth = 51;
            this.dataGridWayToPay.Size = new System.Drawing.Size(603, 406);
            this.dataGridWayToPay.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(317, 11);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(158, 56);
            this.label1.TabIndex = 7;
            this.label1.Text = "Pagar";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(295, 596);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 30);
            this.label3.TabIndex = 29;
            this.label3.Text = "Método de pago";
            // 
            // txtCashPay
            // 
            this.txtCashPay.Location = new System.Drawing.Point(369, 674);
            this.txtCashPay.Margin = new System.Windows.Forms.Padding(4);
            this.txtCashPay.Multiline = true;
            this.txtCashPay.Name = "txtCashPay";
            this.txtCashPay.Size = new System.Drawing.Size(84, 26);
            this.txtCashPay.TabIndex = 35;
            this.txtCashPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCashPay_KeyPress);
            // 
            // txtDebitCardPay
            // 
            this.txtDebitCardPay.Location = new System.Drawing.Point(212, 737);
            this.txtDebitCardPay.Margin = new System.Windows.Forms.Padding(4);
            this.txtDebitCardPay.Multiline = true;
            this.txtDebitCardPay.Name = "txtDebitCardPay";
            this.txtDebitCardPay.Size = new System.Drawing.Size(84, 26);
            this.txtDebitCardPay.TabIndex = 36;
            this.txtDebitCardPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDebitCardPay_KeyPress);
            // 
            // txtCreditCardPay
            // 
            this.txtCreditCardPay.Location = new System.Drawing.Point(212, 674);
            this.txtCreditCardPay.Margin = new System.Windows.Forms.Padding(4);
            this.txtCreditCardPay.Multiline = true;
            this.txtCreditCardPay.Name = "txtCreditCardPay";
            this.txtCreditCardPay.Size = new System.Drawing.Size(84, 26);
            this.txtCreditCardPay.TabIndex = 37;
            this.txtCreditCardPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditCardPay_KeyPress);
            // 
            // txtCheckPay
            // 
            this.txtCheckPay.Location = new System.Drawing.Point(369, 737);
            this.txtCheckPay.Margin = new System.Windows.Forms.Padding(4);
            this.txtCheckPay.Multiline = true;
            this.txtCheckPay.Name = "txtCheckPay";
            this.txtCheckPay.Size = new System.Drawing.Size(84, 26);
            this.txtCheckPay.TabIndex = 38;
            this.txtCheckPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCheckPay_KeyPress);
            // 
            // txtVoucherPay
            // 
            this.txtVoucherPay.Location = new System.Drawing.Point(516, 674);
            this.txtVoucherPay.Margin = new System.Windows.Forms.Padding(4);
            this.txtVoucherPay.Multiline = true;
            this.txtVoucherPay.Name = "txtVoucherPay";
            this.txtVoucherPay.Size = new System.Drawing.Size(84, 26);
            this.txtVoucherPay.TabIndex = 39;
            this.txtVoucherPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtVoucherPay_KeyPress);
            // 
            // txtOtherPay
            // 
            this.txtOtherPay.Location = new System.Drawing.Point(516, 737);
            this.txtOtherPay.Margin = new System.Windows.Forms.Padding(4);
            this.txtOtherPay.Multiline = true;
            this.txtOtherPay.Name = "txtOtherPay";
            this.txtOtherPay.Size = new System.Drawing.Size(84, 26);
            this.txtOtherPay.TabIndex = 41;
            this.txtOtherPay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtOtherPay_KeyPress);
            // 
            // btnPayPay
            // 
            this.btnPayPay.BackColor = System.Drawing.Color.Green;
            this.btnPayPay.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayPay.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayPay.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPayPay.Location = new System.Drawing.Point(659, 756);
            this.btnPayPay.Margin = new System.Windows.Forms.Padding(4);
            this.btnPayPay.Name = "btnPayPay";
            this.btnPayPay.Size = new System.Drawing.Size(119, 42);
            this.btnPayPay.TabIndex = 42;
            this.btnPayPay.Text = "Pagar";
            this.btnPayPay.UseVisualStyleBackColor = false;
            this.btnPayPay.Click += new System.EventHandler(this.btnPayPay_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(131, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(521, 21);
            this.label2.TabIndex = 43;
            this.label2.Text = "Seleccione los métodos de pago que usará y cuanto pagará";
            // 
            // rbCreditCardPay
            // 
            this.rbCreditCardPay.AutoSize = true;
            this.rbCreditCardPay.Location = new System.Drawing.Point(208, 646);
            this.rbCreditCardPay.Margin = new System.Windows.Forms.Padding(4);
            this.rbCreditCardPay.Name = "rbCreditCardPay";
            this.rbCreditCardPay.Size = new System.Drawing.Size(144, 21);
            this.rbCreditCardPay.TabIndex = 44;
            this.rbCreditCardPay.Text = "Tarjeta de Crédito";
            this.rbCreditCardPay.UseVisualStyleBackColor = true;
            this.rbCreditCardPay.Click += new System.EventHandler(this.rbCreditCardPay_Click);
            // 
            // rbDebitCardPay
            // 
            this.rbDebitCardPay.AutoSize = true;
            this.rbDebitCardPay.Location = new System.Drawing.Point(208, 710);
            this.rbDebitCardPay.Margin = new System.Windows.Forms.Padding(4);
            this.rbDebitCardPay.Name = "rbDebitCardPay";
            this.rbDebitCardPay.Size = new System.Drawing.Size(140, 21);
            this.rbDebitCardPay.TabIndex = 45;
            this.rbDebitCardPay.Text = "Tarjeta de Débito";
            this.rbDebitCardPay.UseVisualStyleBackColor = true;
            this.rbDebitCardPay.Click += new System.EventHandler(this.rbDebitCardPay_Click);
            // 
            // rbCashPay
            // 
            this.rbCashPay.AutoSize = true;
            this.rbCashPay.Location = new System.Drawing.Point(372, 646);
            this.rbCashPay.Margin = new System.Windows.Forms.Padding(4);
            this.rbCashPay.Name = "rbCashPay";
            this.rbCashPay.Size = new System.Drawing.Size(80, 21);
            this.rbCashPay.TabIndex = 46;
            this.rbCashPay.Text = "Efectivo";
            this.rbCashPay.UseVisualStyleBackColor = true;
            this.rbCashPay.Click += new System.EventHandler(this.rbCashPay_Click);
            // 
            // rbCheckPay
            // 
            this.rbCheckPay.AutoSize = true;
            this.rbCheckPay.Location = new System.Drawing.Point(369, 709);
            this.rbCheckPay.Margin = new System.Windows.Forms.Padding(4);
            this.rbCheckPay.Name = "rbCheckPay";
            this.rbCheckPay.Size = new System.Drawing.Size(79, 21);
            this.rbCheckPay.TabIndex = 47;
            this.rbCheckPay.Text = "Cheque";
            this.rbCheckPay.UseVisualStyleBackColor = true;
            this.rbCheckPay.Click += new System.EventHandler(this.rbCheckPay_Click);
            // 
            // rbOtherPay
            // 
            this.rbOtherPay.AutoSize = true;
            this.rbOtherPay.Location = new System.Drawing.Point(516, 710);
            this.rbOtherPay.Margin = new System.Windows.Forms.Padding(4);
            this.rbOtherPay.Name = "rbOtherPay";
            this.rbOtherPay.Size = new System.Drawing.Size(58, 21);
            this.rbOtherPay.TabIndex = 48;
            this.rbOtherPay.Text = "Otro";
            this.rbOtherPay.UseVisualStyleBackColor = true;
            this.rbOtherPay.Click += new System.EventHandler(this.rbOtherPay_Click);
            // 
            // rbVouchersPay
            // 
            this.rbVouchersPay.AutoSize = true;
            this.rbVouchersPay.Location = new System.Drawing.Point(516, 646);
            this.rbVouchersPay.Margin = new System.Windows.Forms.Padding(4);
            this.rbVouchersPay.Name = "rbVouchersPay";
            this.rbVouchersPay.Size = new System.Drawing.Size(65, 21);
            this.rbVouchersPay.TabIndex = 49;
            this.rbVouchersPay.Text = "Vales";
            this.rbVouchersPay.UseVisualStyleBackColor = true;
            this.rbVouchersPay.Click += new System.EventHandler(this.rbVouchersPay_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label4.Location = new System.Drawing.Point(468, 533);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(132, 30);
            this.label4.TabIndex = 50;
            this.label4.Text = "Total Final";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.label5.Location = new System.Drawing.Point(104, 533);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 30);
            this.label5.TabIndex = 51;
            this.label5.Text = "Total";
            // 
            // totalblwaytopay
            // 
            this.totalblwaytopay.AutoSize = true;
            this.totalblwaytopay.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.totalblwaytopay.Location = new System.Drawing.Point(180, 533);
            this.totalblwaytopay.Name = "totalblwaytopay";
            this.totalblwaytopay.Size = new System.Drawing.Size(72, 30);
            this.totalblwaytopay.TabIndex = 52;
            this.totalblwaytopay.Text = "$0.00";
            // 
            // finalPaylbl
            // 
            this.finalPaylbl.AutoSize = true;
            this.finalPaylbl.Font = new System.Drawing.Font("Century Gothic", 14.25F);
            this.finalPaylbl.Location = new System.Drawing.Point(606, 533);
            this.finalPaylbl.Name = "finalPaylbl";
            this.finalPaylbl.Size = new System.Drawing.Size(72, 30);
            this.finalPaylbl.TabIndex = 53;
            this.finalPaylbl.Text = "$0.00";
            // 
            // WaytoPayScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(793, 801);
            this.Controls.Add(this.finalPaylbl);
            this.Controls.Add(this.totalblwaytopay);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.rbVouchersPay);
            this.Controls.Add(this.rbOtherPay);
            this.Controls.Add(this.rbCheckPay);
            this.Controls.Add(this.rbCashPay);
            this.Controls.Add(this.rbDebitCardPay);
            this.Controls.Add(this.rbCreditCardPay);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnPayPay);
            this.Controls.Add(this.txtOtherPay);
            this.Controls.Add(this.txtVoucherPay);
            this.Controls.Add(this.txtCheckPay);
            this.Controls.Add(this.txtCreditCardPay);
            this.Controls.Add(this.txtDebitCardPay);
            this.Controls.Add(this.txtCashPay);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridWayToPay);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "WaytoPayScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Forma de pago";
            this.Load += new System.EventHandler(this.WaytoPayScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridWayToPay)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridWayToPay;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCashPay;
        private System.Windows.Forms.TextBox txtDebitCardPay;
        private System.Windows.Forms.TextBox txtCreditCardPay;
        private System.Windows.Forms.TextBox txtCheckPay;
        private System.Windows.Forms.TextBox txtVoucherPay;
        private System.Windows.Forms.TextBox txtOtherPay;
        private System.Windows.Forms.Button btnPayPay;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox rbCreditCardPay;
        private System.Windows.Forms.CheckBox rbDebitCardPay;
        private System.Windows.Forms.CheckBox rbCashPay;
        private System.Windows.Forms.CheckBox rbCheckPay;
        private System.Windows.Forms.CheckBox rbOtherPay;
        private System.Windows.Forms.CheckBox rbVouchersPay;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label totalblwaytopay;
        private System.Windows.Forms.Label finalPaylbl;
    }
}