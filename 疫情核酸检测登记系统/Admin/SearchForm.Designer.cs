namespace Admin
{
    partial class SearchForm
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
            this.button1 = new System.Windows.Forms.Button();
            this.dateTimePicker_finalDate = new System.Windows.Forms.DateTimePicker();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker_startDate = new System.Windows.Forms.DateTimePicker();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_search = new System.Windows.Forms.Button();
            this.textBox_phone = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox_name = new System.Windows.Forms.TextBox();
            this.textBox_carId = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.序号 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.超72小时 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.carId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.name = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.result = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.phone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.addr = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.unit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.other = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.dateTimePicker_finalDate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.dateTimePicker_startDate);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.btn_search);
            this.groupBox1.Controls.Add(this.textBox_phone);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox_name);
            this.groupBox1.Controls.Add(this.textBox_carId);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 125);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询核算登记信息";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(679, 80);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 13;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dateTimePicker_finalDate
            // 
            this.dateTimePicker_finalDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_finalDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_finalDate.Location = new System.Drawing.Point(375, 80);
            this.dateTimePicker_finalDate.Name = "dateTimePicker_finalDate";
            this.dateTimePicker_finalDate.Size = new System.Drawing.Size(160, 23);
            this.dateTimePicker_finalDate.TabIndex = 11;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(340, 84);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(18, 17);
            this.label5.TabIndex = 10;
            this.label5.Text = "--";
            // 
            // dateTimePicker_startDate
            // 
            this.dateTimePicker_startDate.CustomFormat = "yyyy-MM-dd HH:mm:ss";
            this.dateTimePicker_startDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePicker_startDate.Location = new System.Drawing.Point(164, 80);
            this.dateTimePicker_startDate.Name = "dateTimePicker_startDate";
            this.dateTimePicker_startDate.Size = new System.Drawing.Size(159, 23);
            this.dateTimePicker_startDate.TabIndex = 8;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(84, 84);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "时间范围";
            // 
            // btn_search
            // 
            this.btn_search.Location = new System.Drawing.Point(679, 28);
            this.btn_search.Name = "btn_search";
            this.btn_search.Size = new System.Drawing.Size(75, 23);
            this.btn_search.TabIndex = 6;
            this.btn_search.Text = "查询";
            this.btn_search.UseVisualStyleBackColor = true;
            this.btn_search.Click += new System.EventHandler(this.btn_search_Click);
            // 
            // textBox_phone
            // 
            this.textBox_phone.Location = new System.Drawing.Point(502, 28);
            this.textBox_phone.Name = "textBox_phone";
            this.textBox_phone.Size = new System.Drawing.Size(118, 23);
            this.textBox_phone.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(431, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 17);
            this.label3.TabIndex = 4;
            this.label3.Text = "电话";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(260, 31);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "姓名";
            // 
            // textBox_name
            // 
            this.textBox_name.Location = new System.Drawing.Point(298, 28);
            this.textBox_name.Name = "textBox_name";
            this.textBox_name.Size = new System.Drawing.Size(84, 23);
            this.textBox_name.TabIndex = 2;
            // 
            // textBox_carId
            // 
            this.textBox_carId.Location = new System.Drawing.Point(68, 28);
            this.textBox_carId.Name = "textBox_carId";
            this.textBox_carId.Size = new System.Drawing.Size(153, 23);
            this.textBox_carId.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(56, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "身份证号";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.序号,
            this.超72小时,
            this.carId,
            this.name,
            this.date,
            this.result,
            this.phone,
            this.gender,
            this.addr,
            this.unit,
            this.other});
            this.dataGridView1.Location = new System.Drawing.Point(12, 143);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(776, 295);
            this.dataGridView1.TabIndex = 1;
            // 
            // 序号
            // 
            this.序号.DataPropertyName = "Index";
            this.序号.HeaderText = "序号";
            this.序号.Name = "序号";
            // 
            // 超72小时
            // 
            this.超72小时.DataPropertyName = "overtime";
            this.超72小时.HeaderText = "超72小时";
            this.超72小时.Name = "超72小时";
            // 
            // carId
            // 
            this.carId.DataPropertyName = "carId";
            this.carId.HeaderText = "身份证号";
            this.carId.Name = "carId";
            // 
            // name
            // 
            this.name.DataPropertyName = "name";
            this.name.HeaderText = "姓名";
            this.name.Name = "name";
            // 
            // date
            // 
            this.date.DataPropertyName = "date";
            this.date.HeaderText = "日期";
            this.date.Name = "date";
            // 
            // result
            // 
            this.result.DataPropertyName = "result";
            this.result.HeaderText = "核算结果";
            this.result.Name = "result";
            // 
            // phone
            // 
            this.phone.DataPropertyName = "phone";
            this.phone.HeaderText = "电话";
            this.phone.Name = "phone";
            // 
            // gender
            // 
            this.gender.DataPropertyName = "gender";
            this.gender.HeaderText = "性别";
            this.gender.Name = "gender";
            // 
            // addr
            // 
            this.addr.DataPropertyName = "addr";
            this.addr.HeaderText = "地址";
            this.addr.Name = "addr";
            // 
            // unit
            // 
            this.unit.DataPropertyName = "unit";
            this.unit.HeaderText = "单位";
            this.unit.Name = "unit";
            // 
            // other
            // 
            this.other.DataPropertyName = "other";
            this.other.HeaderText = "备注";
            this.other.Name = "other";
            // 
            // SearchForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SearchForm";
            this.Text = "SearchForm";
            this.Load += new System.EventHandler(this.SearchForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private GroupBox groupBox1;
        private TextBox textBox_phone;
        private Label label3;
        private Label label2;
        private TextBox textBox_name;
        private TextBox textBox_carId;
        private Label label1;
        private DataGridView dataGridView1;
        private Button btn_search;
        private DateTimePicker dateTimePicker_startDate;
        private Label label4;
        private DateTimePicker dateTimePicker_finalDate;
        private Label label5;
        private Button button1;
        private DataGridViewTextBoxColumn 序号;
        private DataGridViewTextBoxColumn 超72小时;
        private DataGridViewTextBoxColumn carId;
        private DataGridViewTextBoxColumn name;
        private DataGridViewTextBoxColumn date;
        private DataGridViewTextBoxColumn result;
        private DataGridViewTextBoxColumn phone;
        private DataGridViewTextBoxColumn gender;
        private DataGridViewTextBoxColumn addr;
        private DataGridViewTextBoxColumn unit;
        private DataGridViewTextBoxColumn other;
    }
}