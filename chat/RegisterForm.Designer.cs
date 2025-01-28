namespace chat
{
    partial class RegisterForm
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
            this.buttonRegister = new System.Windows.Forms.Button();
            this.passField = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.loginField = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.windowState = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.userSurnameField = new System.Windows.Forms.TextBox();
            this.usernameField = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // buttonRegister
            // 
            this.buttonRegister.BackColor = System.Drawing.Color.OliveDrab;
            this.buttonRegister.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonRegister.FlatAppearance.BorderSize = 0;
            this.buttonRegister.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(135)))), ((int)(((byte)(39)))));
            this.buttonRegister.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(4)))), ((int)(((byte)(201)))), ((int)(((byte)(20)))));
            this.buttonRegister.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonRegister.Font = new System.Drawing.Font("Comic Sans MS", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonRegister.Location = new System.Drawing.Point(152, 465);
            this.buttonRegister.Name = "buttonRegister";
            this.buttonRegister.Size = new System.Drawing.Size(207, 42);
            this.buttonRegister.TabIndex = 11;
            this.buttonRegister.Text = "Sign up";
            this.buttonRegister.UseVisualStyleBackColor = false;
            this.buttonRegister.Click += new System.EventHandler(this.buttonRegister_Click);
            // 
            // passField
            // 
            this.passField.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.passField.Location = new System.Drawing.Point(131, 401);
            this.passField.Name = "passField";
            this.passField.PasswordChar = '*';
            this.passField.Size = new System.Drawing.Size(263, 41);
            this.passField.TabIndex = 10;
            this.passField.UseSystemPasswordChar = true;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::chat.Properties.Resources._lock;
            this.pictureBox2.Location = new System.Drawing.Point(52, 401);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(64, 64);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 9;
            this.pictureBox2.TabStop = false;
            // 
            // loginField
            // 
            this.loginField.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.loginField.Location = new System.Drawing.Point(131, 305);
            this.loginField.Multiline = true;
            this.loginField.Name = "loginField";
            this.loginField.Size = new System.Drawing.Size(263, 64);
            this.loginField.TabIndex = 8;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::chat.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(52, 305);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(64, 64);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.MediumSlateBlue;
            this.panel2.Controls.Add(this.windowState);
            this.panel2.Controls.Add(this.closeButton);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(490, 100);
            this.panel2.TabIndex = 6;
            // 
            // windowState
            // 
            this.windowState.AutoSize = true;
            this.windowState.Cursor = System.Windows.Forms.Cursors.Hand;
            this.windowState.Font = new System.Drawing.Font("Comic Sans MS", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.windowState.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.windowState.Location = new System.Drawing.Point(420, -1);
            this.windowState.Name = "windowState";
            this.windowState.Size = new System.Drawing.Size(26, 30);
            this.windowState.TabIndex = 6;
            this.windowState.Text = "_";
            // 
            // closeButton
            // 
            this.closeButton.AutoSize = true;
            this.closeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.closeButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.closeButton.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.closeButton.Location = new System.Drawing.Point(452, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(30, 29);
            this.closeButton.TabIndex = 1;
            this.closeButton.Text = "X";
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // label1
            // 
            this.label1.Dock = System.Windows.Forms.DockStyle.Top;
            this.label1.Font = new System.Drawing.Font("Comic Sans MS", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(490, 51);
            this.label1.TabIndex = 0;
            this.label1.Text = "Регистрация";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // userSurnameField
            // 
            this.userSurnameField.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.userSurnameField.Location = new System.Drawing.Point(131, 212);
            this.userSurnameField.Multiline = true;
            this.userSurnameField.Name = "userSurnameField";
            this.userSurnameField.Size = new System.Drawing.Size(263, 64);
            this.userSurnameField.TabIndex = 12;
            this.userSurnameField.Enter += new System.EventHandler(this.userSurnameField_Enter);
            this.userSurnameField.Leave += new System.EventHandler(this.userSurnameField_Leave);
            // 
            // usernameField
            // 
            this.usernameField.Font = new System.Drawing.Font("Arial", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.usernameField.Location = new System.Drawing.Point(131, 129);
            this.usernameField.Multiline = true;
            this.usernameField.Name = "usernameField";
            this.usernameField.Size = new System.Drawing.Size(263, 64);
            this.usernameField.TabIndex = 13;
            this.usernameField.Enter += new System.EventHandler(this.usernameField_Enter);
            this.usernameField.Leave += new System.EventHandler(this.usernameField_Leave);
            // 
            // RegisterForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MediumPurple;
            this.ClientSize = new System.Drawing.Size(490, 603);
            this.Controls.Add(this.usernameField);
            this.Controls.Add(this.userSurnameField);
            this.Controls.Add(this.buttonRegister);
            this.Controls.Add(this.passField);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.loginField);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "RegisterForm";
            this.Text = "RegisterForm";
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.RegisterForm_MouseMove);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonRegister;
        private System.Windows.Forms.TextBox passField;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.TextBox loginField;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label windowState;
        private System.Windows.Forms.Label closeButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox userSurnameField;
        private System.Windows.Forms.TextBox usernameField;
    }
}