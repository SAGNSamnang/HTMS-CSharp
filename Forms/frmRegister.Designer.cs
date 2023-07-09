namespace Hotel_Management_System.Forms
{
    partial class frmRegister
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
            this.txtConfirmPassword = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnRegister = new System.Windows.Forms.Button();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.ptbBack = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ptbCPasswordShow = new System.Windows.Forms.PictureBox();
            this.ptbCPasswordHide = new System.Windows.Forms.PictureBox();
            this.pictureBoxMinimize = new System.Windows.Forms.PictureBox();
            this.pictureBoxCancel = new System.Windows.Forms.PictureBox();
            this.ptbPasswordHide = new System.Windows.Forms.PictureBox();
            this.ptbPasswordShow = new System.Windows.Forms.PictureBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.ptbBack)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCPasswordShow)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCPasswordHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCancel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPasswordHide)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPasswordShow)).BeginInit();
            this.SuspendLayout();
            // 
            // txtConfirmPassword
            // 
            this.txtConfirmPassword.Location = new System.Drawing.Point(620, 318);
            this.txtConfirmPassword.Name = "txtConfirmPassword";
            this.txtConfirmPassword.Size = new System.Drawing.Size(238, 31);
            this.txtConfirmPassword.TabIndex = 3;
            this.txtConfirmPassword.Tag = "Confirm password";
            this.txtConfirmPassword.UseSystemPasswordChar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(617, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 22);
            this.label4.TabIndex = 5;
            this.label4.Text = "Confirm password:";
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(620, 386);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(238, 31);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Register now";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // txtPassword
            // 
            this.txtPassword.Location = new System.Drawing.Point(621, 222);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(237, 31);
            this.txtPassword.TabIndex = 2;
            this.txtPassword.Tag = "Password";
            this.txtPassword.UseSystemPasswordChar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(617, 187);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 22);
            this.label2.TabIndex = 0;
            this.label2.Text = "Password:";
            // 
            // txtUsername
            // 
            this.txtUsername.Location = new System.Drawing.Point(619, 53);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.Size = new System.Drawing.Size(276, 31);
            this.txtUsername.TabIndex = 0;
            this.txtUsername.Tag = "Username";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(616, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Username:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DimGray;
            this.panel1.Location = new System.Drawing.Point(554, 18);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(3, 413);
            this.panel1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(116, 408);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(295, 30);
            this.label3.TabIndex = 6;
            this.label3.Text = "Hotel Manament Sytem";
            // 
            // ptbBack
            // 
            this.ptbBack.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbBack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbBack.Image = global::Hotel_Management_System.Properties.Resources.icons8_right_button_501;
            this.ptbBack.Location = new System.Drawing.Point(857, 386);
            this.ptbBack.Name = "ptbBack";
            this.ptbBack.Size = new System.Drawing.Size(38, 30);
            this.ptbBack.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ptbBack.TabIndex = 9;
            this.ptbBack.TabStop = false;
            this.ptbBack.Click += new System.EventHandler(this.ptbBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hotel_Management_System.Properties.Resources.register;
            this.pictureBox1.Location = new System.Drawing.Point(33, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 364);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // ptbCPasswordShow
            // 
            this.ptbCPasswordShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbCPasswordShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbCPasswordShow.Image = global::Hotel_Management_System.Properties.Resources.eye;
            this.ptbCPasswordShow.Location = new System.Drawing.Point(858, 318);
            this.ptbCPasswordShow.Name = "ptbCPasswordShow";
            this.ptbCPasswordShow.Size = new System.Drawing.Size(38, 31);
            this.ptbCPasswordShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCPasswordShow.TabIndex = 7;
            this.ptbCPasswordShow.TabStop = false;
            this.ptbCPasswordShow.Click += new System.EventHandler(this.ptbCPasswordShow_Click);
            this.ptbCPasswordShow.MouseHover += new System.EventHandler(this.ptbCPasswordShow_MouseHover);
            // 
            // ptbCPasswordHide
            // 
            this.ptbCPasswordHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbCPasswordHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbCPasswordHide.Image = global::Hotel_Management_System.Properties.Resources.hide;
            this.ptbCPasswordHide.Location = new System.Drawing.Point(858, 318);
            this.ptbCPasswordHide.Name = "ptbCPasswordHide";
            this.ptbCPasswordHide.Size = new System.Drawing.Size(38, 31);
            this.ptbCPasswordHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbCPasswordHide.TabIndex = 8;
            this.ptbCPasswordHide.TabStop = false;
            this.ptbCPasswordHide.Click += new System.EventHandler(this.ptbCPasswordHide_Click);
            this.ptbCPasswordHide.MouseHover += new System.EventHandler(this.ptbCPasswordHide_MouseHover);
            // 
            // pictureBoxMinimize
            // 
            this.pictureBoxMinimize.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMinimize.Image = global::Hotel_Management_System.Properties.Resources.minimize;
            this.pictureBoxMinimize.Location = new System.Drawing.Point(979, 13);
            this.pictureBoxMinimize.Name = "pictureBoxMinimize";
            this.pictureBoxMinimize.Size = new System.Drawing.Size(42, 31);
            this.pictureBoxMinimize.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMinimize.TabIndex = 2;
            this.pictureBoxMinimize.TabStop = false;
            this.pictureBoxMinimize.Click += new System.EventHandler(this.pictureBoxMinimize_Click);
            this.pictureBoxMinimize.MouseHover += new System.EventHandler(this.pictureBoxMinimize_MouseHover);
            // 
            // pictureBoxCancel
            // 
            this.pictureBoxCancel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxCancel.Image = global::Hotel_Management_System.Properties.Resources.cancel;
            this.pictureBoxCancel.Location = new System.Drawing.Point(1027, 12);
            this.pictureBoxCancel.Name = "pictureBoxCancel";
            this.pictureBoxCancel.Size = new System.Drawing.Size(42, 32);
            this.pictureBoxCancel.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxCancel.TabIndex = 3;
            this.pictureBoxCancel.TabStop = false;
            this.pictureBoxCancel.Click += new System.EventHandler(this.pictureBoxCancel_Click);
            this.pictureBoxCancel.MouseHover += new System.EventHandler(this.pictureBoxCancel_MouseHover);
            // 
            // ptbPasswordHide
            // 
            this.ptbPasswordHide.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbPasswordHide.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbPasswordHide.Image = global::Hotel_Management_System.Properties.Resources.hide;
            this.ptbPasswordHide.Location = new System.Drawing.Point(858, 222);
            this.ptbPasswordHide.Name = "ptbPasswordHide";
            this.ptbPasswordHide.Size = new System.Drawing.Size(38, 31);
            this.ptbPasswordHide.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPasswordHide.TabIndex = 4;
            this.ptbPasswordHide.TabStop = false;
            this.ptbPasswordHide.Click += new System.EventHandler(this.ptbPasswordHide_Click);
            this.ptbPasswordHide.MouseHover += new System.EventHandler(this.ptbPasswordHide_MouseHover);
            // 
            // ptbPasswordShow
            // 
            this.ptbPasswordShow.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.ptbPasswordShow.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ptbPasswordShow.Image = global::Hotel_Management_System.Properties.Resources.eye;
            this.ptbPasswordShow.Location = new System.Drawing.Point(858, 222);
            this.ptbPasswordShow.Name = "ptbPasswordShow";
            this.ptbPasswordShow.Size = new System.Drawing.Size(38, 31);
            this.ptbPasswordShow.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.ptbPasswordShow.TabIndex = 4;
            this.ptbPasswordShow.TabStop = false;
            this.ptbPasswordShow.Click += new System.EventHandler(this.ptbPasswordShow_Click);
            this.ptbPasswordShow.MouseHover += new System.EventHandler(this.ptbPasswordShow_MouseHover);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(616, 101);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 22);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email:";
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(619, 136);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(276, 31);
            this.txtEmail.TabIndex = 1;
            this.txtEmail.Tag = "Email";
            // 
            // frmRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1079, 494);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtUsername);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ptbBack);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.ptbCPasswordShow);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtConfirmPassword);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.ptbCPasswordHide);
            this.Controls.Add(this.pictureBoxMinimize);
            this.Controls.Add(this.pictureBoxCancel);
            this.Controls.Add(this.ptbPasswordShow);
            this.Controls.Add(this.ptbPasswordHide);
            this.Font = new System.Drawing.Font("Century Gothic", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "frmRegister";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmRegister";
            ((System.ComponentModel.ISupportInitialize)(this.ptbBack)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCPasswordShow)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbCPasswordHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMinimize)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxCancel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPasswordHide)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ptbPasswordShow)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBoxMinimize;
        private System.Windows.Forms.PictureBox pictureBoxCancel;
        private System.Windows.Forms.PictureBox ptbPasswordShow;
        private System.Windows.Forms.Button btnRegister;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox ptbPasswordHide;
        private System.Windows.Forms.PictureBox ptbCPasswordHide;
        private System.Windows.Forms.PictureBox ptbCPasswordShow;
        private System.Windows.Forms.TextBox txtConfirmPassword;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox ptbBack;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtEmail;
    }
}