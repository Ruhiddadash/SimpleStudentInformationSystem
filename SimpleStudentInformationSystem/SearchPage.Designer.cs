namespace SimpleStudentInformationSystem
{
    partial class SearchPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SearchPage));
            this.student_list = new System.Windows.Forms.ListView();
            this.textBox_search = new System.Windows.Forms.TextBox();
            this.btn_search = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.btn_refresh = new System.Windows.Forms.Button();
            this.pictureBox_cancel = new System.Windows.Forms.PictureBox();
            this.pictureBox_maximize = new System.Windows.Forms.PictureBox();
            this.pictureBox_minimize = new System.Windows.Forms.PictureBox();
            this.FirstName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Surname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Email = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Address = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Birthday = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maximize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).BeginInit();
            this.SuspendLayout();
            // 
            // student_list
            // 
            this.student_list.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.student_list.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FirstName,
            this.Surname,
            this.Email,
            this.Number,
            this.Address,
            this.Birthday});
            this.student_list.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.student_list.FullRowSelect = true;
            this.student_list.GridLines = true;
            this.student_list.HideSelection = false;
            this.student_list.Location = new System.Drawing.Point(10, 79);
            this.student_list.Name = "student_list";
            this.student_list.Size = new System.Drawing.Size(930, 652);
            this.student_list.TabIndex = 20;
            this.student_list.UseCompatibleStateImageBehavior = false;
            this.student_list.View = System.Windows.Forms.View.Details;
            // 
            // textBox_search
            // 
            this.textBox_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.textBox_search.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_search.Location = new System.Drawing.Point(209, 23);
            this.textBox_search.Multiline = true;
            this.textBox_search.Name = "textBox_search";
            this.textBox_search.Size = new System.Drawing.Size(198, 31);
            this.textBox_search.TabIndex = 21;
            // 
            // btn_search
            // 
            this.btn_search.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_search.BackColor = System.Drawing.Color.White;
            this.btn_search.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_search.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_search.Location = new System.Drawing.Point(435, 13);
            this.btn_search.Margin = new System.Windows.Forms.Padding(4);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(123, 45);
            this.btn_search.TabIndex = 31;
            this.btn_search.Text = "Search";
            this.btn_search.UseVisualStyleBackColor = false;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // btn_back
            // 
            this.btn_back.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_back.BackColor = System.Drawing.Color.White;
            this.btn_back.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_back.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_back.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_back.Location = new System.Drawing.Point(790, 750);
            this.btn_back.Margin = new System.Windows.Forms.Padding(4);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(130, 55);
            this.btn_back.TabIndex = 32;
            this.btn_back.Text = "Back";
            this.btn_back.UseVisualStyleBackColor = false;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // btn_refresh
            // 
            this.btn_refresh.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.btn_refresh.BackColor = System.Drawing.Color.White;
            this.btn_refresh.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_refresh.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_refresh.Font = new System.Drawing.Font("Ink Free", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_refresh.Location = new System.Drawing.Point(584, 13);
            this.btn_refresh.Margin = new System.Windows.Forms.Padding(4);
            this.btn_refresh.Name = "btn_refresh";
            this.btn_refresh.Size = new System.Drawing.Size(123, 45);
            this.btn_refresh.TabIndex = 33;
            this.btn_refresh.Text = "Refresh";
            this.btn_refresh.UseVisualStyleBackColor = false;
            this.btn_refresh.Click += new System.EventHandler(this.btn_refresh_Click);
            // 
            // pictureBox_cancel
            // 
            this.pictureBox_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_cancel.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_cancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_cancel.Image = global::SimpleStudentInformationSystem.Properties.Resources.Cancel;
            this.pictureBox_cancel.Location = new System.Drawing.Point(911, 2);
            this.pictureBox_cancel.Name = "pictureBox_cancel";
            this.pictureBox_cancel.Size = new System.Drawing.Size(29, 26);
            this.pictureBox_cancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_cancel.TabIndex = 36;
            this.pictureBox_cancel.TabStop = false;
            this.pictureBox_cancel.Click += new System.EventHandler(this.pictureBox_cancel_Click);
            // 
            // pictureBox_maximize
            // 
            this.pictureBox_maximize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_maximize.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_maximize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_maximize.Image = global::SimpleStudentInformationSystem.Properties.Resources.Maximize;
            this.pictureBox_maximize.Location = new System.Drawing.Point(876, 2);
            this.pictureBox_maximize.Name = "pictureBox_maximize";
            this.pictureBox_maximize.Size = new System.Drawing.Size(29, 26);
            this.pictureBox_maximize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_maximize.TabIndex = 35;
            this.pictureBox_maximize.TabStop = false;
            this.pictureBox_maximize.Click += new System.EventHandler(this.pictureBox_maximize_Click);
            // 
            // pictureBox_minimize
            // 
            this.pictureBox_minimize.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox_minimize.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox_minimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBox_minimize.Image = global::SimpleStudentInformationSystem.Properties.Resources.Minimize;
            this.pictureBox_minimize.Location = new System.Drawing.Point(840, 2);
            this.pictureBox_minimize.Name = "pictureBox_minimize";
            this.pictureBox_minimize.Size = new System.Drawing.Size(29, 26);
            this.pictureBox_minimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_minimize.TabIndex = 34;
            this.pictureBox_minimize.TabStop = false;
            this.pictureBox_minimize.Click += new System.EventHandler(this.pictureBox_minimize_Click);
            // 
            // FirstName
            // 
            this.FirstName.Text = "Name";
            this.FirstName.Width = 139;
            // 
            // Surname
            // 
            this.Surname.Text = "Surname";
            this.Surname.Width = 177;
            // 
            // Email
            // 
            this.Email.Text = "Email";
            this.Email.Width = 155;
            // 
            // Number
            // 
            this.Number.Text = "Number";
            this.Number.Width = 162;
            // 
            // Address
            // 
            this.Address.Text = "Address";
            this.Address.Width = 134;
            // 
            // Birthday
            // 
            this.Birthday.Text = "Birthday";
            this.Birthday.Width = 155;
            // 
            // SearchPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Purple;
            this.ClientSize = new System.Drawing.Size(944, 818);
            this.Controls.Add(this.pictureBox_cancel);
            this.Controls.Add(this.pictureBox_maximize);
            this.Controls.Add(this.pictureBox_minimize);
            this.Controls.Add(this.btn_refresh);
            this.Controls.Add(this.btn_back);
            this.Controls.Add(this.btn_search);
            this.Controls.Add(this.textBox_search);
            this.Controls.Add(this.student_list);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SearchPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SearchPage";
            this.Load += new System.EventHandler(this.SearchPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_cancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_maximize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_minimize)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView student_list;
        private System.Windows.Forms.TextBox textBox_search;
        private System.Windows.Forms.Button btn_search;
        private System.Windows.Forms.Button btn_back;
        private System.Windows.Forms.Button btn_refresh;
        private System.Windows.Forms.PictureBox pictureBox_cancel;
        private System.Windows.Forms.PictureBox pictureBox_maximize;
        private System.Windows.Forms.PictureBox pictureBox_minimize;
        private System.Windows.Forms.ColumnHeader FirstName;
        private System.Windows.Forms.ColumnHeader Surname;
        private System.Windows.Forms.ColumnHeader Email;
        private System.Windows.Forms.ColumnHeader Number;
        private System.Windows.Forms.ColumnHeader Address;
        private System.Windows.Forms.ColumnHeader Birthday;
    }
}