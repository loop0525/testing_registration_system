using Admin.Models;
using Admin.Utility;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace Admin
{
    public partial class SearchForm : Form
    {
        Form1 form1 = new Form1();
        DataSet data1;
        public SearchForm(Form1 form1)
        {
            InitializeComponent();
            this.form1 = form1;   
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {

        }
        //查询按钮(异步async在返回修饰符前)
        private async void btn_search_Click(object sender, EventArgs e)
        {
            //String sql = "select u.carId,u.`name`,u.phone,c.date,u.addr,u.gender,u.unit,u.other,c.result  from User u LEFT JOIN checkinfo c ON u.carId=c.carId where u.name like @name and u.carId like @carId and u.phone like @phone and (c.date  between @dateStart and @dateFinal)";
            ////参数化防止sql注入
            //MySqlParameter[] parameters = {
            //    new MySqlParameter("@name", MySqlDbType.VarChar, 255),
            //       new MySqlParameter("@carId", MySqlDbType.VarChar, 255),
            //       new MySqlParameter("@phone", MySqlDbType.VarChar, 255),
            //       new MySqlParameter("@dateStart", MySqlDbType.VarChar, 255),
            //       new MySqlParameter("@dateFinal", MySqlDbType.VarChar, 255)
            //    };
            //parameters[0].Value = textBox_name.Text + "%";
            //parameters[1].Value = textBox_carId.Text + "%";
            //parameters[2].Value = textBox_phone.Text + "%";
            //parameters[3].Value = dateTimePicker_startDate.Value.ToString("yyyy'-'MM'-'dd HH:mm:ss");
            //parameters[4].Value = dateTimePicker_finalDate.Value.ToString("yyyy'-'MM'-'dd HH:mm:ss");

            //data1 = SqlHelper.GetDataSet(sql,parameters);
            //dataGridView1.AutoGenerateColumns = false;//关闭自动甜筒
            //dataGridView1.DataSource = data1.Tables[0];//将数据显示到dataGridView


            SearchInfo searchInfo= new SearchInfo() { 
                name=textBox_name.Text,carId=textBox_carId.Text,phone=textBox_phone.Text,
                startDate= dateTimePicker_startDate.Value.ToString("yyyy'-'MM'-'dd HH:mm:ss").Replace(" ","T"),
                finalDate= dateTimePicker_finalDate.Value.ToString("yyyy'-'MM'-'dd HH:mm:ss").Replace(" ", "T")
            };
            DataTable dt = await HttpHelper.Search(searchInfo);

            DateTime dateTimeNow= DateTime.Now;
            DateTime dateTimeCheck;
            if (dt != null)
            {
                dt.Columns.Add(new DataColumn() { ColumnName = "Index", DataType = typeof(String) });
                dt.Columns.Add(new DataColumn() { ColumnName = "overtime", DataType = typeof(String) });
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["Index"] = i + 1;

                    string datestr = dt.Rows[i]["date"].ToString();

                    dateTimeCheck = Convert.ToDateTime(datestr);
                    //beginDateTime.Subtract(endDateTime).Duration() ==开始时间.计算时间跨度(结束时间).Duration() 此方法返回的是时间的绝对值
                    TimeSpan timeSpan = dateTimeCheck.Subtract(dateTimeNow).Duration();
                    //带小数部分的值
                    //double days = timeSpan.TotalDays;//天数
                    //double hours = timeSpan.TotalHours;//小时
                    //double minutes = timeSpan.TotalMinutes;//分钟
                    //double seconds = timeSpan.TotalSeconds;//秒
                    //double milliSeconds = timeSpan.TotalMilliseconds;//毫秒
                    double hours = timeSpan.TotalHours;//小时
                    if(hours >= 72)
                    {
                        dt.Rows[i]["overtime"] = "是";
                    }
                    else
                    {
                        dt.Rows[i]["overtime"] = "否";
                    }

                }
            }
            dataGridView1.AutoGenerateColumns = false;//关闭自动甜筒
            dataGridView1.DataSource = dt;//将数据显示到dataGridView
        }

        //测试按钮
        private void button1_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(dateTimePicker_startDate.Value);
            DateTime date = dateTimePicker_startDate.Value;
            //MessageBox.Show(dateTimePicker_startDate.Value.ToString());
            MessageBox.Show(date.ToString("yyyy'-'MM'-'dd HH:mm:ss"));

        }
    }
}
