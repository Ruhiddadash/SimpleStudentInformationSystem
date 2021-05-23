namespace SimpleStudentInformationSystem
{
    partial class AddStudent
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddStudent));
            this.btn_back = new System.Windows.Forms.Button();
            this.tb_surName = new System.Windows.Forms.TextBox();
            this.lbl_name = new System.Windows.Forms.Label();
            this.lbl_surname = new System.Windows.Forms.Label();
            this.tb_name = new System.Windows.Forms.TextBox();
            this.panel_add = new System.Windows.Forms.Panel();
            this.btn_add = new System.Windows.Forms.Button();
            this.mtb_birthday = new System.Windows.Forms.MaskedTextBox();
            this.lbl_birthday = new System.Windows.Forms.Label();
            this.tb_address = new System.Windows.Forms.TextBox();
            this.lbl_address = new System.Windows.Forms.Label();
            this.tb_email = new System.Windows.Forms.TextBox();
            this.tb_number = new System.Windows.Forms.TextBox();
            this.lbl_email = new System.Windows.Forms.Label();
            this.lbl_number = new System.Windows.Forms.Label();
            this.student_list = new System.Windows.Forms.ListView();
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Birthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.pictureBox_cancel = new System.Windows.Forms.PictureBox();
            this.pictureBox_maximize = new System.Windows.Forms.PictureBox();
            this.pictureBox_minimize = new System.Windows.Forms.PictureBox();
            this.panel_add.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(962, 635);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(130, 55);
            this.btn_back.TabIndex = 11;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // tb_surName
            // 
            this.tb_surName.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_surName.Location = new System.Drawing.Point(22, 137);
            this.tb_surName.Name = "tb_surName";
            this.tb_surName.Size = new System.Drawing.Size(237, 29);
            this.tb_surName.TabIndex = 13;
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Constantia", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_name.Location = new System.Drawing.Point(94, 17);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(78, 27);
            this.lbl_name.TabIndex = 14;
            this.lbl_name.Text = "Name:";
            // 
            // lbl_surname
            // 
            this.lbl_surname.AutoSize = true;
            this.lbl_surname.BackColor = System.Drawing.Color.Transparent;
            this.lbl_surname.Font = new System.Drawing.Font("Constantia", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_surname.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_surname.Location = new System.Drawing.Point(81, 106);
            this.lbl_surname.Name = "lbl_surname";
            this.lbl_surname.Size = new System.Drawing.Size(112, 27);
            this.lbl_surname.TabIndex = 16;
            this.lbl_surname.Text = "Surname:";
            // 
            // tb_name
            // 
            this.tb_name.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_name.Location = new System.Drawing.Point(22, 48);
            this.tb_name.Name = "tb_name";
            this.tb_name.Size = new System.Drawing.Size(237, 29);
            this.tb_name.TabIndex = 15;
            // 
            // panel_add
            // 
            this.panel_add.Controls.Add(this.btn_add);
            this.panel_add.Controls.Add(this.mtb_birthday);
            this.panel_add.Controls.Add(this.lbl_birthday);
            this.panel_add.Controls.Add(this.tb_address);
            this.panel_add.Controls.Add(this.lbl_address);
            this.panel_add.Controls.Add(this.tb_email);
            this.panel_add.Controls.Add(this.tb_number);
            this.panel_add.Controls.Add(this.lbl_email);
            this.panel_add.Controls.Add(this.lbl_number);
            this.panel_add.Controls.Add(this.tb_name);
            this.panel_add.Controls.Add(this.tb_surName);
            this.panel_add.Controls.Add(this.lbl_name);
            this.panel_add.Controls.Add(this.lbl_surname);
            this.panel_add.Location = new System.Drawing.Point(2, 3);
            this.panel_add.Name = "panel_add";
            this.panel_add.Size = new System.Drawing.Size(286, 698);
            this.panel_add.TabIndex = 17;
            // 
            // btn_add
            // 
            this.btn_add.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btn_add.BackColor = System.Drawing.Color.White;
            this.btn_add.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_add.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_add.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_add.Location = new System.Drawing.Point(73, 616);
            this.btn_add.Margin = new System.Windows.Forms.Padding(4);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(130, 55);
            this.btn_add.TabIndex = 29;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = false;
            this.btn_add.Click += new System.EventHandler(this.btn_add_Click);
            // 
            // mtb_birthday
            // 
            this.mtb_birthday.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtb_birthday.Location = new System.Drawing.Point(22, 521);
            this.mtb_birthday.Mask = "00/00/0000";
            this.mtb_birthday.Name = "mtb_birthday";
            this.mtb_birthday.Size = new System.Drawing.Size(237, 29);
            this.mtb_birthday.TabIndex = 28;
            this.mtb_birthday.ValidatingType = typeof(System.DateTime);
            // 
            // lbl_birthday
            // 
            this.lbl_birthday.AutoSize = true;
            this.lbl_birthday.BackColor = System.Drawing.Color.Transparent;
            this.lbl_birthday.Font = new System.Drawing.Font("Constantia", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_birthday.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_birthday.Location = new System.Drawing.Point(81, 490);
            this.lbl_birthday.Name = "lbl_birthday";
            this.lbl_birthday.Size = new System.Drawing.Size(108, 27);
            this.lbl_birthday.TabIndex = 27;
            this.lbl_birthday.Text = "Birthday:";
            // 
            // tb_address
            // 
            this.tb_address.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_address.Location = new System.Drawing.Point(22, 413);
            this.tb_address.Name = "tb_address";
            this.tb_address.Size = new System.Drawing.Size(237, 29);
            this.tb_address.TabIndex = 23;
            // 
            // lbl_address
            // 
            this.lbl_address.AutoSize = true;
            this.lbl_address.BackColor = System.Drawing.Color.Transparent;
            this.lbl_address.Font = new System.Drawing.Font("Constantia", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_address.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_address.Location = new System.Drawing.Point(85, 382);
            this.lbl_address.Name = "lbl_address";
            this.lbl_address.Size = new System.Drawing.Size(100, 27);
            this.lbl_address.TabIndex = 22;
            this.lbl_address.Text = "Address:";
            // 
            // tb_email
            // 
            this.tb_email.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_email.Location = new System.Drawing.Point(22, 227);
            this.tb_email.Name = "tb_email";
            this.tb_email.Size = new System.Drawing.Size(237, 29);
            this.tb_email.TabIndex = 19;
            // 
            // tb_number
            // 
            this.tb_number.Font = new System.Drawing.Font("Constantia", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_number.Location = new System.Drawing.Point(22, 321);
            this.tb_number.Name = "tb_number";
            this.tb_number.Size = new System.Drawing.Size(237, 29);
            this.tb_number.TabIndex = 17;
            // 
            // lbl_email
            // 
            this.lbl_email.AutoSize = true;
            this.lbl_email.BackColor = System.Drawing.Color.Transparent;
            this.lbl_email.Font = new System.Drawing.Font("Constantia", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_email.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_email.Location = new System.Drawing.Point(94, 196);
            this.lbl_email.Name = "lbl_email";
            this.lbl_email.Size = new System.Drawing.Size(78, 27);
            this.lbl_email.TabIndex = 18;
            this.lbl_email.Text = "Email:";
            // 
            // lbl_number
            // 
            this.lbl_number.AutoSize = true;
            this.lbl_number.BackColor = System.Drawing.Color.Transparent;
            this.lbl_number.Font = new System.Drawing.Font("Constantia", 13.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_number.ForeColor = System.Drawing.SystemColors.ControlLightLight;
            this.lbl_number.Location = new System.Drawing.Point(85, 290);
            this.lbl_number.Name = "lbl_number";
            this.lbl_number.Size = new System.Drawing.Size(102, 27);
            this.lbl_number.TabIndex = 20;
            this.lbl_number.Text = "Number:";
            // 
            // student_list
            // 
            this.student_list.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.student_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.Surname,
            this.Email,
            this.Number,
            this.Address,
            this.Birthday});
            this.student_list.FullRowSelect = true;
            this.student_list.GridLines = true;
            this.student_list.HideSelection = false;
            this.student_list.Location = new System.Drawing.Point(294, 42);
            this.student_list.Name = "student_list";
            this.student_list.Size = new System.Drawing.Size(806, 544);
            this.student_list.TabIndex = 18;
            this.student_list.UseCompatibleStateImageBehavior = false;
            this.student_list.View = System.Windows.Forms.View.Details;
            // 
            // FirstName
            // 
            this.FirstName.Text = "Name";
            this.FirstName.Width = 116;
            // 
            // Surname
            // 
            this.Surname.Text = "Surname";
            this.Surname.Width = 116;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 134;
            // 
            // Number
            // 
            this.Number.Text = "Number";
            this.Number.Width = 140;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 161;
            // 
            // Birthday
            // 
            this.Birthday.Text = "Birthday";
            this.Birthday.Width = 132;
            // 
            // pictureBox_cancel
            // 
            this.pictureBox_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_cancel.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_cancel.Image = global::SimpleStudentInformationSystem.Properties.Resources.Cancel;
            this.pictureBox_cancel.Location = new System.Drawing.Point(1070, 3);
            this.pictureBox_cancel.Name = "pictureBox_cancel";
            this.pictureBox_cancel.Size = new System.Drawing.Size(29, 26);
            this.pictureBox_cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_cancel.TabIndex = 21;
            this.pictureBox_cancel.TabStop = false;
            this.pictureBox_cancel.Click += new System.EventHandler(this.pictureBox_cancel_Click);
            // 
            // pictureBox_maximize
            // 
            this.pictureBox_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_maximize.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_maximize.Image = global::SimpleStudentInformationSystem.Properties.Resources.Maximize;
            this.pictureBox_maximize.Location = new System.Drawing.Point(1035, 3);
            this.pictureBox_maximize.Name = "pictureBox_maximize";
            this.pictureBox_maximize.Size = new System.Drawing.Size(29, 26);
            this.pictureBox_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_maximize.TabIndex = 20;
            this.pictureBox_maximize.TabStop = false;
            this.pictureBox_maximize.Click += new System.EventHandler(this.pictureBox_maximize_Click);
            // 
            // pictureBox_minimize
            // 
            this.pictureBox_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_minimize.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_minimize.Image = global::SimpleStudentInformationSystem.Properties.Resources.Minimize;
            this.pictureBox_minimize.Location = new System.Drawing.Point(999, 3);
            this.pictureBox_minimize.Name = "pictureBox_minimize";
            this.pictureBox_minimize.Size = new System.Drawing.Size(29, 26);
            this.pictureBox_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_minimize.TabIndex = 19;
            this.pictureBox_minimize.TabStop = false;
            this.pictureBox_minimize.Click += new System.EventHandler(this.pictureBox_minimize_Click);
            // 
            // AddStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(1105, 703);
            this.Controls.Add(this.pictureBox_cancel);
            this.Controls.Add(this.pictureBox_maximize);
            this.Controls.Add(this.pictureBox_minimize);
            this.Controls.Add(this.student_list);
            this.Controls.Add(this.panel_add);
            this.Controls.Add(this.btn_back);
            this.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "AddStudent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Information System";
            this.Load += new System.EventHandler(this.AddStudent_Load);
            this.panel_add.ResumeLayout(false);
            this.panel_add.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.TextBox tb_surName;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.Label lbl_surname;
        private System.Windows.Forms.TextBox tb_name;
        private System.Windows.Forms.Panel panel_add;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.MaskedTextBox mtb_birthday;
        private System.Windows.Forms.Label lbl_birthday;
        private System.Windows.Forms.TextBox tb_address;
        private System.Windows.Forms.Label lbl_address;
        private System.Windows.Forms.TextBox tb_email;
        private System.Windows.Forms.TextBox tb_number;
        private System.Windows.Forms.Label lbl_email;
        private System.Windows.Forms.Label lbl_number;
        private System.Windows.Forms.ListView student_list;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Birthday;
        private System.Windows.Forms.PictureBox pictureBox_cancel;
        private System.Windows.Forms.PictureBox pictureBox_maximize;
        private System.Windows.Forms.PictureBox pictureBox_minimize;
    }
}