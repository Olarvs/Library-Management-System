﻿namespace LibrarySystem
{
    partial class frmUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUser));
            this.dtg_listUser = new System.Windows.Forms.DataGridView();
            this.btn_saveuser = new System.Windows.Forms.Button();
            this.btn_update = new System.Windows.Forms.Button();
            this.Button1 = new System.Windows.Forms.Button();
            this.btn_New = new System.Windows.Forms.Button();
            this.Label4 = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.Label3 = new System.Windows.Forms.Label();
            this.txt_username = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.txt_pass = new System.Windows.Forms.TextBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.cbo_type = new System.Windows.Forms.ComboBox();
            this.btn_delete = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listUser)).BeginInit();
            this.SuspendLayout();
            // 
            // dtg_listUser
            // 
            this.dtg_listUser.AllowUserToAddRows = false;
            this.dtg_listUser.AllowUserToDeleteRows = false;
            this.dtg_listUser.AllowUserToResizeColumns = false;
            this.dtg_listUser.AllowUserToResizeRows = false;
            this.dtg_listUser.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dtg_listUser.BackgroundColor = System.Drawing.SystemColors.ButtonFace;
            this.dtg_listUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtg_listUser.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dtg_listUser.Location = new System.Drawing.Point(12, 135);
            this.dtg_listUser.Name = "dtg_listUser";
            this.dtg_listUser.RowHeadersVisible = false;
            this.dtg_listUser.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dtg_listUser.Size = new System.Drawing.Size(506, 294);
            this.dtg_listUser.TabIndex = 43;
            this.dtg_listUser.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtg_listUser_CellClick);
            // 
            // btn_saveuser
            // 
            this.btn_saveuser.BackColor = System.Drawing.Color.Transparent;
            this.btn_saveuser.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_saveuser.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_saveuser.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_saveuser.Location = new System.Drawing.Point(14, 442);
            this.btn_saveuser.Name = "btn_saveuser";
            this.btn_saveuser.Size = new System.Drawing.Size(76, 30);
            this.btn_saveuser.TabIndex = 34;
            this.btn_saveuser.Text = "SAVE";
            this.btn_saveuser.UseVisualStyleBackColor = false;
            this.btn_saveuser.Click += new System.EventHandler(this.btn_saveuser_Click);
            // 
            // btn_update
            // 
            this.btn_update.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_update.Enabled = false;
            this.btn_update.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_update.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_update.Location = new System.Drawing.Point(96, 442);
            this.btn_update.Name = "btn_update";
            this.btn_update.Size = new System.Drawing.Size(76, 30);
            this.btn_update.TabIndex = 36;
            this.btn_update.Text = "UPDATE";
            this.btn_update.UseVisualStyleBackColor = true;
            this.btn_update.Click += new System.EventHandler(this.btn_update_Click);
            // 
            // Button1
            // 
            this.Button1.BackColor = System.Drawing.Color.Transparent;
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.Button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Button1.ForeColor = System.Drawing.Color.Brown;
            this.Button1.Location = new System.Drawing.Point(442, 442);
            this.Button1.Name = "Button1";
            this.Button1.Size = new System.Drawing.Size(76, 30);
            this.Button1.TabIndex = 38;
            this.Button1.Text = "CLOSE";
            this.Button1.UseVisualStyleBackColor = false;
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // btn_New
            // 
            this.btn_New.BackColor = System.Drawing.Color.Transparent;
            this.btn_New.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btn_New.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_New.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_New.Location = new System.Drawing.Point(360, 442);
            this.btn_New.Name = "btn_New";
            this.btn_New.Size = new System.Drawing.Size(76, 30);
            this.btn_New.TabIndex = 39;
            this.btn_New.Text = "NEW";
            this.btn_New.UseVisualStyleBackColor = false;
            this.btn_New.Click += new System.EventHandler(this.btn_New_Click);
            // 
            // Label4
            // 
            this.Label4.AutoSize = true;
            this.Label4.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label4.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label4.Location = new System.Drawing.Point(21, 104);
            this.Label4.Name = "Label4";
            this.Label4.Size = new System.Drawing.Size(39, 17);
            this.Label4.TabIndex = 37;
            this.Label4.Text = "TYPE:";
            // 
            // txt_name
            // 
            this.txt_name.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.Location = new System.Drawing.Point(120, 21);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(322, 25);
            this.txt_name.TabIndex = 28;
            // 
            // Label3
            // 
            this.Label3.AutoSize = true;
            this.Label3.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label3.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label3.Location = new System.Drawing.Point(21, 79);
            this.Label3.Name = "Label3";
            this.Label3.Size = new System.Drawing.Size(78, 17);
            this.Label3.TabIndex = 35;
            this.Label3.Text = "PASSWORD:";
            // 
            // txt_username
            // 
            this.txt_username.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_username.Location = new System.Drawing.Point(120, 48);
            this.txt_username.Name = "txt_username";
            this.txt_username.Size = new System.Drawing.Size(322, 25);
            this.txt_username.TabIndex = 29;
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label2.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label2.Location = new System.Drawing.Point(20, 51);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(79, 17);
            this.Label2.TabIndex = 32;
            this.Label2.Text = "USERNAME:";
            // 
            // txt_pass
            // 
            this.txt_pass.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_pass.Location = new System.Drawing.Point(120, 76);
            this.txt_pass.Name = "txt_pass";
            this.txt_pass.Size = new System.Drawing.Size(322, 25);
            this.txt_pass.TabIndex = 30;
            this.txt_pass.UseSystemPasswordChar = true;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Label1.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Label1.Location = new System.Drawing.Point(20, 24);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(48, 17);
            this.Label1.TabIndex = 31;
            this.Label1.Text = "NAME:";
            // 
            // cbo_type
            // 
            this.cbo_type.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_type.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_type.FormattingEnabled = true;
            this.cbo_type.Items.AddRange(new object[] {
            "Librarian",
            "Assistant"});
            this.cbo_type.Location = new System.Drawing.Point(120, 104);
            this.cbo_type.Name = "cbo_type";
            this.cbo_type.Size = new System.Drawing.Size(322, 25);
            this.cbo_type.TabIndex = 33;
            // 
            // btn_delete
            // 
            this.btn_delete.Enabled = false;
            this.btn_delete.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_delete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_delete.Location = new System.Drawing.Point(178, 442);
            this.btn_delete.Name = "btn_delete";
            this.btn_delete.Size = new System.Drawing.Size(76, 30);
            this.btn_delete.TabIndex = 41;
            this.btn_delete.Text = "ARCHIVE";
            this.btn_delete.UseVisualStyleBackColor = true;
            this.btn_delete.Click += new System.EventHandler(this.btn_delete_Click);
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(260, 442);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(94, 30);
            this.button2.TabIndex = 44;
            this.button2.Text = "UNARCHIVE";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_id.Location = new System.Drawing.Point(245, 227);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(19, 17);
            this.lbl_id.TabIndex = 40;
            this.lbl_id.Text = "id";
            this.lbl_id.Visible = false;
            // 
            // frmUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.ForestGreen;
            this.ClientSize = new System.Drawing.Size(530, 484);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.dtg_listUser);
            this.Controls.Add(this.btn_saveuser);
            this.Controls.Add(this.btn_update);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.btn_New);
            this.Controls.Add(this.Label4);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.Label3);
            this.Controls.Add(this.txt_username);
            this.Controls.Add(this.Label2);
            this.Controls.Add(this.txt_pass);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.cbo_type);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_delete);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Manage Users";
            this.Load += new System.EventHandler(this.frmUser_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtg_listUser)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        internal System.Windows.Forms.DataGridView dtg_listUser;
        internal System.Windows.Forms.Button btn_saveuser;
        internal System.Windows.Forms.Button btn_update;
        internal System.Windows.Forms.Button Button1;
        internal System.Windows.Forms.Button btn_New;
        internal System.Windows.Forms.Label Label4;
        internal System.Windows.Forms.TextBox txt_name;
        internal System.Windows.Forms.Label Label3;
        internal System.Windows.Forms.TextBox txt_username;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.TextBox txt_pass;
        internal System.Windows.Forms.Label Label1;
        internal System.Windows.Forms.ComboBox cbo_type;
        internal System.Windows.Forms.Button btn_delete;
        internal System.Windows.Forms.Button button2;
        internal System.Windows.Forms.Label lbl_id;
    }
}