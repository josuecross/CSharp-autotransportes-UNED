namespace GUI_Servidor
{
    partial class RegistrarRoles
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
            this.mensajelabel1 = new System.Windows.Forms.Label();
            this.labelFecha = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.fechadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.idAutobustextBox = new System.Windows.Forms.TextBox();
            this.conductortextBox = new System.Windows.Forms.TextBox();
            this.guardarbutton1 = new System.Windows.Forms.Button();
            this.limpiarbutton = new System.Windows.Forms.Button();
            this.horaSalidacomboBox = new System.Windows.Forms.ComboBox();
            this.idRutatextBox = new System.Windows.Forms.TextBox();
            this.rutalabel = new System.Windows.Forms.Label();
            this.terminalOrigenlabel = new System.Windows.Forms.Label();
            this.terminalDestinolabel = new System.Windows.Forms.Label();
            this.tarifalabel = new System.Windows.Forms.Label();
            this.tipolabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.capacidadlabel = new System.Windows.Forms.Label();
            this.marcalabel = new System.Windows.Forms.Label();
            this.placalabel = new System.Windows.Forms.Label();
            this.autobuslabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // mensajelabel1
            // 
            this.mensajelabel1.AutoSize = true;
            this.mensajelabel1.Font = new System.Drawing.Font("Lucida Fax", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.mensajelabel1.Location = new System.Drawing.Point(64, 24);
            this.mensajelabel1.Name = "mensajelabel1";
            this.mensajelabel1.Size = new System.Drawing.Size(314, 18);
            this.mensajelabel1.TabIndex = 0;
            this.mensajelabel1.Text = "Por favor ingrese los datos solicitados";
            // 
            // labelFecha
            // 
            this.labelFecha.AutoSize = true;
            this.labelFecha.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelFecha.Location = new System.Drawing.Point(64, 81);
            this.labelFecha.Name = "labelFecha";
            this.labelFecha.Size = new System.Drawing.Size(47, 20);
            this.labelFecha.TabIndex = 1;
            this.labelFecha.Text = "Fecha";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label3.Location = new System.Drawing.Point(64, 141);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(106, 20);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hora de salida";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label4.Location = new System.Drawing.Point(64, 212);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 20);
            this.label4.TabIndex = 3;
            this.label4.Text = "ID ruta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label5.Location = new System.Drawing.Point(64, 288);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 20);
            this.label5.TabIndex = 4;
            this.label5.Text = "ID del autobus";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label6.Location = new System.Drawing.Point(64, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 20);
            this.label6.TabIndex = 5;
            this.label6.Text = "Conductor";
            // 
            // fechadateTimePicker
            // 
            this.fechadateTimePicker.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.fechadateTimePicker.Location = new System.Drawing.Point(242, 72);
            this.fechadateTimePicker.Name = "fechadateTimePicker";
            this.fechadateTimePicker.Size = new System.Drawing.Size(200, 27);
            this.fechadateTimePicker.TabIndex = 6;
            // 
            // idAutobustextBox
            // 
            this.idAutobustextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idAutobustextBox.Location = new System.Drawing.Point(242, 282);
            this.idAutobustextBox.Name = "idAutobustextBox";
            this.idAutobustextBox.Size = new System.Drawing.Size(208, 27);
            this.idAutobustextBox.TabIndex = 9;
            this.idAutobustextBox.TextChanged += new System.EventHandler(this.idAutobustextBox_TextChanged);
            // 
            // conductortextBox
            // 
            this.conductortextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.conductortextBox.Location = new System.Drawing.Point(242, 354);
            this.conductortextBox.Name = "conductortextBox";
            this.conductortextBox.Size = new System.Drawing.Size(208, 27);
            this.conductortextBox.TabIndex = 10;
            // 
            // guardarbutton1
            // 
            this.guardarbutton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.guardarbutton1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.guardarbutton1.ForeColor = System.Drawing.Color.White;
            this.guardarbutton1.Image = global::GUI_Servidor.Properties.Resources.diskette;
            this.guardarbutton1.Location = new System.Drawing.Point(48, 432);
            this.guardarbutton1.Name = "guardarbutton1";
            this.guardarbutton1.Size = new System.Drawing.Size(159, 40);
            this.guardarbutton1.TabIndex = 11;
            this.guardarbutton1.Text = "Guardar";
            this.guardarbutton1.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.guardarbutton1.UseVisualStyleBackColor = false;
            this.guardarbutton1.Click += new System.EventHandler(this.guardarbutton1_Click);
            // 
            // limpiarbutton
            // 
            this.limpiarbutton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.limpiarbutton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.limpiarbutton.ForeColor = System.Drawing.Color.White;
            this.limpiarbutton.Image = global::GUI_Servidor.Properties.Resources.archeology;
            this.limpiarbutton.Location = new System.Drawing.Point(252, 432);
            this.limpiarbutton.Name = "limpiarbutton";
            this.limpiarbutton.Size = new System.Drawing.Size(159, 40);
            this.limpiarbutton.TabIndex = 12;
            this.limpiarbutton.Text = "Limpiar";
            this.limpiarbutton.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.limpiarbutton.UseVisualStyleBackColor = false;
            this.limpiarbutton.Click += new System.EventHandler(this.limpiarbutton_Click);
            // 
            // horaSalidacomboBox
            // 
            this.horaSalidacomboBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.horaSalidacomboBox.FormattingEnabled = true;
            this.horaSalidacomboBox.Items.AddRange(new object[] {
            "08:00",
            "08:30",
            "09:00",
            "09:30",
            "10:00",
            "10:30",
            "11:00",
            "11:30",
            "12:00",
            "12:30",
            "13:00",
            "13:30",
            "14:00",
            "14:30",
            "15:00",
            "16:00",
            "17:00",
            "18:00",
            "19:00",
            "20:00"});
            this.horaSalidacomboBox.Location = new System.Drawing.Point(242, 135);
            this.horaSalidacomboBox.Name = "horaSalidacomboBox";
            this.horaSalidacomboBox.Size = new System.Drawing.Size(121, 28);
            this.horaSalidacomboBox.TabIndex = 7;
            this.horaSalidacomboBox.Text = "-Seleccione-";
            // 
            // idRutatextBox
            // 
            this.idRutatextBox.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.idRutatextBox.Location = new System.Drawing.Point(242, 209);
            this.idRutatextBox.Name = "idRutatextBox";
            this.idRutatextBox.Size = new System.Drawing.Size(208, 27);
            this.idRutatextBox.TabIndex = 15;
            this.idRutatextBox.TextChanged += new System.EventHandler(this.idRutatextBox_TextChanged);
            // 
            // rutalabel
            // 
            this.rutalabel.AutoSize = true;
            this.rutalabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rutalabel.Location = new System.Drawing.Point(14, 16);
            this.rutalabel.Name = "rutalabel";
            this.rutalabel.Size = new System.Drawing.Size(42, 20);
            this.rutalabel.TabIndex = 16;
            this.rutalabel.Text = "Ruta";
            // 
            // terminalOrigenlabel
            // 
            this.terminalOrigenlabel.AutoSize = true;
            this.terminalOrigenlabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.terminalOrigenlabel.Location = new System.Drawing.Point(10, 55);
            this.terminalOrigenlabel.Name = "terminalOrigenlabel";
            this.terminalOrigenlabel.Size = new System.Drawing.Size(108, 20);
            this.terminalOrigenlabel.TabIndex = 17;
            this.terminalOrigenlabel.Text = "Origen: -vacio-";
            // 
            // terminalDestinolabel
            // 
            this.terminalDestinolabel.AutoSize = true;
            this.terminalDestinolabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.terminalDestinolabel.Location = new System.Drawing.Point(11, 96);
            this.terminalDestinolabel.Name = "terminalDestinolabel";
            this.terminalDestinolabel.Size = new System.Drawing.Size(114, 20);
            this.terminalDestinolabel.TabIndex = 18;
            this.terminalDestinolabel.Text = "Destino: -vacio-";
            // 
            // tarifalabel
            // 
            this.tarifalabel.AutoSize = true;
            this.tarifalabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tarifalabel.Location = new System.Drawing.Point(11, 137);
            this.tarifalabel.Name = "tarifalabel";
            this.tarifalabel.Size = new System.Drawing.Size(99, 20);
            this.tarifalabel.TabIndex = 19;
            this.tarifalabel.Text = "Tarifa: -vacio-";
            // 
            // tipolabel
            // 
            this.tipolabel.AutoSize = true;
            this.tipolabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tipolabel.Location = new System.Drawing.Point(14, 179);
            this.tipolabel.Name = "tipolabel";
            this.tipolabel.Size = new System.Drawing.Size(94, 20);
            this.tipolabel.TabIndex = 20;
            this.tipolabel.Text = "Tipo: -Vacio-";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.tipolabel);
            this.panel1.Controls.Add(this.rutalabel);
            this.panel1.Controls.Add(this.terminalOrigenlabel);
            this.panel1.Controls.Add(this.terminalDestinolabel);
            this.panel1.Controls.Add(this.tarifalabel);
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(513, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 219);
            this.panel1.TabIndex = 21;
            // 
            // capacidadlabel
            // 
            this.capacidadlabel.AutoSize = true;
            this.capacidadlabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.capacidadlabel.Location = new System.Drawing.Point(14, 141);
            this.capacidadlabel.Name = "capacidadlabel";
            this.capacidadlabel.Size = new System.Drawing.Size(134, 20);
            this.capacidadlabel.TabIndex = 25;
            this.capacidadlabel.Text = "Capacidad: -vacio-";
            // 
            // marcalabel
            // 
            this.marcalabel.AutoSize = true;
            this.marcalabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.marcalabel.Location = new System.Drawing.Point(14, 100);
            this.marcalabel.Name = "marcalabel";
            this.marcalabel.Size = new System.Drawing.Size(104, 20);
            this.marcalabel.TabIndex = 24;
            this.marcalabel.Text = "Marca: -vacio-";
            // 
            // placalabel
            // 
            this.placalabel.AutoSize = true;
            this.placalabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placalabel.Location = new System.Drawing.Point(14, 57);
            this.placalabel.Name = "placalabel";
            this.placalabel.Size = new System.Drawing.Size(98, 20);
            this.placalabel.TabIndex = 23;
            this.placalabel.Text = "Placa: -vacio-";
            // 
            // autobuslabel
            // 
            this.autobuslabel.AutoSize = true;
            this.autobuslabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autobuslabel.Location = new System.Drawing.Point(14, 16);
            this.autobuslabel.Name = "autobuslabel";
            this.autobuslabel.Size = new System.Drawing.Size(69, 20);
            this.autobuslabel.TabIndex = 22;
            this.autobuslabel.Text = "Autobus";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.autobuslabel);
            this.panel2.Controls.Add(this.placalabel);
            this.panel2.Controls.Add(this.marcalabel);
            this.panel2.Controls.Add(this.capacidadlabel);
            this.panel2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel2.Location = new System.Drawing.Point(513, 291);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(265, 186);
            this.panel2.TabIndex = 27;
            // 
            // RegistrarRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.idRutatextBox);
            this.Controls.Add(this.limpiarbutton);
            this.Controls.Add(this.guardarbutton1);
            this.Controls.Add(this.conductortextBox);
            this.Controls.Add(this.idAutobustextBox);
            this.Controls.Add(this.horaSalidacomboBox);
            this.Controls.Add(this.fechadateTimePicker);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.labelFecha);
            this.Controls.Add(this.mensajelabel1);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegistrarRoles";
            this.Text = "RegistrarRoles";
            this.Load += new System.EventHandler(this.RegistrarRoles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label mensajelabel1;
        private Label labelFecha;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private DateTimePicker fechadateTimePicker;
        private TextBox idAutobustextBox;
        private TextBox conductortextBox;
        private Button guardarbutton1;
        private Button limpiarbutton;
        private ComboBox horaSalidacomboBox;
        private TextBox idRutatextBox;
        private Label rutalabel;
        private Label terminalOrigenlabel;
        private Label terminalDestinolabel;
        private Label tarifalabel;
        private Label tipolabel;
        private Panel panel1;
        private Label capacidadlabel;
        private Label marcalabel;
        private Label placalabel;
        private Label autobuslabel;
        private Panel panel2;
    }
}