namespace Playground_Home
{
    partial class Playground_frm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Playground_frm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.userNameTxt = new System.Windows.Forms.TextBox();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.loginBtn = new System.Windows.Forms.Button();
            this.forgotPasswordLbl = new System.Windows.Forms.LinkLabel();
            this.logoImg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.OrangeRed;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(484, 24);
            this.menuStrip.TabIndex = 0;
            this.menuStrip.Text = "menuStrip1";
            // 
            // userNameTxt
            // 
            this.userNameTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.userNameTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userNameTxt.ForeColor = System.Drawing.Color.OrangeRed;
            this.userNameTxt.Location = new System.Drawing.Point(145, 186);
            this.userNameTxt.Name = "userNameTxt";
            this.userNameTxt.Size = new System.Drawing.Size(179, 31);
            this.userNameTxt.TabIndex = 3;
            this.userNameTxt.Text = "Username";
            this.userNameTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // passwordTxt
            // 
            this.passwordTxt.BackColor = System.Drawing.Color.WhiteSmoke;
            this.passwordTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordTxt.ForeColor = System.Drawing.Color.OrangeRed;
            this.passwordTxt.Location = new System.Drawing.Point(145, 258);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(179, 31);
            this.passwordTxt.TabIndex = 4;
            this.passwordTxt.Text = "Password";
            this.passwordTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.passwordTxt.UseSystemPasswordChar = true;
            this.passwordTxt.TextChanged += new System.EventHandler(this.passwordTxt_TextChanged);
            // 
            // loginBtn
            // 
            this.loginBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.loginBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.loginBtn.Location = new System.Drawing.Point(167, 363);
            this.loginBtn.Name = "loginBtn";
            this.loginBtn.Size = new System.Drawing.Size(122, 43);
            this.loginBtn.TabIndex = 5;
            this.loginBtn.Text = "Login";
            this.loginBtn.UseVisualStyleBackColor = false;
            this.loginBtn.Click += new System.EventHandler(this.loginBtn_Click);
            // 
            // forgotPasswordLbl
            // 
            this.forgotPasswordLbl.AutoSize = true;
            this.forgotPasswordLbl.LinkColor = System.Drawing.Color.WhiteSmoke;
            this.forgotPasswordLbl.Location = new System.Drawing.Point(164, 292);
            this.forgotPasswordLbl.Name = "forgotPasswordLbl";
            this.forgotPasswordLbl.Size = new System.Drawing.Size(92, 13);
            this.forgotPasswordLbl.TabIndex = 6;
            this.forgotPasswordLbl.TabStop = true;
            this.forgotPasswordLbl.Text = "Forgot Password?";
            // 
            // logoImg
            // 
            this.logoImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoImg.BackgroundImage")));
            this.logoImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoImg.Location = new System.Drawing.Point(148, 47);
            this.logoImg.Margin = new System.Windows.Forms.Padding(2);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(175, 110);
            this.logoImg.TabIndex = 7;
            this.logoImg.TabStop = false;
            // 
            // Playground_frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(484, 462);
            this.Controls.Add(this.logoImg);
            this.Controls.Add(this.forgotPasswordLbl);
            this.Controls.Add(this.loginBtn);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.userNameTxt);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip;
            this.Name = "Playground_frm";
            this.Text = "Playground";
            this.Load += new System.EventHandler(this.Playground_frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.TextBox userNameTxt;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Button loginBtn;
        private System.Windows.Forms.LinkLabel forgotPasswordLbl;
        private System.Windows.Forms.PictureBox logoImg;
    }
}

