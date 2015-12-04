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
            this.menuStrip.Padding = new System.Windows.Forms.Padding(9, 3, 0, 3);
            this.menuStrip.Size = new System.Drawing.Size(1041, 24);
            this.menuStrip.TabIndex = 1;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // studIDTxt
            // 
            this.studIDTxt.Location = new System.Drawing.Point(660, 77);
            this.studIDTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.studIDTxt.Name = "studIDTxt";
            this.studIDTxt.ReadOnly = true;
            this.studIDTxt.Size = new System.Drawing.Size(298, 26);
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
            this.menuPnl.Location = new System.Drawing.Point(0, 43);
            this.menuPnl.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.menuPnl.Name = "menuPnl";
            this.menuPnl.Size = new System.Drawing.Size(206, 743);
            this.menuPnl.TabIndex = 3;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutBtn.Location = new System.Drawing.Point(9, 663);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(183, 66);
            this.logoutBtn.TabIndex = 24;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            // 
            // editStuLinkLbl
            // 
            this.editStuLinkLbl.AutoSize = true;
            this.editStuLinkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStuLinkLbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editStuLinkLbl.Location = new System.Drawing.Point(4, 160);
            this.editStuLinkLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.editStuLinkLbl.Name = "editStuLinkLbl";
            this.editStuLinkLbl.Size = new System.Drawing.Size(143, 29);
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
            this.delStuLinkLbl.Location = new System.Drawing.Point(4, 97);
            this.delStuLinkLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.delStuLinkLbl.Name = "delStuLinkLbl";
            this.delStuLinkLbl.Size = new System.Drawing.Size(191, 29);
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
            this.regStuLinkLbl.Location = new System.Drawing.Point(4, 35);
            this.regStuLinkLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.regStuLinkLbl.Name = "regStuLinkLbl";
            this.regStuLinkLbl.Size = new System.Drawing.Size(192, 29);
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
            this.stuIDLbl.Location = new System.Drawing.Point(472, 77);
            this.stuIDLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stuIDLbl.Name = "stuIDLbl";
            this.stuIDLbl.Size = new System.Drawing.Size(124, 29);
            this.stuIDLbl.TabIndex = 4;
            this.stuIDLbl.Text = "Student ID";
            // 
            // forenameLbl
            // 
            this.forenameLbl.AutoSize = true;
            this.forenameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forenameLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.forenameLbl.Location = new System.Drawing.Point(480, 140);
            this.forenameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.forenameLbl.Name = "forenameLbl";
            this.forenameLbl.Size = new System.Drawing.Size(124, 29);
            this.forenameLbl.TabIndex = 6;
            this.forenameLbl.Text = "Forename";
            // 
            // forenameTxt
            // 
            this.forenameTxt.Location = new System.Drawing.Point(660, 143);
            this.forenameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.forenameTxt.Name = "forenameTxt";
            this.forenameTxt.Size = new System.Drawing.Size(298, 26);
            this.forenameTxt.TabIndex = 5;
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.surnameLbl.Location = new System.Drawing.Point(492, 203);
            this.surnameLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(110, 29);
            this.surnameLbl.TabIndex = 8;
            this.surnameLbl.Text = "Surname";
            // 
            // surnameTxt
            // 
            this.surnameTxt.Location = new System.Drawing.Point(660, 203);
            this.surnameTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(298, 26);
            this.surnameTxt.TabIndex = 7;
            // 
            // dobLbl
            // 
            this.dobLbl.AutoSize = true;
            this.dobLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.dobLbl.Location = new System.Drawing.Point(537, 268);
            this.dobLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.dobLbl.Name = "dobLbl";
            this.dobLbl.Size = new System.Drawing.Size(65, 29);
            this.dobLbl.TabIndex = 10;
            this.dobLbl.Text = "DOB";
            // 
            // groupIDlbl
            // 
            this.groupIDlbl.AutoSize = true;
            this.groupIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupIDlbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupIDlbl.Location = new System.Drawing.Point(495, 379);
            this.groupIDlbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.groupIDlbl.Name = "groupIDlbl";
            this.groupIDlbl.Size = new System.Drawing.Size(109, 29);
            this.groupIDlbl.TabIndex = 13;
            this.groupIDlbl.Text = "Group ID";
            // 
            // groupIDTxt
            // 
            this.groupIDTxt.Location = new System.Drawing.Point(665, 379);
            this.groupIDTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.groupIDTxt.Name = "groupIDTxt";
            this.groupIDTxt.ReadOnly = true;
            this.groupIDTxt.Size = new System.Drawing.Size(298, 26);
            this.groupIDTxt.TabIndex = 12;
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.genderLbl.Location = new System.Drawing.Point(513, 442);
            this.genderLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(94, 29);
            this.genderLbl.TabIndex = 15;
            this.genderLbl.Text = "Gender";
            // 
            // imageLbl
            // 
            this.imageLbl.AutoSize = true;
            this.imageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.imageLbl.Location = new System.Drawing.Point(527, 513);
            this.imageLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.imageLbl.Name = "imageLbl";
            this.imageLbl.Size = new System.Drawing.Size(80, 29);
            this.imageLbl.TabIndex = 17;
            this.imageLbl.Text = "Image";
            // 
            // imgTxt
            // 
            this.imgTxt.Location = new System.Drawing.Point(665, 513);
            this.imgTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.imgTxt.Name = "imgTxt";
            this.imgTxt.ReadOnly = true;
            this.imgTxt.Size = new System.Drawing.Size(298, 26);
            this.imgTxt.TabIndex = 16;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.passwordLbl.Location = new System.Drawing.Point(491, 567);
            this.passwordLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(120, 29);
            this.passwordLbl.TabIndex = 19;
            this.passwordLbl.Text = "Password";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(665, 567);
            this.passwordTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.ReadOnly = true;
            this.passwordTxt.Size = new System.Drawing.Size(298, 26);
            this.passwordTxt.TabIndex = 18;
            // 
            // studNumTxt
            // 
            this.studNumTxt.AutoSize = true;
            this.studNumTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studNumTxt.ForeColor = System.Drawing.Color.OrangeRed;
            this.studNumTxt.Location = new System.Drawing.Point(419, 627);
            this.studNumTxt.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.studNumTxt.Name = "studNumTxt";
            this.studNumTxt.Size = new System.Drawing.Size(188, 29);
            this.studNumTxt.TabIndex = 21;
            this.studNumTxt.Text = "Student Number";
            // 
            // stuNumTxt
            // 
            this.stuNumTxt.Location = new System.Drawing.Point(665, 627);
            this.stuNumTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.stuNumTxt.Name = "stuNumTxt";
            this.stuNumTxt.ReadOnly = true;
            this.stuNumTxt.Size = new System.Drawing.Size(298, 26);
            this.stuNumTxt.TabIndex = 20;
            // 
            // regBtn
            // 
            this.regBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.regBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.regBtn.Location = new System.Drawing.Point(701, 720);
            this.regBtn.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(183, 66);
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
            this.label1.Location = new System.Drawing.Point(213, 43);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 33);
            this.label1.TabIndex = 24;
            this.label1.Text = "Register Student";
            // 
            // dobTxt
            // 
            this.dobTxt.Location = new System.Drawing.Point(660, 268);
            this.dobTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dobTxt.Name = "dobTxt";
            this.dobTxt.Size = new System.Drawing.Size(298, 26);
            this.dobTxt.TabIndex = 25;
            // 
            // SchoolIDTxt
            // 
            this.SchoolIDTxt.Location = new System.Drawing.Point(662, 325);
            this.SchoolIDTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.SchoolIDTxt.Name = "SchoolIDTxt";
            this.SchoolIDTxt.Size = new System.Drawing.Size(298, 26);
            this.SchoolIDTxt.TabIndex = 27;
            // 
            // schoolidLbl
            // 
            this.schoolidLbl.AutoSize = true;
            this.schoolidLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schoolidLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.schoolidLbl.Location = new System.Drawing.Point(487, 322);
            this.schoolidLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.schoolidLbl.Name = "schoolidLbl";
            this.schoolidLbl.Size = new System.Drawing.Size(117, 29);
            this.schoolidLbl.TabIndex = 26;
            this.schoolidLbl.Text = "School ID";
            // 
            // genderTxt
            // 
            this.genderTxt.Location = new System.Drawing.Point(665, 445);
            this.genderTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.genderTxt.Name = "genderTxt";
            this.genderTxt.ReadOnly = true;
            this.genderTxt.Size = new System.Drawing.Size(298, 26);
            this.genderTxt.TabIndex = 28;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(525, 678);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 29);
            this.label2.TabIndex = 30;
            this.label2.Text = "Status";
            // 
            // statusTxt
            // 
            this.statusTxt.Location = new System.Drawing.Point(669, 681);
            this.statusTxt.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.statusTxt.Name = "statusTxt";
            this.statusTxt.ReadOnly = true;
            this.statusTxt.Size = new System.Drawing.Size(298, 26);
            this.statusTxt.TabIndex = 29;
            // 
            // RegisterStudentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1041, 788);
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
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
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