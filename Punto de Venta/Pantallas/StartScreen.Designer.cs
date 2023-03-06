namespace Punto_de_Venta
{
    partial class DataBaseSelectionForm
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataBaseSelectionForm));
            this.SQLserverDBbuttonProject = new System.Windows.Forms.Button();
            this.CassandraDBProjectButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // SQLserverDBbuttonProject
            // 
            this.SQLserverDBbuttonProject.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.SQLserverDBbuttonProject.Cursor = System.Windows.Forms.Cursors.Hand;
            this.SQLserverDBbuttonProject.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.SQLserverDBbuttonProject.Location = new System.Drawing.Point(196, 385);
            this.SQLserverDBbuttonProject.Name = "SQLserverDBbuttonProject";
            this.SQLserverDBbuttonProject.Size = new System.Drawing.Size(259, 86);
            this.SQLserverDBbuttonProject.TabIndex = 0;
            this.SQLserverDBbuttonProject.Text = "SQL SERVER";
            this.SQLserverDBbuttonProject.UseVisualStyleBackColor = false;
            this.SQLserverDBbuttonProject.Click += new System.EventHandler(this.SQLserverDBbuttonProject_Click);
            // 
            // CassandraDBProjectButton
            // 
            this.CassandraDBProjectButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.CassandraDBProjectButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CassandraDBProjectButton.FlatAppearance.BorderSize = 2;
            this.CassandraDBProjectButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CassandraDBProjectButton.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CassandraDBProjectButton.Location = new System.Drawing.Point(760, 385);
            this.CassandraDBProjectButton.Name = "CassandraDBProjectButton";
            this.CassandraDBProjectButton.Size = new System.Drawing.Size(259, 86);
            this.CassandraDBProjectButton.TabIndex = 1;
            this.CassandraDBProjectButton.Text = "CASSANDRA";
            this.CassandraDBProjectButton.UseVisualStyleBackColor = false;
            this.CassandraDBProjectButton.Click += new System.EventHandler(this.CassandraDBProjectButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(362, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(499, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Elija la base de datos a usar.";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::Punto_de_Venta.Properties.Resources.Cassandra;
            this.pictureBox2.Location = new System.Drawing.Point(800, 184);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(174, 178);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.pictureBox1.Image = global::Punto_de_Venta.Properties.Resources.output_onlinepngtools__2_;
            this.pictureBox1.Location = new System.Drawing.Point(218, 184);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 178);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // DataBaseSelectionForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1184, 631);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CassandraDBProjectButton);
            this.Controls.Add(this.SQLserverDBbuttonProject);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "DataBaseSelectionForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Seleccione la base de datos";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.DataBaseSelectionForm_FormClosed);
            this.Load += new System.EventHandler(this.DataBaseSelectionForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button SQLserverDBbuttonProject;
        private System.Windows.Forms.Button CassandraDBProjectButton;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label1;
    }
}

