﻿namespace Playground_Home
{
    partial class RemoveStudentFrm
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
            this.menuStrip = new System.Windows.Forms.MenuStrip();
            this.menuPnl = new System.Windows.Forms.Panel();
            this.logoutBtn = new System.Windows.Forms.Button();
            this.editStuLinkLbl = new System.Windows.Forms.LinkLabel();
            this.delStuLinkLbl = new System.Windows.Forms.LinkLabel();
            this.regStuLinkLbl = new System.Windows.Forms.LinkLabel();
            this.label1 = new System.Windows.Forms.Label();
            this.studGrd = new System.Windows.Forms.DataGridView();
            this.studIDBtn = new System.Windows.Forms.Button();
            this.surnameBtn = new System.Windows.Forms.Button();
            this.sortLbl = new System.Windows.Forms.Label();
            this.grpBtn = new System.Windows.Forms.Button();
            this.studnumBtn = new System.Windows.Forms.Button();
            this.stuIDLbl = new System.Windows.Forms.Label();
            this.studIDTxt = new System.Windows.Forms.TextBox();
            this.delBtn = new System.Windows.Forms.Button();
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
            this.menuStrip.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip.Size = new System.Drawing.Size(925, 24);
            this.menuStrip.TabIndex = 2;
            this.menuStrip.Text = "menuStrip";
            this.menuStrip.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip_ItemClicked);
            // 
            // menuPnl
            // 
            this.menuPnl.BackColor = System.Drawing.Color.OrangeRed;
            this.menuPnl.Controls.Add(this.logoutBtn);
            this.menuPnl.Controls.Add(this.editStuLinkLbl);
            this.menuPnl.Controls.Add(this.delStuLinkLbl);
            this.menuPnl.Controls.Add(this.regStuLinkLbl);
            this.menuPnl.Location = new System.Drawing.Point(0, 33);
            this.menuPnl.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menuPnl.Name = "menuPnl";
            this.menuPnl.Size = new System.Drawing.Size(183, 594);
            this.menuPnl.TabIndex = 4;
            this.menuPnl.Paint += new System.Windows.Forms.PaintEventHandler(this.menuPnl_Paint);
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.logoutBtn.Location = new System.Drawing.Point(8, 529);
            this.logoutBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoutBtn.Name = "logoutBtn";
            this.logoutBtn.Size = new System.Drawing.Size(163, 53);
            this.logoutBtn.TabIndex = 24;
            this.logoutBtn.Text = "Log Out";
            this.logoutBtn.UseVisualStyleBackColor = false;
            this.logoutBtn.Click += new System.EventHandler(this.logoutBtn_Click);
            // 
            // editStuLinkLbl
            // 
            this.editStuLinkLbl.AutoSize = true;
            this.editStuLinkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.editStuLinkLbl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.editStuLinkLbl.Location = new System.Drawing.Point(4, 128);
            this.editStuLinkLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.editStuLinkLbl.Name = "editStuLinkLbl";
            this.editStuLinkLbl.Size = new System.Drawing.Size(111, 24);
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
            this.delStuLinkLbl.Location = new System.Drawing.Point(4, 79);
            this.delStuLinkLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.delStuLinkLbl.Name = "delStuLinkLbl";
            this.delStuLinkLbl.Size = new System.Drawing.Size(150, 24);
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
            this.regStuLinkLbl.Location = new System.Drawing.Point(4, 28);
            this.regStuLinkLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.regStuLinkLbl.Name = "regStuLinkLbl";
            this.regStuLinkLbl.Size = new System.Drawing.Size(148, 24);
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
            this.label1.Location = new System.Drawing.Point(191, 33);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 29);
            this.label1.TabIndex = 25;
            this.label1.Text = "Remove Student";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // studGrd
            // 
            this.studGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studGrd.Location = new System.Drawing.Point(223, 112);
            this.studGrd.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studGrd.Name = "studGrd";
            this.studGrd.Size = new System.Drawing.Size(668, 239);
            this.studGrd.TabIndex = 26;
            this.studGrd.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.studGrd_CellContentClick);
            // 
            // studIDBtn
            // 
            this.studIDBtn.Location = new System.Drawing.Point(324, 358);
            this.studIDBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studIDBtn.Name = "studIDBtn";
            this.studIDBtn.Size = new System.Drawing.Size(100, 28);
            this.studIDBtn.TabIndex = 27;
            this.studIDBtn.Text = "Student ID";
            this.studIDBtn.UseVisualStyleBackColor = true;
            this.studIDBtn.Click += new System.EventHandler(this.studIDBtn_Click);
            // 
            // surnameBtn
            // 
            this.surnameBtn.Location = new System.Drawing.Point(444, 358);
            this.surnameBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.surnameBtn.Name = "surnameBtn";
            this.surnameBtn.Size = new System.Drawing.Size(100, 28);
            this.surnameBtn.TabIndex = 28;
            this.surnameBtn.Text = "Surname";
            this.surnameBtn.UseVisualStyleBackColor = true;
            this.surnameBtn.Click += new System.EventHandler(this.surnameBtn_Click);
            // 
            // sortLbl
            // 
            this.sortLbl.AutoSize = true;
            this.sortLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.sortLbl.Location = new System.Drawing.Point(219, 364);
            this.sortLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.sortLbl.Name = "sortLbl";
            this.sortLbl.Size = new System.Drawing.Size(74, 24);
            this.sortLbl.TabIndex = 29;
            this.sortLbl.Text = "Sort By:";
            this.sortLbl.Click += new System.EventHandler(this.sortLbl_Click);
            // 
            // grpBtn
            // 
            this.grpBtn.Location = new System.Drawing.Point(567, 358);
            this.grpBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpBtn.Name = "grpBtn";
            this.grpBtn.Size = new System.Drawing.Size(100, 28);
            this.grpBtn.TabIndex = 30;
            this.grpBtn.Text = "Group ID";
            this.grpBtn.UseVisualStyleBackColor = true;
            this.grpBtn.Click += new System.EventHandler(this.grpBtn_Click);
            // 
            // studnumBtn
            // 
            this.studnumBtn.Location = new System.Drawing.Point(691, 358);
            this.studnumBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studnumBtn.Name = "studnumBtn";
            this.studnumBtn.Size = new System.Drawing.Size(100, 28);
            this.studnumBtn.TabIndex = 31;
            this.studnumBtn.Text = "Student No.";
            this.studnumBtn.UseVisualStyleBackColor = true;
            this.studnumBtn.Click += new System.EventHandler(this.studnumBtn_Click);
            // 
            // stuIDLbl
            // 
            this.stuIDLbl.AutoSize = true;
            this.stuIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuIDLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.stuIDLbl.Location = new System.Drawing.Point(293, 443);
            this.stuIDLbl.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.stuIDLbl.Name = "stuIDLbl";
            this.stuIDLbl.Size = new System.Drawing.Size(104, 25);
            this.stuIDLbl.TabIndex = 33;
            this.stuIDLbl.Text = "Student ID";
            // 
            // studIDTxt
            // 
            this.studIDTxt.Location = new System.Drawing.Point(460, 443);
            this.studIDTxt.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.studIDTxt.Name = "studIDTxt";
            this.studIDTxt.ReadOnly = true;
            this.studIDTxt.Size = new System.Drawing.Size(265, 22);
            this.studIDTxt.TabIndex = 32;
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.delBtn.Location = new System.Drawing.Point(504, 516);
            this.delBtn.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(163, 53);
            this.delBtn.TabIndex = 34;
            this.delBtn.Text = "Remove";
            this.delBtn.UseVisualStyleBackColor = false;
            // 
            // RemoveStudentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(925, 630);
            this.Controls.Add(this.delBtn);
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
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "RemoveStudentFrm";
            this.Text = "RemoveStudentFrm";
            this.Load += new System.EventHandler(this.RemoveStudentFrm_Load);
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
        private System.Windows.Forms.DataGridView studGrd;
        private System.Windows.Forms.Button studIDBtn;
        private System.Windows.Forms.Button surnameBtn;
        private System.Windows.Forms.Label sortLbl;
        private System.Windows.Forms.Button grpBtn;
        private System.Windows.Forms.Button studnumBtn;
        private System.Windows.Forms.Label stuIDLbl;
        private System.Windows.Forms.TextBox studIDTxt;
        private System.Windows.Forms.Button delBtn;
    }
}