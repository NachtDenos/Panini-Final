
namespace Punto_de_Venta
{
    partial class QuickSearchScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(QuickSearchScreen));
            this.dataGridQuickSearch = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdCashRegister = new System.Windows.Forms.TextBox();
            this.txtNameQuickSearch = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFilterQuickSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuickSearch)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridQuickSearch
            // 
            this.dataGridQuickSearch.AllowUserToAddRows = false;
            this.dataGridQuickSearch.AllowUserToDeleteRows = false;
            this.dataGridQuickSearch.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridQuickSearch.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridQuickSearch.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridQuickSearch.Location = new System.Drawing.Point(236, 85);
            this.dataGridQuickSearch.Name = "dataGridQuickSearch";
            this.dataGridQuickSearch.ReadOnly = true;
            this.dataGridQuickSearch.Size = new System.Drawing.Size(326, 458);
            this.dataGridQuickSearch.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(128, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(313, 44);
            this.label2.TabIndex = 6;
            this.label2.Text = "Consulta Rápida";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 22);
            this.label1.TabIndex = 29;
            this.label1.Text = "Código del artículo";
            // 
            // txtIdCashRegister
            // 
            this.txtIdCashRegister.Location = new System.Drawing.Point(16, 120);
            this.txtIdCashRegister.Multiline = true;
            this.txtIdCashRegister.Name = "txtIdCashRegister";
            this.txtIdCashRegister.Size = new System.Drawing.Size(194, 22);
            this.txtIdCashRegister.TabIndex = 30;
            this.txtIdCashRegister.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCashRegister_KeyPress);
            // 
            // txtNameQuickSearch
            // 
            this.txtNameQuickSearch.Location = new System.Drawing.Point(16, 196);
            this.txtNameQuickSearch.Multiline = true;
            this.txtNameQuickSearch.Name = "txtNameQuickSearch";
            this.txtNameQuickSearch.Size = new System.Drawing.Size(194, 22);
            this.txtNameQuickSearch.TabIndex = 32;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 22);
            this.label3.TabIndex = 31;
            this.label3.Text = "Nombre del artículo";
            // 
            // btnFilterQuickSearch
            // 
            this.btnFilterQuickSearch.BackColor = System.Drawing.Color.Navy;
            this.btnFilterQuickSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFilterQuickSearch.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFilterQuickSearch.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnFilterQuickSearch.Location = new System.Drawing.Point(44, 492);
            this.btnFilterQuickSearch.Name = "btnFilterQuickSearch";
            this.btnFilterQuickSearch.Size = new System.Drawing.Size(139, 51);
            this.btnFilterQuickSearch.TabIndex = 33;
            this.btnFilterQuickSearch.Text = "Filtrar";
            this.btnFilterQuickSearch.UseVisualStyleBackColor = false;
            this.btnFilterQuickSearch.Click += new System.EventHandler(this.btnFilterQuickSearch_Click);
            // 
            // QuickSearchScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(595, 586);
            this.Controls.Add(this.btnFilterQuickSearch);
            this.Controls.Add(this.txtNameQuickSearch);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIdCashRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridQuickSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "QuickSearchScreen";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Consulta rápida";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridQuickSearch)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridQuickSearch;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdCashRegister;
        private System.Windows.Forms.TextBox txtNameQuickSearch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFilterQuickSearch;
    }
}