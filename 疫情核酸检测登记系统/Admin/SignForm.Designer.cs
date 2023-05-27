namespace Admin
{
    partial class SignForm
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btn_sign = new System.Windows.Forms.Button();
            this.btn_back = new System.Windows.Forms.Button();
            this.textBox_password2 = new System.Windows.Forms.TextBox();
            this.textBox_password1 = new System.Windows.Forms.TextBox();
            this.textBox_username = new System.Windows.Forms.TextBox();
            this.label_password1 = new System.Windows.Forms.Label();
            this.label_password2 = new System.Windows.Forms.Label();
            this.label_username = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btn_sign);
            this.groupBox1.Controls.Add(this.btn_back);
            this.groupBox1.Controls.Add(this.textBox_password2);
            this.groupBox1.Controls.Add(this.textBox_password1);
            this.groupBox1.Controls.Add(this.textBox_username);
            this.groupBox1.Controls.Add(this.label_password1);
            this.groupBox1.Controls.Add(this.label_password2);
            this.groupBox1.Controls.Add(this.label_username);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(790, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "注册";
            // 
            // btn_sign
            // 
            this.btn_sign.Location = new System.Drawing.Point(398, 253);
            this.btn_sign.Name = "btn_sign";
            this.btn_sign.Size = new System.Drawing.Size(75, 23);
            this.btn_sign.TabIndex = 10;
            this.btn_sign.Text = "注册";
            this.btn_sign.UseVisualStyleBackColor = true;
            this.btn_sign.Click += new System.EventHandler(this.btn_sign_Click);
            // 
            // btn_back
            // 
            this.btn_back.Location = new System.Drawing.Point(306, 253);
            this.btn_back.Name = "btn_back";
            this.btn_back.Size = new System.Drawing.Size(75, 23);
            this.btn_back.TabIndex = 9;
            this.btn_back.Text = "返回";
            this.btn_back.UseVisualStyleBackColor = true;
            this.btn_back.Click += new System.EventHandler(this.btn_back_Click);
            // 
            // textBox_password2
            // 
            this.textBox_password2.Location = new System.Drawing.Point(373, 206);
            this.textBox_password2.Name = "textBox_password2";
            this.textBox_password2.Size = new System.Drawing.Size(100, 23);
            this.textBox_password2.TabIndex = 8;
            // 
            // textBox_password1
            // 
            this.textBox_password1.Location = new System.Drawing.Point(373, 153);
            this.textBox_password1.Name = "textBox_password1";
            this.textBox_password1.Size = new System.Drawing.Size(100, 23);
            this.textBox_password1.TabIndex = 7;
            // 
            // textBox_username
            // 
            this.textBox_username.Location = new System.Drawing.Point(373, 101);
            this.textBox_username.Name = "textBox_username";
            this.textBox_username.Size = new System.Drawing.Size(100, 23);
            this.textBox_username.TabIndex = 6;
            this.textBox_username.Enter += new System.EventHandler(this.textBox_username_Enter);
            this.textBox_username.Leave += new System.EventHandler(this.textBox_username_Leave);
            // 
            // label_password1
            // 
            this.label_password1.AutoSize = true;
            this.label_password1.Location = new System.Drawing.Point(496, 153);
            this.label_password1.Name = "label_password1";
            this.label_password1.Size = new System.Drawing.Size(43, 17);
            this.label_password1.TabIndex = 5;
            this.label_password1.Text = "label6";
            // 
            // label_password2
            // 
            this.label_password2.AutoSize = true;
            this.label_password2.Location = new System.Drawing.Point(496, 209);
            this.label_password2.Name = "label_password2";
            this.label_password2.Size = new System.Drawing.Size(43, 17);
            this.label_password2.TabIndex = 4;
            this.label_password2.Text = "label5";
            // 
            // label_username
            // 
            this.label_username.AutoSize = true;
            this.label_username.Location = new System.Drawing.Point(496, 104);
            this.label_username.Name = "label_username";
            this.label_username.Size = new System.Drawing.Size(0, 17);
            this.label_username.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(282, 209);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "确认密码";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(306, 153);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "密码";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(294, 104);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "用户名";
            // 
            // SignForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(814, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SignForm";
            this.Text = "SignForm";
            this.Load += new System.EventHandler(this.SignForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private Button btn_sign;
        private Button btn_back;
        private TextBox textBox_password2;
        private TextBox textBox_password1;
        private TextBox textBox_username;
        private Label label_password1;
        private Label label_password2;
        private Label label_username;
        private Label label3;
        private Label label2;
        private Label label1;
    }
}