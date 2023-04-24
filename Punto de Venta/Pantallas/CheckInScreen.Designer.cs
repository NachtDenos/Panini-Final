
namespace Punto_de_Venta
{
    partial class InventaryScreen
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
            this.txtCodeCheckIn = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dataGridCheckIn = new System.Windows.Forms.DataGridView();
            this.btnConfirmCheckIn = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCheckIn)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(377, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(182, 44);
            this.label2.TabIndex = 96;
            this.label2.Text = "Check In";
            // 
            // txtCodeCheckIn
            // 
            this.txtCodeCheckIn.Location = new System.Drawing.Point(310, 156);
            this.txtCodeCheckIn.Multiline = true;
            this.txtCodeCheckIn.Name = "txtCodeCheckIn";
            this.txtCodeCheckIn.Size = new System.Drawing.Size(310, 22);
            this.txtCodeCheckIn.TabIndex = 136;
            this.txtCodeCheckIn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCodeCheckIn_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(306, 106);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(314, 22);
            this.label3.TabIndex = 135;
            this.label3.Text = "Ingresa el Código de reservación";
            // 
            // dataGridCheckIn
            // 
            this.dataGridCheckIn.AllowUserToAddRows = false;
            this.dataGridCheckIn.AllowUserToDeleteRows = false;
            this.dataGridCheckIn.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridCheckIn.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCheckIn.Location = new System.Drawing.Point(244, 205);
            this.dataGridCheckIn.Name = "dataGridCheckIn";
            this.dataGridCheckIn.ReadOnly = true;
            this.dataGridCheckIn.RowHeadersWidth = 51;
            this.dataGridCheckIn.Size = new System.Drawing.Size(452, 313);
            this.dataGridCheckIn.TabIndex = 134;
            // 
            // btnConfirmCheckIn
            // 
            this.btnConfirmCheckIn.BackColor = System.Drawing.Color.Green;
            this.btnConfirmCheckIn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmCheckIn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmCheckIn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmCheckIn.Location = new System.Drawing.Point(399, 542);
            this.btnConfirmCheckIn.Name = "btnConfirmCheckIn";
            this.btnConfirmCheckIn.Size = new System.Drawing.Size(139, 51);
            this.btnConfirmCheckIn.TabIndex = 137;
            this.btnConfirmCheckIn.Text = "Confirmar";
            this.btnConfirmCheckIn.UseVisualStyleBackColor = false;
            this.btnConfirmCheckIn.Click += new System.EventHandler(this.btnConfirmCheckIn_Click);
            // 
            // InventaryScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.btnConfirmCheckIn);
            this.Controls.Add(this.txtCodeCheckIn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridCheckIn);
            this.Controls.Add(this.label2);
            this.Name = "InventaryScreen";
            this.Text = "Inventario";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCheckIn)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtCodeCheckIn;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dataGridCheckIn;
        private System.Windows.Forms.Button btnConfirmCheckIn;
    }
}