﻿namespace NetWork.Vista
{
    partial class FormGestionFacturas
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
            this.label1 = new System.Windows.Forms.Label();
            this.dgvGestionFacturas = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.EmailUsuario = new System.Windows.Forms.Label();
            this.genFactura = new System.Windows.Forms.Button();
            this.textboxNumeroFactura = new System.Windows.Forms.TextBox();
            this.textBoxCodigoReservas1 = new System.Windows.Forms.TextBox();
            this.textBoxCodigoServicio = new System.Windows.Forms.TextBox();
            this.textBoxIdCliente = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBoxTotalFactura = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.dateTimePickerFechaFactura = new System.Windows.Forms.DateTimePicker();
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionFacturas)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 32.25F);
            this.label1.Location = new System.Drawing.Point(267, 42);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(594, 74);
            this.label1.TabIndex = 1;
            this.label1.Text = "Gestión de facturas";
            // 
            // dgvGestionFacturas
            // 
            this.dgvGestionFacturas.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvGestionFacturas.Location = new System.Drawing.Point(52, 466);
            this.dgvGestionFacturas.Name = "dgvGestionFacturas";
            this.dgvGestionFacturas.RowHeadersWidth = 62;
            this.dgvGestionFacturas.RowTemplate.Height = 28;
            this.dgvGestionFacturas.Size = new System.Drawing.Size(1009, 335);
            this.dgvGestionFacturas.TabIndex = 28;
            this.dgvGestionFacturas.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dgvGestionFacturas_CellMouseClick_1);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(44, 825);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(168, 35);
            this.button1.TabIndex = 31;
            this.button1.Text = "Volver";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // EmailUsuario
            // 
            this.EmailUsuario.AutoSize = true;
            this.EmailUsuario.Location = new System.Drawing.Point(39, 42);
            this.EmailUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailUsuario.Name = "EmailUsuario";
            this.EmailUsuario.Size = new System.Drawing.Size(103, 20);
            this.EmailUsuario.TabIndex = 32;
            this.EmailUsuario.Text = "EmailUsuario";
            // 
            // genFactura
            // 
            this.genFactura.Location = new System.Drawing.Point(434, 155);
            this.genFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.genFactura.Name = "genFactura";
            this.genFactura.Size = new System.Drawing.Size(168, 46);
            this.genFactura.TabIndex = 36;
            this.genFactura.Text = "Generar factura";
            this.genFactura.UseVisualStyleBackColor = true;
            this.genFactura.Click += new System.EventHandler(this.genFactura_Click);
            // 
            // textboxNumeroFactura
            // 
            this.textboxNumeroFactura.Location = new System.Drawing.Point(52, 331);
            this.textboxNumeroFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textboxNumeroFactura.Name = "textboxNumeroFactura";
            this.textboxNumeroFactura.Size = new System.Drawing.Size(194, 26);
            this.textboxNumeroFactura.TabIndex = 40;
            // 
            // textBoxCodigoReservas1
            // 
            this.textBoxCodigoReservas1.Location = new System.Drawing.Point(280, 331);
            this.textBoxCodigoReservas1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCodigoReservas1.Name = "textBoxCodigoReservas1";
            this.textBoxCodigoReservas1.Size = new System.Drawing.Size(194, 26);
            this.textBoxCodigoReservas1.TabIndex = 41;
            // 
            // textBoxCodigoServicio
            // 
            this.textBoxCodigoServicio.Location = new System.Drawing.Point(513, 331);
            this.textBoxCodigoServicio.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxCodigoServicio.Name = "textBoxCodigoServicio";
            this.textBoxCodigoServicio.Size = new System.Drawing.Size(194, 26);
            this.textBoxCodigoServicio.TabIndex = 42;
            // 
            // textBoxIdCliente
            // 
            this.textBoxIdCliente.Location = new System.Drawing.Point(726, 331);
            this.textBoxIdCliente.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxIdCliente.Name = "textBoxIdCliente";
            this.textBoxIdCliente.Size = new System.Drawing.Size(194, 26);
            this.textBoxIdCliente.TabIndex = 43;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(87, 302);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 20);
            this.label2.TabIndex = 44;
            this.label2.Text = "Nº Factura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(312, 302);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(130, 20);
            this.label4.TabIndex = 45;
            this.label4.Text = "Codigo Reservas";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(542, 302);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 46;
            this.label5.Text = "Código Servicio";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(766, 302);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(79, 20);
            this.label6.TabIndex = 47;
            this.label6.Text = "ID Cliente";
            // 
            // textBoxTotalFactura
            // 
            this.textBoxTotalFactura.Location = new System.Drawing.Point(513, 408);
            this.textBoxTotalFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBoxTotalFactura.Name = "textBoxTotalFactura";
            this.textBoxTotalFactura.Size = new System.Drawing.Size(194, 26);
            this.textBoxTotalFactura.TabIndex = 49;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(542, 383);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(103, 20);
            this.label7.TabIndex = 50;
            this.label7.Text = "Total Factura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(326, 383);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(113, 20);
            this.label8.TabIndex = 51;
            this.label8.Text = "Fecha Factura";
            // 
            // dateTimePickerFechaFactura
            // 
            this.dateTimePickerFechaFactura.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.dateTimePickerFechaFactura.Location = new System.Drawing.Point(280, 408);
            this.dateTimePickerFechaFactura.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dateTimePickerFechaFactura.Name = "dateTimePickerFechaFactura";
            this.dateTimePickerFechaFactura.Size = new System.Drawing.Size(194, 26);
            this.dateTimePickerFechaFactura.TabIndex = 52;
            // 
            // FormGestionFacturas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1107, 878);
            this.Controls.Add(this.dateTimePickerFechaFactura);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBoxTotalFactura);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxIdCliente);
            this.Controls.Add(this.textBoxCodigoServicio);
            this.Controls.Add(this.textBoxCodigoReservas1);
            this.Controls.Add(this.textboxNumeroFactura);
            this.Controls.Add(this.genFactura);
            this.Controls.Add(this.EmailUsuario);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvGestionFacturas);
            this.Controls.Add(this.label1);
            this.Name = "FormGestionFacturas";
            this.Text = "FormModificarReservas";
            ((System.ComponentModel.ISupportInitialize)(this.dgvGestionFacturas)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvGestionFacturas;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label EmailUsuario;
        private System.Windows.Forms.Button genFactura;
        private System.Windows.Forms.TextBox textboxNumeroFactura;
        private System.Windows.Forms.TextBox textBoxCodigoReservas1;
        private System.Windows.Forms.TextBox textBoxCodigoServicio;
        private System.Windows.Forms.TextBox textBoxIdCliente;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBoxTotalFactura;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DateTimePicker dateTimePickerFechaFactura;
    }
}