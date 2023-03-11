
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
            this.txtDiscountDiscount = new System.Windows.Forms.TextBox();
            this.addDiscountBtton = new System.Windows.Forms.Button();
            this.dtpOutDiscounts = new System.Windows.Forms.DateTimePicker();
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
            this.label6.Location = new System.Drawing.Point(359, 199);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(242, 22);
            this.label6.TabIndex = 35;
            this.label6.Text = "Código de la reservación";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(359, 290);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 22);
            this.label1.TabIndex = 36;
            this.label1.Text = "Fecha de la cancelación";
            // 
            // txtDiscountDiscount
            // 
            this.txtDiscountDiscount.Location = new System.Drawing.Point(332, 233);
            this.txtDiscountDiscount.Multiline = true;
            this.txtDiscountDiscount.Name = "txtDiscountDiscount";
            this.txtDiscountDiscount.Size = new System.Drawing.Size(287, 22);
            this.txtDiscountDiscount.TabIndex = 54;
            this.txtDiscountDiscount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDiscountDiscount_KeyPress);
            // 
            // addDiscountBtton
            // 
            this.addDiscountBtton.BackColor = System.Drawing.Color.Green;
            this.addDiscountBtton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addDiscountBtton.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addDiscountBtton.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.addDiscountBtton.Location = new System.Drawing.Point(389, 401);
            this.addDiscountBtton.Name = "addDiscountBtton";
            this.addDiscountBtton.Size = new System.Drawing.Size(161, 61);
            this.addDiscountBtton.TabIndex = 55;
            this.addDiscountBtton.Text = "Confirmar";
            this.addDiscountBtton.UseVisualStyleBackColor = false;
            this.addDiscountBtton.Click += new System.EventHandler(this.addDiscountBtton_Click);
            // 
            // dtpOutDiscounts
            // 
            this.dtpOutDiscounts.Location = new System.Drawing.Point(332, 333);
            this.dtpOutDiscounts.Name = "dtpOutDiscounts";
            this.dtpOutDiscounts.Size = new System.Drawing.Size(287, 20);
            this.dtpOutDiscounts.TabIndex = 41;
            // 
            // DiscountsScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.addDiscountBtton);
            this.Controls.Add(this.txtDiscountDiscount);
            this.Controls.Add(this.dtpOutDiscounts);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label2);
            this.Name = "DiscountsScreen";
            this.Text = "Descuentos";
            this.Load += new System.EventHandler(this.DiscountsScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDiscountDiscount;
        private System.Windows.Forms.Button addDiscountBtton;
        private System.Windows.Forms.DateTimePicker dtpOutDiscounts;
    }
}