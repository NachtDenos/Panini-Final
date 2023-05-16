
namespace Punto_de_Venta
{
    partial class SalesScreen
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
            this.label8 = new System.Windows.Forms.Label();
            this.dataGridCustomerRe = new System.Windows.Forms.DataGridView();
            this.btnConfirmReser = new System.Windows.Forms.Button();
            this.txtCustomerReservation = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridHotelRe = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cbCityReservations = new System.Windows.Forms.ComboBox();
            this.dataGridRoomsRe = new System.Windows.Forms.DataGridView();
            this.dataGridRoomsChosenRe = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPeopleReservations = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnSelectReservation = new System.Windows.Forms.Button();
            this.btnAddReser = new System.Windows.Forms.Button();
            this.dtpLodgingReser = new System.Windows.Forms.DateTimePicker();
            this.dtpLodgingReser2 = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.rbDebitCardPayRe = new System.Windows.Forms.CheckBox();
            this.rbCreditCardPayRe = new System.Windows.Forms.CheckBox();
            this.txtCreditCardPayRe = new System.Windows.Forms.TextBox();
            this.txtDebitCardPayRe = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.rbTransferPayRe = new System.Windows.Forms.CheckBox();
            this.txtTransferPayRe = new System.Windows.Forms.TextBox();
            this.btnSelectCityReservation = new System.Windows.Forms.Button();
            this.btnSearchNameReservation = new System.Windows.Forms.Button();
            this.btnSearchRFCReservation = new System.Windows.Forms.Button();
            this.btnSearchEmailReservation = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomerRe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHotelRe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoomsRe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoomsChosenRe)).BeginInit();
            this.SuspendLayout();
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Century Gothic", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(545, 9);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(281, 44);
            this.label8.TabIndex = 38;
            this.label8.Text = "Reservaciones";
            // 
            // dataGridCustomerRe
            // 
            this.dataGridCustomerRe.AllowUserToAddRows = false;
            this.dataGridCustomerRe.AllowUserToDeleteRows = false;
            this.dataGridCustomerRe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridCustomerRe.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridCustomerRe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridCustomerRe.Location = new System.Drawing.Point(14, 79);
            this.dataGridCustomerRe.Name = "dataGridCustomerRe";
            this.dataGridCustomerRe.ReadOnly = true;
            this.dataGridCustomerRe.RowHeadersWidth = 51;
            this.dataGridCustomerRe.Size = new System.Drawing.Size(436, 96);
            this.dataGridCustomerRe.TabIndex = 59;
            this.dataGridCustomerRe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridCustomerRe_CellClick);
            // 
            // btnConfirmReser
            // 
            this.btnConfirmReser.BackColor = System.Drawing.Color.Green;
            this.btnConfirmReser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConfirmReser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmReser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnConfirmReser.Location = new System.Drawing.Point(783, 568);
            this.btnConfirmReser.Name = "btnConfirmReser";
            this.btnConfirmReser.Size = new System.Drawing.Size(139, 51);
            this.btnConfirmReser.TabIndex = 56;
            this.btnConfirmReser.Text = "Confirmar";
            this.btnConfirmReser.UseVisualStyleBackColor = false;
            this.btnConfirmReser.Click += new System.EventHandler(this.btnAddEmployees_Click);
            // 
            // txtCustomerReservation
            // 
            this.txtCustomerReservation.Location = new System.Drawing.Point(84, 41);
            this.txtCustomerReservation.Multiline = true;
            this.txtCustomerReservation.Name = "txtCustomerReservation";
            this.txtCustomerReservation.Size = new System.Drawing.Size(154, 22);
            this.txtCustomerReservation.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 22);
            this.label2.TabIndex = 39;
            this.label2.Text = "Cliente";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(466, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 22);
            this.label1.TabIndex = 60;
            this.label1.Text = "Ciudad a visitar";
            // 
            // dataGridHotelRe
            // 
            this.dataGridHotelRe.AllowUserToAddRows = false;
            this.dataGridHotelRe.AllowUserToDeleteRows = false;
            this.dataGridHotelRe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridHotelRe.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridHotelRe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridHotelRe.Location = new System.Drawing.Point(14, 205);
            this.dataGridHotelRe.Name = "dataGridHotelRe";
            this.dataGridHotelRe.ReadOnly = true;
            this.dataGridHotelRe.RowHeadersWidth = 51;
            this.dataGridHotelRe.Size = new System.Drawing.Size(436, 113);
            this.dataGridHotelRe.TabIndex = 65;
            this.dataGridHotelRe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridHotelRe_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(192, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 63;
            this.label3.Text = "Hoteles";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(176, 357);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 22);
            this.label4.TabIndex = 66;
            this.label4.Text = "Habitaciones";
            // 
            // cbCityReservations
            // 
            this.cbCityReservations.FormattingEnabled = true;
            this.cbCityReservations.Items.AddRange(new object[] {
            "Cancun",
            "Monterrey",
            "CDMX",
            "Guadalajara",
            "Apodaca"});
            this.cbCityReservations.Location = new System.Drawing.Point(626, 70);
            this.cbCityReservations.Name = "cbCityReservations";
            this.cbCityReservations.Size = new System.Drawing.Size(273, 21);
            this.cbCityReservations.TabIndex = 114;
            this.cbCityReservations.Text = "Seleccionar";
            this.cbCityReservations.SelectedIndexChanged += new System.EventHandler(this.cbCityReservations_SelectedIndexChanged);
            // 
            // dataGridRoomsRe
            // 
            this.dataGridRoomsRe.AllowUserToAddRows = false;
            this.dataGridRoomsRe.AllowUserToDeleteRows = false;
            this.dataGridRoomsRe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridRoomsRe.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridRoomsRe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRoomsRe.Location = new System.Drawing.Point(12, 382);
            this.dataGridRoomsRe.Name = "dataGridRoomsRe";
            this.dataGridRoomsRe.ReadOnly = true;
            this.dataGridRoomsRe.RowHeadersWidth = 51;
            this.dataGridRoomsRe.Size = new System.Drawing.Size(436, 111);
            this.dataGridRoomsRe.TabIndex = 115;
            this.dataGridRoomsRe.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridRoomsRe_CellClick);
            // 
            // dataGridRoomsChosenRe
            // 
            this.dataGridRoomsChosenRe.AllowUserToAddRows = false;
            this.dataGridRoomsChosenRe.AllowUserToDeleteRows = false;
            this.dataGridRoomsChosenRe.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridRoomsChosenRe.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridRoomsChosenRe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRoomsChosenRe.Location = new System.Drawing.Point(463, 259);
            this.dataGridRoomsChosenRe.Name = "dataGridRoomsChosenRe";
            this.dataGridRoomsChosenRe.ReadOnly = true;
            this.dataGridRoomsChosenRe.RowHeadersWidth = 51;
            this.dataGridRoomsChosenRe.Size = new System.Drawing.Size(436, 200);
            this.dataGridRoomsChosenRe.TabIndex = 116;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(583, 234);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(211, 22);
            this.label5.TabIndex = 117;
            this.label5.Text = "Habitaciones elegidas";
            // 
            // txtPeopleReservations
            // 
            this.txtPeopleReservations.Location = new System.Drawing.Point(229, 496);
            this.txtPeopleReservations.Multiline = true;
            this.txtPeopleReservations.Name = "txtPeopleReservations";
            this.txtPeopleReservations.Size = new System.Drawing.Size(219, 22);
            this.txtPeopleReservations.TabIndex = 119;
            this.txtPeopleReservations.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPeopleReservations_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 496);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(216, 22);
            this.label6.TabIndex = 118;
            this.label6.Text = "Cantidad de personas";
            // 
            // btnSelectReservation
            // 
            this.btnSelectReservation.BackColor = System.Drawing.Color.Navy;
            this.btnSelectReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectReservation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectReservation.Location = new System.Drawing.Point(169, 324);
            this.btnSelectReservation.Name = "btnSelectReservation";
            this.btnSelectReservation.Size = new System.Drawing.Size(116, 29);
            this.btnSelectReservation.TabIndex = 158;
            this.btnSelectReservation.Text = "Seleccionar";
            this.btnSelectReservation.UseVisualStyleBackColor = false;
            this.btnSelectReservation.Click += new System.EventHandler(this.btnSelectReservation_Click);
            // 
            // btnAddReser
            // 
            this.btnAddReser.BackColor = System.Drawing.Color.Navy;
            this.btnAddReser.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddReser.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReser.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnAddReser.Location = new System.Drawing.Point(184, 531);
            this.btnAddReser.Name = "btnAddReser";
            this.btnAddReser.Size = new System.Drawing.Size(101, 29);
            this.btnAddReser.TabIndex = 160;
            this.btnAddReser.Text = "Agregar";
            this.btnAddReser.UseVisualStyleBackColor = false;
            this.btnAddReser.Click += new System.EventHandler(this.btnAddReser_Click);
            // 
            // dtpLodgingReser
            // 
            this.dtpLodgingReser.CustomFormat = "yyyy-MM-dd";
            this.dtpLodgingReser.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLodgingReser.Location = new System.Drawing.Point(511, 143);
            this.dtpLodgingReser.Name = "dtpLodgingReser";
            this.dtpLodgingReser.Size = new System.Drawing.Size(146, 20);
            this.dtpLodgingReser.TabIndex = 161;
            // 
            // dtpLodgingReser2
            // 
            this.dtpLodgingReser2.CustomFormat = "yyyy-MM-dd";
            this.dtpLodgingReser2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpLodgingReser2.Location = new System.Drawing.Point(703, 143);
            this.dtpLodgingReser2.Name = "dtpLodgingReser2";
            this.dtpLodgingReser2.Size = new System.Drawing.Size(146, 20);
            this.dtpLodgingReser2.TabIndex = 162;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(574, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(207, 22);
            this.label7.TabIndex = 163;
            this.label7.Text = "Tiempo de hospedaje";
            // 
            // rbDebitCardPayRe
            // 
            this.rbDebitCardPayRe.AutoSize = true;
            this.rbDebitCardPayRe.Location = new System.Drawing.Point(629, 496);
            this.rbDebitCardPayRe.Name = "rbDebitCardPayRe";
            this.rbDebitCardPayRe.Size = new System.Drawing.Size(108, 17);
            this.rbDebitCardPayRe.TabIndex = 168;
            this.rbDebitCardPayRe.Text = "Tarjeta de Débito";
            this.rbDebitCardPayRe.UseVisualStyleBackColor = true;
            this.rbDebitCardPayRe.Click += new System.EventHandler(this.rbDebitCardPayRe_Click);
            // 
            // rbCreditCardPayRe
            // 
            this.rbCreditCardPayRe.AutoSize = true;
            this.rbCreditCardPayRe.Location = new System.Drawing.Point(500, 495);
            this.rbCreditCardPayRe.Name = "rbCreditCardPayRe";
            this.rbCreditCardPayRe.Size = new System.Drawing.Size(110, 17);
            this.rbCreditCardPayRe.TabIndex = 167;
            this.rbCreditCardPayRe.Text = "Tarjeta de Crédito";
            this.rbCreditCardPayRe.UseVisualStyleBackColor = true;
            this.rbCreditCardPayRe.Click += new System.EventHandler(this.rbCreditCardPayRe_Click);
            // 
            // txtCreditCardPayRe
            // 
            this.txtCreditCardPayRe.Location = new System.Drawing.Point(503, 518);
            this.txtCreditCardPayRe.Multiline = true;
            this.txtCreditCardPayRe.Name = "txtCreditCardPayRe";
            this.txtCreditCardPayRe.Size = new System.Drawing.Size(107, 22);
            this.txtCreditCardPayRe.TabIndex = 166;
            this.txtCreditCardPayRe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCreditCardPayRe_KeyPress);
            // 
            // txtDebitCardPayRe
            // 
            this.txtDebitCardPayRe.Location = new System.Drawing.Point(629, 518);
            this.txtDebitCardPayRe.Multiline = true;
            this.txtDebitCardPayRe.Name = "txtDebitCardPayRe";
            this.txtDebitCardPayRe.Size = new System.Drawing.Size(108, 22);
            this.txtDebitCardPayRe.TabIndex = 165;
            this.txtDebitCardPayRe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDebitCardPayRe_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(542, 462);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(282, 22);
            this.label9.TabIndex = 164;
            this.label9.Text = "Método de pago del anticipo";
            // 
            // rbTransferPayRe
            // 
            this.rbTransferPayRe.AutoSize = true;
            this.rbTransferPayRe.Location = new System.Drawing.Point(758, 496);
            this.rbTransferPayRe.Name = "rbTransferPayRe";
            this.rbTransferPayRe.Size = new System.Drawing.Size(91, 17);
            this.rbTransferPayRe.TabIndex = 170;
            this.rbTransferPayRe.Text = "Transferencia";
            this.rbTransferPayRe.UseVisualStyleBackColor = true;
            this.rbTransferPayRe.Click += new System.EventHandler(this.rbTransferPayRe_Click);
            // 
            // txtTransferPayRe
            // 
            this.txtTransferPayRe.Location = new System.Drawing.Point(758, 518);
            this.txtTransferPayRe.Multiline = true;
            this.txtTransferPayRe.Name = "txtTransferPayRe";
            this.txtTransferPayRe.Size = new System.Drawing.Size(108, 22);
            this.txtTransferPayRe.TabIndex = 169;
            this.txtTransferPayRe.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTransferPayRe_KeyPress);
            // 
            // btnSelectCityReservation
            // 
            this.btnSelectCityReservation.BackColor = System.Drawing.Color.Navy;
            this.btnSelectCityReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSelectCityReservation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSelectCityReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSelectCityReservation.Location = new System.Drawing.Point(626, 173);
            this.btnSelectCityReservation.Name = "btnSelectCityReservation";
            this.btnSelectCityReservation.Size = new System.Drawing.Size(116, 29);
            this.btnSelectCityReservation.TabIndex = 171;
            this.btnSelectCityReservation.Text = "Seleccionar";
            this.btnSelectCityReservation.UseVisualStyleBackColor = false;
            this.btnSelectCityReservation.Click += new System.EventHandler(this.btnSelectCityReservation_Click);
            // 
            // btnSearchNameReservation
            // 
            this.btnSearchNameReservation.BackColor = System.Drawing.Color.Navy;
            this.btnSearchNameReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchNameReservation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchNameReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchNameReservation.Location = new System.Drawing.Point(244, 39);
            this.btnSearchNameReservation.Name = "btnSearchNameReservation";
            this.btnSearchNameReservation.Size = new System.Drawing.Size(77, 29);
            this.btnSearchNameReservation.TabIndex = 172;
            this.btnSearchNameReservation.Text = "Nombre";
            this.btnSearchNameReservation.UseVisualStyleBackColor = false;
            this.btnSearchNameReservation.Click += new System.EventHandler(this.btnSearchNameReservation_Click);
            // 
            // btnSearchRFCReservation
            // 
            this.btnSearchRFCReservation.BackColor = System.Drawing.Color.Navy;
            this.btnSearchRFCReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchRFCReservation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchRFCReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchRFCReservation.Location = new System.Drawing.Point(327, 39);
            this.btnSearchRFCReservation.Name = "btnSearchRFCReservation";
            this.btnSearchRFCReservation.Size = new System.Drawing.Size(56, 29);
            this.btnSearchRFCReservation.TabIndex = 173;
            this.btnSearchRFCReservation.Text = "RFC";
            this.btnSearchRFCReservation.UseVisualStyleBackColor = false;
            this.btnSearchRFCReservation.Click += new System.EventHandler(this.btnSearchRFCReservation_Click);
            // 
            // btnSearchEmailReservation
            // 
            this.btnSearchEmailReservation.BackColor = System.Drawing.Color.Navy;
            this.btnSearchEmailReservation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSearchEmailReservation.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchEmailReservation.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSearchEmailReservation.Location = new System.Drawing.Point(389, 39);
            this.btnSearchEmailReservation.Name = "btnSearchEmailReservation";
            this.btnSearchEmailReservation.Size = new System.Drawing.Size(56, 29);
            this.btnSearchEmailReservation.TabIndex = 174;
            this.btnSearchEmailReservation.Text = "Email";
            this.btnSearchEmailReservation.UseVisualStyleBackColor = false;
            this.btnSearchEmailReservation.Click += new System.EventHandler(this.btnSearchEmailReservation_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(597, 543);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(175, 17);
            this.label10.TabIndex = 175;
            this.label10.Text = "El anticipo minimo es de $10";
            // 
            // SalesScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(233)))), ((int)(((byte)(227)))));
            this.ClientSize = new System.Drawing.Size(934, 631);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.btnSearchEmailReservation);
            this.Controls.Add(this.btnSearchRFCReservation);
            this.Controls.Add(this.btnSearchNameReservation);
            this.Controls.Add(this.btnSelectCityReservation);
            this.Controls.Add(this.rbTransferPayRe);
            this.Controls.Add(this.txtTransferPayRe);
            this.Controls.Add(this.rbDebitCardPayRe);
            this.Controls.Add(this.rbCreditCardPayRe);
            this.Controls.Add(this.txtCreditCardPayRe);
            this.Controls.Add(this.txtDebitCardPayRe);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dtpLodgingReser2);
            this.Controls.Add(this.dtpLodgingReser);
            this.Controls.Add(this.btnAddReser);
            this.Controls.Add(this.btnSelectReservation);
            this.Controls.Add(this.txtPeopleReservations);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.dataGridRoomsChosenRe);
            this.Controls.Add(this.dataGridRoomsRe);
            this.Controls.Add(this.cbCityReservations);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.dataGridHotelRe);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridCustomerRe);
            this.Controls.Add(this.btnConfirmReser);
            this.Controls.Add(this.txtCustomerReservation);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label8);
            this.Name = "SalesScreen";
            this.Text = "Ventas";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridCustomerRe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridHotelRe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoomsRe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRoomsChosenRe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dataGridCustomerRe;
        private System.Windows.Forms.Button btnConfirmReser;
        private System.Windows.Forms.TextBox txtCustomerReservation;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridHotelRe;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbCityReservations;
        private System.Windows.Forms.DataGridView dataGridRoomsRe;
        private System.Windows.Forms.DataGridView dataGridRoomsChosenRe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPeopleReservations;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnSelectReservation;
        private System.Windows.Forms.Button btnAddReser;
        private System.Windows.Forms.DateTimePicker dtpLodgingReser;
        private System.Windows.Forms.DateTimePicker dtpLodgingReser2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox rbDebitCardPayRe;
        private System.Windows.Forms.CheckBox rbCreditCardPayRe;
        private System.Windows.Forms.TextBox txtCreditCardPayRe;
        private System.Windows.Forms.TextBox txtDebitCardPayRe;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.CheckBox rbTransferPayRe;
        private System.Windows.Forms.TextBox txtTransferPayRe;
        private System.Windows.Forms.Button btnSelectCityReservation;
        private System.Windows.Forms.Button btnSearchNameReservation;
        private System.Windows.Forms.Button btnSearchRFCReservation;
        private System.Windows.Forms.Button btnSearchEmailReservation;
        private System.Windows.Forms.Label label10;
    }
}