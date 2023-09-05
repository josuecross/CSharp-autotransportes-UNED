namespace GUI_Servidor.WindowsForm
{
    partial class consultarRoles
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.consultarRolesdataGridView = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tipolabel = new System.Windows.Forms.Label();
            this.tarifalabel = new System.Windows.Forms.Label();
            this.terminalDestinolabel = new System.Windows.Forms.Label();
            this.terminalOrigenlabel = new System.Windows.Forms.Label();
            this.rutalabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.capacidadlabel = new System.Windows.Forms.Label();
            this.marcalabel = new System.Windows.Forms.Label();
            this.placalabel = new System.Windows.Forms.Label();
            this.autobuslabel = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.consultarRolesdataGridView)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // consultarRolesdataGridView
            // 
            this.consultarRolesdataGridView.AllowUserToAddRows = false;
            this.consultarRolesdataGridView.AllowUserToDeleteRows = false;
            this.consultarRolesdataGridView.AllowUserToResizeRows = false;
            this.consultarRolesdataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.consultarRolesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.consultarRolesdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.consultarRolesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.consultarRolesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.consultarRolesdataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.consultarRolesdataGridView.Location = new System.Drawing.Point(12, 28);
            this.consultarRolesdataGridView.MultiSelect = false;
            this.consultarRolesdataGridView.Name = "consultarRolesdataGridView";
            this.consultarRolesdataGridView.ReadOnly = true;
            this.consultarRolesdataGridView.RowTemplate.Height = 25;
            this.consultarRolesdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.consultarRolesdataGridView.Size = new System.Drawing.Size(543, 482);
            this.consultarRolesdataGridView.TabIndex = 0;
            this.consultarRolesdataGridView.SelectionChanged += new System.EventHandler(this.consultarRolesdataGridView_SelectionChanged);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "Fecha";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.HeaderText = "Hora de Salida";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.HeaderText = "ID ruta";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            // 
            // Column4
            // 
            this.Column4.HeaderText = "ID autobus";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            // 
            // Column5
            // 
            this.Column5.HeaderText = "Nombre conductor";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            // 
            // tipolabel
            // 
            this.tipolabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tipolabel.AutoSize = true;
            this.tipolabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tipolabel.Location = new System.Drawing.Point(10, 176);
            this.tipolabel.Name = "tipolabel";
            this.tipolabel.Size = new System.Drawing.Size(94, 20);
            this.tipolabel.TabIndex = 26;
            this.tipolabel.Text = "Tipo: -Vacio-";
            // 
            // tarifalabel
            // 
            this.tarifalabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.tarifalabel.AutoSize = true;
            this.tarifalabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.tarifalabel.Location = new System.Drawing.Point(10, 136);
            this.tarifalabel.Name = "tarifalabel";
            this.tarifalabel.Size = new System.Drawing.Size(99, 20);
            this.tarifalabel.TabIndex = 25;
            this.tarifalabel.Text = "Tarifa: -vacio-";
            // 
            // terminalDestinolabel
            // 
            this.terminalDestinolabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.terminalDestinolabel.AutoSize = true;
            this.terminalDestinolabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.terminalDestinolabel.Location = new System.Drawing.Point(10, 94);
            this.terminalDestinolabel.Name = "terminalDestinolabel";
            this.terminalDestinolabel.Size = new System.Drawing.Size(114, 20);
            this.terminalDestinolabel.TabIndex = 24;
            this.terminalDestinolabel.Text = "Destino: -vacio-";
            // 
            // terminalOrigenlabel
            // 
            this.terminalOrigenlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.terminalOrigenlabel.AutoSize = true;
            this.terminalOrigenlabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.terminalOrigenlabel.Location = new System.Drawing.Point(10, 55);
            this.terminalOrigenlabel.Name = "terminalOrigenlabel";
            this.terminalOrigenlabel.Size = new System.Drawing.Size(108, 20);
            this.terminalOrigenlabel.TabIndex = 23;
            this.terminalOrigenlabel.Text = "Origen: -vacio-";
            // 
            // rutalabel
            // 
            this.rutalabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.rutalabel.AutoSize = true;
            this.rutalabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.rutalabel.Location = new System.Drawing.Point(10, 20);
            this.rutalabel.Name = "rutalabel";
            this.rutalabel.Size = new System.Drawing.Size(42, 20);
            this.rutalabel.TabIndex = 22;
            this.rutalabel.Text = "Ruta";
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel1.Controls.Add(this.rutalabel);
            this.panel1.Controls.Add(this.tipolabel);
            this.panel1.Controls.Add(this.tarifalabel);
            this.panel1.Controls.Add(this.terminalDestinolabel);
            this.panel1.Controls.Add(this.terminalOrigenlabel);
            this.panel1.Location = new System.Drawing.Point(569, 28);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(227, 217);
            this.panel1.TabIndex = 27;
            // 
            // capacidadlabel
            // 
            this.capacidadlabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.capacidadlabel.AutoSize = true;
            this.capacidadlabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.capacidadlabel.Location = new System.Drawing.Point(10, 151);
            this.capacidadlabel.Name = "capacidadlabel";
            this.capacidadlabel.Size = new System.Drawing.Size(134, 20);
            this.capacidadlabel.TabIndex = 31;
            this.capacidadlabel.Text = "Capacidad: -vacio-";
            // 
            // marcalabel
            // 
            this.marcalabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.marcalabel.AutoSize = true;
            this.marcalabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.marcalabel.Location = new System.Drawing.Point(10, 110);
            this.marcalabel.Name = "marcalabel";
            this.marcalabel.Size = new System.Drawing.Size(104, 20);
            this.marcalabel.TabIndex = 30;
            this.marcalabel.Text = "Marca: -vacio-";
            // 
            // placalabel
            // 
            this.placalabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.placalabel.AutoSize = true;
            this.placalabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.placalabel.Location = new System.Drawing.Point(10, 65);
            this.placalabel.Name = "placalabel";
            this.placalabel.Size = new System.Drawing.Size(98, 20);
            this.placalabel.TabIndex = 29;
            this.placalabel.Text = "Placa: -vacio-";
            // 
            // autobuslabel
            // 
            this.autobuslabel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.autobuslabel.AutoSize = true;
            this.autobuslabel.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.autobuslabel.Location = new System.Drawing.Point(10, 22);
            this.autobuslabel.Name = "autobuslabel";
            this.autobuslabel.Size = new System.Drawing.Size(69, 20);
            this.autobuslabel.TabIndex = 28;
            this.autobuslabel.Text = "Autobus";
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.panel2.Controls.Add(this.autobuslabel);
            this.panel2.Controls.Add(this.placalabel);
            this.panel2.Controls.Add(this.marcalabel);
            this.panel2.Controls.Add(this.capacidadlabel);
            this.panel2.Location = new System.Drawing.Point(569, 289);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(227, 191);
            this.panel2.TabIndex = 32;
            // 
            // consultarRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(808, 522);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.consultarRolesdataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "consultarRoles";
            this.Text = "consultarRoles";
            this.Load += new System.EventHandler(this.consultarRoles_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultarRolesdataGridView)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView consultarRolesdataGridView;
        private Label tipolabel;
        private Label tarifalabel;
        private Label terminalDestinolabel;
        private Label terminalOrigenlabel;
        private Label rutalabel;
        private Panel panel1;
        private Label capacidadlabel;
        private Label marcalabel;
        private Label placalabel;
        private Label autobuslabel;
        private Panel panel2;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private DataGridViewTextBoxColumn Column5;
    }
}