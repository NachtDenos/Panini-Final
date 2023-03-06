
namespace Punto_de_Venta
{
    partial class ReturnScreen
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
            this.dataGridReturn1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIdReturn = new System.Windows.Forms.TextBox();
            this.rbYesReturn = new System.Windows.Forms.RadioButton();
            this.rbNoReturn = new System.Windows.Forms.RadioButton();
            this.txtQuantityReturn = new System.Windows.Forms.TextBox();
            this.btnAddReturn = new System.Windows.Forms.Button();
            this.btnOkReturn = new System.Windows.Forms.Button();
            this.btnDeleteReturn = new System.Windows.Forms.Button();
            this.dataGridReturn2 = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtReturnReason = new System.Windows.Forms.TextBox();
            this.filterBtnticket = new System.Windows.Forms.Button();
            this.txtCantidadBorrar = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReturn1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReturn2)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(423, 31);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(332, 56);
            this.label2.TabIndex = 4;
            this.label2.Text = "Devoluciones";
            // 
            // dataGridReturn1
            // 
            this.dataGridReturn1.AllowUserToAddRows = false;
            this.dataGridReturn1.AllowUserToDeleteRows = false;
            this.dataGridReturn1.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridReturn1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReturn1.Location = new System.Drawing.Point(299, 132);
            this.dataGridReturn1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridReturn1.Name = "dataGridReturn1";
            this.dataGridReturn1.ReadOnly = true;
            this.dataGridReturn1.RowHeadersWidth = 51;
            this.dataGridReturn1.Size = new System.Drawing.Size(352, 548);
            this.dataGridReturn1.TabIndex = 5;
            this.dataGridReturn1.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReturn1_CellClick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(16, 311);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(225, 30);
            this.label1.TabIndex = 29;
            this.label1.Text = "Producto Dañado";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 409);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(263, 30);
            this.label3.TabIndex = 30;
            this.label3.Text = "Cantidad a devolver";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(428, 101);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 30);
            this.label4.TabIndex = 32;
            this.label4.Text = "Ticket";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(756, 101);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 30);
            this.label5.TabIndex = 33;
            this.label5.Text = "Devolución";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 154);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(224, 30);
            this.label6.TabIndex = 34;
            this.label6.Text = "Número de Ticket";
            // 
            // txtIdReturn
            // 
            this.txtIdReturn.Location = new System.Drawing.Point(21, 197);
            this.txtIdReturn.Margin = new System.Windows.Forms.Padding(4);
            this.txtIdReturn.Multiline = true;
            this.txtIdReturn.Name = "txtIdReturn";
            this.txtIdReturn.Size = new System.Drawing.Size(220, 26);
            this.txtIdReturn.TabIndex = 35;
            this.txtIdReturn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtIdReturn_KeyPress);
            // 
            // rbYesReturn
            // 
            this.rbYesReturn.AutoSize = true;
            this.rbYesReturn.Location = new System.Drawing.Point(76, 363);
            this.rbYesReturn.Margin = new System.Windows.Forms.Padding(4);
            this.rbYesReturn.Name = "rbYesReturn";
            this.rbYesReturn.Size = new System.Drawing.Size(41, 21);
            this.rbYesReturn.TabIndex = 36;
            this.rbYesReturn.TabStop = true;
            this.rbYesReturn.Text = "Si";
            this.rbYesReturn.UseVisualStyleBackColor = true;
            this.rbYesReturn.Click += new System.EventHandler(this.rbYesReturn_Click);
            // 
            // rbNoReturn
            // 
            this.rbNoReturn.AutoSize = true;
            this.rbNoReturn.Location = new System.Drawing.Point(145, 363);
            this.rbNoReturn.Margin = new System.Windows.Forms.Padding(4);
            this.rbNoReturn.Name = "rbNoReturn";
            this.rbNoReturn.Size = new System.Drawing.Size(47, 21);
            this.rbNoReturn.TabIndex = 37;
            this.rbNoReturn.TabStop = true;
            this.rbNoReturn.Text = "No";
            this.rbNoReturn.UseVisualStyleBackColor = true;
            this.rbNoReturn.Click += new System.EventHandler(this.rbNoReturn_Click);
            // 
            // txtQuantityReturn
            // 
            this.txtQuantityReturn.Location = new System.Drawing.Point(21, 455);
            this.txtQuantityReturn.Margin = new System.Windows.Forms.Padding(4);
            this.txtQuantityReturn.Multiline = true;
            this.txtQuantityReturn.Name = "txtQuantityReturn";
            this.txtQuantityReturn.Size = new System.Drawing.Size(220, 26);
            this.txtQuantityReturn.TabIndex = 38;
            this.txtQuantityReturn.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantityReturn_KeyPress);
            // 
            // btnAddReturn
            // 
            this.btnAddReturn.BackColor = System.Drawing.Color.Navy;
            this.btnAddReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReturn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddReturn.Location = new System.Drawing.Point(21, 700);
            this.btnAddReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddReturn.Name = "btnAddReturn";
            this.btnAddReturn.Size = new System.Drawing.Size(164, 62);
            this.btnAddReturn.TabIndex = 51;
            this.btnAddReturn.Text = "Devolver";
            this.btnAddReturn.UseVisualStyleBackColor = false;
            this.btnAddReturn.Click += new System.EventHandler(this.btnAddReturn_Click);
            // 
            // btnOkReturn
            // 
            this.btnOkReturn.BackColor = System.Drawing.Color.Green;
            this.btnOkReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnOkReturn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnOkReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnOkReturn.Location = new System.Drawing.Point(1057, 700);
            this.btnOkReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnOkReturn.Name = "btnOkReturn";
            this.btnOkReturn.Size = new System.Drawing.Size(172, 62);
            this.btnOkReturn.TabIndex = 52;
            this.btnOkReturn.Text = "Confirmar";
            this.btnOkReturn.UseVisualStyleBackColor = false;
            this.btnOkReturn.Click += new System.EventHandler(this.btnOkReturn_Click);
            // 
            // btnDeleteReturn
            // 
            this.btnDeleteReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btnDeleteReturn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDeleteReturn.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReturn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnDeleteReturn.Location = new System.Drawing.Point(749, 700);
            this.btnDeleteReturn.Margin = new System.Windows.Forms.Padding(4);
            this.btnDeleteReturn.Name = "btnDeleteReturn";
            this.btnDeleteReturn.Size = new System.Drawing.Size(172, 62);
            this.btnDeleteReturn.TabIndex = 53;
            this.btnDeleteReturn.Text = "Cancelar Producto";
            this.btnDeleteReturn.UseVisualStyleBackColor = false;
            this.btnDeleteReturn.Click += new System.EventHandler(this.btnDeleteReturn_Click);
            // 
            // dataGridReturn2
            // 
            this.dataGridReturn2.AllowUserToAddRows = false;
            this.dataGridReturn2.AllowUserToDeleteRows = false;
            this.dataGridReturn2.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.dataGridReturn2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridReturn2.Location = new System.Drawing.Point(659, 132);
            this.dataGridReturn2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridReturn2.Name = "dataGridReturn2";
            this.dataGridReturn2.ReadOnly = true;
            this.dataGridReturn2.RowHeadersWidth = 51;
            this.dataGridReturn2.Size = new System.Drawing.Size(352, 548);
            this.dataGridReturn2.TabIndex = 31;
            this.dataGridReturn2.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridReturn2_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(20, 496);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 30);
            this.label7.TabIndex = 54;
            this.label7.Text = "Motivo";
            // 
            // txtReturnReason
            // 
            this.txtReturnReason.Location = new System.Drawing.Point(21, 541);
            this.txtReturnReason.Margin = new System.Windows.Forms.Padding(4);
            this.txtReturnReason.Multiline = true;
            this.txtReturnReason.Name = "txtReturnReason";
            this.txtReturnReason.Size = new System.Drawing.Size(220, 26);
            this.txtReturnReason.TabIndex = 55;
            this.txtReturnReason.Text = "Ponga el motivo";
            // 
            // filterBtnticket
            // 
            this.filterBtnticket.BackColor = System.Drawing.Color.Navy;
            this.filterBtnticket.Cursor = System.Windows.Forms.Cursors.Hand;
            this.filterBtnticket.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filterBtnticket.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.filterBtnticket.Location = new System.Drawing.Point(53, 231);
            this.filterBtnticket.Margin = new System.Windows.Forms.Padding(4);
            this.filterBtnticket.Name = "filterBtnticket";
            this.filterBtnticket.Size = new System.Drawing.Size(164, 62);
            this.filterBtnticket.TabIndex = 56;
            this.filterBtnticket.Text = "Buscar";
            this.filterBtnticket.UseVisualStyleBackColor = false;
            this.filterBtnticket.Click += new System.EventHandler(this.filterBtnticket_Click);
            // 
            // txtCantidadBorrar
            // 
            this.txtCantidadBorrar.Location = new System.Drawing.Point(1019, 496);
            this.txtCantidadBorrar.Margin = new System.Windows.Forms.Padding(4);
            this.txtCantidadBorrar.Multiline = true;
            this.txtCantidadBorrar.Name = "txtCantidadBorrar";
            this.txtCantidadBorrar.Size = new System.Drawing.Size(220, 26);
            this.txtCantidadBorrar.TabIndex = 57;
            this.txtCantidadBorrar.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(1014, 455);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(252, 30);
            this.label8.TabIndex = 58;
            this.label8.Text = "Cantidad a eliminar";
            // 
            // ReturnScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(1267, 777);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtCantidadBorrar);
            this.Controls.Add(this.filterBtnticket);
            this.Controls.Add(this.txtReturnReason);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnDeleteReturn);
            this.Controls.Add(this.btnOkReturn);
            this.Controls.Add(this.btnAddReturn);
            this.Controls.Add(this.txtQuantityReturn);
            this.Controls.Add(this.rbNoReturn);
            this.Controls.Add(this.rbYesReturn);
            this.Controls.Add(this.txtIdReturn);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridReturn2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridReturn1);
            this.Controls.Add(this.label2);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "ReturnScreen";
            this.Text = "ReturnScreen";
            this.Load += new System.EventHandler(this.ReturnScreen_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReturn1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridReturn2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dataGridReturn1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIdReturn;
        private System.Windows.Forms.RadioButton rbYesReturn;
        private System.Windows.Forms.RadioButton rbNoReturn;
        private System.Windows.Forms.TextBox txtQuantityReturn;
        private System.Windows.Forms.Button btnAddReturn;
        private System.Windows.Forms.Button btnOkReturn;
        private System.Windows.Forms.Button btnDeleteReturn;
        private System.Windows.Forms.DataGridView dataGridReturn2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtReturnReason;
        private System.Windows.Forms.Button filterBtnticket;
        private System.Windows.Forms.TextBox txtCantidadBorrar;
        private System.Windows.Forms.Label label8;
    }
}