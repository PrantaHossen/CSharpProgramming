namespace WindowsFormsAppA
{
    partial class Form1
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtAddItems = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btnTotalcount = new System.Windows.Forms.Button();
            this.btnSortitems = new System.Windows.Forms.Button();
            this.btnRemoveItems = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Burger",
            "Pizza"});
            this.comboBox1.Location = new System.Drawing.Point(214, 133);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(170, 37);
            this.comboBox1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.BackColor = System.Drawing.Color.Firebrick;
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClose.Location = new System.Drawing.Point(425, 493);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(93, 36);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Food Items";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 231);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(129, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Add Items";
            // 
            // txtAddItems
            // 
            this.txtAddItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAddItems.Location = new System.Drawing.Point(214, 226);
            this.txtAddItems.Name = "txtAddItems";
            this.txtAddItems.Size = new System.Drawing.Size(170, 34);
            this.txtAddItems.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(416, 224);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(166, 44);
            this.button1.TabIndex = 9;
            this.button1.Text = "Add Items";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnTotalcount
            // 
            this.btnTotalcount.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTotalcount.Location = new System.Drawing.Point(12, 396);
            this.btnTotalcount.Name = "btnTotalcount";
            this.btnTotalcount.Size = new System.Drawing.Size(222, 49);
            this.btnTotalcount.TabIndex = 10;
            this.btnTotalcount.Text = "Total Items";
            this.btnTotalcount.UseVisualStyleBackColor = true;
            this.btnTotalcount.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnSortitems
            // 
            this.btnSortitems.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSortitems.Location = new System.Drawing.Point(245, 396);
            this.btnSortitems.Name = "btnSortitems";
            this.btnSortitems.Size = new System.Drawing.Size(222, 49);
            this.btnSortitems.TabIndex = 11;
            this.btnSortitems.Text = "Sort Items";
            this.btnSortitems.UseVisualStyleBackColor = true;
            this.btnSortitems.Click += new System.EventHandler(this.button3_Click);
            // 
            // btnRemoveItems
            // 
            this.btnRemoveItems.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRemoveItems.Location = new System.Drawing.Point(478, 396);
            this.btnRemoveItems.Name = "btnRemoveItems";
            this.btnRemoveItems.Size = new System.Drawing.Size(222, 49);
            this.btnRemoveItems.TabIndex = 12;
            this.btnRemoveItems.Text = "Remove Items";
            this.btnRemoveItems.UseVisualStyleBackColor = true;
            this.btnRemoveItems.Click += new System.EventHandler(this.btnRemoveItems_Click);
            // 
            // btnClear
            // 
            this.btnClear.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClear.Location = new System.Drawing.Point(711, 396);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(189, 49);
            this.btnClear.TabIndex = 13;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1094, 598);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnRemoveItems);
            this.Controls.Add(this.btnSortitems);
            this.Controls.Add(this.btnTotalcount);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtAddItems);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.comboBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtAddItems;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnTotalcount;
        private System.Windows.Forms.Button btnSortitems;
        private System.Windows.Forms.Button btnRemoveItems;
        private System.Windows.Forms.Button btnClear;
    }
}

