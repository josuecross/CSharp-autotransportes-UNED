namespace Tarea1
{
    partial class Menu
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
            this.registrarRolesbutton = new System.Windows.Forms.Button();
            this.consultarRolesbutton = new System.Windows.Forms.Button();
            this.panelSideMenu = new System.Windows.Forms.Panel();
            this.panelRolesSubMenu = new System.Windows.Forms.Panel();
            this.buttonDDRoles = new System.Windows.Forms.Button();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.buttonDDConductores = new System.Windows.Forms.Button();
            this.panelChildForm = new System.Windows.Forms.Panel();
            this.pictureBoxLogoChildPanel = new System.Windows.Forms.PictureBox();
            this.panelClienteConexion = new System.Windows.Forms.Panel();
            this.labelInfoClient = new System.Windows.Forms.Label();
            this.buttonClienteConexion = new System.Windows.Forms.Button();
            this.panelSideMenu.SuspendLayout();
            this.panelRolesSubMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.panelChildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoChildPanel)).BeginInit();
            this.panelClienteConexion.SuspendLayout();
            this.SuspendLayout();
            // 
            // registrarRolesbutton
            // 
            this.registrarRolesbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.registrarRolesbutton.FlatAppearance.BorderSize = 0;
            this.registrarRolesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.registrarRolesbutton.ForeColor = System.Drawing.Color.LightGray;
            this.registrarRolesbutton.Location = new System.Drawing.Point(0, 0);
            this.registrarRolesbutton.Name = "registrarRolesbutton";
            this.registrarRolesbutton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.registrarRolesbutton.Size = new System.Drawing.Size(200, 40);
            this.registrarRolesbutton.TabIndex = 4;
            this.registrarRolesbutton.Text = "Registrar Roles";
            this.registrarRolesbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.registrarRolesbutton.UseVisualStyleBackColor = true;
            this.registrarRolesbutton.Click += new System.EventHandler(this.registrarRolesbutton_Click);
            // 
            // consultarRolesbutton
            // 
            this.consultarRolesbutton.Dock = System.Windows.Forms.DockStyle.Top;
            this.consultarRolesbutton.FlatAppearance.BorderSize = 0;
            this.consultarRolesbutton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.consultarRolesbutton.ForeColor = System.Drawing.Color.LightGray;
            this.consultarRolesbutton.Location = new System.Drawing.Point(0, 40);
            this.consultarRolesbutton.Name = "consultarRolesbutton";
            this.consultarRolesbutton.Padding = new System.Windows.Forms.Padding(35, 0, 0, 0);
            this.consultarRolesbutton.Size = new System.Drawing.Size(200, 40);
            this.consultarRolesbutton.TabIndex = 9;
            this.consultarRolesbutton.Text = "Consultar Roles";
            this.consultarRolesbutton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.consultarRolesbutton.UseVisualStyleBackColor = true;
            this.consultarRolesbutton.Click += new System.EventHandler(this.consultarRolesbutton_Click);
            // 
            // panelSideMenu
            // 
            this.panelSideMenu.AutoScroll = true;
            this.panelSideMenu.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.panelSideMenu.Controls.Add(this.panelRolesSubMenu);
            this.panelSideMenu.Controls.Add(this.buttonDDRoles);
            this.panelSideMenu.Controls.Add(this.panelLogo);
            this.panelSideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSideMenu.Name = "panelSideMenu";
            this.panelSideMenu.Size = new System.Drawing.Size(200, 587);
            this.panelSideMenu.TabIndex = 10;
            // 
            // panelRolesSubMenu
            // 
            this.panelRolesSubMenu.Controls.Add(this.consultarRolesbutton);
            this.panelRolesSubMenu.Controls.Add(this.registrarRolesbutton);
            this.panelRolesSubMenu.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelRolesSubMenu.Location = new System.Drawing.Point(0, 199);
            this.panelRolesSubMenu.Name = "panelRolesSubMenu";
            this.panelRolesSubMenu.Size = new System.Drawing.Size(200, 81);
            this.panelRolesSubMenu.TabIndex = 19;
            // 
            // buttonDDRoles
            // 
            this.buttonDDRoles.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonDDRoles.FlatAppearance.BorderSize = 0;
            this.buttonDDRoles.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDDRoles.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDDRoles.Image = global::GUI_Cliente.Properties.Resources.arrival_time;
            this.buttonDDRoles.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDDRoles.Location = new System.Drawing.Point(0, 154);
            this.buttonDDRoles.Name = "buttonDDRoles";
            this.buttonDDRoles.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonDDRoles.Size = new System.Drawing.Size(200, 45);
            this.buttonDDRoles.TabIndex = 18;
            this.buttonDDRoles.Text = "   Roles";
            this.buttonDDRoles.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDDRoles.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDDRoles.UseVisualStyleBackColor = true;
            this.buttonDDRoles.Click += new System.EventHandler(this.buttonDDRoles_Click);
            // 
            // panelLogo
            // 
            this.panelLogo.Controls.Add(this.pictureBox2);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(200, 154);
            this.panelLogo.TabIndex = 11;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox2.Image = global::GUI_Cliente.Properties.Resources.logo;
            this.pictureBox2.Location = new System.Drawing.Point(0, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(200, 154);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // buttonDDConductores
            // 
            this.buttonDDConductores.AutoEllipsis = true;
            this.buttonDDConductores.Dock = System.Windows.Forms.DockStyle.Left;
            this.buttonDDConductores.FlatAppearance.BorderSize = 0;
            this.buttonDDConductores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDDConductores.ForeColor = System.Drawing.Color.Gainsboro;
            this.buttonDDConductores.Image = global::GUI_Cliente.Properties.Resources.driver;
            this.buttonDDConductores.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDDConductores.Location = new System.Drawing.Point(0, 0);
            this.buttonDDConductores.Name = "buttonDDConductores";
            this.buttonDDConductores.Padding = new System.Windows.Forms.Padding(10, 0, 0, 0);
            this.buttonDDConductores.Size = new System.Drawing.Size(155, 56);
            this.buttonDDConductores.TabIndex = 12;
            this.buttonDDConductores.Text = "MI informacion:";
            this.buttonDDConductores.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonDDConductores.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.buttonDDConductores.UseVisualStyleBackColor = true;
            // 
            // panelChildForm
            // 
            this.panelChildForm.AutoSize = true;
            this.panelChildForm.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panelChildForm.Controls.Add(this.pictureBoxLogoChildPanel);
            this.panelChildForm.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelChildForm.Location = new System.Drawing.Point(200, 0);
            this.panelChildForm.Name = "panelChildForm";
            this.panelChildForm.Size = new System.Drawing.Size(734, 531);
            this.panelChildForm.TabIndex = 11;
            // 
            // pictureBoxLogoChildPanel
            // 
            this.pictureBoxLogoChildPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBoxLogoChildPanel.Image = global::GUI_Cliente.Properties.Resources.logo;
            this.pictureBoxLogoChildPanel.Location = new System.Drawing.Point(0, 0);
            this.pictureBoxLogoChildPanel.Name = "pictureBoxLogoChildPanel";
            this.pictureBoxLogoChildPanel.Size = new System.Drawing.Size(734, 531);
            this.pictureBoxLogoChildPanel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBoxLogoChildPanel.TabIndex = 0;
            this.pictureBoxLogoChildPanel.TabStop = false;
            // 
            // panelClienteConexion
            // 
            this.panelClienteConexion.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panelClienteConexion.Controls.Add(this.labelInfoClient);
            this.panelClienteConexion.Controls.Add(this.buttonDDConductores);
            this.panelClienteConexion.Controls.Add(this.buttonClienteConexion);
            this.panelClienteConexion.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelClienteConexion.Location = new System.Drawing.Point(200, 531);
            this.panelClienteConexion.Name = "panelClienteConexion";
            this.panelClienteConexion.Size = new System.Drawing.Size(734, 56);
            this.panelClienteConexion.TabIndex = 1;
            // 
            // labelInfoClient
            // 
            this.labelInfoClient.AutoSize = true;
            this.labelInfoClient.ForeColor = System.Drawing.SystemColors.Info;
            this.labelInfoClient.Location = new System.Drawing.Point(161, 21);
            this.labelInfoClient.Name = "labelInfoClient";
            this.labelInfoClient.Size = new System.Drawing.Size(157, 15);
            this.labelInfoClient.TabIndex = 3;
            this.labelInfoClient.Text = "Nombre Apellido1 Apellido2";
            // 
            // buttonClienteConexion
            // 
            this.buttonClienteConexion.BackColor = System.Drawing.Color.DarkTurquoise;
            this.buttonClienteConexion.Dock = System.Windows.Forms.DockStyle.Right;
            this.buttonClienteConexion.FlatAppearance.BorderSize = 0;
            this.buttonClienteConexion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonClienteConexion.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.buttonClienteConexion.Location = new System.Drawing.Point(571, 0);
            this.buttonClienteConexion.Name = "buttonClienteConexion";
            this.buttonClienteConexion.Size = new System.Drawing.Size(163, 56);
            this.buttonClienteConexion.TabIndex = 0;
            this.buttonClienteConexion.Text = "Desconectar";
            this.buttonClienteConexion.UseVisualStyleBackColor = false;
            this.buttonClienteConexion.Click += new System.EventHandler(this.buttonClienteConexion_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(934, 587);
            this.Controls.Add(this.panelChildForm);
            this.Controls.Add(this.panelClienteConexion);
            this.Controls.Add(this.panelSideMenu);
            this.MinimumSize = new System.Drawing.Size(950, 600);
            this.Name = "Menu";
            this.Text = "Menu";
            this.Activated += new System.EventHandler(this.Menu_Activated);
            this.Load += new System.EventHandler(this.Menu_Load);
            this.panelSideMenu.ResumeLayout(false);
            this.panelRolesSubMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.panelChildForm.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxLogoChildPanel)).EndInit();
            this.panelClienteConexion.ResumeLayout(false);
            this.panelClienteConexion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Button registrarRolesbutton;
        private Button consultarRolesbutton;
        private Panel panelSideMenu;
        private Panel panelLogo;
        private Panel panelRolesSubMenu;
        private Button buttonDDRoles;
        private Button buttonDDConductores;
        private Panel panelChildForm;
        private PictureBox pictureBox2;
        private Panel panelClienteConexion;
        private Button buttonClienteConexion;
        private Label labelInfoClient;
        private PictureBox pictureBoxLogoChildPanel;
    }
}