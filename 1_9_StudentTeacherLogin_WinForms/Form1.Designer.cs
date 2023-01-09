namespace _1_9_StudentTeacherLogin_WinForms
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.rdostudent = new System.Windows.Forms.RadioButton();
            this.rdotecher = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(155, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(155, 127);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "密  码";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(230, 72);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(298, 27);
            this.txtname.TabIndex = 2;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(230, 124);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(298, 27);
            this.txtpwd.TabIndex = 3;
            // 
            // rdostudent
            // 
            this.rdostudent.AutoSize = true;
            this.rdostudent.Location = new System.Drawing.Point(230, 185);
            this.rdostudent.Name = "rdostudent";
            this.rdostudent.Size = new System.Drawing.Size(60, 24);
            this.rdostudent.TabIndex = 4;
            this.rdostudent.TabStop = true;
            this.rdostudent.Text = "学生";
            this.rdostudent.UseVisualStyleBackColor = true;
            // 
            // rdotecher
            // 
            this.rdotecher.AutoSize = true;
            this.rdotecher.Location = new System.Drawing.Point(450, 185);
            this.rdotecher.Name = "rdotecher";
            this.rdotecher.Size = new System.Drawing.Size(60, 24);
            this.rdotecher.TabIndex = 5;
            this.rdotecher.TabStop = true;
            this.rdotecher.Text = "老师";
            this.rdotecher.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(328, 242);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(94, 29);
            this.button1.TabIndex = 6;
            this.button1.Text = "登录";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rdotecher);
            this.Controls.Add(this.rdostudent);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox txtname;
        private TextBox txtpwd;
        private RadioButton rdostudent;
        private RadioButton rdotecher;
        private Button button1;
    }
}