namespace FRoG_Creator.Client
{
    partial class ClientForm
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelUsername = new System.Windows.Forms.Label();
            this.textBoxUsername = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.panelLogin = new System.Windows.Forms.Panel();
            this.buttonConnect = new System.Windows.Forms.Button();
            this.checkBoxRemember = new System.Windows.Forms.CheckBox();
            this.buttonRegister = new System.Windows.Forms.Button();
            this.labelConnect = new System.Windows.Forms.Label();
            this.panelRegister = new System.Windows.Forms.Panel();
            this.labelRegister = new System.Windows.Forms.Label();
            this.labelRegisterName = new System.Windows.Forms.Label();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.labelRegisterPassword = new System.Windows.Forms.Label();
            this.textBoxRegisterPassword = new System.Windows.Forms.TextBox();
            this.labelRepeatPassword = new System.Windows.Forms.Label();
            this.textBoxRepeatPassword = new System.Windows.Forms.TextBox();
            this.buttonRegisterDone = new System.Windows.Forms.Button();
            this.buttonReturnMain = new System.Windows.Forms.Button();
            this.panelLogin.SuspendLayout();
            this.panelRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelUsername
            // 
            this.labelUsername.AutoSize = true;
            this.labelUsername.Location = new System.Drawing.Point(100, 100);
            this.labelUsername.Name = "labelUsername";
            this.labelUsername.Size = new System.Drawing.Size(88, 13);
            this.labelUsername.TabIndex = 1;
            this.labelUsername.Text = "Nom de compte :";
            // 
            // textBoxUsername
            // 
            this.textBoxUsername.Location = new System.Drawing.Point(103, 116);
            this.textBoxUsername.Name = "textBoxUsername";
            this.textBoxUsername.Size = new System.Drawing.Size(380, 20);
            this.textBoxUsername.TabIndex = 2;
            // 
            // labelPassword
            // 
            this.labelPassword.AutoSize = true;
            this.labelPassword.Location = new System.Drawing.Point(100, 180);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(77, 13);
            this.labelPassword.TabIndex = 3;
            this.labelPassword.Text = "Mot de passe :";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(103, 196);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '#';
            this.textBoxPassword.Size = new System.Drawing.Size(380, 20);
            this.textBoxPassword.TabIndex = 4;
            // 
            // panelLogin
            // 
            this.panelLogin.Controls.Add(this.labelConnect);
            this.panelLogin.Controls.Add(this.buttonRegister);
            this.panelLogin.Controls.Add(this.checkBoxRemember);
            this.panelLogin.Controls.Add(this.buttonConnect);
            this.panelLogin.Controls.Add(this.textBoxUsername);
            this.panelLogin.Controls.Add(this.textBoxPassword);
            this.panelLogin.Controls.Add(this.labelPassword);
            this.panelLogin.Controls.Add(this.labelUsername);
            this.panelLogin.Location = new System.Drawing.Point(12, 12);
            this.panelLogin.Name = "panelLogin";
            this.panelLogin.Size = new System.Drawing.Size(600, 417);
            this.panelLogin.TabIndex = 4;
            // 
            // buttonConnect
            // 
            this.buttonConnect.Location = new System.Drawing.Point(333, 300);
            this.buttonConnect.Name = "buttonConnect";
            this.buttonConnect.Size = new System.Drawing.Size(150, 35);
            this.buttonConnect.TabIndex = 7;
            this.buttonConnect.Text = "Connexion";
            this.buttonConnect.UseVisualStyleBackColor = true;
            this.buttonConnect.Click += new System.EventHandler(this.buttonConnect_Click);
            // 
            // checkBoxRemember
            // 
            this.checkBoxRemember.AutoSize = true;
            this.checkBoxRemember.Location = new System.Drawing.Point(103, 222);
            this.checkBoxRemember.Name = "checkBoxRemember";
            this.checkBoxRemember.Size = new System.Drawing.Size(151, 17);
            this.checkBoxRemember.TabIndex = 5;
            this.checkBoxRemember.Text = "Mémoriser le mot de passe";
            this.checkBoxRemember.UseVisualStyleBackColor = true;
            // 
            // buttonRegister
            // 
            this.buttonRegister.Location = new System.Drawing.Point(103, 300);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(150, 35);
            this.buttonRegister.TabIndex = 6;
            this.buttonRegister.Text = "Créer un compte";
            this.buttonRegister.UseVisualStyleBackColor = true;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // labelConnect
            // 
            this.labelConnect.AutoSize = true;
            this.labelConnect.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelConnect.Location = new System.Drawing.Point(50, 50);
            this.labelConnect.Name = "labelConnect";
            this.labelConnect.Size = new System.Drawing.Size(84, 20);
            this.labelConnect.TabIndex = 0;
            this.labelConnect.Text = "Connexion";
            // 
            // panelRegister
            // 
            this.panelRegister.Controls.Add(this.buttonReturnMain);
            this.panelRegister.Controls.Add(this.buttonRegisterDone);
            this.panelRegister.Controls.Add(this.textBoxRepeatPassword);
            this.panelRegister.Controls.Add(this.labelRepeatPassword);
            this.panelRegister.Controls.Add(this.textBoxRegisterPassword);
            this.panelRegister.Controls.Add(this.labelRegisterPassword);
            this.panelRegister.Controls.Add(this.textBoxName);
            this.panelRegister.Controls.Add(this.labelRegisterName);
            this.panelRegister.Controls.Add(this.labelRegister);
            this.panelRegister.Enabled = false;
            this.panelRegister.Location = new System.Drawing.Point(12, 12);
            this.panelRegister.Name = "panelRegister";
            this.panelRegister.Size = new System.Drawing.Size(600, 416);
            this.panelRegister.TabIndex = 5;
            // 
            // labelRegister
            // 
            this.labelRegister.AutoSize = true;
            this.labelRegister.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRegister.Location = new System.Drawing.Point(50, 50);
            this.labelRegister.Name = "labelRegister";
            this.labelRegister.Size = new System.Drawing.Size(82, 20);
            this.labelRegister.TabIndex = 0;
            this.labelRegister.Text = "Inscription";
            // 
            // labelRegisterName
            // 
            this.labelRegisterName.AutoSize = true;
            this.labelRegisterName.Location = new System.Drawing.Point(100, 100);
            this.labelRegisterName.Name = "labelRegisterName";
            this.labelRegisterName.Size = new System.Drawing.Size(74, 13);
            this.labelRegisterName.TabIndex = 1;
            this.labelRegisterName.Text = "Pseudonyme :";
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(103, 116);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(380, 20);
            this.textBoxName.TabIndex = 2;
            // 
            // labelRegisterPassword
            // 
            this.labelRegisterPassword.AutoSize = true;
            this.labelRegisterPassword.Location = new System.Drawing.Point(100, 180);
            this.labelRegisterPassword.Name = "labelRegisterPassword";
            this.labelRegisterPassword.Size = new System.Drawing.Size(77, 13);
            this.labelRegisterPassword.TabIndex = 3;
            this.labelRegisterPassword.Text = "Mot de passe :";
            // 
            // textBoxRegisterPassword
            // 
            this.textBoxRegisterPassword.Location = new System.Drawing.Point(103, 196);
            this.textBoxRegisterPassword.Name = "textBoxRegisterPassword";
            this.textBoxRegisterPassword.PasswordChar = '#';
            this.textBoxRegisterPassword.Size = new System.Drawing.Size(380, 20);
            this.textBoxRegisterPassword.TabIndex = 4;
            // 
            // labelRepeatPassword
            // 
            this.labelRepeatPassword.AutoSize = true;
            this.labelRepeatPassword.Location = new System.Drawing.Point(103, 230);
            this.labelRepeatPassword.Name = "labelRepeatPassword";
            this.labelRepeatPassword.Size = new System.Drawing.Size(130, 13);
            this.labelRepeatPassword.TabIndex = 5;
            this.labelRepeatPassword.Text = "Retapez le mot de passe :";
            // 
            // textBoxRepeatPassword
            // 
            this.textBoxRepeatPassword.Location = new System.Drawing.Point(103, 246);
            this.textBoxRepeatPassword.Name = "textBoxRepeatPassword";
            this.textBoxRepeatPassword.PasswordChar = '#';
            this.textBoxRepeatPassword.Size = new System.Drawing.Size(380, 20);
            this.textBoxRepeatPassword.TabIndex = 6;
            // 
            // buttonRegisterDone
            // 
            this.buttonRegisterDone.Location = new System.Drawing.Point(333, 300);
            this.buttonRegisterDone.Name = "buttonRegisterDone";
            this.buttonRegisterDone.Size = new System.Drawing.Size(150, 35);
            this.buttonRegisterDone.TabIndex = 8;
            this.buttonRegisterDone.Text = "S\'enregistrer";
            this.buttonRegisterDone.UseVisualStyleBackColor = true;
            this.buttonRegisterDone.Click += new System.EventHandler(this.buttonRegisterDone_Click);
            // 
            // buttonReturnMain
            // 
            this.buttonReturnMain.Location = new System.Drawing.Point(103, 300);
            this.buttonReturnMain.Name = "buttonReturnMain";
            this.buttonReturnMain.Size = new System.Drawing.Size(150, 35);
            this.buttonReturnMain.TabIndex = 7;
            this.buttonReturnMain.Text = "Retour";
            this.buttonReturnMain.UseVisualStyleBackColor = true;
            this.buttonReturnMain.Click += new System.EventHandler(this.buttonReturnMain_Click);
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 441);
            this.Controls.Add(this.panelLogin);
            this.Controls.Add(this.panelRegister);
            this.Name = "ClientForm";
            this.Text = "Frog Creator 1.0";
            this.panelLogin.ResumeLayout(false);
            this.panelLogin.PerformLayout();
            this.panelRegister.ResumeLayout(false);
            this.panelRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label labelUsername;
        private System.Windows.Forms.TextBox textBoxUsername;
        private System.Windows.Forms.Label labelPassword;
        private System.Windows.Forms.TextBox textBoxPassword;
        private System.Windows.Forms.Panel panelLogin;
        private System.Windows.Forms.CheckBox checkBoxRemember;
        private System.Windows.Forms.Button buttonConnect;
        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.Label labelConnect;
        private System.Windows.Forms.Panel panelRegister;
        private System.Windows.Forms.Label labelRegister;
        private System.Windows.Forms.Label labelRegisterName;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label labelRegisterPassword;
        private System.Windows.Forms.TextBox textBoxRegisterPassword;
        private System.Windows.Forms.TextBox textBoxRepeatPassword;
        private System.Windows.Forms.Label labelRepeatPassword;
        private System.Windows.Forms.Button buttonRegisterDone;
        private System.Windows.Forms.Button buttonReturnMain;
    }
}

