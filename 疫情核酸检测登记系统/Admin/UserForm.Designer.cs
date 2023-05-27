namespace Admin
{
    partial class UserForm
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
            this.label_carId = new System.Windows.Forms.Label();
            this.comboBox_gender = new System.Windows.Forms.ComboBox();
            this.textBox_other = new System.Windows.Forms.TextBox();
            this.textBox_unit = new System.Windows.Forms.TextBox();
            this.textBox_carId = new System.Windows.Forms.TextBox();
            this.textBox_addr = new System.Windows.Forms.TextBox();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.textBox1_name = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btn_clear = new System.Windows.Forms.Button();
            this.btn_confirm = new System.Windows.Forms.Button();
            this.btn_cancel = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label_carId);
            this.groupBox1.Controls.Add(this.comboBox_gender);
            this.groupBox1.Controls.Add(this.textBox_other);
            this.groupBox1.Controls.Add(this.textBox_unit);
            this.groupBox1.Controls.Add(this.textBox_carId);
            this.groupBox1.Controls.Add(this.textBox_addr);
            this.groupBox1.Controls.Add(this.textBox_phone);
            this.groupBox1.Controls.Add(this.textBox1_name);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(792, 350);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "登记信息";
            // 
            // label_carId
            // 
            this.label_carId.AutoSize = true;
            this.label_carId.Location = new System.Drawing.Point(595, 109);
            this.label_carId.Name = "label_carId";
            this.label_carId.Size = new System.Drawing.Size(0, 17);
            this.label_carId.TabIndex = 15;
            // 
            // comboBox_gender
            // 
            this.comboBox_gender.FormattingEnabled = true;
            this.comboBox_gender.Items.AddRange(new object[] {
            "男",
            "女"});
            this.comboBox_gender.Location = new System.Drawing.Point(487, 42);
            this.comboBox_gender.Name = "comboBox_gender";
            this.comboBox_gender.Size = new System.Drawing.Size(100, 25);
            this.comboBox_gender.TabIndex = 14;
            // 
            // textBox_other
            // 
            this.textBox_other.Location = new System.Drawing.Point(284, 277);
            this.textBox_other.Name = "textBox_other";
            this.textBox_other.Size = new System.Drawing.Size(303, 23);
            this.textBox_other.TabIndex = 13;
            // 
            // textBox_unit
            // 
            this.textBox_unit.Location = new System.Drawing.Point(487, 182);
            this.textBox_unit.Name = "textBox_unit";
            this.textBox_unit.Size = new System.Drawing.Size(100, 23);
            this.textBox_unit.TabIndex = 12;
            // 
            // textBox_carId
            // 
            this.textBox_carId.Location = new System.Drawing.Point(487, 105);
            this.textBox_carId.Name = "textBox_carId";
            this.textBox_carId.Size = new System.Drawing.Size(100, 23);
            this.textBox_carId.TabIndex = 11;
            this.textBox_carId.Enter += new System.EventHandler(this.textBox_carId_Enter);
            this.textBox_carId.Leave += new System.EventHandler(this.textBox_carId_Leave);
            // 
            // textBox_addr
            // 
            this.textBox_addr.Location = new System.Drawing.Point(284, 182);
            this.textBox_addr.Name = "textBox_addr";
            this.textBox_addr.Size = new System.Drawing.Size(100, 23);
            this.textBox_addr.TabIndex = 10;
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(284, 102);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(100, 23);
            this.textBox_phone.TabIndex = 9;
            // 
            // textBox1_name
            // 
            this.textBox1_name.Location = new System.Drawing.Point(284, 44);
            this.textBox1_name.Name = "textBox1_name";
            this.textBox1_name.Size = new System.Drawing.Size(100, 23);
            this.textBox1_name.TabIndex = 7;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(198, 247);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(56, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "其他备注";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(428, 182);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "单位";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(222, 182);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "住址";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(422, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "身份证号";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(222, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "电话";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(428, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "性别";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(222, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "姓名";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btn_clear);
            this.groupBox3.Controls.Add(this.btn_confirm);
            this.groupBox3.Controls.Add(this.btn_cancel);
            this.groupBox3.Location = new System.Drawing.Point(12, 368);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(792, 70);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "登记";
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(403, 31);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 2;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // btn_confirm
            // 
            this.btn_confirm.Location = new System.Drawing.Point(512, 31);
            this.btn_confirm.Name = "btn_confirm";
            this.btn_confirm.Size = new System.Drawing.Size(75, 23);
            this.btn_confirm.TabIndex = 1;
            this.btn_confirm.Text = "确定";
            this.btn_confirm.UseVisualStyleBackColor = true;
            this.btn_confirm.Click += new System.EventHandler(this.btn_confirm_Click);
            // 
            // btn_cancel
            // 
            this.btn_cancel.Location = new System.Drawing.Point(284, 31);
            this.btn_cancel.Name = "btn_cancel";
            this.btn_cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_cancel.TabIndex = 0;
            this.btn_cancel.Text = "取消";
            this.btn_cancel.UseVisualStyleBackColor = true;
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(816, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.Text = "UserForm";
            this.Load += new System.EventHandler(this.UserForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox_other;
        private TextBox textBox_unit;
        private TextBox textBox_carId;
        private TextBox textBox_addr;
        private TextBox textBox_phone;
        private TextBox textBox1_name;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private ComboBox comboBox_gender;
        private GroupBox groupBox3;
        private Button btn_confirm;
        private Button btn_cancel;
        private Button btn_clear;
        private Label label_carId;
    }
}