namespace Presentation
{
    partial class Profilefrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Profilefrm));
            this.PanelEdit = new System.Windows.Forms.Panel();
            this.lkEditar = new System.Windows.Forms.LinkLabel();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.txtCurrentPass = new System.Windows.Forms.TextBox();
            this.txtConfirmPass = new System.Windows.Forms.TextBox();
            this.lblEditCurrentPass = new System.Windows.Forms.Label();
            this.lblConfirmPass = new System.Windows.Forms.Label();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.lblEditContraseña = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblEditEmail = new System.Windows.Forms.Label();
            this.txtApellidos = new System.Windows.Forms.TextBox();
            this.lblEditApellidos = new System.Windows.Forms.Label();
            this.txtNames = new System.Windows.Forms.TextBox();
            this.lblEditName = new System.Windows.Forms.Label();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.lblEditUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnClose = new System.Windows.Forms.PictureBox();
            this.ProfilePicture = new System.Windows.Forms.PictureBox();
            this.lblMyProfile = new System.Windows.Forms.Label();
            this.lblUsernameTitle = new System.Windows.Forms.Label();
            this.lblPrimerNombretitle = new System.Windows.Forms.Label();
            this.lblApellidosTite = new System.Windows.Forms.Label();
            this.lblInfoEmail = new System.Windows.Forms.Label();
            this.lkEditProfile = new System.Windows.Forms.LinkLabel();
            this.lblInfoUser = new System.Windows.Forms.Label();
            this.lblInfoName = new System.Windows.Forms.Label();
            this.lblInfoLastName = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.PanelEdit.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelEdit
            // 
            this.PanelEdit.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(70)))), ((int)(((byte)(67)))), ((int)(((byte)(75)))));
            this.PanelEdit.Controls.Add(this.lkEditar);
            this.PanelEdit.Controls.Add(this.btnSave);
            this.PanelEdit.Controls.Add(this.btnCancel);
            this.PanelEdit.Controls.Add(this.txtCurrentPass);
            this.PanelEdit.Controls.Add(this.txtConfirmPass);
            this.PanelEdit.Controls.Add(this.lblEditCurrentPass);
            this.PanelEdit.Controls.Add(this.lblConfirmPass);
            this.PanelEdit.Controls.Add(this.txtContraseña);
            this.PanelEdit.Controls.Add(this.lblEditContraseña);
            this.PanelEdit.Controls.Add(this.txtEmail);
            this.PanelEdit.Controls.Add(this.lblEditEmail);
            this.PanelEdit.Controls.Add(this.txtApellidos);
            this.PanelEdit.Controls.Add(this.lblEditApellidos);
            this.PanelEdit.Controls.Add(this.txtNames);
            this.PanelEdit.Controls.Add(this.lblEditName);
            this.PanelEdit.Controls.Add(this.txtUserName);
            this.PanelEdit.Controls.Add(this.lblEditUsername);
            this.PanelEdit.Controls.Add(this.label1);
            this.PanelEdit.Dock = System.Windows.Forms.DockStyle.Right;
            this.PanelEdit.Location = new System.Drawing.Point(562, 0);
            this.PanelEdit.Name = "PanelEdit";
            this.PanelEdit.Size = new System.Drawing.Size(389, 539);
            this.PanelEdit.TabIndex = 0;
            this.PanelEdit.Visible = false;
            // 
            // lkEditar
            // 
            this.lkEditar.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(53)))), ((int)(((byte)(79)))));
            this.lkEditar.AutoSize = true;
            this.lkEditar.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkEditar.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lkEditar.Location = new System.Drawing.Point(130, 265);
            this.lkEditar.Name = "lkEditar";
            this.lkEditar.Size = new System.Drawing.Size(45, 17);
            this.lkEditar.TabIndex = 17;
            this.lkEditar.TabStop = true;
            this.lkEditar.Text = "Editar";
            this.lkEditar.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkEditar_LinkClicked);
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(39)))), ((int)(((byte)(84)))));
            this.btnSave.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnSave.Location = new System.Drawing.Point(230, 455);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(136, 40);
            this.btnSave.TabIndex = 16;
            this.btnSave.Text = "Guardar";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.BackColor = System.Drawing.Color.Gray;
            this.btnCancel.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnCancel.Location = new System.Drawing.Point(27, 455);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(136, 40);
            this.btnCancel.TabIndex = 15;
            this.btnCancel.Text = "Cancelar";
            this.btnCancel.UseVisualStyleBackColor = false;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // txtCurrentPass
            // 
            this.txtCurrentPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCurrentPass.Location = new System.Drawing.Point(27, 390);
            this.txtCurrentPass.Name = "txtCurrentPass";
            this.txtCurrentPass.Size = new System.Drawing.Size(342, 23);
            this.txtCurrentPass.TabIndex = 14;
            // 
            // txtConfirmPass
            // 
            this.txtConfirmPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConfirmPass.Location = new System.Drawing.Point(24, 338);
            this.txtConfirmPass.Name = "txtConfirmPass";
            this.txtConfirmPass.Size = new System.Drawing.Size(342, 23);
            this.txtConfirmPass.TabIndex = 13;
            // 
            // lblEditCurrentPass
            // 
            this.lblEditCurrentPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditCurrentPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEditCurrentPass.Location = new System.Drawing.Point(24, 364);
            this.lblEditCurrentPass.Name = "lblEditCurrentPass";
            this.lblEditCurrentPass.Size = new System.Drawing.Size(139, 23);
            this.lblEditCurrentPass.TabIndex = 12;
            this.lblEditCurrentPass.Text = "Contraseña actual:";
            this.lblEditCurrentPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblConfirmPass
            // 
            this.lblConfirmPass.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblConfirmPass.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblConfirmPass.Location = new System.Drawing.Point(24, 312);
            this.lblConfirmPass.Name = "lblConfirmPass";
            this.lblConfirmPass.Size = new System.Drawing.Size(196, 23);
            this.lblConfirmPass.TabIndex = 11;
            this.lblConfirmPass.Text = "Confirme su contraseña:";
            this.lblConfirmPass.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtContraseña
            // 
            this.txtContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtContraseña.Location = new System.Drawing.Point(24, 286);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.Size = new System.Drawing.Size(342, 23);
            this.txtContraseña.TabIndex = 10;
            // 
            // lblEditContraseña
            // 
            this.lblEditContraseña.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditContraseña.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEditContraseña.Location = new System.Drawing.Point(24, 260);
            this.lblEditContraseña.Name = "lblEditContraseña";
            this.lblEditContraseña.Size = new System.Drawing.Size(139, 23);
            this.lblEditContraseña.TabIndex = 9;
            this.lblEditContraseña.Text = "Contraseña:";
            this.lblEditContraseña.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(24, 234);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(342, 23);
            this.txtEmail.TabIndex = 8;
            // 
            // lblEditEmail
            // 
            this.lblEditEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEditEmail.Location = new System.Drawing.Point(24, 208);
            this.lblEditEmail.Name = "lblEditEmail";
            this.lblEditEmail.Size = new System.Drawing.Size(139, 23);
            this.lblEditEmail.TabIndex = 7;
            this.lblEditEmail.Text = "Email:";
            this.lblEditEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtApellidos
            // 
            this.txtApellidos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtApellidos.Location = new System.Drawing.Point(24, 182);
            this.txtApellidos.Name = "txtApellidos";
            this.txtApellidos.Size = new System.Drawing.Size(342, 23);
            this.txtApellidos.TabIndex = 6;
            // 
            // lblEditApellidos
            // 
            this.lblEditApellidos.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditApellidos.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEditApellidos.Location = new System.Drawing.Point(24, 156);
            this.lblEditApellidos.Name = "lblEditApellidos";
            this.lblEditApellidos.Size = new System.Drawing.Size(139, 23);
            this.lblEditApellidos.TabIndex = 5;
            this.lblEditApellidos.Text = "Apellidos:";
            this.lblEditApellidos.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtNames
            // 
            this.txtNames.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNames.Location = new System.Drawing.Point(24, 130);
            this.txtNames.Name = "txtNames";
            this.txtNames.Size = new System.Drawing.Size(342, 23);
            this.txtNames.TabIndex = 4;
            // 
            // lblEditName
            // 
            this.lblEditName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEditName.Location = new System.Drawing.Point(24, 104);
            this.lblEditName.Name = "lblEditName";
            this.lblEditName.Size = new System.Drawing.Size(139, 23);
            this.lblEditName.TabIndex = 3;
            this.lblEditName.Text = "Nombres:";
            this.lblEditName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtUserName
            // 
            this.txtUserName.Enabled = false;
            this.txtUserName.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUserName.Location = new System.Drawing.Point(24, 78);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(342, 23);
            this.txtUserName.TabIndex = 2;
            // 
            // lblEditUsername
            // 
            this.lblEditUsername.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEditUsername.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEditUsername.Location = new System.Drawing.Point(24, 51);
            this.lblEditUsername.Name = "lblEditUsername";
            this.lblEditUsername.Size = new System.Drawing.Size(139, 23);
            this.lblEditUsername.TabIndex = 1;
            this.lblEditUsername.Text = "Nombre de usuario:";
            this.lblEditUsername.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(20, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Editar perfil";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnClose
            // 
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(12, 12);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(16, 16);
            this.btnClose.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btnClose.TabIndex = 1;
            this.btnClose.TabStop = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // ProfilePicture
            // 
            this.ProfilePicture.Image = ((System.Drawing.Image)(resources.GetObject("ProfilePicture.Image")));
            this.ProfilePicture.Location = new System.Drawing.Point(12, 51);
            this.ProfilePicture.Name = "ProfilePicture";
            this.ProfilePicture.Size = new System.Drawing.Size(222, 201);
            this.ProfilePicture.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ProfilePicture.TabIndex = 2;
            this.ProfilePicture.TabStop = false;
            // 
            // lblMyProfile
            // 
            this.lblMyProfile.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMyProfile.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblMyProfile.Location = new System.Drawing.Point(34, 9);
            this.lblMyProfile.Name = "lblMyProfile";
            this.lblMyProfile.Size = new System.Drawing.Size(120, 38);
            this.lblMyProfile.TabIndex = 3;
            this.lblMyProfile.Text = "Mi Perfil";
            this.lblMyProfile.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblUsernameTitle
            // 
            this.lblUsernameTitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsernameTitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblUsernameTitle.Location = new System.Drawing.Point(240, 51);
            this.lblUsernameTitle.Name = "lblUsernameTitle";
            this.lblUsernameTitle.Size = new System.Drawing.Size(139, 23);
            this.lblUsernameTitle.TabIndex = 4;
            this.lblUsernameTitle.Text = "Nombre de usuario:";
            this.lblUsernameTitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblPrimerNombretitle
            // 
            this.lblPrimerNombretitle.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrimerNombretitle.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblPrimerNombretitle.Location = new System.Drawing.Point(240, 97);
            this.lblPrimerNombretitle.Name = "lblPrimerNombretitle";
            this.lblPrimerNombretitle.Size = new System.Drawing.Size(139, 23);
            this.lblPrimerNombretitle.TabIndex = 5;
            this.lblPrimerNombretitle.Text = "Nombres: ";
            this.lblPrimerNombretitle.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblApellidosTite
            // 
            this.lblApellidosTite.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblApellidosTite.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblApellidosTite.Location = new System.Drawing.Point(240, 143);
            this.lblApellidosTite.Name = "lblApellidosTite";
            this.lblApellidosTite.Size = new System.Drawing.Size(139, 23);
            this.lblApellidosTite.TabIndex = 6;
            this.lblApellidosTite.Text = "Apellidos:";
            this.lblApellidosTite.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lblInfoEmail
            // 
            this.lblInfoEmail.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfoEmail.Location = new System.Drawing.Point(240, 189);
            this.lblInfoEmail.Name = "lblInfoEmail";
            this.lblInfoEmail.Size = new System.Drawing.Size(139, 23);
            this.lblInfoEmail.TabIndex = 7;
            this.lblInfoEmail.Text = "Email:";
            this.lblInfoEmail.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // lkEditProfile
            // 
            this.lkEditProfile.ActiveLinkColor = System.Drawing.Color.SteelBlue;
            this.lkEditProfile.AutoSize = true;
            this.lkEditProfile.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lkEditProfile.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.lkEditProfile.Location = new System.Drawing.Point(240, 249);
            this.lkEditProfile.Name = "lkEditProfile";
            this.lkEditProfile.Size = new System.Drawing.Size(80, 17);
            this.lkEditProfile.TabIndex = 8;
            this.lkEditProfile.TabStop = true;
            this.lkEditProfile.Text = "Editar perfil";
            this.lkEditProfile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lkEditProfile_LinkClicked);
            // 
            // lblInfoUser
            // 
            this.lblInfoUser.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoUser.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfoUser.Location = new System.Drawing.Point(240, 74);
            this.lblInfoUser.Name = "lblInfoUser";
            this.lblInfoUser.Size = new System.Drawing.Size(136, 23);
            this.lblInfoUser.TabIndex = 9;
            this.lblInfoUser.Text = "username";
            // 
            // lblInfoName
            // 
            this.lblInfoName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfoName.Location = new System.Drawing.Point(240, 120);
            this.lblInfoName.Name = "lblInfoName";
            this.lblInfoName.Size = new System.Drawing.Size(136, 23);
            this.lblInfoName.TabIndex = 10;
            this.lblInfoName.Text = "names";
            // 
            // lblInfoLastName
            // 
            this.lblInfoLastName.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInfoLastName.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblInfoLastName.Location = new System.Drawing.Point(240, 166);
            this.lblInfoLastName.Name = "lblInfoLastName";
            this.lblInfoLastName.Size = new System.Drawing.Size(136, 23);
            this.lblInfoLastName.TabIndex = 11;
            this.lblInfoLastName.Text = "lastname";
            // 
            // lblEmail
            // 
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.lblEmail.Location = new System.Drawing.Point(240, 212);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(167, 23);
            this.lblEmail.TabIndex = 12;
            this.lblEmail.Text = "email";
            // 
            // Profilefrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(35)))), ((int)(((byte)(32)))), ((int)(((byte)(39)))));
            this.ClientSize = new System.Drawing.Size(951, 539);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblInfoLastName);
            this.Controls.Add(this.lblInfoName);
            this.Controls.Add(this.lblInfoUser);
            this.Controls.Add(this.lkEditProfile);
            this.Controls.Add(this.lblInfoEmail);
            this.Controls.Add(this.lblApellidosTite);
            this.Controls.Add(this.lblPrimerNombretitle);
            this.Controls.Add(this.lblUsernameTitle);
            this.Controls.Add(this.lblMyProfile);
            this.Controls.Add(this.ProfilePicture);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.PanelEdit);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Profilefrm";
            this.Text = "EditProfile";
            this.Load += new System.EventHandler(this.btnClose_Load);
            this.PanelEdit.ResumeLayout(false);
            this.PanelEdit.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnClose)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePicture)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel PanelEdit;
        private System.Windows.Forms.PictureBox btnClose;
        private System.Windows.Forms.PictureBox ProfilePicture;
        private System.Windows.Forms.Label lblMyProfile;
        private System.Windows.Forms.Label lblUsernameTitle;
        private System.Windows.Forms.Label lblPrimerNombretitle;
        private System.Windows.Forms.Label lblApellidosTite;
        private System.Windows.Forms.Label lblInfoEmail;
        private System.Windows.Forms.LinkLabel lkEditProfile;
        private System.Windows.Forms.Label lblInfoUser;
        private System.Windows.Forms.Label lblInfoName;
        private System.Windows.Forms.Label lblInfoLastName;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblEditUsername;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Label lblEditName;
        private System.Windows.Forms.TextBox txtNames;
        private System.Windows.Forms.TextBox txtApellidos;
        private System.Windows.Forms.Label lblEditApellidos;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label lblEditEmail;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.Label lblEditContraseña;
        private System.Windows.Forms.TextBox txtCurrentPass;
        private System.Windows.Forms.TextBox txtConfirmPass;
        private System.Windows.Forms.Label lblEditCurrentPass;
        private System.Windows.Forms.Label lblConfirmPass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.LinkLabel lkEditar;
    }
}