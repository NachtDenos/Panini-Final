
namespace Punto_de_Venta
{
    partial class CashRegisterScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CashRegisterScreen));
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridCashRegister = new System.Windows.Forms.DataGridView();
            this.btnDeleteCashRegister = new System.Windows.Forms.Button();
            this.btnEditCashRegister = new System.Windows.Forms.Button();
            this.btnAddCashResgister = new System.Windows.Forms.Button();
            this.txtIdCashRegister = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbCashRegister = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCashRegister)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 44);
            this.label2.TabIndex = 5;
            this.label2.Text = "Cajas";
            // 
            // dataGridCashRegister
            // 
            this.dataGridCashRegister.AllowUserToAddRows = false;
            this.dataGridCashRegister.AllowUserToDeleteRows = false;
            this.dataGridCashRegister.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridCashRegister.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridCashRegister.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCashRegister.Location = new System.Drawing.Point(246, 278);
            this.dataGridCashRegister.Name = "dataGridCashRegister";
            this.dataGridCashRegister.ReadOnly = true;
            this.dataGridCashRegister.RowHeadersWidth = 51;
            this.dataGridCashRegister.Size = new System.Drawing.Size(456, 241);
            this.dataGridCashRegister.TabIndex = 51;
            this.dataGridCashRegister.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCashRegister_CellClick);
            // 
            // btnDeleteCashRegister
            // 
            this.btnDeleteCashRegister.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteCashRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteCashRegister.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteCashRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteCashRegister.Location = new System.Drawing.Point(563, 543);
            this.btnDeleteCashRegister.Name = "btnDeleteCashRegister";
            this.btnDeleteCashRegister.Size = new System.Drawing.Size(139, 51);
            this.btnDeleteCashRegister.TabIndex = 50;
            this.btnDeleteCashRegister.Text = "Eliminar";
            this.btnDeleteCashRegister.UseVisualStyleBackColor = false;
            this.btnDeleteCashRegister.Click += new System.EventHandler(this.btnDeleteCashRegister_Click);
            // 
            // btnEditCashRegister
            // 
            this.btnEditCashRegister.BackColor = System.Drawing.Color.Navy;
            this.btnEditCashRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditCashRegister.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditCashRegister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditCashRegister.Location = new System.Drawing.Point(402, 543);
            this.btnEditCashRegister.Name = "btnEditCashRegister";
            this.btnEditCashRegister.Size = new System.Drawing.Size(139, 51);
            this.btnEditCashRegister.TabIndex = 49;
            this.btnEditCashRegister.Text = "Editar";
            this.btnEditCashRegister.UseVisualStyleBackColor = false;
            this.btnEditCashRegister.Click += new System.EventHandler(this.btnEditCashRegister_Click);
            // 
            // btnAddCashResgister
            // 
            this.btnAddCashResgister.BackColor = System.Drawing.Color.Green;
            this.btnAddCashResgister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddCashResgister.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddCashResgister.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddCashResgister.Location = new System.Drawing.Point(246, 543);
            this.btnAddCashResgister.Name = "btnAddCashResgister";
            this.btnAddCashResgister.Size = new System.Drawing.Size(139, 51);
            this.btnAddCashResgister.TabIndex = 48;
            this.btnAddCashResgister.Text = "Agregar";
            this.btnAddCashResgister.UseVisualStyleBackColor = false;
            this.btnAddCashResgister.Click += new System.EventHandler(this.btnAddCashResgister_Click);
            // 
            // txtIdCashRegister
            // 
            this.txtIdCashRegister.Location = new System.Drawing.Point(340, 149);
            this.txtIdCashRegister.Multiline = true;
            this.txtIdCashRegister.Name = "txtIdCashRegister";
            this.txtIdCashRegister.Size = new System.Drawing.Size(253, 22);
            this.txtIdCashRegister.TabIndex = 29;
            this.txtIdCashRegister.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdCashRegister_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(382, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 22);
            this.label1.TabIndex = 28;
            this.label1.Text = "Número de caja";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(398, 185);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(135, 22);
            this.label3.TabIndex = 52;
            this.label3.Text = "Disponibilidad";
            // 
            // cbCashRegister
            // 
            this.cbCashRegister.FormattingEnabled = true;
            this.cbCashRegister.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.cbCashRegister.Location = new System.Drawing.Point(340, 227);
            this.cbCashRegister.Name = "cbCashRegister";
            this.cbCashRegister.Size = new System.Drawing.Size(253, 21);
            this.cbCashRegister.TabIndex = 53;
            this.cbCashRegister.Text = "Seleccione";
            this.cbCashRegister.SelectedIndexChanged += new System.EventHandler(this.cbCashRegister_SelectedIndexChanged);
            // 
            // CashRegisterScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.cbCashRegister);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dataGridCashRegister);
            this.Controls.Add(this.btnDeleteCashRegister);
            this.Controls.Add(this.btnEditCashRegister);
            this.Controls.Add(this.btnAddCashResgister);
            this.Controls.Add(this.txtIdCashRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CashRegisterScreen";
            this.Text = "CashRegisterScreen";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCashRegister)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridCashRegister;
        private System.Windows.Forms.Button btnDeleteCashRegister;
        private System.Windows.Forms.Button btnEditCashRegister;
        private System.Windows.Forms.Button btnAddCashResgister;
        private System.Windows.Forms.TextBox txtIdCashRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbCashRegister;
    }
}