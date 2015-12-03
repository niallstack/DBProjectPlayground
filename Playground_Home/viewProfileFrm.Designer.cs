namespace Playground_Home
{
    partial class viewProfileFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(viewProfileFrm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.profileImg = new System.Windows.Forms.PictureBox();
            this.logoImg = new System.Windows.Forms.PictureBox();
            this.aboutGrp = new System.Windows.Forms.GroupBox();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.surnameVal = new System.Windows.Forms.Label();
            this.genderVal = new System.Windows.Forms.Label();
            this.genderLbl = new System.Windows.Forms.Label();
            this.dobVal = new System.Windows.Forms.Label();
            this.dobLbl = new System.Windows.Forms.Label();
            this.forenameLbl = new System.Windows.Forms.Label();
            this.forenameVal = new System.Windows.Forms.Label();
            this.aboutLbl = new System.Windows.Forms.Label();
            this.interestGrp = new System.Windows.Forms.GroupBox();
            this.interestGrd = new System.Windows.Forms.DataGridView();
            this.interestLbl = new System.Windows.Forms.Label();
            this.friendsLbl = new System.Windows.Forms.Label();
            this.profileLbl = new System.Windows.Forms.Label();
            this.addBtn = new System.Windows.Forms.Button();
            this.chatBtn = new System.Windows.Forms.Button();
            this.friendsGrp = new System.Windows.Forms.GroupBox();
            this.friendsGrd = new System.Windows.Forms.DataGridView();
            this.studentNumLbl = new System.Windows.Forms.Label();
            this.studentNumVal = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).BeginInit();
            this.aboutGrp.SuspendLayout();
            this.interestGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.interestGrd)).BeginInit();
            this.friendsGrp.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.friendsGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.OrangeRed;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(694, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip1";
            // 
            // profileImg
            // 
            this.profileImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("profileImg.BackgroundImage")));
            this.profileImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.profileImg.Location = new System.Drawing.Point(22, 36);
            this.profileImg.Margin = new System.Windows.Forms.Padding(2);
            this.profileImg.Name = "profileImg";
            this.profileImg.Size = new System.Drawing.Size(153, 127);
            this.profileImg.TabIndex = 2;
            this.profileImg.TabStop = false;
            // 
            // logoImg
            // 
            this.logoImg.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("logoImg.BackgroundImage")));
            this.logoImg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.logoImg.Location = new System.Drawing.Point(603, 26);
            this.logoImg.Margin = new System.Windows.Forms.Padding(2);
            this.logoImg.Name = "logoImg";
            this.logoImg.Size = new System.Drawing.Size(88, 58);
            this.logoImg.TabIndex = 3;
            this.logoImg.TabStop = false;
            // 
            // aboutGrp
            // 
            this.aboutGrp.Controls.Add(this.studentNumLbl);
            this.aboutGrp.Controls.Add(this.studentNumVal);
            this.aboutGrp.Controls.Add(this.surnameLbl);
            this.aboutGrp.Controls.Add(this.surnameVal);
            this.aboutGrp.Controls.Add(this.genderVal);
            this.aboutGrp.Controls.Add(this.genderLbl);
            this.aboutGrp.Controls.Add(this.dobVal);
            this.aboutGrp.Controls.Add(this.dobLbl);
            this.aboutGrp.Controls.Add(this.forenameLbl);
            this.aboutGrp.Controls.Add(this.forenameVal);
            this.aboutGrp.Location = new System.Drawing.Point(11, 236);
            this.aboutGrp.Margin = new System.Windows.Forms.Padding(2);
            this.aboutGrp.Name = "aboutGrp";
            this.aboutGrp.Padding = new System.Windows.Forms.Padding(2);
            this.aboutGrp.Size = new System.Drawing.Size(232, 230);
            this.aboutGrp.TabIndex = 12;
            this.aboutGrp.TabStop = false;
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLbl.ForeColor = System.Drawing.Color.Coral;
            this.surnameLbl.Location = new System.Drawing.Point(11, 99);
            this.surnameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(78, 20);
            this.surnameLbl.TabIndex = 22;
            this.surnameLbl.Text = "Surname:";
            // 
            // surnameVal
            // 
            this.surnameVal.AutoSize = true;
            this.surnameVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameVal.ForeColor = System.Drawing.Color.OrangeRed;
            this.surnameVal.Location = new System.Drawing.Point(115, 99);
            this.surnameVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.surnameVal.Name = "surnameVal";
            this.surnameVal.Size = new System.Drawing.Size(53, 20);
            this.surnameVal.TabIndex = 21;
            this.surnameVal.Text = "Gates";
            // 
            // genderVal
            // 
            this.genderVal.AutoSize = true;
            this.genderVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderVal.ForeColor = System.Drawing.Color.OrangeRed;
            this.genderVal.Location = new System.Drawing.Point(115, 155);
            this.genderVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genderVal.Name = "genderVal";
            this.genderVal.Size = new System.Drawing.Size(22, 20);
            this.genderVal.TabIndex = 17;
            this.genderVal.Text = "M";
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLbl.ForeColor = System.Drawing.Color.Coral;
            this.genderLbl.Location = new System.Drawing.Point(11, 155);
            this.genderLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(67, 20);
            this.genderLbl.TabIndex = 16;
            this.genderLbl.Text = "Gender:";
            // 
            // dobVal
            // 
            this.dobVal.AutoSize = true;
            this.dobVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobVal.ForeColor = System.Drawing.Color.OrangeRed;
            this.dobVal.Location = new System.Drawing.Point(115, 126);
            this.dobVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dobVal.Name = "dobVal";
            this.dobVal.Size = new System.Drawing.Size(82, 20);
            this.dobVal.TabIndex = 15;
            this.dobVal.Text = "23-Nov-92\r\n";
            // 
            // dobLbl
            // 
            this.dobLbl.AutoSize = true;
            this.dobLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLbl.ForeColor = System.Drawing.Color.Coral;
            this.dobLbl.Location = new System.Drawing.Point(11, 126);
            this.dobLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.dobLbl.Name = "dobLbl";
            this.dobLbl.Size = new System.Drawing.Size(103, 20);
            this.dobLbl.TabIndex = 14;
            this.dobLbl.Text = "Date of Birth:";
            // 
            // forenameLbl
            // 
            this.forenameLbl.AutoSize = true;
            this.forenameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forenameLbl.ForeColor = System.Drawing.Color.Coral;
            this.forenameLbl.Location = new System.Drawing.Point(11, 72);
            this.forenameLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.forenameLbl.Name = "forenameLbl";
            this.forenameLbl.Size = new System.Drawing.Size(86, 20);
            this.forenameLbl.TabIndex = 13;
            this.forenameLbl.Text = "Forename:";
            // 
            // forenameVal
            // 
            this.forenameVal.AutoSize = true;
            this.forenameVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forenameVal.ForeColor = System.Drawing.Color.OrangeRed;
            this.forenameVal.Location = new System.Drawing.Point(115, 72);
            this.forenameVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.forenameVal.Name = "forenameVal";
            this.forenameVal.Size = new System.Drawing.Size(29, 20);
            this.forenameVal.TabIndex = 12;
            this.forenameVal.Text = "Bill";
            // 
            // aboutLbl
            // 
            this.aboutLbl.AutoSize = true;
            this.aboutLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.aboutLbl.ForeColor = System.Drawing.Color.Coral;
            this.aboutLbl.Location = new System.Drawing.Point(83, 196);
            this.aboutLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.aboutLbl.Name = "aboutLbl";
            this.aboutLbl.Size = new System.Drawing.Size(75, 29);
            this.aboutLbl.TabIndex = 20;
            this.aboutLbl.Text = "About";
            // 
            // interestGrp
            // 
            this.interestGrp.Controls.Add(this.interestGrd);
            this.interestGrp.Location = new System.Drawing.Point(504, 236);
            this.interestGrp.Margin = new System.Windows.Forms.Padding(2);
            this.interestGrp.Name = "interestGrp";
            this.interestGrp.Padding = new System.Windows.Forms.Padding(2);
            this.interestGrp.Size = new System.Drawing.Size(179, 230);
            this.interestGrp.TabIndex = 13;
            this.interestGrp.TabStop = false;
            // 
            // interestGrd
            // 
            this.interestGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.interestGrd.Location = new System.Drawing.Point(5, 14);
            this.interestGrd.Name = "interestGrd";
            this.interestGrd.Size = new System.Drawing.Size(169, 207);
            this.interestGrd.TabIndex = 0;
            // 
            // interestLbl
            // 
            this.interestLbl.AutoSize = true;
            this.interestLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.interestLbl.ForeColor = System.Drawing.Color.Coral;
            this.interestLbl.Location = new System.Drawing.Point(548, 196);
            this.interestLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.interestLbl.Name = "interestLbl";
            this.interestLbl.Size = new System.Drawing.Size(104, 29);
            this.interestLbl.TabIndex = 0;
            this.interestLbl.Text = "Interests";
            // 
            // friendsLbl
            // 
            this.friendsLbl.AutoSize = true;
            this.friendsLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.friendsLbl.ForeColor = System.Drawing.Color.Coral;
            this.friendsLbl.Location = new System.Drawing.Point(332, 196);
            this.friendsLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.friendsLbl.Name = "friendsLbl";
            this.friendsLbl.Size = new System.Drawing.Size(95, 29);
            this.friendsLbl.TabIndex = 21;
            this.friendsLbl.Text = "Friends";
            // 
            // profileLbl
            // 
            this.profileLbl.AutoSize = true;
            this.profileLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.profileLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.profileLbl.Location = new System.Drawing.Point(310, 36);
            this.profileLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.profileLbl.Name = "profileLbl";
            this.profileLbl.Size = new System.Drawing.Size(205, 31);
            this.profileLbl.TabIndex = 22;
            this.profileLbl.Text = "Personal Profile";
            // 
            // addBtn
            // 
            this.addBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.addBtn.Location = new System.Drawing.Point(258, 471);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(110, 30);
            this.addBtn.TabIndex = 23;
            this.addBtn.Text = "Add Friend";
            this.addBtn.UseVisualStyleBackColor = false;
            // 
            // chatBtn
            // 
            this.chatBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.chatBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chatBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.chatBtn.Location = new System.Drawing.Point(381, 471);
            this.chatBtn.Name = "chatBtn";
            this.chatBtn.Size = new System.Drawing.Size(110, 30);
            this.chatBtn.TabIndex = 24;
            this.chatBtn.Text = "Chat";
            this.chatBtn.UseVisualStyleBackColor = false;
            // 
            // friendsGrp
            // 
            this.friendsGrp.Controls.Add(this.friendsGrd);
            this.friendsGrp.Location = new System.Drawing.Point(261, 236);
            this.friendsGrp.Name = "friendsGrp";
            this.friendsGrp.Size = new System.Drawing.Size(227, 224);
            this.friendsGrp.TabIndex = 25;
            this.friendsGrp.TabStop = false;
            // 
            // friendsGrd
            // 
            this.friendsGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.friendsGrd.Location = new System.Drawing.Point(6, 12);
            this.friendsGrd.Name = "friendsGrd";
            this.friendsGrd.Size = new System.Drawing.Size(215, 207);
            this.friendsGrd.TabIndex = 1;
            // 
            // studentNumLbl
            // 
            this.studentNumLbl.AutoSize = true;
            this.studentNumLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNumLbl.ForeColor = System.Drawing.Color.Coral;
            this.studentNumLbl.Location = new System.Drawing.Point(11, 43);
            this.studentNumLbl.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentNumLbl.Name = "studentNumLbl";
            this.studentNumLbl.Size = new System.Drawing.Size(107, 20);
            this.studentNumLbl.TabIndex = 24;
            this.studentNumLbl.Text = "Student Num:";
            // 
            // studentNumVal
            // 
            this.studentNumVal.AutoSize = true;
            this.studentNumVal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentNumVal.ForeColor = System.Drawing.Color.OrangeRed;
            this.studentNumVal.Location = new System.Drawing.Point(115, 43);
            this.studentNumVal.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.studentNumVal.Name = "studentNumVal";
            this.studentNumVal.Size = new System.Drawing.Size(27, 20);
            this.studentNumVal.TabIndex = 23;
            this.studentNumVal.Text = "22";
            // 
            // viewProfileFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(694, 511);
            this.Controls.Add(this.friendsGrp);
            this.Controls.Add(this.chatBtn);
            this.Controls.Add(this.interestLbl);
            this.Controls.Add(this.addBtn);
            this.Controls.Add(this.aboutLbl);
            this.Controls.Add(this.profileLbl);
            this.Controls.Add(this.friendsLbl);
            this.Controls.Add(this.interestGrp);
            this.Controls.Add(this.aboutGrp);
            this.Controls.Add(this.logoImg);
            this.Controls.Add(this.profileImg);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "viewProfileFrm";
            this.Text = "Profile";
            this.Load += new System.EventHandler(this.viewProfileFrm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.profileImg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.logoImg)).EndInit();
            this.aboutGrp.ResumeLayout(false);
            this.aboutGrp.PerformLayout();
            this.interestGrp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.interestGrd)).EndInit();
            this.friendsGrp.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.friendsGrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.PictureBox profileImg;
        private System.Windows.Forms.PictureBox logoImg;
        private System.Windows.Forms.GroupBox aboutGrp;
        private System.Windows.Forms.Label genderVal;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Label dobVal;
        private System.Windows.Forms.Label dobLbl;
        private System.Windows.Forms.Label forenameLbl;
        private System.Windows.Forms.Label forenameVal;
        private System.Windows.Forms.GroupBox interestGrp;
        private System.Windows.Forms.Label aboutLbl;
        private System.Windows.Forms.Label interestLbl;
        private System.Windows.Forms.Label friendsLbl;
        private System.Windows.Forms.Label profileLbl;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button chatBtn;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.Label surnameVal;
        private System.Windows.Forms.DataGridView interestGrd;
        private System.Windows.Forms.GroupBox friendsGrp;
        private System.Windows.Forms.DataGridView friendsGrd;
        private System.Windows.Forms.Label studentNumLbl;
        private System.Windows.Forms.Label studentNumVal;
    }
}