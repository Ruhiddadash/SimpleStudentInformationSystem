namespace SimpleStudentInformationSystem
{
    partial class Register
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Register));
            this.lbl_join = new System.Windows.Forms.Label();
            this.panel_login = new System.Windows.Forms.Panel();
            this.tb_confirm = new System.Windows.Forms.TextBox();
            this.lbl_confirmPass = new System.Windows.Forms.Label();
            this.btn_register = new System.Windows.Forms.Button();
            this.cb_showPass = new System.Windows.Forms.CheckBox();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_go_login = new System.Windows.Forms.Button();
            this.pictureBox_cancel = new System.Windows.Forms.PictureBox();
            this.pictureBox_maximize = new System.Windows.Forms.PictureBox();
            this.pictureBox_minimize = new System.Windows.Forms.PictureBox();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_join
            // 
            this.lbl_join.AutoSize = true;
            this.lbl_join.Font = new System.Drawing.Font("CommercialScript BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_join.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_join.Location = new System.Drawing.Point(265, 18);
            this.lbl_join.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_join.Name = "lbl_join";
            this.lbl_join.Size = new System.Drawing.Size(445, 69);
            this.lbl_join.TabIndex = 3;
            this.lbl_join.Text = "Join to the System";
            // 
            // panel_login
            // 
            this.panel_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel_login.Controls.Add(this.tb_confirm);
            this.panel_login.Controls.Add(this.lbl_confirmPass);
            this.panel_login.Controls.Add(this.btn_register);
            this.panel_login.Controls.Add(this.cb_showPass);
            this.panel_login.Controls.Add(this.tb_username);
            this.panel_login.Controls.Add(this.lbl_join);
            this.panel_login.Controls.Add(this.tb_password);
            this.panel_login.Controls.Add(this.lbl_username);
            this.panel_login.Controls.Add(this.lbl_password);
            this.panel_login.Location = new System.Drawing.Point(117, 12);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(901, 613);
            this.panel_login.TabIndex = 8;
            // 
            // tb_confirm
            // 
            this.tb_confirm.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_confirm.Location = new System.Drawing.Point(315, 381);
            this.tb_confirm.Name = "tb_confirm";
            this.tb_confirm.PasswordChar = '•';
            this.tb_confirm.Size = new System.Drawing.Size(324, 31);
            this.tb_confirm.TabIndex = 9;
            // 
            // lbl_confirmPass
            // 
            this.lbl_confirmPass.AutoSize = true;
            this.lbl_confirmPass.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_confirmPass.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_confirmPass.Location = new System.Drawing.Point(351, 330);
            this.lbl_confirmPass.Name = "lbl_confirmPass";
            this.lbl_confirmPass.Size = new System.Drawing.Size(255, 33);
            this.lbl_confirmPass.TabIndex = 8;
            this.lbl_confirmPass.Text = "Confirm Password";
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.White;
            this.btn_register.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_register.Location = new System.Drawing.Point(350, 506);
            this.btn_register.Margin = new System.Windows.Forms.Padding(4);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(256, 69);
            this.btn_register.TabIndex = 9;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // cb_showPass
            // 
            this.cb_showPass.AutoSize = true;
            this.cb_showPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_showPass.Location = new System.Drawing.Point(315, 446);
            this.cb_showPass.Name = "cb_showPass";
            this.cb_showPass.Size = new System.Drawing.Size(156, 28);
            this.cb_showPass.TabIndex = 7;
            this.cb_showPass.Text = "Show Password";
            this.cb_showPass.UseVisualStyleBackColor = true;
            this.cb_showPass.CheckedChanged += new System.EventHandler(this.cb_showPass_CheckedChanged);
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(315, 178);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(324, 31);
            this.tb_username.TabIndex = 5;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(315, 277);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '•';
            this.tb_password.Size = new System.Drawing.Size(324, 31);
            this.tb_password.TabIndex = 6;
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_username.Location = new System.Drawing.Point(394, 123);
            this.lbl_username.Name = "lbl_username";
            this.lbl_username.Size = new System.Drawing.Size(135, 33);
            this.lbl_username.TabIndex = 3;
            this.lbl_username.Text = "Username";
            // 
            // lbl_password
            // 
            this.lbl_password.AutoSize = true;
            this.lbl_password.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_password.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_password.Location = new System.Drawing.Point(394, 222);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(135, 33);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password";
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(13, 634);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(130, 55);
            this.btn_exit.TabIndex = 10;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_go_login
            // 
            this.btn_go_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_go_login.BackColor = System.Drawing.Color.White;
            this.btn_go_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_go_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_go_login.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_go_login.Location = new System.Drawing.Point(996, 634);
            this.btn_go_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_go_login.Name = "btn_go_login";
            this.btn_go_login.Size = new System.Drawing.Size(130, 55);
            this.btn_go_login.TabIndex = 11;
            this.btn_go_login.Text = "Login";
            this.btn_go_login.UseVisualStyleBackColor = false;
            this.btn_go_login.Click += new System.EventHandler(this.btn_go_login_Click);
            // 
            // pictureBox_cancel
            // 
            this.pictureBox_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_cancel.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_cancel.Image = global::SimpleStudentInformationSystem.Properties.Resources.Cancel;
            this.pictureBox_cancel.Location = new System.Drawing.Point(1107, 3);
            this.pictureBox_cancel.Name = "pictureBox_cancel";
            this.pictureBox_cancel.Size = new System.Drawing.Size(29, 26);
            this.pictureBox_cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_cancel.TabIndex = 11;
            this.pictureBox_cancel.TabStop = false;
            this.pictureBox_cancel.Click += new System.EventHandler(this.pictureBox_cancel_Click);
            // 
            // pictureBox_maximize
            // 
            this.pictureBox_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_maximize.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_maximize.Image = global::SimpleStudentInformationSystem.Properties.Resources.Maximize;
            this.pictureBox_maximize.Location = new System.Drawing.Point(1072, 3);
            this.pictureBox_maximize.Name = "pictureBox_maximize";
            this.pictureBox_maximize.Size = new System.Drawing.Size(29, 26);
            this.pictureBox_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_maximize.TabIndex = 11;
            this.pictureBox_maximize.TabStop = false;
            this.pictureBox_maximize.Click += new System.EventHandler(this.pictureBox_maximize_Click);
            // 
            // pictureBox_minimize
            // 
            this.pictureBox_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_minimize.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_minimize.Image = global::SimpleStudentInformationSystem.Properties.Resources.Minimize;
            this.pictureBox_minimize.Location = new System.Drawing.Point(1037, 3);
            this.pictureBox_minimize.Name = "pictureBox_minimize";
            this.pictureBox_minimize.Size = new System.Drawing.Size(29, 26);
            this.pictureBox_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_minimize.TabIndex = 9;
            this.pictureBox_minimize.TabStop = false;
            this.pictureBox_minimize.Click += new System.EventHandler(this.pictureBox_minimize_Click);
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1139, 702);
            this.Controls.Add(this.pictureBox_minimize);
            this.Controls.Add(this.pictureBox_maximize);
            this.Controls.Add(this.pictureBox_cancel);
            this.Controls.Add(this.btn_go_login);
            this.Controls.Add(this.btn_exit);
            this.Controls.Add(this.panel_login);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Register";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information System";
            this.panel_login.ResumeLayout(false);
            this.panel_login.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_join;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.CheckBox cb_showPass;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_confirm;
        private System.Windows.Forms.Label lbl_confirmPass;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_go_login;
        private System.Windows.Forms.PictureBox pictureBox_cancel;
        private System.Windows.Forms.PictureBox pictureBox_maximize;
        private System.Windows.Forms.PictureBox pictureBox_minimize;
    }
}