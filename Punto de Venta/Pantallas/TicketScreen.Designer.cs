
namespace Punto_de_Venta
{
    partial class ticketScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ticketScreen));
            this.btnPrintTicket = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pbTicketSell = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbTicketSell)).BeginInit();
            this.SuspendLayout();
            // 
            // btnPrintTicket
            // 
            this.btnPrintTicket.BackColor = System.Drawing.Color.Green;
            this.btnPrintTicket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintTicket.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintTicket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrintTicket.Location = new System.Drawing.Point(472, 530);
            this.btnPrintTicket.Name = "btnPrintTicket";
            this.btnPrintTicket.Size = new System.Drawing.Size(111, 44);
            this.btnPrintTicket.TabIndex = 43;
            this.btnPrintTicket.Text = "Imprimir";
            this.btnPrintTicket.UseVisualStyleBackColor = false;
            this.btnPrintTicket.Click += new System.EventHandler(this.btnPrintTicket_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(229, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(125, 44);
            this.label1.TabIndex = 44;
            this.label1.Text = "Ticket";
            // 
            // pbTicketSell
            // 
            this.pbTicketSell.Image = global::Punto_de_Venta.Properties.Resources.EjemploTicket;
            this.pbTicketSell.Location = new System.Drawing.Point(73, 56);
            this.pbTicketSell.Name = "pbTicketSell";
            this.pbTicketSell.Size = new System.Drawing.Size(447, 459);
            this.pbTicketSell.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbTicketSell.TabIndex = 45;
            this.pbTicketSell.TabStop = false;
            // 
            // ticketScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(595, 586);
            this.Controls.Add(this.pbTicketSell);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintTicket);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ticketScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ticket";
            ((System.ComponentModel.ISupportInitialize)(this.pbTicketSell)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnPrintTicket;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbTicketSell;
    }
}