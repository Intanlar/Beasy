namespace BeasyApp
{
    partial class AuthPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AuthPage));
            this.guna2BorderlessForm1 = new Guna.UI2.WinForms.Guna2BorderlessForm(this.components);
            this.CloseButtton = new FontAwesome.Sharp.IconButton();
            this.MinButton = new FontAwesome.Sharp.IconButton();
            this.UNameInsert = new System.Windows.Forms.TextBox();
            this.UNameLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.UPINInsert = new System.Windows.Forms.TextBox();
            this.UPINLabel = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Welcome = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.AuthButton = new Guna.UI2.WinForms.Guna2TileButton();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2BorderlessForm1
            // 
            this.guna2BorderlessForm1.ContainerControl = this;
            this.guna2BorderlessForm1.DockIndicatorTransparencyValue = 0.6D;
            this.guna2BorderlessForm1.TransparentWhileDrag = true;
            // 
            // CloseButtton
            // 
            this.CloseButtton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CloseButtton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.CloseButtton.IconChar = FontAwesome.Sharp.IconChar.WindowClose;
            this.CloseButtton.IconColor = System.Drawing.Color.White;
            this.CloseButtton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.CloseButtton.Location = new System.Drawing.Point(931, -1);
            this.CloseButtton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.CloseButtton.Name = "CloseButtton";
            this.CloseButtton.Size = new System.Drawing.Size(54, 56);
            this.CloseButtton.TabIndex = 0;
            this.CloseButtton.UseVisualStyleBackColor = true;
            this.CloseButtton.Click += new System.EventHandler(this.CloseButtton_Click);
            // 
            // MinButton
            // 
            this.MinButton.BackColor = System.Drawing.Color.CornflowerBlue;
            this.MinButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.MinButton.ForeColor = System.Drawing.Color.LightSteelBlue;
            this.MinButton.IconChar = FontAwesome.Sharp.IconChar.WindowMinimize;
            this.MinButton.IconColor = System.Drawing.Color.White;
            this.MinButton.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.MinButton.Location = new System.Drawing.Point(870, -1);
            this.MinButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MinButton.Name = "MinButton";
            this.MinButton.Size = new System.Drawing.Size(54, 56);
            this.MinButton.TabIndex = 1;
            this.MinButton.UseVisualStyleBackColor = false;
            this.MinButton.Click += new System.EventHandler(this.MinButton_Click);
            // 
            // UNameInsert
            // 
            this.UNameInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UNameInsert.Location = new System.Drawing.Point(450, 349);
            this.UNameInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UNameInsert.Name = "UNameInsert";
            this.UNameInsert.Size = new System.Drawing.Size(222, 39);
            this.UNameInsert.TabIndex = 3;
            this.UNameInsert.TextChanged += new System.EventHandler(this.UNameInsert_TextChanged);
            // 
            // UNameLabel
            // 
            this.UNameLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UNameLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UNameLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.UNameLabel.Location = new System.Drawing.Point(311, 349);
            this.UNameLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UNameLabel.Name = "UNameLabel";
            this.UNameLabel.Size = new System.Drawing.Size(110, 34);
            this.UNameLabel.TabIndex = 4;
            this.UNameLabel.Text = "Username";
            // 
            // UPINInsert
            // 
            this.UPINInsert.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UPINInsert.Location = new System.Drawing.Point(450, 410);
            this.UPINInsert.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UPINInsert.Name = "UPINInsert";
            this.UPINInsert.Size = new System.Drawing.Size(222, 39);
            this.UPINInsert.TabIndex = 5;
            this.UPINInsert.TextChanged += new System.EventHandler(this.UPINInsert_TextChanged);
            // 
            // UPINLabel
            // 
            this.UPINLabel.BackColor = System.Drawing.Color.WhiteSmoke;
            this.UPINLabel.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.UPINLabel.Location = new System.Drawing.Point(311, 410);
            this.UPINLabel.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.UPINLabel.Name = "UPINLabel";
            this.UPINLabel.Size = new System.Drawing.Size(101, 34);
            this.UPINLabel.TabIndex = 6;
            this.UPINLabel.Text = "Password";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.guna2HtmlLabel1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(360, 280);
            this.guna2HtmlLabel1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(279, 40);
            this.guna2HtmlLabel1.TabIndex = 8;
            this.guna2HtmlLabel1.Text = "Manajemen Depo Bus";
            this.guna2HtmlLabel1.Click += new System.EventHandler(this.guna2HtmlLabel1_Click);
            // 
            // Welcome
            // 
            this.Welcome.BackColor = System.Drawing.Color.WhiteSmoke;
            this.Welcome.Font = new System.Drawing.Font("Segoe UI", 22F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point);
            this.Welcome.ForeColor = System.Drawing.Color.Black;
            this.Welcome.Location = new System.Drawing.Point(429, 219);
            this.Welcome.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Welcome.Name = "Welcome";
            this.Welcome.Size = new System.Drawing.Size(137, 62);
            this.Welcome.TabIndex = 23;
            this.Welcome.Text = "BEASY";
            // 
            // AuthButton
            // 
            this.AuthButton.AutoRoundedCorners = true;
            this.AuthButton.BackColor = System.Drawing.Color.AliceBlue;
            this.AuthButton.BorderRadius = 24;
            this.AuthButton.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.AuthButton.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.AuthButton.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.AuthButton.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.AuthButton.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.AuthButton.ForeColor = System.Drawing.Color.White;
            this.AuthButton.Location = new System.Drawing.Point(429, 488);
            this.AuthButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.AuthButton.Name = "AuthButton";
            this.AuthButton.Size = new System.Drawing.Size(154, 51);
            this.AuthButton.TabIndex = 24;
            this.AuthButton.Text = "Auth";
            this.AuthButton.Click += new System.EventHandler(this.AuthButton_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox2.Location = new System.Drawing.Point(272, 34);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(460, 562);
            this.pictureBox2.TabIndex = 26;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(382, 54);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(244, 170);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 25;
            this.pictureBox1.TabStop = false;
            // 
            // AuthPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.CornflowerBlue;
            this.ClientSize = new System.Drawing.Size(1000, 625);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.AuthButton);
            this.Controls.Add(this.Welcome);
            this.Controls.Add(this.guna2HtmlLabel1);
            this.Controls.Add(this.UPINLabel);
            this.Controls.Add(this.UPINInsert);
            this.Controls.Add(this.UNameLabel);
            this.Controls.Add(this.UNameInsert);
            this.Controls.Add(this.MinButton);
            this.Controls.Add(this.CloseButtton);
            this.Controls.Add(this.pictureBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "AuthPage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AuthPage";
            this.Load += new System.EventHandler(this.AuthPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2BorderlessForm guna2BorderlessForm1;
        private Guna.UI2.WinForms.Guna2HtmlLabel UNameLabel;
        private TextBox UNameInsert;
        private FontAwesome.Sharp.IconButton MinButton;
        private FontAwesome.Sharp.IconButton CloseButtton;
        private TextBox UPINInsert;
        private Guna.UI2.WinForms.Guna2HtmlLabel UPINLabel;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Welcome;
        private Guna.UI2.WinForms.Guna2TileButton AuthButton;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
    }
}