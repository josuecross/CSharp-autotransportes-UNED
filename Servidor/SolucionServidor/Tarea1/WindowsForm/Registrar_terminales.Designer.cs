namespace GUI_Servidor
{
    partial class Registrar_terminales
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
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.guardarbutton = new System.Windows.Forms.Button();
            this.limpiarDatosbutton = new System.Windows.Forms.Button();
            this.nombretextBox = new System.Windows.Forms.TextBox();
            this.direcciontextBox = new System.Windows.Forms.TextBox();
            this.telefonotextBox4 = new System.Windows.Forms.TextBox();
            this.horaAperturacomboBox = new System.Windows.Forms.ComboBox();
            this.horaCierracomboBox = new System.Windows.Forms.ComboBox();
            this.estadocomboBox = new System.Windows.Forms.ComboBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(69, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(314, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "Por favor ingrese los datos solicitados";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(69, 84);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(69, 141);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "Dirección";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(69, 196);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "Telefono";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(72, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(102, 25);
            this.label6.TabIndex = 5;
            this.label6.Text = "Hora de cierre";
            this.label6.UseCompatibleTextRendering = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label7.Location = new System.Drawing.Point(72, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(123, 20);
            this.label7.TabIndex = 6;
            this.label7.Text = "Hora de apertura";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label8.Location = new System.Drawing.Point(72, 383);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(54, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Estado";
            // 
            // guardarbutton
            // 
            this.guardarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guardarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guardarbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.guardarbutton.ForeColor = System.Drawing.Color.White;
            this.guardarbutton.Image = global::GUI_Servidor.Properties.Resources.diskette;
            this.guardarbutton.Location = new System.Drawing.Point(179, 25);
            this.guardarbutton.Name = "guardarbutton";
            this.guardarbutton.Size = new System.Drawing.Size(159, 40);
            this.guardarbutton.TabIndex = 7;
            this.guardarbutton.Text = "Guardar";
            this.guardarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.guardarbutton.UseVisualStyleBackColor = false;
            this.guardarbutton.Click += new System.EventHandler(this.guardarbutton_Click);
            // 
            // limpiarDatosbutton
            // 
            this.limpiarDatosbutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.limpiarDatosbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.limpiarDatosbutton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.limpiarDatosbutton.ForeColor = System.Drawing.Color.White;
            this.limpiarDatosbutton.Image = global::GUI_Servidor.Properties.Resources.archeology;
            this.limpiarDatosbutton.Location = new System.Drawing.Point(407, 25);
            this.limpiarDatosbutton.Name = "limpiarDatosbutton";
            this.limpiarDatosbutton.Size = new System.Drawing.Size(159, 40);
            this.limpiarDatosbutton.TabIndex = 8;
            this.limpiarDatosbutton.Text = "Limpiar ";
            this.limpiarDatosbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.limpiarDatosbutton.UseVisualStyleBackColor = false;
            this.limpiarDatosbutton.Click += new System.EventHandler(this.limpiarDatosbutton_Click);
            // 
            // nombretextBox
            // 
            this.nombretextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.nombretextBox.Location = new System.Drawing.Point(188, 81);
            this.nombretextBox.Name = "nombretextBox";
            this.nombretextBox.Size = new System.Drawing.Size(208, 27);
            this.nombretextBox.TabIndex = 1;
            // 
            // direcciontextBox
            // 
            this.direcciontextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.direcciontextBox.Location = new System.Drawing.Point(188, 141);
            this.direcciontextBox.Name = "direcciontextBox";
            this.direcciontextBox.Size = new System.Drawing.Size(208, 27);
            this.direcciontextBox.TabIndex = 2;
            // 
            // telefonotextBox4
            // 
            this.telefonotextBox4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.telefonotextBox4.Location = new System.Drawing.Point(188, 196);
            this.telefonotextBox4.Name = "telefonotextBox4";
            this.telefonotextBox4.Size = new System.Drawing.Size(208, 27);
            this.telefonotextBox4.TabIndex = 3;
            // 
            // horaAperturacomboBox
            // 
            this.horaAperturacomboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.horaAperturacomboBox.FormattingEnabled = true;
            this.horaAperturacomboBox.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00"});
            this.horaAperturacomboBox.Location = new System.Drawing.Point(237, 258);
            this.horaAperturacomboBox.Name = "horaAperturacomboBox";
            this.horaAperturacomboBox.Size = new System.Drawing.Size(121, 28);
            this.horaAperturacomboBox.TabIndex = 4;
            this.horaAperturacomboBox.Text = "-Seleccionar-";
            // 
            // horaCierracomboBox
            // 
            this.horaCierracomboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.horaCierracomboBox.FormattingEnabled = true;
            this.horaCierracomboBox.Items.AddRange(new object[] {
            "08:00",
            "09:00",
            "10:00",
            "11:00",
            "12:00",
            "13:00",
            "14:00",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00"});
            this.horaCierracomboBox.Location = new System.Drawing.Point(237, 321);
            this.horaCierracomboBox.Name = "horaCierracomboBox";
            this.horaCierracomboBox.Size = new System.Drawing.Size(121, 28);
            this.horaCierracomboBox.TabIndex = 5;
            this.horaCierracomboBox.Text = "-Seleccionar-";
            // 
            // estadocomboBox
            // 
            this.estadocomboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.estadocomboBox.FormattingEnabled = true;
            this.estadocomboBox.Items.AddRange(new object[] {
            "Activo",
            "Inactivo"});
            this.estadocomboBox.Location = new System.Drawing.Point(237, 383);
            this.estadocomboBox.Name = "estadocomboBox";
            this.estadocomboBox.Size = new System.Drawing.Size(121, 28);
            this.estadocomboBox.TabIndex = 6;
            this.estadocomboBox.Text = "-Seleccionar-";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.limpiarDatosbutton);
            this.panel1.Controls.Add(this.guardarbutton);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 423);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(791, 100);
            this.panel1.TabIndex = 9;
            // 
            // panel2
            // 
            this.panel2.AutoScroll = true;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(791, 423);
            this.panel2.TabIndex = 10;
            // 
            // Registrar_terminales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(808, 522);
            this.Controls.Add(this.estadocomboBox);
            this.Controls.Add(this.horaCierracomboBox);
            this.Controls.Add(this.horaAperturacomboBox);
            this.Controls.Add(this.telefonotextBox4);
            this.Controls.Add(this.direcciontextBox);
            this.Controls.Add(this.nombretextBox);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Registrar_terminales";
            this.Text = "Registrar Terminales";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private Button guardarbutton;
        private Button limpiarDatosbutton;
        private TextBox nombretextBox;
        private TextBox direcciontextBox;
        private TextBox telefonotextBox4;
        private ComboBox horaAperturacomboBox;
        private ComboBox horaCierracomboBox;
        private ComboBox estadocomboBox;
        private Panel panel1;
        private Panel panel2;
    }
}