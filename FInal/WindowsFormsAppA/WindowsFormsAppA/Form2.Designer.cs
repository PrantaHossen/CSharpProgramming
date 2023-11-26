namespace WindowsFormsAppA
{
    partial class Form2
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtusername = new System.Windows.Forms.TextBox();
            this.txtpassword = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(54, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "User Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(54, 146);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(132, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "PassWord";
            // 
            // txtusername
            // 
            this.txtusername.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtusername.Location = new System.Drawing.Point(246, 85);
            this.txtusername.Name = "txtusername";
            this.txtusername.Size = new System.Drawing.Size(153, 34);
            this.txtusername.TabIndex = 2;
            this.txtusername.Leave += new System.EventHandler(this.txtusername_Leave);
            // 
            // txtpassword
            // 
            this.txtpassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtpassword.Location = new System.Drawing.Point(246, 159);
            this.txtpassword.Name = "txtpassword";
            this.txtpassword.Size = new System.Drawing.Size(153, 34);
            this.txtpassword.TabIndex = 3;
            this.txtpassword.Leave += new System.EventHandler(this.txtpassword_Leave);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(303, 247);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Submit";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.MouseHover += new System.EventHandler(this.button1_MouseHover);
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.IndianRed;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Location = new System.Drawing.Point(713, 389);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(75, 49);
            this.btnClose.TabIndex = 5;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.BackColor = System.Drawing.SystemColors.Info;
            this.checkBox1.Location = new System.Drawing.Point(303, 199);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(96, 20);
            this.checkBox1.TabIndex = 6;
            this.checkBox1.Text = "Show Pass";
            this.checkBox1.UseVisualStyleBackColor = false;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtpassword);
            this.Controls.Add(this.txtusername);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form2";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtusername;
        private System.Windows.Forms.TextBox txtpassword;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}