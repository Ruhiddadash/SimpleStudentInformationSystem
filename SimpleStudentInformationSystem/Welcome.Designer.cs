namespace SimpleStudentInformationSystem
{
    partial class Welcome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Welcome));
            this.btn_exit = new System.Windows.Forms.Button();
            this.btn_login = new System.Windows.Forms.Button();
            this.lbl_welcome = new System.Windows.Forms.Label();
            this.lbl_username = new System.Windows.Forms.Label();
            this.lbl_password = new System.Windows.Forms.Label();
            this.tb_username = new System.Windows.Forms.TextBox();
            this.tb_password = new System.Windows.Forms.TextBox();
            this.panel_login = new System.Windows.Forms.Panel();
            this.cb_showPass = new System.Windows.Forms.CheckBox();
            this.btn_go_regester = new System.Windows.Forms.Button();
            this.pictureBox_cancel = new System.Windows.Forms.PictureBox();
            this.pictureBox_maximize = new System.Windows.Forms.PictureBox();
            this.pictureBox_minimize = new System.Windows.Forms.PictureBox();
            this.panel_login.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_exit.BackColor = System.Drawing.Color.White;
            this.btn_exit.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_exit.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_exit.Location = new System.Drawing.Point(25, 546);
            this.btn_exit.Margin = new System.Windows.Forms.Padding(4);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(130, 55);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Exit";
            this.btn_exit.UseVisualStyleBackColor = false;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.White;
            this.btn_login.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.Font = new System.Drawing.Font("Ink Free", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_login.Location = new System.Drawing.Point(219, 435);
            this.btn_login.Margin = new System.Windows.Forms.Padding(4);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(256, 69);
            this.btn_login.TabIndex = 1;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // lbl_welcome
            // 
            this.lbl_welcome.AutoSize = true;
            this.lbl_welcome.Font = new System.Drawing.Font("CommercialScript BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_welcome.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_welcome.Location = new System.Drawing.Point(79, 18);
            this.lbl_welcome.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_welcome.Name = "lbl_welcome";
            this.lbl_welcome.Size = new System.Drawing.Size(541, 69);
            this.lbl_welcome.TabIndex = 2;
            this.lbl_welcome.Text = "Welcome to the System";
            // 
            // lbl_username
            // 
            this.lbl_username.AutoSize = true;
            this.lbl_username.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_username.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_username.Location = new System.Drawing.Point(264, 132);
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
            this.lbl_password.Location = new System.Drawing.Point(264, 240);
            this.lbl_password.Name = "lbl_password";
            this.lbl_password.Size = new System.Drawing.Size(135, 33);
            this.lbl_password.TabIndex = 4;
            this.lbl_password.Text = "Password";
            // 
            // tb_username
            // 
            this.tb_username.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_username.Location = new System.Drawing.Point(185, 187);
            this.tb_username.Name = "tb_username";
            this.tb_username.Size = new System.Drawing.Size(324, 31);
            this.tb_username.TabIndex = 5;
            // 
            // tb_password
            // 
            this.tb_password.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_password.Location = new System.Drawing.Point(185, 295);
            this.tb_password.Name = "tb_password";
            this.tb_password.PasswordChar = '•';
            this.tb_password.Size = new System.Drawing.Size(324, 31);
            this.tb_password.TabIndex = 6;
            // 
            // panel_login
            // 
            this.panel_login.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel_login.Controls.Add(this.cb_showPass);
            this.panel_login.Controls.Add(this.tb_username);
            this.panel_login.Controls.Add(this.lbl_welcome);
            this.panel_login.Controls.Add(this.tb_password);
            this.panel_login.Controls.Add(this.btn_login);
            this.panel_login.Controls.Add(this.lbl_username);
            this.panel_login.Controls.Add(this.lbl_password);
            this.panel_login.Location = new System.Drawing.Point(225, 12);
            this.panel_login.Name = "panel_login";
            this.panel_login.Size = new System.Drawing.Size(654, 550);
            this.panel_login.TabIndex = 7;
            // 
            // cb_showPass
            // 
            this.cb_showPass.AutoSize = true;
            this.cb_showPass.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.cb_showPass.Location = new System.Drawing.Point(185, 347);
            this.cb_showPass.Name = "cb_showPass";
            this.cb_showPass.Size = new System.Drawing.Size(156, 28);
            this.cb_showPass.TabIndex = 7;
            this.cb_showPass.Text = "Show Password";
            this.cb_showPass.UseVisualStyleBackColor = true;
            this.cb_showPass.CheckedChanged += new System.EventHandler(this.cb_showPass_CheckedChanged);
            // 
            // btn_go_regester
            // 
            this.btn_go_regester.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_go_regester.BackColor = System.Drawing.Color.White;
            this.btn_go_regester.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_go_regester.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_go_regester.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_go_regester.Location = new System.Drawing.Point(956, 546);
            this.btn_go_regester.Margin = new System.Windows.Forms.Padding(4);
            this.btn_go_regester.Name = "btn_go_regester";
            this.btn_go_regester.Size = new System.Drawing.Size(130, 55);
            this.btn_go_regester.TabIndex = 8;
            this.btn_go_regester.Text = "Register";
            this.btn_go_regester.UseVisualStyleBackColor = false;
            this.btn_go_regester.Click += new System.EventHandler(this.btn_go_regester_Click);
            // 
            // pictureBox_cancel
            // 
            this.pictureBox_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_cancel.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_cancel.Image = global::SimpleStudentInformationSystem.Properties.Resources.Cancel;
            this.pictureBox_cancel.Location = new System.Drawing.Point(1061, 3);
            this.pictureBox_cancel.Name = "pictureBox_cancel";
            this.pictureBox_cancel.Size = new System.Drawing.Size(29, 26);
            this.pictureBox_cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_cancel.TabIndex = 24;
            this.pictureBox_cancel.TabStop = false;
            this.pictureBox_cancel.Click += new System.EventHandler(this.pictureBox_cancel_Click_1);
            // 
            // pictureBox_maximize
            // 
            this.pictureBox_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_maximize.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_maximize.Image = global::SimpleStudentInformationSystem.Properties.Resources.Maximize;
            this.pictureBox_maximize.Location = new System.Drawing.Point(1026, 3);
            this.pictureBox_maximize.Name = "pictureBox_maximize";
            this.pictureBox_maximize.Size = new System.Drawing.Size(29, 26);
            this.pictureBox_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_maximize.TabIndex = 23;
            this.pictureBox_maximize.TabStop = false;
            this.pictureBox_maximize.Click += new System.EventHandler(this.pictureBox_maximize_Click_1);
            // 
            // pictureBox_minimize
            // 
            this.pictureBox_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_minimize.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_minimize.Image = global::SimpleStudentInformationSystem.Properties.Resources.Minimize;
            this.pictureBox_minimize.Location = new System.Drawing.Point(990, 3);
            this.pictureBox_minimize.Name = "pictureBox_minimize";
            this.pictureBox_minimize.Size = new System.Drawing.Size(29, 26);
            this.pictureBox_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_minimize.TabIndex = 22;
            this.pictureBox_minimize.TabStop = false;
            this.pictureBox_minimize.Click += new System.EventHandler(this.pictureBox_minimize_Click);
            // 
            // Welcome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1096, 613);
            this.Controls.Add(this.pictureBox_cancel);
            this.Controls.Add(this.pictureBox_maximize);
            this.Controls.Add(this.pictureBox_minimize);
            this.Controls.Add(this.btn_go_regester);
            this.Controls.Add(this.panel_login);
            this.Controls.Add(this.btn_exit);
            this.Font = new System.Drawing.Font("Comic Sans MS", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Welcome";
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

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label lbl_welcome;
        private System.Windows.Forms.Label lbl_username;
        private System.Windows.Forms.Label lbl_password;
        private System.Windows.Forms.TextBox tb_username;
        private System.Windows.Forms.TextBox tb_password;
        private System.Windows.Forms.Panel panel_login;
        private System.Windows.Forms.CheckBox cb_showPass;
        private System.Windows.Forms.Button btn_go_regester;
        private System.Windows.Forms.PictureBox pictureBox_cancel;
        private System.Windows.Forms.PictureBox pictureBox_maximize;
        private System.Windows.Forms.PictureBox pictureBox_minimize;
    }
}

