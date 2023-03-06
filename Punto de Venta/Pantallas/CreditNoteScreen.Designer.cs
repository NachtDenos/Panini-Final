
namespace Punto_de_Venta
{
    partial class CreditNoteScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreditNoteScreen));
            this.label1 = new System.Windows.Forms.Label();
            this.btnPrintCredit = new System.Windows.Forms.Button();
            this.pbNote = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pbNote)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(157, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(307, 44);
            this.label1.TabIndex = 47;
            this.label1.Text = "Nota de Crédito";
            // 
            // btnPrintCredit
            // 
            this.btnPrintCredit.BackColor = System.Drawing.Color.Green;
            this.btnPrintCredit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPrintCredit.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrintCredit.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnPrintCredit.Location = new System.Drawing.Point(473, 536);
            this.btnPrintCredit.Name = "btnPrintCredit";
            this.btnPrintCredit.Size = new System.Drawing.Size(111, 44);
            this.btnPrintCredit.TabIndex = 46;
            this.btnPrintCredit.Text = "Imprimir";
            this.btnPrintCredit.UseVisualStyleBackColor = false;
            this.btnPrintCredit.Click += new System.EventHandler(this.btnPrintCredit_Click);
            // 
            // pbNote
            // 
            this.pbNote.Image = global::Punto_de_Venta.Properties.Resources.EjemploTicket;
            this.pbNote.Location = new System.Drawing.Point(61, 56);
            this.pbNote.Name = "pbNote";
            this.pbNote.Size = new System.Drawing.Size(493, 474);
            this.pbNote.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbNote.TabIndex = 48;
            this.pbNote.TabStop = false;
            // 
            // CreditNoteScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(595, 586);
            this.Controls.Add(this.pbNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnPrintCredit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CreditNoteScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nota de Crédito";
            ((System.ComponentModel.ISupportInitialize)(this.pbNote)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnPrintCredit;
        private System.Windows.Forms.PictureBox pbNote;
    }
}