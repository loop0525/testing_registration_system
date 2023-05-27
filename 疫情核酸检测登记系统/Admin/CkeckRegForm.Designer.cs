namespace Admin
{
    partial class CkeckRegForm
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
            this.dateTimePicker_checkDate = new System.Windows.Forms.DateTimePicker();
            this.btn_Reg = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label_carId = new System.Windows.Forms.Label();
            this.comboBox_checkResult = new System.Windows.Forms.ComboBox();
            this.textBox_carId = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.dateTimePicker_checkDate);
            this.groupBox1.Controls.Add(this.btn_Reg);
            this.groupBox1.Controls.Add(this.btn_clear);
            this.groupBox1.Controls.Add(this.label_carId);
            this.groupBox1.Controls.Add(this.comboBox_checkResult);
            this.groupBox1.Controls.Add(this.textBox_carId);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(10, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(797, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "核算登记";
            // 
            // dateTimePicker_checkDate
            // 
            this.dateTimePicker_checkDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_checkDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_checkDate.Location = new System.Drawing.Point(360, 160);
            this.dateTimePicker_checkDate.Name = "dateTimePicker_checkDate";
            this.dateTimePicker_checkDate.Size = new System.Drawing.Size(186, 23);
            this.dateTimePicker_checkDate.TabIndex = 9;
            // 
            // btn_Reg
            // 
            this.btn_Reg.Location = new System.Drawing.Point(385, 333);
            this.btn_Reg.Name = "btn_Reg";
            this.btn_Reg.Size = new System.Drawing.Size(75, 23);
            this.btn_Reg.TabIndex = 8;
            this.btn_Reg.Text = "登记";
            this.btn_Reg.UseVisualStyleBackColor = true;
            this.btn_Reg.Click += new System.EventHandler(this.btn_Reg_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.Location = new System.Drawing.Point(271, 333);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(75, 23);
            this.btn_clear.TabIndex = 7;
            this.btn_clear.Text = "清空";
            this.btn_clear.UseVisualStyleBackColor = true;
            // 
            // label_carId
            // 
            this.label_carId.AutoSize = true;
            this.label_carId.Location = new System.Drawing.Point(495, 78);
            this.label_carId.Name = "label_carId";
            this.label_carId.Size = new System.Drawing.Size(0, 17);
            this.label_carId.TabIndex = 6;
            // 
            // comboBox_checkResult
            // 
            this.comboBox_checkResult.FormattingEnabled = true;
            this.comboBox_checkResult.Items.AddRange(new object[] {
            "阴",
            "阳"});
            this.comboBox_checkResult.Location = new System.Drawing.Point(360, 252);
            this.comboBox_checkResult.Name = "comboBox_checkResult";
            this.comboBox_checkResult.Size = new System.Drawing.Size(100, 25);
            this.comboBox_checkResult.TabIndex = 5;
            // 
            // textBox_carId
            // 
            this.textBox_carId.Location = new System.Drawing.Point(360, 75);
            this.textBox_carId.Name = "textBox_carId";
            this.textBox_carId.Size = new System.Drawing.Size(100, 23);
            this.textBox_carId.TabIndex = 3;
            this.textBox_carId.Enter += new System.EventHandler(this.textBox_carId_Enter);
            this.textBox_carId.Leave += new System.EventHandler(this.textBox_carId_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(271, 255);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "检测结果";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(271, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "检测日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(271, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "身份证号";
            // 
            // CkeckRegForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(819, 450);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CkeckRegForm";
            this.Text = "CkeckRegForm";
            this.Load += new System.EventHandler(this.CkeckRegForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private ComboBox comboBox_checkResult;
        private TextBox textBox_carId;
        private Label label3;
        private Label label2;
        private Label label1;
        private Label label_carId;
        private Button btn_Reg;
        private Button btn_clear;
        private DateTimePicker dateTimePicker_checkDate;
    }
}