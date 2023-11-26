namespace _27NovemberTheory
{
    partial class OOp2C
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
            this.pnlInformation = new System.Windows.Forms.Panel();
            this.rbProgram = new System.Windows.Forms.Panel();
            this.rbBechelor = new System.Windows.Forms.RadioButton();
            this.rbMasters = new System.Windows.Forms.RadioButton();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.cmbDepartment = new System.Windows.Forms.ComboBox();
            this.btnShow = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.txtUsername = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtOutputUsername = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.pnlOut = new System.Windows.Forms.Panel();
            this.btnClear = new System.Windows.Forms.Button();
            this.lblProgram = new System.Windows.Forms.Label();
            this.lblDOB = new System.Windows.Forms.Label();
            this.lblDepartment = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.pnlInformation.SuspendLayout();
            this.rbProgram.SuspendLayout();
            this.pnlOut.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlInformation
            // 
            this.pnlInformation.BackColor = System.Drawing.Color.LightSlateGray;
            this.pnlInformation.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlInformation.Controls.Add(this.rbProgram);
            this.pnlInformation.Controls.Add(this.dateTimePicker1);
            this.pnlInformation.Controls.Add(this.cmbDepartment);
            this.pnlInformation.Controls.Add(this.btnShow);
            this.pnlInformation.Controls.Add(this.label6);
            this.pnlInformation.Controls.Add(this.label4);
            this.pnlInformation.Controls.Add(this.label5);
            this.pnlInformation.Controls.Add(this.label3);
            this.pnlInformation.Controls.Add(this.txtPassword);
            this.pnlInformation.Controls.Add(this.txtUsername);
            this.pnlInformation.Controls.Add(this.label2);
            this.pnlInformation.Controls.Add(this.label1);
            this.pnlInformation.Location = new System.Drawing.Point(12, 12);
            this.pnlInformation.Name = "pnlInformation";
            this.pnlInformation.Size = new System.Drawing.Size(426, 517);
            this.pnlInformation.TabIndex = 0;
            // 
            // rbProgram
            // 
            this.rbProgram.Controls.Add(this.rbBechelor);
            this.rbProgram.Controls.Add(this.rbMasters);
            this.rbProgram.Location = new System.Drawing.Point(192, 286);
            this.rbProgram.Name = "rbProgram";
            this.rbProgram.Size = new System.Drawing.Size(135, 72);
            this.rbProgram.TabIndex = 19;
            // 
            // rbBechelor
            // 
            this.rbBechelor.AutoSize = true;
            this.rbBechelor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBechelor.Location = new System.Drawing.Point(14, 3);
            this.rbBechelor.Name = "rbBechelor";
            this.rbBechelor.Size = new System.Drawing.Size(110, 29);
            this.rbBechelor.TabIndex = 14;
            this.rbBechelor.TabStop = true;
            this.rbBechelor.Text = "Bechelor";
            this.rbBechelor.UseVisualStyleBackColor = true;
            // 
            // rbMasters
            // 
            this.rbMasters.AutoSize = true;
            this.rbMasters.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbMasters.Location = new System.Drawing.Point(14, 38);
            this.rbMasters.Name = "rbMasters";
            this.rbMasters.Size = new System.Drawing.Size(107, 29);
            this.rbMasters.TabIndex = 15;
            this.rbMasters.TabStop = true;
            this.rbMasters.Text = "Master\'s";
            this.rbMasters.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd-MM-yyyy";
            this.dateTimePicker1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker1.Location = new System.Drawing.Point(192, 237);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(159, 22);
            this.dateTimePicker1.TabIndex = 13;
            // 
            // cmbDepartment
            // 
            this.cmbDepartment.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbDepartment.FormattingEnabled = true;
            this.cmbDepartment.Items.AddRange(new object[] {
            "CSE",
            "BBA",
            "EEE",
            "MBA"});
            this.cmbDepartment.Location = new System.Drawing.Point(192, 181);
            this.cmbDepartment.Name = "cmbDepartment";
            this.cmbDepartment.Size = new System.Drawing.Size(159, 24);
            this.cmbDepartment.TabIndex = 12;
            this.cmbDepartment.SelectedIndexChanged += new System.EventHandler(this.cmbDepartment_SelectedIndexChanged);
            // 
            // btnShow
            // 
            this.btnShow.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShow.Location = new System.Drawing.Point(67, 387);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(106, 38);
            this.btnShow.TabIndex = 11;
            this.btnShow.Text = "Show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(18, 306);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(113, 29);
            this.label6.TabIndex = 10;
            this.label6.Text = "Program";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(18, 243);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(162, 29);
            this.label4.TabIndex = 8;
            this.label4.Text = "Date Of Birth";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(18, 180);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(155, 29);
            this.label5.TabIndex = 5;
            this.label5.Text = "Department ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(18, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(132, 29);
            this.label3.TabIndex = 4;
            this.label3.Text = "PassWord";
            // 
            // txtPassword
            // 
            this.txtPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPassword.Location = new System.Drawing.Point(192, 115);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(159, 34);
            this.txtPassword.TabIndex = 3;
            // 
            // txtUsername
            // 
            this.txtUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtUsername.Location = new System.Drawing.Point(192, 49);
            this.txtUsername.Name = "txtUsername";
            this.txtUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtUsername.Size = new System.Drawing.Size(159, 34);
            this.txtUsername.TabIndex = 2;
            this.txtUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "User Name ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(119, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Information";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(900, 491);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 38);
            this.button2.TabIndex = 20;
            this.button2.Text = "Close";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Nirmala UI", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(151, 10);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(91, 31);
            this.label12.TabIndex = 0;
            this.label12.Text = "Output";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(18, 54);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 29);
            this.label11.TabIndex = 1;
            this.label11.Text = "User Name ";
            // 
            // txtOutputUsername
            // 
            this.txtOutputUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtOutputUsername.Location = new System.Drawing.Point(192, 49);
            this.txtOutputUsername.Name = "txtOutputUsername";
            this.txtOutputUsername.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtOutputUsername.Size = new System.Drawing.Size(159, 34);
            this.txtOutputUsername.TabIndex = 2;
            this.txtOutputUsername.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(18, 117);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(132, 29);
            this.label10.TabIndex = 4;
            this.label10.Text = "PassWord";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(18, 180);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(155, 29);
            this.label9.TabIndex = 5;
            this.label9.Text = "Department ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(162, 29);
            this.label8.TabIndex = 8;
            this.label8.Text = "Date Of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(18, 306);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(113, 29);
            this.label7.TabIndex = 10;
            this.label7.Text = "Program";
            // 
            // pnlOut
            // 
            this.pnlOut.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.pnlOut.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlOut.Controls.Add(this.btnClear);
            this.pnlOut.Controls.Add(this.lblProgram);
            this.pnlOut.Controls.Add(this.label7);
            this.pnlOut.Controls.Add(this.lblDOB);
            this.pnlOut.Controls.Add(this.label8);
            this.pnlOut.Controls.Add(this.lblDepartment);
            this.pnlOut.Controls.Add(this.label9);
            this.pnlOut.Controls.Add(this.lblPassword);
            this.pnlOut.Controls.Add(this.label10);
            this.pnlOut.Controls.Add(this.txtOutputUsername);
            this.pnlOut.Controls.Add(this.label11);
            this.pnlOut.Controls.Add(this.label12);
            this.pnlOut.Location = new System.Drawing.Point(468, 12);
            this.pnlOut.Name = "pnlOut";
            this.pnlOut.Size = new System.Drawing.Size(426, 517);
            this.pnlOut.TabIndex = 0;
            this.pnlOut.Visible = false;
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(241, 387);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(75, 38);
            this.btnClear.TabIndex = 11;
            this.btnClear.Text = "CLear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // lblProgram
            // 
            this.lblProgram.AutoSize = true;
            this.lblProgram.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgram.Location = new System.Drawing.Point(187, 309);
            this.lblProgram.Name = "lblProgram";
            this.lblProgram.Size = new System.Drawing.Size(113, 29);
            this.lblProgram.TabIndex = 10;
            this.lblProgram.Text = "Program";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOB.Location = new System.Drawing.Point(187, 246);
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(162, 29);
            this.lblDOB.TabIndex = 8;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // lblDepartment
            // 
            this.lblDepartment.AutoSize = true;
            this.lblDepartment.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDepartment.Location = new System.Drawing.Point(187, 183);
            this.lblDepartment.Name = "lblDepartment";
            this.lblDepartment.Size = new System.Drawing.Size(155, 29);
            this.lblDepartment.TabIndex = 5;
            this.lblDepartment.Text = "Department ";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPassword.Location = new System.Drawing.Point(187, 120);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(132, 29);
            this.lblPassword.TabIndex = 4;
            this.lblPassword.Text = "PassWord";
            // 
            // OOp2C
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1012, 541);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.pnlOut);
            this.Controls.Add(this.pnlInformation);
            this.Name = "OOp2C";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "OOp2C";
            this.pnlInformation.ResumeLayout(false);
            this.pnlInformation.PerformLayout();
            this.rbProgram.ResumeLayout(false);
            this.rbProgram.PerformLayout();
            this.pnlOut.ResumeLayout(false);
            this.pnlOut.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlInformation;
        private System.Windows.Forms.Button btnShow;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.TextBox txtUsername;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbDepartment;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Panel rbProgram;
        private System.Windows.Forms.RadioButton rbBechelor;
        private System.Windows.Forms.RadioButton rbMasters;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtOutputUsername;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Panel pnlOut;
        private System.Windows.Forms.Label lblProgram;
        private System.Windows.Forms.Label lblDOB;
        private System.Windows.Forms.Label lblDepartment;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.Button btnClear;
    }
}