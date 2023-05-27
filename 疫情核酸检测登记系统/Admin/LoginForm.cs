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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Admin
{
    public partial class LoginForm : Form
    {
        Form1 form1 = new Form1();
        public LoginForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        //输入账号密码
        public string username;
        public string password;

        //登录
        private async void btn_login_Click(object sender, EventArgs e)
        {
            username = textBox_username.Text;
            password = textBox_password.Text;
            //string sql = "select u.username,u.password from userM u WHERE u.username=@userName";

            ////参数化防止sql注入
            //MySqlParameter[] parameters = {
            //       new MySqlParameter("@userName", MySqlDbType.VarChar,255)};
            //parameters[0].Value = username;

            //DataSet dataset =  SqlHelper.GetDataSet(sql, parameters);
            //DataTable dt = dataset.Tables[0];
            LoginInfo loginInfo = new LoginInfo() { username = textBox_username.Text,password = textBox_password.Text
        };
            DataTable dt = await HttpHelper.Login(loginInfo);

            if(dt == null)
            {
                MessageBox.Show("用户名或密码错误！");
            }
            else if (dt.Rows[0][1].ToString() == password)//登录成功
            {
                MessageBox.Show("登录成功！");
                //打开主窗口功能
                this.form1.treeView1.Enabled = true;
                this.Close();
            }
            //else
            //{
            //    MessageBox.Show("用户名或密码错误！");
            //}
        }
        //注册
        private void btn_sign_Click(object sender, EventArgs e)
        {
            //加载注册窗口
            this.form1.FormSwitch(2);

        }

        private void LoginForm_Load(object sender, EventArgs e)
        {

        }
    }
}
