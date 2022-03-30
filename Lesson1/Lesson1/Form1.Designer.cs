namespace Lesson1
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.labelTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonTrap = new System.Windows.Forms.Button();
            this.labelDemo = new System.Windows.Forms.Label();
            this.checkBoxDemo = new System.Windows.Forms.CheckBox();
            this.listBoxDemo = new System.Windows.Forms.ListBox();
            this.textBoxDemo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.ForeColor = System.Drawing.Color.Green;
            this.labelTitle.Location = new System.Drawing.Point(206, 20);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.labelTitle.Size = new System.Drawing.Size(290, 22);
            this.labelTitle.TabIndex = 0;
            this.labelTitle.Text = "Introduction with control elements";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Black", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(218, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Don\'t press this button!!1!\r\n";
            // 
            // buttonTrap
            // 
            this.buttonTrap.BackColor = System.Drawing.SystemColors.Control;
            this.buttonTrap.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.buttonTrap.Location = new System.Drawing.Point(218, 81);
            this.buttonTrap.Name = "buttonTrap";
            this.buttonTrap.Size = new System.Drawing.Size(258, 38);
            this.buttonTrap.TabIndex = 2;
            this.buttonTrap.Text = "Super Button";
            this.buttonTrap.UseVisualStyleBackColor = false;
            this.buttonTrap.Click += new System.EventHandler(this.buttonTrap_Click);
            // 
            // labelDemo
            // 
            this.labelDemo.AutoSize = true;
            this.labelDemo.Location = new System.Drawing.Point(218, 122);
            this.labelDemo.Name = "labelDemo";
            this.labelDemo.Size = new System.Drawing.Size(0, 15);
            this.labelDemo.TabIndex = 3;
            // 
            // checkBoxDemo
            // 
            this.checkBoxDemo.AutoSize = true;
            this.checkBoxDemo.Location = new System.Drawing.Point(285, 151);
            this.checkBoxDemo.Name = "checkBoxDemo";
            this.checkBoxDemo.Size = new System.Drawing.Size(109, 19);
            this.checkBoxDemo.TabIndex = 4;
            this.checkBoxDemo.Text = "You still alive???";
            this.checkBoxDemo.UseVisualStyleBackColor = true;
            this.checkBoxDemo.CheckedChanged += new System.EventHandler(this.checkBoxDemo_CheckedChanged);
            // 
            // listBoxDemo
            // 
            this.listBoxDemo.FormattingEnabled = true;
            this.listBoxDemo.ItemHeight = 15;
            this.listBoxDemo.Location = new System.Drawing.Point(218, 193);
            this.listBoxDemo.Name = "listBoxDemo";
            this.listBoxDemo.Size = new System.Drawing.Size(258, 64);
            this.listBoxDemo.TabIndex = 5;
            // 
            // textBoxDemo
            // 
            this.textBoxDemo.Location = new System.Drawing.Point(218, 263);
            this.textBoxDemo.Name = "textBoxDemo";
            this.textBoxDemo.Size = new System.Drawing.Size(258, 23);
            this.textBoxDemo.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 297);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(38, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "label2";
            //this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 447);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxDemo);
            this.Controls.Add(this.listBoxDemo);
            this.Controls.Add(this.checkBoxDemo);
            this.Controls.Add(this.labelDemo);
            this.Controls.Add(this.buttonTrap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.labelTitle);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonTrap;
        private System.Windows.Forms.Label labelDemo;
        private System.Windows.Forms.CheckBox checkBoxDemo;
        private System.Windows.Forms.ListBox listBoxDemo;
        private System.Windows.Forms.TextBox textBoxDemo;
        private System.Windows.Forms.Label label2;
    }
}
