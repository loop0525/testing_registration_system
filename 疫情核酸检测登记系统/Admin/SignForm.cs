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

namespace Admin
{
    public partial class SignForm : Form
    {
        Form1 form1 = new Form1();
        public SignForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void SignForm_Load(object sender, EventArgs e)
        {

        }
        //返回登录页面
        private void btn_back_Click(object sender, EventArgs e)
        {
            //返回登录页面
            this.form1.FormSwitch(1);
      
        }
        public string username;
        public string password1;
        public string password2;

        public bool usernameFlag = false;
        //注册
        private async void btn_sign_Click(object sender, EventArgs e)
        {
            username = textBox_username.Text;
            password1 = textBox_password1.Text;
            password2= textBox_password2.Text; 

            if(!usernameFlag)
            {
                MessageBox.Show("用户名已存在");
            }
            else if(username!=""&&password1!=""&&password2!=""&&password1==password2)
            {
                //string sql = "insert into userm (username,password) values (@userName,@password)";          
                ////参数化防止sql注入
                //MySqlParameter[] parameters = {
                //   new MySqlParameter("@userName", MySqlDbType.VarChar,255),
                //   new MySqlParameter("@password", MySqlDbType.VarChar,255)
                //};
                //parameters[0].Value = username;
                //parameters[1].Value = password1;
                //SqlHelper.ExecuteSql(sql, parameters);

                SignInfo signInfo = new SignInfo() { 
                    username = username,password= password1,
                };
                String res = await HttpHelper.Sign(signInfo);

                MessageBox.Show(res);

                //打开主窗口功能
                this.form1.treeView1.Enabled = true;
                this.Close();

            }
            else
            {
                MessageBox.Show("输入格式不对");
            }


        }
        //验证用户名是否存在
        private async void textBox_username_Leave(object sender, EventArgs e)
        {
            ProofUsername proofUsername = new ProofUsername() { 
                username= textBox_username.Text,
            };
            DataTable dt = await HttpHelper.Proofusername(proofUsername);
            if (dt == null)
            {
                label_username.BackColor = Color.Green;
                label_username.Text = "用户名可用！";
                usernameFlag = true;
            }
            else
            {
                label_username.BackColor = Color.Red;
                label_username.Text = "用户名已存在！";
            }
        }

        private void textBox_username_Enter(object sender, EventArgs e)
        {
            label_username.BackColor = Color.White;
            label_username.Text = "";
            usernameFlag = false;
        }
    }
}
