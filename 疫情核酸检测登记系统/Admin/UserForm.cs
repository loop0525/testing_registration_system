using Admin.Models;
using Admin.Utility;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Admin
{
    public partial class UserForm : Form
    {
        Form1 form1 = new Form1();
        public UserForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void UserForm_Load(object sender, EventArgs e)
        {

        }

        public string name;
        public string gender;
        public string carId;
        public string phone;
        public string addr;
        public string unit;
        public string other;

        public bool carIdFlag = false;
        //确认登记
        private async void btn_confirm_Click(object sender, EventArgs e)
        {
            name = textBox1_name.Text;
            gender = comboBox_gender.Text;
            carId = textBox_carId.Text; 
            phone = textBox_phone.Text;
            addr = textBox_addr.Text;
            unit = textBox_unit.Text;
            other = textBox_other.Text;

            if (name == "" || gender == "" || carId == "" || phone == "" || addr == "" || unit == "")
            {
                MessageBox.Show("信息未填完整！");
            }
            else if (!carIdFlag)
            {
                MessageBox.Show("该身份证号已录入!");
            }
            else
            {
                //string sql = "insert into user (name,gender,carId,phone,addr,unit,other) values (@name,@gender,@carId,@phone,@addr,@unit,@other)";
                ////参数化防止sql注入
                //MySqlParameter[] parameters = {
                //   new MySqlParameter("@name", MySqlDbType.VarChar,255),
                //   new MySqlParameter("@gender", MySqlDbType.VarChar,255),
                //   new MySqlParameter("@carId", MySqlDbType.VarChar,255),
                //   new MySqlParameter("@phone", MySqlDbType.VarChar,255),
                //   new MySqlParameter("@addr", MySqlDbType.VarChar,255),
                //   new MySqlParameter("@unit", MySqlDbType.VarChar,255),
                //   new MySqlParameter("@other", MySqlDbType.VarChar,255)
                //};
                //parameters[0].Value = name;
                //parameters[1].Value = gender;
                //parameters[2].Value = carId;
                //parameters[3].Value = phone;
                //parameters[4].Value = addr;
                //parameters[5].Value = unit;
                //parameters[6].Value = other;
                //SqlHelper.ExecuteSql(sql, parameters);
                UserInfo userInfo = new UserInfo() { 
                    name= name,gender=gender, carId=carId, phone=phone, addr=addr,unit=unit, other=other
                };
                string res = await HttpHelper.RegUser(userInfo);
                MessageBox.Show(res);
            }
        }

        private async void textBox_carId_Leave(object sender, EventArgs e)
        {

            ProofInfo proofInfo = new ProofInfo() { carId = textBox_carId.Text };
            DataTable res = await HttpHelper.Proof(proofInfo);

            if (res == null)
            {
                carIdFlag = true;
            }
            else
            {
                label_carId.BackColor = Color.Red;
                label_carId.Text = "该身份证号已录入!";
                

            }
        }

        private void textBox_carId_Enter(object sender, EventArgs e)
        {
            label_carId.BackColor = Color.White;
            label_carId.Text = "";
            carIdFlag = false;
        }
    }
}
