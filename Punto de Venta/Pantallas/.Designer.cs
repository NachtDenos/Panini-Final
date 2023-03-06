
namespace Punto_de_Venta
{
    partial class departamentScreen
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
            this.txtFilterDepartament = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.dataGridDepartament = new System.Windows.Forms.DataGridView();
            this.btnDeleteDepartament = new System.Windows.Forms.Button();
            this.btnEditDepartament = new System.Windows.Forms.Button();
            this.btnAddDepartament = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNameDepartament = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtIdDepartament = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbDevolutionDepartament = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDepartament)).BeginInit();
            this.SuspendLayout();
            // 
            // txtFilterDepartament
            // 
            this.txtFilterDepartament.Location = new System.Drawing.Point(86, 559);
            this.txtFilterDepartament.Multiline = true;
            this.txtFilterDepartament.Name = "txtFilterDepartament";
            this.txtFilterDepartament.Size = new System.Drawing.Size(241, 22);
            this.txtFilterDepartament.TabIndex = 79;
            this.txtFilterDepartament.TextChanged += new System.EventHandler(this.txtFilterDepartament_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(25, 559);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(55, 22);
            this.label12.TabIndex = 78;
            this.label12.Text = "Filtro:";
            // 
            // dataGridDepartament
            // 
            this.dataGridDepartament.AllowUserToAddRows = false;
            this.dataGridDepartament.AllowUserToDeleteRows = false;
            this.dataGridDepartament.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridDepartament.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridDepartament.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridDepartament.Location = new System.Drawing.Point(26, 245);
            this.dataGridDepartament.Name = "dataGridDepartament";
            this.dataGridDepartament.ReadOnly = true;
            this.dataGridDepartament.RowHeadersWidth = 51;
            this.dataGridDepartament.Size = new System.Drawing.Size(493, 291);
            this.dataGridDepartament.TabIndex = 77;
            this.dataGridDepartament.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridDepartament_CellClick);
            // 
            // btnDeleteDepartament
            // 
            this.btnDeleteDepartament.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteDepartament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteDepartament.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteDepartament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteDepartament.Location = new System.Drawing.Point(767, 546);
            this.btnDeleteDepartament.Name = "btnDeleteDepartament";
            this.btnDeleteDepartament.Size = new System.Drawing.Size(139, 51);
            this.btnDeleteDepartament.TabIndex = 76;
            this.btnDeleteDepartament.Text = "Eliminar";
            this.btnDeleteDepartament.UseVisualStyleBackColor = false;
            this.btnDeleteDepartament.Click += new System.EventHandler(this.btnDeleteDepartament_Click);
            // 
            // btnEditDepartament
            // 
            this.btnEditDepartament.BackColor = System.Drawing.Color.Navy;
            this.btnEditDepartament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditDepartament.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditDepartament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnEditDepartament.Location = new System.Drawing.Point(612, 546);
            this.btnEditDepartament.Name = "btnEditDepartament";
            this.btnEditDepartament.Size = new System.Drawing.Size(139, 51);
            this.btnEditDepartament.TabIndex = 75;
            this.btnEditDepartament.Text = "Editar";
            this.btnEditDepartament.UseVisualStyleBackColor = false;
            this.btnEditDepartament.Click += new System.EventHandler(this.btnEditDepartament_Click);
            // 
            // btnAddDepartament
            // 
            this.btnAddDepartament.BackColor = System.Drawing.Color.Green;
            this.btnAddDepartament.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDepartament.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddDepartament.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddDepartament.Location = new System.Drawing.Point(454, 546);
            this.btnAddDepartament.Name = "btnAddDepartament";
            this.btnAddDepartament.Size = new System.Drawing.Size(139, 51);
            this.btnAddDepartament.TabIndex = 74;
            this.btnAddDepartament.Text = "Agregar";
            this.btnAddDepartament.UseVisualStyleBackColor = false;
            this.btnAddDepartament.Click += new System.EventHandler(this.btnAddDepartament_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(324, 28);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 44);
            this.label2.TabIndex = 61;
            this.label2.Text = "Departamentos";
            // 
            // txtNameDepartament
            // 
            this.txtNameDepartament.Location = new System.Drawing.Point(36, 123);
            this.txtNameDepartament.Multiline = true;
            this.txtNameDepartament.Name = "txtNameDepartament";
            this.txtNameDepartament.Size = new System.Drawing.Size(291, 22);
            this.txtNameDepartament.TabIndex = 60;
            this.txtNameDepartament.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNameDepartament_KeyPress);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 98);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 22);
            this.label1.TabIndex = 59;
            this.label1.Text = "Nombre";
            // 
            // txtIdDepartament
            // 
            this.txtIdDepartament.Location = new System.Drawing.Point(36, 201);
            this.txtIdDepartament.Multiline = true;
            this.txtIdDepartament.Name = "txtIdDepartament";
            this.txtIdDepartament.Size = new System.Drawing.Size(291, 22);
            this.txtIdDepartament.TabIndex = 81;
            this.txtIdDepartament.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdDepartament_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(241, 22);
            this.label3.TabIndex = 80;
            this.label3.Text = "Clave del departamento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(385, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(115, 22);
            this.label4.TabIndex = 82;
            this.label4.Text = "Devolución";
            // 
            // cbDevolutionDepartament
            // 
            this.cbDevolutionDepartament.FormattingEnabled = true;
            this.cbDevolutionDepartament.Items.AddRange(new object[] {
            "Si",
            "No"});
            this.cbDevolutionDepartament.Location = new System.Drawing.Point(389, 123);
            this.cbDevolutionDepartament.Name = "cbDevolutionDepartament";
            this.cbDevolutionDepartament.Size = new System.Drawing.Size(209, 21);
            this.cbDevolutionDepartament.TabIndex = 83;
            this.cbDevolutionDepartament.Text = "Seleccione";
            this.cbDevolutionDepartament.SelectedIndexChanged += new System.EventHandler(this.cbDevolutionDepartament_SelectedIndexChanged);
            // 
            // departamentScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.cbDevolutionDepartament);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtIdDepartament);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtFilterDepartament);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.dataGridDepartament);
            this.Controls.Add(this.btnDeleteDepartament);
            this.Controls.Add(this.btnEditDepartament);
            this.Controls.Add(this.btnAddDepartament);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtNameDepartament);
            this.Controls.Add(this.label1);
            this.Name = "departamentScreen";
            this.Text = "Departament";
            this.Load += new System.EventHandler(this.departamentScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridDepartament)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtFilterDepartament;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.DataGridView dataGridDepartament;
        private System.Windows.Forms.Button btnDeleteDepartament;
        private System.Windows.Forms.Button btnEditDepartament;
        private System.Windows.Forms.Button btnAddDepartament;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtNameDepartament;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIdDepartament;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbDevolutionDepartament;
    }
}