namespace SimpleStudentInformationSystem
{
    partial class Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main));
            this.panel_main = new System.Windows.Forms.Panel();
            this.pb_search = new System.Windows.Forms.PictureBox();
            this.pb_information = new System.Windows.Forms.PictureBox();
            this.pb_logOut = new System.Windows.Forms.PictureBox();
            this.pb_addStudent = new System.Windows.Forms.PictureBox();
            this.lbl_logOut = new System.Windows.Forms.Label();
            this.lbl_information = new System.Windows.Forms.Label();
            this.lbl_search = new System.Windows.Forms.Label();
            this.lbl_addStudent = new System.Windows.Forms.Label();
            this.lbl_main = new System.Windows.Forms.Label();
            this.pictureBox_cancel = new System.Windows.Forms.PictureBox();
            this.pictureBox_maximize = new System.Windows.Forms.PictureBox();
            this.pictureBox_minimize = new System.Windows.Forms.PictureBox();
            this.panel_main.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_search)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_information)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logOut)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_addStudent)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // panel_main
            // 
            this.panel_main.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.panel_main.BackColor = System.Drawing.Color.Purple;
            this.panel_main.Controls.Add(this.pb_search);
            this.panel_main.Controls.Add(this.pb_information);
            this.panel_main.Controls.Add(this.pb_logOut);
            this.panel_main.Controls.Add(this.pb_addStudent);
            this.panel_main.Controls.Add(this.lbl_logOut);
            this.panel_main.Controls.Add(this.lbl_information);
            this.panel_main.Controls.Add(this.lbl_search);
            this.panel_main.Controls.Add(this.lbl_addStudent);
            this.panel_main.Location = new System.Drawing.Point(63, 113);
            this.panel_main.Name = "panel_main";
            this.panel_main.Size = new System.Drawing.Size(985, 350);
            this.panel_main.TabIndex = 0;
            // 
            // pb_search
            // 
            this.pb_search.BackColor = System.Drawing.Color.Transparent;
            this.pb_search.Image = global::SimpleStudentInformationSystem.Properties.Resources.Search;
            this.pb_search.Location = new System.Drawing.Point(391, 121);
            this.pb_search.Name = "pb_search";
            this.pb_search.Size = new System.Drawing.Size(107, 69);
            this.pb_search.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_search.TabIndex = 0;
            this.pb_search.TabStop = false;
            this.pb_search.Click += new System.EventHandler(this.pb_search_Click);
            // 
            // pb_information
            // 
            this.pb_information.BackColor = System.Drawing.Color.Transparent;
            this.pb_information.Image = global::SimpleStudentInformationSystem.Properties.Resources.Information;
            this.pb_information.Location = new System.Drawing.Point(578, 121);
            this.pb_information.Name = "pb_information";
            this.pb_information.Size = new System.Drawing.Size(107, 69);
            this.pb_information.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_information.TabIndex = 0;
            this.pb_information.TabStop = false;
            this.pb_information.Click += new System.EventHandler(this.pb_information_Click);
            // 
            // pb_logOut
            // 
            this.pb_logOut.BackColor = System.Drawing.Color.Transparent;
            this.pb_logOut.Image = global::SimpleStudentInformationSystem.Properties.Resources.LogOut;
            this.pb_logOut.Location = new System.Drawing.Point(760, 121);
            this.pb_logOut.Name = "pb_logOut";
            this.pb_logOut.Size = new System.Drawing.Size(107, 69);
            this.pb_logOut.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_logOut.TabIndex = 0;
            this.pb_logOut.TabStop = false;
            this.pb_logOut.Click += new System.EventHandler(this.pb_logOut_Click);
            // 
            // pb_addStudent
            // 
            this.pb_addStudent.BackColor = System.Drawing.Color.Transparent;
            this.pb_addStudent.Image = global::SimpleStudentInformationSystem.Properties.Resources.AddStudent;
            this.pb_addStudent.Location = new System.Drawing.Point(169, 121);
            this.pb_addStudent.Name = "pb_addStudent";
            this.pb_addStudent.Size = new System.Drawing.Size(107, 69);
            this.pb_addStudent.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pb_addStudent.TabIndex = 0;
            this.pb_addStudent.TabStop = false;
            this.pb_addStudent.Click += new System.EventHandler(this.pb_addStudent_Click);
            // 
            // lbl_logOut
            // 
            this.lbl_logOut.AutoSize = true;
            this.lbl_logOut.BackColor = System.Drawing.Color.Purple;
            this.lbl_logOut.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_logOut.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_logOut.Location = new System.Drawing.Point(767, 221);
            this.lbl_logOut.Name = "lbl_logOut";
            this.lbl_logOut.Size = new System.Drawing.Size(87, 23);
            this.lbl_logOut.TabIndex = 14;
            this.lbl_logOut.Text = "Log Out";
            // 
            // lbl_information
            // 
            this.lbl_information.AutoSize = true;
            this.lbl_information.BackColor = System.Drawing.Color.Transparent;
            this.lbl_information.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_information.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_information.Location = new System.Drawing.Point(565, 221);
            this.lbl_information.Name = "lbl_information";
            this.lbl_information.Size = new System.Drawing.Size(131, 23);
            this.lbl_information.TabIndex = 10;
            this.lbl_information.Text = "Information";
            // 
            // lbl_search
            // 
            this.lbl_search.AutoSize = true;
            this.lbl_search.BackColor = System.Drawing.Color.Purple;
            this.lbl_search.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_search.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_search.Location = new System.Drawing.Point(411, 221);
            this.lbl_search.Name = "lbl_search";
            this.lbl_search.Size = new System.Drawing.Size(76, 23);
            this.lbl_search.TabIndex = 8;
            this.lbl_search.Text = "Search";
            // 
            // lbl_addStudent
            // 
            this.lbl_addStudent.AutoSize = true;
            this.lbl_addStudent.BackColor = System.Drawing.Color.Purple;
            this.lbl_addStudent.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addStudent.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_addStudent.Location = new System.Drawing.Point(156, 221);
            this.lbl_addStudent.Name = "lbl_addStudent";
            this.lbl_addStudent.Size = new System.Drawing.Size(131, 23);
            this.lbl_addStudent.TabIndex = 1;
            this.lbl_addStudent.Text = "Add Student";
            // 
            // lbl_main
            // 
            this.lbl_main.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.lbl_main.AutoSize = true;
            this.lbl_main.Font = new System.Drawing.Font("CommercialScript BT", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_main.ForeColor = System.Drawing.SystemColors.Info;
            this.lbl_main.Location = new System.Drawing.Point(323, 9);
            this.lbl_main.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbl_main.Name = "lbl_main";
            this.lbl_main.Size = new System.Drawing.Size(472, 69);
            this.lbl_main.TabIndex = 4;
            this.lbl_main.Text = "Student Dashboard";
            // 
            // pictureBox_cancel
            // 
            this.pictureBox_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_cancel.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_cancel.Image = global::SimpleStudentInformationSystem.Properties.Resources.Cancel;
            this.pictureBox_cancel.Location = new System.Drawing.Point(1045, 9);
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
            this.pictureBox_maximize.Location = new System.Drawing.Point(1010, 9);
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
            this.pictureBox_minimize.Location = new System.Drawing.Point(974, 9);
            this.pictureBox_minimize.Name = "pictureBox_minimize";
            this.pictureBox_minimize.Size = new System.Drawing.Size(29, 26);
            this.pictureBox_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_minimize.TabIndex = 9;
            this.pictureBox_minimize.TabStop = false;
            this.pictureBox_minimize.Click += new System.EventHandler(this.pictureBox_minimize_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1080, 532);
            this.Controls.Add(this.pictureBox_cancel);
            this.Controls.Add(this.pictureBox_maximize);
            this.Controls.Add(this.lbl_main);
            this.Controls.Add(this.pictureBox_minimize);
            this.Controls.Add(this.panel_main);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information System";
            this.panel_main.ResumeLayout(false);
            this.panel_main.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_search)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_information)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_logOut)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_addStudent)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel_main;
        private System.Windows.Forms.PictureBox pb_addStudent;
        private System.Windows.Forms.Label lbl_addStudent;
        private System.Windows.Forms.Label lbl_main;
        private System.Windows.Forms.Label lbl_logOut;
        private System.Windows.Forms.PictureBox pb_logOut;
        private System.Windows.Forms.Label lbl_information;
        private System.Windows.Forms.PictureBox pb_information;
        private System.Windows.Forms.Label lbl_search;
        private System.Windows.Forms.PictureBox pb_search;
        private System.Windows.Forms.PictureBox pictureBox_cancel;
        private System.Windows.Forms.PictureBox pictureBox_maximize;
        private System.Windows.Forms.PictureBox pictureBox_minimize;
    }
}