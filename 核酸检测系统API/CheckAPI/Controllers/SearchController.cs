using CheckAPI.Models;
using CheckAPI.Utility;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Nancy.Json;
using System.Collections;
using System.Data;
using System.Xml.Linq;

namespace CheckAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SearchController : Controller
    {
        [HttpPost("/search")]
        public ActionResult<string> Index([FromBody] SearchInfo reqInfo)
        {

            String sql = "select u.carId,u.`name`,u.phone,c.date,u.addr,u.gender,u.unit,u.other,c.result  from User u LEFT JOIN checkinfo c ON u.carId=c.carId where u.name like @name and u.carId like @carId and u.phone like @phone and (c.date  between @dateStart and @dateFinal)";
            //参数化防止sql注入
            MySqlParameter[] parameters = {
                new MySqlParameter("@name", MySqlDbType.VarChar, 255),
                   new MySqlParameter("@carId", MySqlDbType.VarChar, 255),
                   new MySqlParameter("@phone", MySqlDbType.VarChar, 255),
                   new MySqlParameter("@dateStart", MySqlDbType.VarChar, 255),
                   new MySqlParameter("@dateFinal", MySqlDbType.VarChar, 255)
                };
            parameters[0].Value = reqInfo.name + "%";
            parameters[1].Value = reqInfo.carId + "%";
            parameters[2].Value = reqInfo.phone + "%";
            parameters[3].Value = reqInfo.startDate.ToString("yyyy'-'MM'-'dd HH:mm:ss");
            parameters[4].Value = reqInfo.finalDate.ToString("yyyy'-'MM'-'dd HH:mm:ss");

            DataSet data = SqlHelper.GetDataSet(sql, parameters);
            DataTable dt = data.Tables[0];
            //DataTable转Json
            JavaScriptSerializer jss = new JavaScriptSerializer();
            ArrayList dic = new ArrayList();
            foreach (DataRow dr in dt.Rows)
            {
                Dictionary<string, object> drow = new Dictionary<string, object>();
                foreach (DataColumn dc in dt.Columns)
                {
                    drow.Add(dc.ColumnName.ToLower(), dr[dc.ColumnName]);
                }
                dic.Add(drow);
            }

            //序列化  
            return jss.Serialize(dic);
            //return data.Tables[0].Rows[0][1].ToString();
        }


        [HttpGet("/test")]
        public ActionResult<string> Test(){

            string sql = "insert into userm (username,password) values (@userName,@password)";
            //参数化防止sql注入
            MySqlParameter[] parameters = {
                   new MySqlParameter("@userName", MySqlDbType.VarChar,255),
                   new MySqlParameter("@password", MySqlDbType.VarChar,255)
                };
            parameters[0].Value = "lixinhua";
            parameters[1].Value = "121231231";
            SqlHelper.ExecuteSql(sql, parameters);

            return "test";
        }
    }
}
