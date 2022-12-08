namespace BeasyApp 
{
    partial class DataPage
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
            this.components = new System.ComponentModel.Container();
            this.AccUIDNonInsert = new System.Windows.Forms.TextBox();
            this.UIDLabel = new System.Windows.Forms.Label();
            this.EmailLabel = new System.Windows.Forms.Label();
            this.SaveButton = new System.Windows.Forms.Button();
            this.AccPhoneInsert = new System.Windows.Forms.TextBox();
            this.AccEmailInsert = new System.Windows.Forms.TextBox();
            this.AccUPassInsert = new System.Windows.Forms.TextBox();
            this.AccUNameInsert = new System.Windows.Forms.TextBox();
            this.ContactLabel = new System.Windows.Forms.Label();
            this.UPassLabel = new System.Windows.Forms.Label();
            this.UNameLabel = new System.Windows.Forms.Label();
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.EditButton = new System.Windows.Forms.Button();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MinButton = new FontAwesome.Sharp.IconButton();
            this.CloseButtton = new FontAwesome.Sharp.IconButton();
            this.LabelData = new System.Windows.Forms.Label();
            this.SaveUpdateButton = new System.Windows.Forms.Button();
            this.AccTypeInsertCBox = new System.Windows.Forms.ComboBox();
            this.TypeLabel = new System.Windows.Forms.Label();
            this.AccDescInsert = new System.Windows.Forms.TextBox();
            this.DescLabel = new System.Windows.Forms.Label();
            this.AccPlatfLabel = new System.Windows.Forms.Label();
            this.AccPlatfInsert = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // AccUIDNonInsert
            // 
            this.AccUIDNonInsert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccUIDNonInsert.Location = new System.Drawing.Point(400, 132);
            this.AccUIDNonInsert.Margin = new System.Windows.Forms.Padding(2);
            this.AccUIDNonInsert.Name = "AccUIDNonInsert";
            this.AccUIDNonInsert.Size = new System.Drawing.Size(309, 35);
            this.AccUIDNonInsert.TabIndex = 63;
            this.AccUIDNonInsert.TextChanged += new System.EventHandler(this.AccUIDNonInsert_TextChanged);
            // 
            // UIDLabel
            // 
            this.UIDLabel.AutoSize = true;
            this.UIDLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UIDLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UIDLabel.ForeColor = System.Drawing.Color.Black;
            this.UIDLabel.Location = new System.Drawing.Point(229, 141);
            this.UIDLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UIDLabel.Name = "UIDLabel";
            this.UIDLabel.Size = new System.Drawing.Size(89, 28);
            this.UIDLabel.TabIndex = 62;
            this.UIDLabel.Text = "No. Plat";
            this.UIDLabel.Click += new System.EventHandler(this.UIDLabel_Click);
            // 
            // EmailLabel
            // 
            this.EmailLabel.AutoSize = true;
            this.EmailLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.EmailLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EmailLabel.ForeColor = System.Drawing.Color.Black;
            this.EmailLabel.Location = new System.Drawing.Point(229, 291);
            this.EmailLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.EmailLabel.Name = "EmailLabel";
            this.EmailLabel.Size = new System.Drawing.Size(63, 28);
            this.EmailLabel.TabIndex = 58;
            this.EmailLabel.Text = "Supir";
            this.EmailLabel.Click += new System.EventHandler(this.EmailLabel_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveButton.ForeColor = System.Drawing.Color.LightCyan;
            this.SaveButton.Location = new System.Drawing.Point(419, 556);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(144, 35);
            this.SaveButton.TabIndex = 55;
            this.SaveButton.Text = "Simpan";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // AccPhoneInsert
            // 
            this.AccPhoneInsert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccPhoneInsert.Location = new System.Drawing.Point(400, 332);
            this.AccPhoneInsert.Margin = new System.Windows.Forms.Padding(2);
            this.AccPhoneInsert.Name = "AccPhoneInsert";
            this.AccPhoneInsert.Size = new System.Drawing.Size(309, 35);
            this.AccPhoneInsert.TabIndex = 53;
            this.AccPhoneInsert.TextChanged += new System.EventHandler(this.AccPhoneInsert_TextChanged);
            // 
            // AccEmailInsert
            // 
            this.AccEmailInsert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccEmailInsert.Location = new System.Drawing.Point(400, 282);
            this.AccEmailInsert.Margin = new System.Windows.Forms.Padding(2);
            this.AccEmailInsert.Name = "AccEmailInsert";
            this.AccEmailInsert.Size = new System.Drawing.Size(309, 35);
            this.AccEmailInsert.TabIndex = 52;
            this.AccEmailInsert.TextChanged += new System.EventHandler(this.AccEmailInsert_TextChanged);
            // 
            // AccUPassInsert
            // 
            this.AccUPassInsert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccUPassInsert.Location = new System.Drawing.Point(400, 232);
            this.AccUPassInsert.Margin = new System.Windows.Forms.Padding(2);
            this.AccUPassInsert.Name = "AccUPassInsert";
            this.AccUPassInsert.Size = new System.Drawing.Size(309, 35);
            this.AccUPassInsert.TabIndex = 51;
            this.AccUPassInsert.TextChanged += new System.EventHandler(this.AccUPassInsert_TextChanged);
            // 
            // AccUNameInsert
            // 
            this.AccUNameInsert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccUNameInsert.Location = new System.Drawing.Point(400, 182);
            this.AccUNameInsert.Margin = new System.Windows.Forms.Padding(2);
            this.AccUNameInsert.Name = "AccUNameInsert";
            this.AccUNameInsert.Size = new System.Drawing.Size(309, 35);
            this.AccUNameInsert.TabIndex = 50;
            this.AccUNameInsert.TextChanged += new System.EventHandler(this.AccUNameInsert_TextChanged);
            // 
            // ContactLabel
            // 
            this.ContactLabel.AutoSize = true;
            this.ContactLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ContactLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ContactLabel.ForeColor = System.Drawing.Color.Black;
            this.ContactLabel.Location = new System.Drawing.Point(229, 341);
            this.ContactLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.ContactLabel.Name = "ContactLabel";
            this.ContactLabel.Size = new System.Drawing.Size(144, 28);
            this.ContactLabel.TabIndex = 47;
            this.ContactLabel.Text = "No. telp supir";
            this.ContactLabel.Click += new System.EventHandler(this.ContactLabel_Click);
            // 
            // UPassLabel
            // 
            this.UPassLabel.AutoSize = true;
            this.UPassLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UPassLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UPassLabel.ForeColor = System.Drawing.Color.Black;
            this.UPassLabel.Location = new System.Drawing.Point(229, 241);
            this.UPassLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UPassLabel.Name = "UPassLabel";
            this.UPassLabel.Size = new System.Drawing.Size(138, 28);
            this.UPassLabel.TabIndex = 46;
            this.UPassLabel.Text = "No. telp staff";
            this.UPassLabel.Click += new System.EventHandler(this.UPassLabel_Click);
            // 
            // UNameLabel
            // 
            this.UNameLabel.AutoSize = true;
            this.UNameLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UNameLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.UNameLabel.ForeColor = System.Drawing.Color.Black;
            this.UNameLabel.Location = new System.Drawing.Point(229, 191);
            this.UNameLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.UNameLabel.Name = "UNameLabel";
            this.UNameLabel.Size = new System.Drawing.Size(57, 28);
            this.UNameLabel.TabIndex = 45;
            this.UNameLabel.Text = "Staff";
            this.UNameLabel.Click += new System.EventHandler(this.UNameLabel_Click);
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // EditButton
            // 
            this.EditButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.EditButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.EditButton.ForeColor = System.Drawing.Color.White;
            this.EditButton.Location = new System.Drawing.Point(326, 556);
            this.EditButton.Margin = new System.Windows.Forms.Padding(2);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(144, 35);
            this.EditButton.TabIndex = 77;
            this.EditButton.Text = "Ubah";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // DeleteButton
            // 
            this.DeleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.DeleteButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DeleteButton.ForeColor = System.Drawing.Color.White;
            this.DeleteButton.Location = new System.Drawing.Point(524, 556);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(144, 35);
            this.DeleteButton.TabIndex = 78;
            this.DeleteButton.Text = "Hapus";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // MinButton
            // 
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.MinButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinButton.IconColor = System.Drawing.Color.White;
            this.MinButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinButton.Location = new System.Drawing.Point(856, 0);
            this.MinButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(54, 56);
            this.MinButton.TabIndex = 82;
            this.MinButton.UseVisualStyleBackColor = true;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // CloseButtton
            // 
            this.CloseButtton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButtton.ForeColor = System.Drawing.Color.RoyalBlue;
            this.CloseButtton.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.CloseButtton.IconColor = System.Drawing.Color.White;
            this.CloseButtton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseButtton.Location = new System.Drawing.Point(919, 1);
            this.CloseButtton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseButtton.Name = "CloseButtton";
            this.CloseButtton.Size = new System.Drawing.Size(54, 56);
            this.CloseButtton.TabIndex = 81;
            this.CloseButtton.UseVisualStyleBackColor = true;
            this.CloseButtton.Click += new System.EventHandler(this.CloseButtton_Click);
            // 
            // LabelData
            // 
            this.LabelData.AutoSize = true;
            this.LabelData.BackColor = System.Drawing.Color.WhiteSmoke;
            this.LabelData.Font = new System.Drawing.Font("Segoe UI Variable Small Semibol", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.LabelData.ForeColor = System.Drawing.Color.Black;
            this.LabelData.Location = new System.Drawing.Point(375, 65);
            this.LabelData.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.LabelData.Name = "LabelData";
            this.LabelData.Size = new System.Drawing.Size(223, 44);
            this.LabelData.TabIndex = 83;
            this.LabelData.Text = "Tambah Data";
            this.LabelData.Click += new System.EventHandler(this.LabelData_Click);
            // 
            // SaveUpdateButton
            // 
            this.SaveUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.SaveUpdateButton.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.SaveUpdateButton.ForeColor = System.Drawing.Color.Transparent;
            this.SaveUpdateButton.Location = new System.Drawing.Point(375, 556);
            this.SaveUpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveUpdateButton.Name = "SaveUpdateButton";
            this.SaveUpdateButton.Size = new System.Drawing.Size(236, 35);
            this.SaveUpdateButton.TabIndex = 84;
            this.SaveUpdateButton.Text = "Simpan Perubahan";
            this.SaveUpdateButton.UseVisualStyleBackColor = true;
            this.SaveUpdateButton.Click += new System.EventHandler(this.SaveUpdateButton_Click);
            // 
            // AccTypeInsertCBox
            // 
            this.AccTypeInsertCBox.FormattingEnabled = true;
            this.AccTypeInsertCBox.Location = new System.Drawing.Point(400, 482);
            this.AccTypeInsertCBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AccTypeInsertCBox.Name = "AccTypeInsertCBox";
            this.AccTypeInsertCBox.Size = new System.Drawing.Size(190, 33);
            this.AccTypeInsertCBox.TabIndex = 86;
            this.AccTypeInsertCBox.SelectedIndexChanged += new System.EventHandler(this.AccTypeInsertCBox_SelectedIndexChanged);
            // 
            // TypeLabel
            // 
            this.TypeLabel.AutoSize = true;
            this.TypeLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.TypeLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.TypeLabel.ForeColor = System.Drawing.Color.Black;
            this.TypeLabel.Location = new System.Drawing.Point(231, 489);
            this.TypeLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.TypeLabel.Name = "TypeLabel";
            this.TypeLabel.Size = new System.Drawing.Size(62, 28);
            this.TypeLabel.TabIndex = 87;
            this.TypeLabel.Text = "Kelas";
            this.TypeLabel.Click += new System.EventHandler(this.TypeLabel_Click);
            // 
            // AccDescInsert
            // 
            this.AccDescInsert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccDescInsert.Location = new System.Drawing.Point(400, 382);
            this.AccDescInsert.Margin = new System.Windows.Forms.Padding(2);
            this.AccDescInsert.Name = "AccDescInsert";
            this.AccDescInsert.Size = new System.Drawing.Size(309, 35);
            this.AccDescInsert.TabIndex = 88;
            this.AccDescInsert.TextChanged += new System.EventHandler(this.AccDescInsert_TextChanged);
            // 
            // DescLabel
            // 
            this.DescLabel.AutoSize = true;
            this.DescLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.DescLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.DescLabel.ForeColor = System.Drawing.Color.Black;
            this.DescLabel.Location = new System.Drawing.Point(229, 391);
            this.DescLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.DescLabel.Name = "DescLabel";
            this.DescLabel.Size = new System.Drawing.Size(52, 28);
            this.DescLabel.TabIndex = 89;
            this.DescLabel.Text = "Asal";
            this.DescLabel.Click += new System.EventHandler(this.DescLabel_Click);
            // 
            // AccPlatfLabel
            // 
            this.AccPlatfLabel.AutoSize = true;
            this.AccPlatfLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.AccPlatfLabel.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.AccPlatfLabel.ForeColor = System.Drawing.Color.Black;
            this.AccPlatfLabel.Location = new System.Drawing.Point(229, 439);
            this.AccPlatfLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.AccPlatfLabel.Name = "AccPlatfLabel";
            this.AccPlatfLabel.Size = new System.Drawing.Size(76, 28);
            this.AccPlatfLabel.TabIndex = 91;
            this.AccPlatfLabel.Text = "Tujuan";
            this.AccPlatfLabel.Click += new System.EventHandler(this.AccPlatfLabel_Click);
            // 
            // AccPlatfInsert
            // 
            this.AccPlatfInsert.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AccPlatfInsert.Location = new System.Drawing.Point(400, 432);
            this.AccPlatfInsert.Margin = new System.Windows.Forms.Padding(2);
            this.AccPlatfInsert.Name = "AccPlatfInsert";
            this.AccPlatfInsert.Size = new System.Drawing.Size(309, 35);
            this.AccPlatfInsert.TabIndex = 90;
            this.AccPlatfInsert.TextChanged += new System.EventHandler(this.AccPlatfInsert_TextChanged);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Location = new System.Drawing.Point(208, 46);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(542, 571);
            this.pictureBox2.TabIndex = 92;
            this.pictureBox2.TabStop = false;
            // 
            // DataPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1000, 664);
            this.Controls.Add(this.AccPlatfLabel);
            this.Controls.Add(this.AccPlatfInsert);
            this.Controls.Add(this.DescLabel);
            this.Controls.Add(this.AccDescInsert);
            this.Controls.Add(this.TypeLabel);
            this.Controls.Add(this.AccTypeInsertCBox);
            this.Controls.Add(this.SaveUpdateButton);
            this.Controls.Add(this.LabelData);
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.CloseButtton);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.EditButton);
            this.Controls.Add(this.AccUIDNonInsert);
            this.Controls.Add(this.UIDLabel);
            this.Controls.Add(this.EmailLabel);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.AccPhoneInsert);
            this.Controls.Add(this.AccEmailInsert);
            this.Controls.Add(this.AccUPassInsert);
            this.Controls.Add(this.AccUNameInsert);
            this.Controls.Add(this.ContactLabel);
            this.Controls.Add(this.UPassLabel);
            this.Controls.Add(this.UNameLabel);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "DataPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataPage";
            this.Load += new System.EventHandler(this.DataPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox AccUIDNonInsert;
        private Label UIDLabel;
        private Label EmailLabel;
        public Button SaveButton;
        private TextBox AccPhoneInsert;
        private TextBox AccEmailInsert;
        private TextBox AccUPassInsert;
        private TextBox AccUNameInsert;
        private Label ContactLabel;
        private Label UPassLabel;
        private Label UNameLabel;
        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        public Button DeleteButton;
        public Button EditButton;
        private FontAwesome.Sharp.IconButton MinButton;
        private FontAwesome.Sharp.IconButton CloseButtton;
        private Label LabelData;
        public Button SaveUpdateButton;
        private Label TypeLabel;
        private ComboBox AccTypeInsertCBox;
        private Label DescLabel;
        private TextBox AccDescInsert;
        private Label AccPlatfLabel;
        private TextBox AccPlatfInsert;
        private PictureBox pictureBox2;
    }
}