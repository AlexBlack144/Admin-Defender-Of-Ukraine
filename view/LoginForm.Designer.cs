namespace Game_Kursak_Admin.view
{
    partial class LoginForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LoginForm));
            this.label_login = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.btn_login = new System.Windows.Forms.Button();
            this.checkBox_See = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.BackColor = System.Drawing.Color.Transparent;
            this.label_login.Font = new System.Drawing.Font("Chiller", 28.25F, System.Drawing.FontStyle.Bold);
            this.label_login.ForeColor = System.Drawing.Color.White;
            this.label_login.Location = new System.Drawing.Point(51, 37);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(93, 44);
            this.label_login.TabIndex = 11;
            this.label_login.Text = "Login:";
            // 
            // label_Password
            // 
            this.label_Password.AutoSize = true;
            this.label_Password.BackColor = System.Drawing.Color.Transparent;
            this.label_Password.Font = new System.Drawing.Font("Chiller", 28.25F, System.Drawing.FontStyle.Bold);
            this.label_Password.ForeColor = System.Drawing.Color.White;
            this.label_Password.Location = new System.Drawing.Point(12, 92);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(132, 44);
            this.label_Password.TabIndex = 12;
            this.label_Password.Text = "Password:";
            // 
            // textBox_login
            // 
            this.textBox_login.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_login.Font = new System.Drawing.Font("Chiller", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_login.Location = new System.Drawing.Point(158, 37);
            this.textBox_login.MaxLength = 15;
            this.textBox_login.Multiline = true;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(197, 38);
            this.textBox_login.TabIndex = 13;
            // 
            // textBox_password
            // 
            this.textBox_password.BackColor = System.Drawing.Color.WhiteSmoke;
            this.textBox_password.Font = new System.Drawing.Font("Chiller", 21.75F, System.Drawing.FontStyle.Bold);
            this.textBox_password.Location = new System.Drawing.Point(158, 98);
            this.textBox_password.MaxLength = 15;
            this.textBox_password.Multiline = true;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.PasswordChar = '*';
            this.textBox_password.Size = new System.Drawing.Size(197, 38);
            this.textBox_password.TabIndex = 14;
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.SystemColors.Desktop;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Default;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Chiller", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.ForeColor = System.Drawing.Color.DarkRed;
            this.btn_login.Location = new System.Drawing.Point(177, 167);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(127, 51);
            this.btn_login.TabIndex = 23;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // checkBox_See
            // 
            this.checkBox_See.AutoSize = true;
            this.checkBox_See.BackColor = System.Drawing.Color.Transparent;
            this.checkBox_See.Font = new System.Drawing.Font("Comic Sans MS", 9.75F, System.Drawing.FontStyle.Bold);
            this.checkBox_See.ForeColor = System.Drawing.Color.White;
            this.checkBox_See.Location = new System.Drawing.Point(370, 108);
            this.checkBox_See.Name = "checkBox_See";
            this.checkBox_See.Size = new System.Drawing.Size(53, 23);
            this.checkBox_See.TabIndex = 25;
            this.checkBox_See.Text = "SEE";
            this.checkBox_See.UseVisualStyleBackColor = false;
            this.checkBox_See.CheckedChanged += new System.EventHandler(this.checkBox_See_CheckedChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Game_Kursak_Admin.Properties.Resources.kamuflyag;
            this.ClientSize = new System.Drawing.Size(435, 230);
            this.Controls.Add(this.checkBox_See);
            this.Controls.Add(this.btn_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_login);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LoginForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Defender of Ukraine";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_Password;
        private System.Windows.Forms.TextBox textBox_login;
        private System.Windows.Forms.TextBox textBox_password;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.CheckBox checkBox_See;
    }
}