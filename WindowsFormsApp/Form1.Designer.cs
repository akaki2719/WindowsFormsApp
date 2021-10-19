
namespace WindowsFormsApp
{
    partial class Form1
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
            this.login_label = new System.Windows.Forms.Label();
            this.login_button = new System.Windows.Forms.Button();
            this.usernameLogin = new System.Windows.Forms.TextBox();
            this.login_username_label = new System.Windows.Forms.Label();
            this.login_password_labal = new System.Windows.Forms.Label();
            this.passwordLogin = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.nameRegister = new System.Windows.Forms.TextBox();
            this.registerusername = new System.Windows.Forms.TextBox();
            this.register_name_label = new System.Windows.Forms.Label();
            this.register_username_label = new System.Windows.Forms.Label();
            this.register_button = new System.Windows.Forms.Button();
            this.lastnameRegister = new System.Windows.Forms.TextBox();
            this.confirmPasswordRegister = new System.Windows.Forms.TextBox();
            this.passwordRegister = new System.Windows.Forms.TextBox();
            this.register_password_label = new System.Windows.Forms.Label();
            this.register_lastname_label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.register_passconfirm_labal = new System.Windows.Forms.Label();
            this.responseRegister = new System.Windows.Forms.Label();
            this.responseLogin = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // login_label
            // 
            this.login_label.AutoSize = true;
            this.login_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.login_label.Location = new System.Drawing.Point(39, 30);
            this.login_label.Name = "login_label";
            this.login_label.Size = new System.Drawing.Size(46, 20);
            this.login_label.TabIndex = 0;
            this.login_label.Text = "log in\r\n";
            // 
            // login_button
            // 
            this.login_button.Location = new System.Drawing.Point(43, 165);
            this.login_button.Name = "login_button";
            this.login_button.Size = new System.Drawing.Size(75, 23);
            this.login_button.TabIndex = 1;
            this.login_button.Text = "login\r\n";
            this.login_button.UseVisualStyleBackColor = true;
            this.login_button.Click += new System.EventHandler(this.login_button_Click);
            // 
            // usernameLogin
            // 
            this.usernameLogin.Location = new System.Drawing.Point(43, 85);
            this.usernameLogin.Name = "usernameLogin";
            this.usernameLogin.Size = new System.Drawing.Size(100, 20);
            this.usernameLogin.TabIndex = 2;
            // 
            // login_username_label
            // 
            this.login_username_label.AutoSize = true;
            this.login_username_label.Location = new System.Drawing.Point(40, 69);
            this.login_username_label.Name = "login_username_label";
            this.login_username_label.Size = new System.Drawing.Size(53, 13);
            this.login_username_label.TabIndex = 3;
            this.login_username_label.Text = "username\r\n";
            // 
            // login_password_labal
            // 
            this.login_password_labal.AutoSize = true;
            this.login_password_labal.Location = new System.Drawing.Point(43, 117);
            this.login_password_labal.Name = "login_password_labal";
            this.login_password_labal.Size = new System.Drawing.Size(52, 13);
            this.login_password_labal.TabIndex = 4;
            this.login_password_labal.Text = "password";
            // 
            // passwordLogin
            // 
            this.passwordLogin.Location = new System.Drawing.Point(43, 133);
            this.passwordLogin.Name = "passwordLogin";
            this.passwordLogin.Size = new System.Drawing.Size(100, 20);
            this.passwordLogin.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(273, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "register";
            // 
            // nameRegister
            // 
            this.nameRegister.Location = new System.Drawing.Point(276, 85);
            this.nameRegister.Name = "nameRegister";
            this.nameRegister.Size = new System.Drawing.Size(100, 20);
            this.nameRegister.TabIndex = 7;
            // 
            // registerusername
            // 
            this.registerusername.Location = new System.Drawing.Point(276, 133);
            this.registerusername.Name = "registerusername";
            this.registerusername.Size = new System.Drawing.Size(100, 20);
            this.registerusername.TabIndex = 8;
            // 
            // register_name_label
            // 
            this.register_name_label.AutoSize = true;
            this.register_name_label.Location = new System.Drawing.Point(276, 68);
            this.register_name_label.Name = "register_name_label";
            this.register_name_label.Size = new System.Drawing.Size(33, 13);
            this.register_name_label.TabIndex = 9;
            this.register_name_label.Text = "name\r\n";
            // 
            // register_username_label
            // 
            this.register_username_label.AutoSize = true;
            this.register_username_label.Location = new System.Drawing.Point(273, 117);
            this.register_username_label.Name = "register_username_label";
            this.register_username_label.Size = new System.Drawing.Size(53, 13);
            this.register_username_label.TabIndex = 10;
            this.register_username_label.Text = "username";
            // 
            // register_button
            // 
            this.register_button.Location = new System.Drawing.Point(276, 217);
            this.register_button.Name = "register_button";
            this.register_button.Size = new System.Drawing.Size(75, 23);
            this.register_button.TabIndex = 11;
            this.register_button.Text = "register";
            this.register_button.UseVisualStyleBackColor = true;
            this.register_button.Click += new System.EventHandler(this.register_button_Click);
            // 
            // lastnameRegister
            // 
            this.lastnameRegister.Location = new System.Drawing.Point(412, 84);
            this.lastnameRegister.Name = "lastnameRegister";
            this.lastnameRegister.Size = new System.Drawing.Size(100, 20);
            this.lastnameRegister.TabIndex = 12;
            // 
            // confirmPasswordRegister
            // 
            this.confirmPasswordRegister.Location = new System.Drawing.Point(412, 184);
            this.confirmPasswordRegister.Name = "confirmPasswordRegister";
            this.confirmPasswordRegister.Size = new System.Drawing.Size(100, 20);
            this.confirmPasswordRegister.TabIndex = 13;
            // 
            // passwordRegister
            // 
            this.passwordRegister.Location = new System.Drawing.Point(276, 184);
            this.passwordRegister.Name = "passwordRegister";
            this.passwordRegister.Size = new System.Drawing.Size(100, 20);
            this.passwordRegister.TabIndex = 14;
            // 
            // register_password_label
            // 
            this.register_password_label.AutoSize = true;
            this.register_password_label.Location = new System.Drawing.Point(276, 165);
            this.register_password_label.Name = "register_password_label";
            this.register_password_label.Size = new System.Drawing.Size(52, 13);
            this.register_password_label.TabIndex = 15;
            this.register_password_label.Text = "password";
            // 
            // register_lastname_label
            // 
            this.register_lastname_label.AutoSize = true;
            this.register_lastname_label.Location = new System.Drawing.Point(412, 65);
            this.register_lastname_label.Name = "register_lastname_label";
            this.register_lastname_label.Size = new System.Drawing.Size(49, 13);
            this.register_lastname_label.TabIndex = 16;
            this.register_lastname_label.Text = "lastname";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(415, 165);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 13);
            this.label6.TabIndex = 17;
            // 
            // register_passconfirm_labal
            // 
            this.register_passconfirm_labal.AutoSize = true;
            this.register_passconfirm_labal.Location = new System.Drawing.Point(409, 165);
            this.register_passconfirm_labal.Name = "register_passconfirm_labal";
            this.register_passconfirm_labal.Size = new System.Drawing.Size(89, 13);
            this.register_passconfirm_labal.TabIndex = 18;
            this.register_passconfirm_labal.Text = "password confirm";
            // 
            // responseRegister
            // 
            this.responseRegister.AutoSize = true;
            this.responseRegister.Location = new System.Drawing.Point(279, 279);
            this.responseRegister.Name = "responseRegister";
            this.responseRegister.Size = new System.Drawing.Size(0, 13);
            this.responseRegister.TabIndex = 19;
            // 
            // responseLogin
            // 
            this.responseLogin.AutoSize = true;
            this.responseLogin.Location = new System.Drawing.Point(46, 217);
            this.responseLogin.Name = "responseLogin";
            this.responseLogin.Size = new System.Drawing.Size(0, 13);
            this.responseLogin.TabIndex = 20;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.responseLogin);
            this.Controls.Add(this.responseRegister);
            this.Controls.Add(this.register_passconfirm_labal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.register_lastname_label);
            this.Controls.Add(this.register_password_label);
            this.Controls.Add(this.passwordRegister);
            this.Controls.Add(this.confirmPasswordRegister);
            this.Controls.Add(this.lastnameRegister);
            this.Controls.Add(this.register_button);
            this.Controls.Add(this.register_username_label);
            this.Controls.Add(this.register_name_label);
            this.Controls.Add(this.registerusername);
            this.Controls.Add(this.nameRegister);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordLogin);
            this.Controls.Add(this.login_password_labal);
            this.Controls.Add(this.login_username_label);
            this.Controls.Add(this.usernameLogin);
            this.Controls.Add(this.login_button);
            this.Controls.Add(this.login_label);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label login_label;
        private System.Windows.Forms.Button login_button;
        private System.Windows.Forms.TextBox usernameLogin;
        private System.Windows.Forms.Label login_username_label;
        private System.Windows.Forms.Label login_password_labal;
        private System.Windows.Forms.TextBox passwordLogin;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameRegister;
        private System.Windows.Forms.TextBox registerusername;
        private System.Windows.Forms.Label register_name_label;
        private System.Windows.Forms.Label register_username_label;
        private System.Windows.Forms.Button register_button;
        private System.Windows.Forms.TextBox lastnameRegister;
        private System.Windows.Forms.TextBox confirmPasswordRegister;
        private System.Windows.Forms.TextBox passwordRegister;
        private System.Windows.Forms.Label register_password_label;
        private System.Windows.Forms.Label register_lastname_label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label register_passconfirm_labal;
        private System.Windows.Forms.Label responseRegister;
        private System.Windows.Forms.Label responseLogin;
    }
}

