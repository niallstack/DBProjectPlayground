namespace Playground_Home
{
    partial class RegisterStudentFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegisterStudentFrm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.studIDTxt = new System.Windows.Forms.TextBox();
            this.menuPnl = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.editStuLinkLbl = new System.Windows.Forms.LinkLabel();
            this.delStuLinkLbl = new System.Windows.Forms.LinkLabel();
            this.regStuLinkLbl = new System.Windows.Forms.LinkLabel();
            this.stuIDLbl = new System.Windows.Forms.Label();
            this.forenameLbl = new System.Windows.Forms.Label();
            this.forenameTxt = new System.Windows.Forms.TextBox();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.dobLbl = new System.Windows.Forms.Label();
            this.groupIDlbl = new System.Windows.Forms.Label();
            this.groupIDTxt = new System.Windows.Forms.TextBox();
            this.genderLbl = new System.Windows.Forms.Label();
            this.imageLbl = new System.Windows.Forms.Label();
            this.imgTxt = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.studNumTxt = new System.Windows.Forms.Label();
            this.stuNumTxt = new System.Windows.Forms.TextBox();
            this.regBtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dobTxt = new System.Windows.Forms.TextBox();
            this.SchoolIDTxt = new System.Windows.Forms.TextBox();
            this.schoolidLbl = new System.Windows.Forms.Label();
            this.genderTxt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.statusTxt = new System.Windows.Forms.TextBox();
            this.menuPnl.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.OrangeRed;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(694, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // studIDTxt
            // 
            this.studIDTxt.Location = new System.Drawing.Point(440, 50);
            this.studIDTxt.Name = "studIDTxt";
            this.studIDTxt.Size = new System.Drawing.Size(200, 20);
            this.studIDTxt.TabIndex = 2;
            this.studIDTxt.TextChanged += new System.EventHandler(this.studIDTxt_TextChanged);
            // 
            // menuPnl
            // 
            this.menuPnl.BackColor = System.Drawing.Color.OrangeRed;
            this.menuPnl.Controls.Add(this.logoutBtn);
            this.menuPnl.Controls.Add(this.editStuLinkLbl);
            this.menuPnl.Controls.Add(this.delStuLinkLbl);
            this.menuPnl.Controls.Add(this.regStuLinkLbl);
            this.menuPnl.Location = new System.Drawing.Point(0, 28);
            this.menuPnl.Name = "menuPnl";
            this.menuPnl.Size = new System.Drawing.Size(137, 483);
            this.menuPnl.TabIndex = 3;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutBtn.Location = new System.Drawing.Point(6, 431);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(122, 43);
            this.logoutBtn.TabIndex = 24;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            // 
            // editStuLinkLbl
            // 
            this.editStuLinkLbl.AutoSize = true;
            this.editStuLinkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStuLinkLbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editStuLinkLbl.Location = new System.Drawing.Point(3, 104);
            this.editStuLinkLbl.Name = "editStuLinkLbl";
            this.editStuLinkLbl.Size = new System.Drawing.Size(87, 18);
            this.editStuLinkLbl.TabIndex = 2;
            this.editStuLinkLbl.TabStop = true;
            this.editStuLinkLbl.Text = "Edit Student";
            this.editStuLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.editStuLinkLbl_LinkClicked);
            // 
            // delStuLinkLbl
            // 
            this.delStuLinkLbl.AutoSize = true;
            this.delStuLinkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delStuLinkLbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delStuLinkLbl.Location = new System.Drawing.Point(3, 63);
            this.delStuLinkLbl.Name = "delStuLinkLbl";
            this.delStuLinkLbl.Size = new System.Drawing.Size(118, 18);
            this.delStuLinkLbl.TabIndex = 1;
            this.delStuLinkLbl.TabStop = true;
            this.delStuLinkLbl.Text = "Remove Student";
            this.delStuLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.delStuLinkLbl_LinkClicked);
            // 
            // regStuLinkLbl
            // 
            this.regStuLinkLbl.AutoSize = true;
            this.regStuLinkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regStuLinkLbl.ForeColor = System.Drawing.SystemColors.WindowFrame;
            this.regStuLinkLbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.regStuLinkLbl.Location = new System.Drawing.Point(3, 23);
            this.regStuLinkLbl.Name = "regStuLinkLbl";
            this.regStuLinkLbl.Size = new System.Drawing.Size(117, 18);
            this.regStuLinkLbl.TabIndex = 0;
            this.regStuLinkLbl.TabStop = true;
            this.regStuLinkLbl.Text = "Register Student";
            this.regStuLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.regStuLinkLbl_LinkClicked);
            // 
            // stuIDLbl
            // 
            this.stuIDLbl.AutoSize = true;
            this.stuIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuIDLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.stuIDLbl.Location = new System.Drawing.Point(315, 50);
            this.stuIDLbl.Name = "stuIDLbl";
            this.stuIDLbl.Size = new System.Drawing.Size(87, 20);
            this.stuIDLbl.TabIndex = 4;
            this.stuIDLbl.Text = "Student ID";
            // 
            // forenameLbl
            // 
            this.forenameLbl.AutoSize = true;
            this.forenameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forenameLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.forenameLbl.Location = new System.Drawing.Point(320, 91);
            this.forenameLbl.Name = "forenameLbl";
            this.forenameLbl.Size = new System.Drawing.Size(82, 20);
            this.forenameLbl.TabIndex = 6;
            this.forenameLbl.Text = "Forename";
            // 
            // forenameTxt
            // 
            this.forenameTxt.Location = new System.Drawing.Point(440, 93);
            this.forenameTxt.Name = "forenameTxt";
            this.forenameTxt.Size = new System.Drawing.Size(200, 20);
            this.forenameTxt.TabIndex = 5;
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.surnameLbl.Location = new System.Drawing.Point(328, 132);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(74, 20);
            this.surnameLbl.TabIndex = 8;
            this.surnameLbl.Text = "Surname";
            // 
            // surnameTxt
            // 
            this.surnameTxt.Location = new System.Drawing.Point(440, 132);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(200, 20);
            this.surnameTxt.TabIndex = 7;
            // 
            // dobLbl
            // 
            this.dobLbl.AutoSize = true;
            this.dobLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.dobLbl.Location = new System.Drawing.Point(358, 174);
            this.dobLbl.Name = "dobLbl";
            this.dobLbl.Size = new System.Drawing.Size(44, 20);
            this.dobLbl.TabIndex = 10;
            this.dobLbl.Text = "DOB";
            // 
            // groupIDlbl
            // 
            this.groupIDlbl.AutoSize = true;
            this.groupIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupIDlbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupIDlbl.Location = new System.Drawing.Point(330, 246);
            this.groupIDlbl.Name = "groupIDlbl";
            this.groupIDlbl.Size = new System.Drawing.Size(75, 20);
            this.groupIDlbl.TabIndex = 13;
            this.groupIDlbl.Text = "Group ID";
            // 
            // groupIDTxt
            // 
            this.groupIDTxt.Location = new System.Drawing.Point(443, 246);
            this.groupIDTxt.Name = "groupIDTxt";
            this.groupIDTxt.Size = new System.Drawing.Size(200, 20);
            this.groupIDTxt.TabIndex = 12;
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.genderLbl.Location = new System.Drawing.Point(342, 287);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(63, 20);
            this.genderLbl.TabIndex = 15;
            this.genderLbl.Text = "Gender";
            // 
            // imageLbl
            // 
            this.imageLbl.AutoSize = true;
            this.imageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.imageLbl.Location = new System.Drawing.Point(351, 333);
            this.imageLbl.Name = "imageLbl";
            this.imageLbl.Size = new System.Drawing.Size(54, 20);
            this.imageLbl.TabIndex = 17;
            this.imageLbl.Text = "Image";
            // 
            // imgTxt
            // 
            this.imgTxt.Location = new System.Drawing.Point(443, 333);
            this.imgTxt.Name = "imgTxt";
            this.imgTxt.Size = new System.Drawing.Size(200, 20);
            this.imgTxt.TabIndex = 16;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.passwordLbl.Location = new System.Drawing.Point(327, 369);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(78, 20);
            this.passwordLbl.TabIndex = 19;
            this.passwordLbl.Text = "Password";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(443, 369);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.Size = new System.Drawing.Size(200, 20);
            this.passwordTxt.TabIndex = 18;
            // 
            // studNumTxt
            // 
            this.studNumTxt.AutoSize = true;
            this.studNumTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studNumTxt.ForeColor = System.Drawing.Color.OrangeRed;
            this.studNumTxt.Location = new System.Drawing.Point(279, 408);
            this.studNumTxt.Name = "studNumTxt";
            this.studNumTxt.Size = new System.Drawing.Size(126, 20);
            this.studNumTxt.TabIndex = 21;
            this.studNumTxt.Text = "Student Number";
            // 
            // stuNumTxt
            // 
            this.stuNumTxt.Location = new System.Drawing.Point(443, 408);
            this.stuNumTxt.Name = "stuNumTxt";
            this.stuNumTxt.Size = new System.Drawing.Size(200, 20);
            this.stuNumTxt.TabIndex = 20;
            // 
            // regBtn
            // 
            this.regBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.regBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.regBtn.Location = new System.Drawing.Point(467, 468);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(122, 43);
            this.regBtn.TabIndex = 23;
            this.regBtn.Text = "Confirm";
            this.regBtn.UseVisualStyleBackColor = false;
            this.regBtn.Click += new System.EventHandler(this.regBtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(142, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 24;
            this.label1.Text = "Register Student";
            // 
            // dobTxt
            // 
            this.dobTxt.Location = new System.Drawing.Point(440, 174);
            this.dobTxt.Name = "dobTxt";
            this.dobTxt.Size = new System.Drawing.Size(200, 20);
            this.dobTxt.TabIndex = 25;
            // 
            // SchoolIDTxt
            // 
            this.SchoolIDTxt.Location = new System.Drawing.Point(441, 211);
            this.SchoolIDTxt.Name = "SchoolIDTxt";
            this.SchoolIDTxt.Size = new System.Drawing.Size(200, 20);
            this.SchoolIDTxt.TabIndex = 27;
            // 
            // schoolidLbl
            // 
            this.schoolidLbl.AutoSize = true;
            this.schoolidLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolidLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.schoolidLbl.Location = new System.Drawing.Point(325, 209);
            this.schoolidLbl.Name = "schoolidLbl";
            this.schoolidLbl.Size = new System.Drawing.Size(79, 20);
            this.schoolidLbl.TabIndex = 26;
            this.schoolidLbl.Text = "School ID";
            // 
            // genderTxt
            // 
            this.genderTxt.Location = new System.Drawing.Point(443, 289);
            this.genderTxt.Name = "genderTxt";
            this.genderTxt.Size = new System.Drawing.Size(200, 20);
            this.genderTxt.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(350, 441);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 20);
            this.label2.TabIndex = 30;
            this.label2.Text = "Status";
            // 
            // statusTxt
            // 
            this.statusTxt.Location = new System.Drawing.Point(446, 443);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.Size = new System.Drawing.Size(200, 20);
            this.statusTxt.TabIndex = 29;
            // 
            // RegisterStudentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(694, 512);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusTxt);
            this.Controls.Add(this.genderTxt);
            this.Controls.Add(this.SchoolIDTxt);
            this.Controls.Add(this.schoolidLbl);
            this.Controls.Add(this.dobTxt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.studNumTxt);
            this.Controls.Add(this.stuNumTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.imageLbl);
            this.Controls.Add(this.imgTxt);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.groupIDlbl);
            this.Controls.Add(this.groupIDTxt);
            this.Controls.Add(this.dobLbl);
            this.Controls.Add(this.surnameLbl);
            this.Controls.Add(this.surnameTxt);
            this.Controls.Add(this.forenameLbl);
            this.Controls.Add(this.forenameTxt);
            this.Controls.Add(this.stuIDLbl);
            this.Controls.Add(this.menuPnl);
            this.Controls.Add(this.studIDTxt);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "RegisterStudentFrm";
            this.Text = "Register Student";
            this.Load += new System.EventHandler(this.RegisterStudentFrm_Load);
            this.menuPnl.ResumeLayout(false);
            this.menuPnl.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.TextBox studIDTxt;
        private System.Windows.Forms.Panel menuPnl;
        private System.Windows.Forms.Label stuIDLbl;
        private System.Windows.Forms.Label forenameLbl;
        private System.Windows.Forms.TextBox forenameTxt;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.Label dobLbl;
        private System.Windows.Forms.Label groupIDlbl;
        private System.Windows.Forms.TextBox groupIDTxt;
        private System.Windows.Forms.Label genderLbl;
        private System.Windows.Forms.Label imageLbl;
        private System.Windows.Forms.TextBox imgTxt;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label studNumTxt;
        private System.Windows.Forms.TextBox stuNumTxt;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.LinkLabel editStuLinkLbl;
        private System.Windows.Forms.LinkLabel delStuLinkLbl;
        private System.Windows.Forms.LinkLabel regStuLinkLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox dobTxt;
        private System.Windows.Forms.TextBox SchoolIDTxt;
        private System.Windows.Forms.Label schoolidLbl;
        private System.Windows.Forms.TextBox genderTxt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox statusTxt;
    }
}