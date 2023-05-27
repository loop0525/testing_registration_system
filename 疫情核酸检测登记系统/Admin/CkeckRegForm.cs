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
    public partial class CkeckRegForm : Form
    {
        Form1 form1 = new Form1();
        public CkeckRegForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;
        }

        private void CkeckRegForm_Load(object sender, EventArgs e)
        {

        }

        public string carId;
        public DateTime date;
        public string result;
        public bool carIdFlag = false;
        //  确认登记核酸信息
        private async void btn_Reg_Click(object sender, EventArgs e)
        {
            carId = textBox_carId.Text;
            date = dateTimePicker_checkDate.Value;
            result = comboBox_checkResult.Text;

            if (carId == ""  || result == "")
            {
                MessageBox.Show("信息未填整！");
            }
            else if (!carIdFlag)
            {
                MessageBox.Show("未匹配登记人请添加 信息！");
            }
            else
            {
                //string sql = "insert into checkinfo (carId,date,result) values (@carId,@date,@result)";
                ////参数化防止sql注入
                //MySqlParameter[] parameters = {
                //   new MySqlParameter("@carId", MySqlDbType.VarChar,255),
                //   new MySqlParameter("@date", MySqlDbType.DateTime,255),
                //   new MySqlParameter("@result", MySqlDbType.VarChar,255)
                //};
                //parameters[0].Value = carId;
                //parameters[1].Value = date;
                //parameters[2].Value = result;
                //SqlHelper.ExecuteSql(sql, parameters);
                //MessageBox.Show("登记成功！");
                CheckRegInfo checkRegInfo = new CheckRegInfo() { carId= textBox_carId.Text,
                    date=dateTimePicker_checkDate.Value.ToString("yyyy'-'MM'-'dd HH:mm:ss").Replace(" ", "T"),
                    result=comboBox_checkResult.Text
                };
                string res = await HttpHelper.CheckReg(checkRegInfo);
                MessageBox.Show(res);
            }
        }

        //身份证号失去焦点查询用户
        private async void textBox_carId_Leave(object sender, EventArgs e)
        {
            //carId = textBox_carId.Text;
            //string sql = "select name from User where carId=@carId";
            ////参数化防止sql注入
            //MySqlParameter[] parameters = {
            //       new MySqlParameter("@carId", MySqlDbType.VarChar,255)
            //    };
            //parameters[0].Value = carId;

            //DataSet data = SqlHelper.GetDataSet(sql, parameters);
            //DataTable res = data.Tables[0];

            ProofInfo proofInfo = new ProofInfo() { carId= textBox_carId.Text };
            DataTable res = await HttpHelper.Proof(proofInfo);
            //MessageBox.Show(res.Rows[0][0].ToString());

            if (res == null)
            {
                label_carId.BackColor = Color.Red;
                label_carId.Text = "没有匹配信息，请添加登记人信息！";

            }
            else
            {
                label_carId.BackColor = Color.Green;
                label_carId.Text = "已匹配：" + res.Rows[0][0].ToString();
                carIdFlag = true;

            }

        }
        //身份证号获得焦点
        private void textBox_carId_Enter(object sender, EventArgs e)
        {
            label_carId.BackColor = Color.White;
            label_carId.Text = "";
            carIdFlag = false;
        }
    }
}
