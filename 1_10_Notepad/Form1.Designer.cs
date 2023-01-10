namespace _1_10_Notepad
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
            this.btnwordwrap = new System.Windows.Forms.Button();
            this.btnsave = new System.Windows.Forms.Button();
            this.txtwords = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtname = new System.Windows.Forms.TextBox();
            this.txtpwd = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnRest = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnwordwrap
            // 
            this.btnwordwrap.Location = new System.Drawing.Point(177, 35);
            this.btnwordwrap.Name = "btnwordwrap";
            this.btnwordwrap.Size = new System.Drawing.Size(94, 29);
            this.btnwordwrap.TabIndex = 0;
            this.btnwordwrap.Text = "自动换行";
            this.btnwordwrap.UseVisualStyleBackColor = true;
            this.btnwordwrap.Click += new System.EventHandler(this.btnwordwrap_Click);
            // 
            // btnsave
            // 
            this.btnsave.Location = new System.Drawing.Point(411, 35);
            this.btnsave.Name = "btnsave";
            this.btnsave.Size = new System.Drawing.Size(94, 29);
            this.btnsave.TabIndex = 1;
            this.btnsave.Text = "保存";
            this.btnsave.UseVisualStyleBackColor = true;
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // txtwords
            // 
            this.txtwords.Location = new System.Drawing.Point(12, 64);
            this.txtwords.Multiline = true;
            this.txtwords.Name = "txtwords";
            this.txtwords.Size = new System.Drawing.Size(758, 374);
            this.txtwords.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(154, 162);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "用户名";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(154, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 20);
            this.label2.TabIndex = 4;
            this.label2.Text = "密  码";
            // 
            // txtname
            // 
            this.txtname.Location = new System.Drawing.Point(235, 162);
            this.txtname.Name = "txtname";
            this.txtname.Size = new System.Drawing.Size(311, 27);
            this.txtname.TabIndex = 5;
            // 
            // txtpwd
            // 
            this.txtpwd.Location = new System.Drawing.Point(235, 213);
            this.txtpwd.Name = "txtpwd";
            this.txtpwd.PasswordChar = '*';
            this.txtpwd.Size = new System.Drawing.Size(311, 27);
            this.txtpwd.TabIndex = 6;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(235, 334);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(94, 29);
            this.btnLogin.TabIndex = 7;
            this.btnLogin.Text = "登录";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnRest
            // 
            this.btnRest.Location = new System.Drawing.Point(452, 334);
            this.btnRest.Name = "btnRest";
            this.btnRest.Size = new System.Drawing.Size(94, 29);
            this.btnRest.TabIndex = 8;
            this.btnRest.Text = "重置";
            this.btnRest.UseVisualStyleBackColor = true;
            this.btnRest.Click += new System.EventHandler(this.btnRest_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRest);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txtpwd);
            this.Controls.Add(this.txtname);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtwords);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btnwordwrap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnwordwrap;
        private Button btnsave;
        private TextBox txtwords;
        private Label label1;
        private Label label2;
        private TextBox txtname;
        private TextBox txtpwd;
        private Button btnLogin;
        private Button btnRest;
    }
}