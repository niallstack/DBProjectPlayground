namespace Playground_Home
{
    partial class EditStudentFrm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditStudentFrm));
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuPnl = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.editStuLinkLbl = new System.Windows.Forms.LinkLabel();
            this.delStuLinkLbl = new System.Windows.Forms.LinkLabel();
            this.regStuLinkLbl = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.studnumBtn = new System.Windows.Forms.Button();
            this.grpBtn = new System.Windows.Forms.Button();
            this.sortLbl = new System.Windows.Forms.Label();
            this.surnameBtn = new System.Windows.Forms.Button();
            this.studIDBtn = new System.Windows.Forms.Button();
            this.studGrd = new System.Windows.Forms.DataGridView();
            this.groupIDlbl = new System.Windows.Forms.Label();
            this.groupIDTxt = new System.Windows.Forms.TextBox();
            this.dobTP = new System.Windows.Forms.DateTimePicker();
            this.dobLbl = new System.Windows.Forms.Label();
            this.surnameLbl = new System.Windows.Forms.Label();
            this.surnameTxt = new System.Windows.Forms.TextBox();
            this.forenameLbl = new System.Windows.Forms.Label();
            this.forenameTxt = new System.Windows.Forms.TextBox();
            this.stuIDLbl = new System.Windows.Forms.Label();
            this.studIDTxt = new System.Windows.Forms.TextBox();
            this.regBtn = new System.Windows.Forms.Button();
            this.genCBM = new System.Windows.Forms.ComboBox();
            this.studNumTxt = new System.Windows.Forms.Label();
            this.stuNumTxt = new System.Windows.Forms.TextBox();
            this.passwordLbl = new System.Windows.Forms.Label();
            this.passwordTxt = new System.Windows.Forms.TextBox();
            this.imageLbl = new System.Windows.Forms.Label();
            this.imgTxt = new System.Windows.Forms.TextBox();
            this.genderLbl = new System.Windows.Forms.Label();
            this.menuPnl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studGrd)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip
            // 
            this.menuStrip.BackColor = System.Drawing.Color.OrangeRed;
            this.menuStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(913, 24);
            this.menuStrip.TabIndex = 3;
            this.menuStrip.Text = "menuStrip";
            // 
            // menuPnl
            // 
            this.menuPnl.BackColor = System.Drawing.Color.OrangeRed;
            this.menuPnl.Controls.Add(this.logoutBtn);
            this.menuPnl.Controls.Add(this.editStuLinkLbl);
            this.menuPnl.Controls.Add(this.delStuLinkLbl);
            this.menuPnl.Controls.Add(this.regStuLinkLbl);
            this.menuPnl.Location = new System.Drawing.Point(0, 27);
            this.menuPnl.Name = "menuPnl";
            this.menuPnl.Size = new System.Drawing.Size(137, 536);
            this.menuPnl.TabIndex = 5;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutBtn.Location = new System.Drawing.Point(6, 483);
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
            this.delStuLinkLbl.Location = new System.Drawing.Point(3, 64);
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
            this.regStuLinkLbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.regStuLinkLbl.Location = new System.Drawing.Point(3, 23);
            this.regStuLinkLbl.Name = "regStuLinkLbl";
            this.regStuLinkLbl.Size = new System.Drawing.Size(117, 18);
            this.regStuLinkLbl.TabIndex = 0;
            this.regStuLinkLbl.TabStop = true;
            this.regStuLinkLbl.Text = "Register Student";
            this.regStuLinkLbl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.regStuLinkLbl_LinkClicked);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.label1.Location = new System.Drawing.Point(143, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(123, 24);
            this.label1.TabIndex = 26;
            this.label1.Text = "Edit Student";
            // 
            // studnumBtn
            // 
            this.studnumBtn.Location = new System.Drawing.Point(512, 270);
            this.studnumBtn.Name = "studnumBtn";
            this.studnumBtn.Size = new System.Drawing.Size(75, 23);
            this.studnumBtn.TabIndex = 37;
            this.studnumBtn.Text = "Student No.";
            this.studnumBtn.UseVisualStyleBackColor = true;
            // 
            // grpBtn
            // 
            this.grpBtn.Location = new System.Drawing.Point(419, 270);
            this.grpBtn.Name = "grpBtn";
            this.grpBtn.Size = new System.Drawing.Size(75, 23);
            this.grpBtn.TabIndex = 36;
            this.grpBtn.Text = "Group ID";
            this.grpBtn.UseVisualStyleBackColor = true;
            // 
            // sortLbl
            // 
            this.sortLbl.AutoSize = true;
            this.sortLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.sortLbl.Location = new System.Drawing.Point(158, 275);
            this.sortLbl.Name = "sortLbl";
            this.sortLbl.Size = new System.Drawing.Size(61, 18);
            this.sortLbl.TabIndex = 35;
            this.sortLbl.Text = "Sort By:";
            // 
            // surnameBtn
            // 
            this.surnameBtn.Location = new System.Drawing.Point(327, 270);
            this.surnameBtn.Name = "surnameBtn";
            this.surnameBtn.Size = new System.Drawing.Size(75, 23);
            this.surnameBtn.TabIndex = 34;
            this.surnameBtn.Text = "Surname";
            this.surnameBtn.UseVisualStyleBackColor = true;
            // 
            // studIDBtn
            // 
            this.studIDBtn.Location = new System.Drawing.Point(237, 270);
            this.studIDBtn.Name = "studIDBtn";
            this.studIDBtn.Size = new System.Drawing.Size(75, 23);
            this.studIDBtn.TabIndex = 33;
            this.studIDBtn.Text = "Student ID";
            this.studIDBtn.UseVisualStyleBackColor = true;
            // 
            // studGrd
            // 
            this.studGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studGrd.Location = new System.Drawing.Point(161, 70);
            this.studGrd.Name = "studGrd";
            this.studGrd.Size = new System.Drawing.Size(724, 194);
            this.studGrd.TabIndex = 32;
            // 
            // groupIDlbl
            // 
            this.groupIDlbl.AutoSize = true;
            this.groupIDlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupIDlbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.groupIDlbl.Location = new System.Drawing.Point(155, 472);
            this.groupIDlbl.Name = "groupIDlbl";
            this.groupIDlbl.Size = new System.Drawing.Size(75, 20);
            this.groupIDlbl.TabIndex = 47;
            this.groupIDlbl.Text = "Group ID";
            // 
            // groupIDTxt
            // 
            this.groupIDTxt.Location = new System.Drawing.Point(268, 472);
            this.groupIDTxt.Name = "groupIDTxt";
            this.groupIDTxt.ReadOnly = true;
            this.groupIDTxt.Size = new System.Drawing.Size(200, 20);
            this.groupIDTxt.TabIndex = 46;
            // 
            // dobTP
            // 
            this.dobTP.Location = new System.Drawing.Point(268, 432);
            this.dobTP.Name = "dobTP";
            this.dobTP.Size = new System.Drawing.Size(200, 20);
            this.dobTP.TabIndex = 45;
            // 
            // dobLbl
            // 
            this.dobLbl.AutoSize = true;
            this.dobLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dobLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.dobLbl.Location = new System.Drawing.Point(186, 432);
            this.dobLbl.Name = "dobLbl";
            this.dobLbl.Size = new System.Drawing.Size(44, 20);
            this.dobLbl.TabIndex = 44;
            this.dobLbl.Text = "DOB";
            // 
            // surnameLbl
            // 
            this.surnameLbl.AutoSize = true;
            this.surnameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.surnameLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.surnameLbl.Location = new System.Drawing.Point(156, 390);
            this.surnameLbl.Name = "surnameLbl";
            this.surnameLbl.Size = new System.Drawing.Size(74, 20);
            this.surnameLbl.TabIndex = 43;
            this.surnameLbl.Text = "Surname";
            // 
            // surnameTxt
            // 
            this.surnameTxt.Location = new System.Drawing.Point(268, 390);
            this.surnameTxt.Name = "surnameTxt";
            this.surnameTxt.Size = new System.Drawing.Size(200, 20);
            this.surnameTxt.TabIndex = 42;
            // 
            // forenameLbl
            // 
            this.forenameLbl.AutoSize = true;
            this.forenameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.forenameLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.forenameLbl.Location = new System.Drawing.Point(148, 349);
            this.forenameLbl.Name = "forenameLbl";
            this.forenameLbl.Size = new System.Drawing.Size(82, 20);
            this.forenameLbl.TabIndex = 41;
            this.forenameLbl.Text = "Forename";
            // 
            // forenameTxt
            // 
            this.forenameTxt.Location = new System.Drawing.Point(268, 351);
            this.forenameTxt.Name = "forenameTxt";
            this.forenameTxt.Size = new System.Drawing.Size(200, 20);
            this.forenameTxt.TabIndex = 40;
            // 
            // stuIDLbl
            // 
            this.stuIDLbl.AutoSize = true;
            this.stuIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuIDLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.stuIDLbl.Location = new System.Drawing.Point(143, 308);
            this.stuIDLbl.Name = "stuIDLbl";
            this.stuIDLbl.Size = new System.Drawing.Size(87, 20);
            this.stuIDLbl.TabIndex = 39;
            this.stuIDLbl.Text = "Student ID";
            // 
            // studIDTxt
            // 
            this.studIDTxt.Location = new System.Drawing.Point(268, 308);
            this.studIDTxt.Name = "studIDTxt";
            this.studIDTxt.ReadOnly = true;
            this.studIDTxt.Size = new System.Drawing.Size(200, 20);
            this.studIDTxt.TabIndex = 38;
            // 
            // regBtn
            // 
            this.regBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.regBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.regBtn.Location = new System.Drawing.Point(465, 510);
            this.regBtn.Name = "regBtn";
            this.regBtn.Size = new System.Drawing.Size(122, 43);
            this.regBtn.TabIndex = 58;
            this.regBtn.Text = "Confirm";
            this.regBtn.UseVisualStyleBackColor = false;
            // 
            // genCBM
            // 
            this.genCBM.FormattingEnabled = true;
            this.genCBM.Location = new System.Drawing.Point(665, 310);
            this.genCBM.Name = "genCBM";
            this.genCBM.Size = new System.Drawing.Size(121, 21);
            this.genCBM.TabIndex = 66;
            // 
            // studNumTxt
            // 
            this.studNumTxt.AutoSize = true;
            this.studNumTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studNumTxt.ForeColor = System.Drawing.Color.OrangeRed;
            this.studNumTxt.Location = new System.Drawing.Point(501, 432);
            this.studNumTxt.Name = "studNumTxt";
            this.studNumTxt.Size = new System.Drawing.Size(126, 20);
            this.studNumTxt.TabIndex = 65;
            this.studNumTxt.Text = "Student Number";
            // 
            // stuNumTxt
            // 
            this.stuNumTxt.Location = new System.Drawing.Point(665, 432);
            this.stuNumTxt.Name = "stuNumTxt";
            this.stuNumTxt.ReadOnly = true;
            this.stuNumTxt.Size = new System.Drawing.Size(200, 20);
            this.stuNumTxt.TabIndex = 64;
            // 
            // passwordLbl
            // 
            this.passwordLbl.AutoSize = true;
            this.passwordLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.passwordLbl.Location = new System.Drawing.Point(549, 393);
            this.passwordLbl.Name = "passwordLbl";
            this.passwordLbl.Size = new System.Drawing.Size(78, 20);
            this.passwordLbl.TabIndex = 63;
            this.passwordLbl.Text = "Password";
            // 
            // passwordTxt
            // 
            this.passwordTxt.Location = new System.Drawing.Point(665, 393);
            this.passwordTxt.Name = "passwordTxt";
            this.passwordTxt.ReadOnly = true;
            this.passwordTxt.Size = new System.Drawing.Size(200, 20);
            this.passwordTxt.TabIndex = 62;
            // 
            // imageLbl
            // 
            this.imageLbl.AutoSize = true;
            this.imageLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.imageLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.imageLbl.Location = new System.Drawing.Point(573, 356);
            this.imageLbl.Name = "imageLbl";
            this.imageLbl.Size = new System.Drawing.Size(54, 20);
            this.imageLbl.TabIndex = 61;
            this.imageLbl.Text = "Image";
            // 
            // imgTxt
            // 
            this.imgTxt.Location = new System.Drawing.Point(665, 356);
            this.imgTxt.Name = "imgTxt";
            this.imgTxt.ReadOnly = true;
            this.imgTxt.Size = new System.Drawing.Size(200, 20);
            this.imgTxt.TabIndex = 60;
            // 
            // genderLbl
            // 
            this.genderLbl.AutoSize = true;
            this.genderLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.genderLbl.Location = new System.Drawing.Point(564, 311);
            this.genderLbl.Name = "genderLbl";
            this.genderLbl.Size = new System.Drawing.Size(63, 20);
            this.genderLbl.TabIndex = 59;
            this.genderLbl.Text = "Gender";
            // 
            // EditStudentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(913, 565);
            this.Controls.Add(this.genCBM);
            this.Controls.Add(this.studNumTxt);
            this.Controls.Add(this.stuNumTxt);
            this.Controls.Add(this.passwordLbl);
            this.Controls.Add(this.passwordTxt);
            this.Controls.Add(this.imageLbl);
            this.Controls.Add(this.imgTxt);
            this.Controls.Add(this.genderLbl);
            this.Controls.Add(this.regBtn);
            this.Controls.Add(this.groupIDlbl);
            this.Controls.Add(this.groupIDTxt);
            this.Controls.Add(this.dobTP);
            this.Controls.Add(this.dobLbl);
            this.Controls.Add(this.surnameLbl);
            this.Controls.Add(this.surnameTxt);
            this.Controls.Add(this.forenameLbl);
            this.Controls.Add(this.forenameTxt);
            this.Controls.Add(this.stuIDLbl);
            this.Controls.Add(this.studIDTxt);
            this.Controls.Add(this.studnumBtn);
            this.Controls.Add(this.grpBtn);
            this.Controls.Add(this.sortLbl);
            this.Controls.Add(this.surnameBtn);
            this.Controls.Add(this.studIDBtn);
            this.Controls.Add(this.studGrd);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.menuPnl);
            this.Controls.Add(this.menuStrip);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "EditStudentFrm";
            this.Text = "EditStudentFrm";
            this.Load += new System.EventHandler(this.EditStudentFrm_Load);
            this.menuPnl.ResumeLayout(false);
            this.menuPnl.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.studGrd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip;
        private System.Windows.Forms.Panel menuPnl;
        private System.Windows.Forms.Button logoutBtn;
        private System.Windows.Forms.LinkLabel editStuLinkLbl;
        private System.Windows.Forms.LinkLabel delStuLinkLbl;
        private System.Windows.Forms.LinkLabel regStuLinkLbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button studnumBtn;
        private System.Windows.Forms.Button grpBtn;
        private System.Windows.Forms.Label sortLbl;
        private System.Windows.Forms.Button surnameBtn;
        private System.Windows.Forms.Button studIDBtn;
        private System.Windows.Forms.DataGridView studGrd;
        private System.Windows.Forms.Label groupIDlbl;
        private System.Windows.Forms.TextBox groupIDTxt;
        private System.Windows.Forms.DateTimePicker dobTP;
        private System.Windows.Forms.Label dobLbl;
        private System.Windows.Forms.Label surnameLbl;
        private System.Windows.Forms.TextBox surnameTxt;
        private System.Windows.Forms.Label forenameLbl;
        private System.Windows.Forms.TextBox forenameTxt;
        private System.Windows.Forms.Label stuIDLbl;
        private System.Windows.Forms.TextBox studIDTxt;
        private System.Windows.Forms.Button regBtn;
        private System.Windows.Forms.ComboBox genCBM;
        private System.Windows.Forms.Label studNumTxt;
        private System.Windows.Forms.TextBox stuNumTxt;
        private System.Windows.Forms.Label passwordLbl;
        private System.Windows.Forms.TextBox passwordTxt;
        private System.Windows.Forms.Label imageLbl;
        private System.Windows.Forms.TextBox imgTxt;
        private System.Windows.Forms.Label genderLbl;
    }
}