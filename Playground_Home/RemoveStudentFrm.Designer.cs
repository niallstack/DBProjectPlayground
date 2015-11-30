namespace Playground_Home
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
            this.menuStrip.Location = new System.Drawing.Point(0, 0);
            this.menuStrip.Name = "menuStrip";
            this.menuStrip.Size = new System.Drawing.Size(694, 24);
            this.menuStrip.TabIndex = 2;
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
            this.menuPnl.Size = new System.Drawing.Size(137, 483);
            this.menuPnl.TabIndex = 4;
            // 
            // logoutBtn
            // 
            this.logoutBtn.BackColor = System.Drawing.Color.OrangeRed;
            this.logoutBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logoutBtn.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.logoutBtn.Location = new System.Drawing.Point(6, 430);
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
            this.editStuLinkLbl.LinkColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.editStuLinkLbl.Location = new System.Drawing.Point(3, 104);
            this.editStuLinkLbl.Name = "editStuLinkLbl";
            this.editStuLinkLbl.Size = new System.Drawing.Size(87, 18);
            this.editStuLinkLbl.TabIndex = 2;
            this.editStuLinkLbl.TabStop = true;
            this.editStuLinkLbl.Text = "Edit Student";
            // 
            // delStuLinkLbl
            // 
            this.delStuLinkLbl.AutoSize = true;
            this.delStuLinkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delStuLinkLbl.LinkColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.delStuLinkLbl.Location = new System.Drawing.Point(3, 64);
            this.delStuLinkLbl.Name = "delStuLinkLbl";
            this.delStuLinkLbl.Size = new System.Drawing.Size(118, 18);
            this.delStuLinkLbl.TabIndex = 1;
            this.delStuLinkLbl.TabStop = true;
            this.delStuLinkLbl.Text = "Remove Student";
            // 
            // regStuLinkLbl
            // 
            this.regStuLinkLbl.AutoSize = true;
            this.regStuLinkLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.regStuLinkLbl.LinkColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.regStuLinkLbl.Location = new System.Drawing.Point(3, 23);
            this.regStuLinkLbl.Name = "regStuLinkLbl";
            this.regStuLinkLbl.Size = new System.Drawing.Size(117, 18);
            this.regStuLinkLbl.TabIndex = 0;
            this.regStuLinkLbl.TabStop = true;
            this.regStuLinkLbl.Text = "Register Student";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(143, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 24);
            this.label1.TabIndex = 25;
            this.label1.Text = "Remove Student";
            // 
            // studGrd
            // 
            this.studGrd.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.studGrd.Location = new System.Drawing.Point(167, 91);
            this.studGrd.Name = "studGrd";
            this.studGrd.Size = new System.Drawing.Size(501, 194);
            this.studGrd.TabIndex = 26;
            // 
            // studIDBtn
            // 
            this.studIDBtn.Location = new System.Drawing.Point(243, 291);
            this.studIDBtn.Name = "studIDBtn";
            this.studIDBtn.Size = new System.Drawing.Size(75, 23);
            this.studIDBtn.TabIndex = 27;
            this.studIDBtn.Text = "Student ID";
            this.studIDBtn.UseVisualStyleBackColor = true;
            // 
            // surnameBtn
            // 
            this.surnameBtn.Location = new System.Drawing.Point(333, 291);
            this.surnameBtn.Name = "surnameBtn";
            this.surnameBtn.Size = new System.Drawing.Size(75, 23);
            this.surnameBtn.TabIndex = 28;
            this.surnameBtn.Text = "Surname";
            this.surnameBtn.UseVisualStyleBackColor = true;
            // 
            // sortLbl
            // 
            this.sortLbl.AutoSize = true;
            this.sortLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sortLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.sortLbl.Location = new System.Drawing.Point(164, 296);
            this.sortLbl.Name = "sortLbl";
            this.sortLbl.Size = new System.Drawing.Size(61, 18);
            this.sortLbl.TabIndex = 29;
            this.sortLbl.Text = "Sort By:";
            // 
            // grpBtn
            // 
            this.grpBtn.Location = new System.Drawing.Point(425, 291);
            this.grpBtn.Name = "grpBtn";
            this.grpBtn.Size = new System.Drawing.Size(75, 23);
            this.grpBtn.TabIndex = 30;
            this.grpBtn.Text = "Group ID";
            this.grpBtn.UseVisualStyleBackColor = true;
            // 
            // studnumBtn
            // 
            this.studnumBtn.Location = new System.Drawing.Point(518, 291);
            this.studnumBtn.Name = "studnumBtn";
            this.studnumBtn.Size = new System.Drawing.Size(75, 23);
            this.studnumBtn.TabIndex = 31;
            this.studnumBtn.Text = "Student No.";
            this.studnumBtn.UseVisualStyleBackColor = true;
            // 
            // stuIDLbl
            // 
            this.stuIDLbl.AutoSize = true;
            this.stuIDLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stuIDLbl.ForeColor = System.Drawing.Color.OrangeRed;
            this.stuIDLbl.Location = new System.Drawing.Point(220, 360);
            this.stuIDLbl.Name = "stuIDLbl";
            this.stuIDLbl.Size = new System.Drawing.Size(87, 20);
            this.stuIDLbl.TabIndex = 33;
            this.stuIDLbl.Text = "Student ID";
            // 
            // studIDTxt
            // 
            this.studIDTxt.Location = new System.Drawing.Point(345, 360);
            this.studIDTxt.Name = "studIDTxt";
            this.studIDTxt.ReadOnly = true;
            this.studIDTxt.Size = new System.Drawing.Size(200, 20);
            this.studIDTxt.TabIndex = 32;
            // 
            // delBtn
            // 
            this.delBtn.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.delBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.delBtn.ForeColor = System.Drawing.Color.OrangeRed;
            this.delBtn.Location = new System.Drawing.Point(378, 419);
            this.delBtn.Name = "delBtn";
            this.delBtn.Size = new System.Drawing.Size(122, 43);
            this.delBtn.TabIndex = 34;
            this.delBtn.Text = "Remove";
            this.delBtn.UseVisualStyleBackColor = false;
            // 
            // RemoveStudentFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.ClientSize = new System.Drawing.Size(694, 512);
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
            this.Name = "RemoveStudentFrm";
            this.Text = "RemoveStudentFrm";
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