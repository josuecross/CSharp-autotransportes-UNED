namespace GUI_Servidor.WindowsForm
{
    partial class ConsultarTerminales
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
            this.terminalesdataGridView = new System.Windows.Forms.DataGridView();
            this.COD_TERMINAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NOM_TERMINAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIR_TERMINAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NUM_TELEFONO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIM_HORA_APERTURA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TIM_HORA_CIERRE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BOL_ESTADO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.terminalesdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // terminalesdataGridView
            // 
            this.terminalesdataGridView.AllowUserToAddRows = false;
            this.terminalesdataGridView.AllowUserToDeleteRows = false;
            this.terminalesdataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.terminalesdataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.terminalesdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.terminalesdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.COD_TERMINAL,
            this.NOM_TERMINAL,
            this.DIR_TERMINAL,
            this.NUM_TELEFONO,
            this.TIM_HORA_APERTURA,
            this.TIM_HORA_CIERRE,
            this.BOL_ESTADO});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.terminalesdataGridView.DefaultCellStyle = dataGridViewCellStyle2;
            this.terminalesdataGridView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.terminalesdataGridView.Location = new System.Drawing.Point(0, 0);
            this.terminalesdataGridView.Name = "terminalesdataGridView";
            this.terminalesdataGridView.ReadOnly = true;
            this.terminalesdataGridView.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.terminalesdataGridView.RowTemplate.Height = 25;
            this.terminalesdataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.terminalesdataGridView.Size = new System.Drawing.Size(808, 522);
            this.terminalesdataGridView.TabIndex = 0;
            // 
            // COD_TERMINAL
            // 
            this.COD_TERMINAL.HeaderText = "ID";
            this.COD_TERMINAL.Name = "COD_TERMINAL";
            this.COD_TERMINAL.ReadOnly = true;
            // 
            // NOM_TERMINAL
            // 
            this.NOM_TERMINAL.HeaderText = "Nombre";
            this.NOM_TERMINAL.Name = "NOM_TERMINAL";
            this.NOM_TERMINAL.ReadOnly = true;
            // 
            // DIR_TERMINAL
            // 
            this.DIR_TERMINAL.HeaderText = "Direccion";
            this.DIR_TERMINAL.Name = "DIR_TERMINAL";
            this.DIR_TERMINAL.ReadOnly = true;
            // 
            // NUM_TELEFONO
            // 
            this.NUM_TELEFONO.HeaderText = "Telefono";
            this.NUM_TELEFONO.Name = "NUM_TELEFONO";
            this.NUM_TELEFONO.ReadOnly = true;
            // 
            // TIM_HORA_APERTURA
            // 
            this.TIM_HORA_APERTURA.HeaderText = "Hora Apertura";
            this.TIM_HORA_APERTURA.Name = "TIM_HORA_APERTURA";
            this.TIM_HORA_APERTURA.ReadOnly = true;
            // 
            // TIM_HORA_CIERRE
            // 
            this.TIM_HORA_CIERRE.HeaderText = "Hora Cierre";
            this.TIM_HORA_CIERRE.Name = "TIM_HORA_CIERRE";
            this.TIM_HORA_CIERRE.ReadOnly = true;
            // 
            // BOL_ESTADO
            // 
            this.BOL_ESTADO.HeaderText = "Estado";
            this.BOL_ESTADO.Name = "BOL_ESTADO";
            this.BOL_ESTADO.ReadOnly = true;
            // 
            // ConsultarTerminales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(808, 522);
            this.Controls.Add(this.terminalesdataGridView);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsultarTerminales";
            this.Text = "Consultar Terminales";
            this.Load += new System.EventHandler(this.ConsultarTerminales_Load);
            ((System.ComponentModel.ISupportInitialize)(this.terminalesdataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DataGridView terminalesdataGridView;
        private DataGridViewTextBoxColumn COD_TERMINAL;
        private DataGridViewTextBoxColumn NOM_TERMINAL;
        private DataGridViewTextBoxColumn DIR_TERMINAL;
        private DataGridViewTextBoxColumn NUM_TELEFONO;
        private DataGridViewTextBoxColumn TIM_HORA_APERTURA;
        private DataGridViewTextBoxColumn TIM_HORA_CIERRE;
        private DataGridViewTextBoxColumn BOL_ESTADO;
    }
}