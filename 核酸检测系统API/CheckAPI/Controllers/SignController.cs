using CheckAPI.Models;
using CheckAPI.Utility;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using Nancy.Json;
using System.Collections;
using System.Data;

namespace CheckAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class SignController : Controller
    {
        [HttpPost("/proofusername")]
        public ActionResult<string> ProofUsername([FromBody] ProofUsername proofUsername)
        {
            string sql = "select username from Userm where username=@username";
            //参数化防止sql注入
            MySqlParameter[] parameters = {
                   new MySqlParameter("@username", MySqlDbType.VarChar,255)
                };
            parameters[0].Value = proofUsername.username;
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

            if (data.Tables[0].Rows.Count == 0)
            {

                //序列化  
                return jss.Serialize(dic);
                //return "未匹配请添加！";
            }
            else
            {
                return jss.Serialize(dic);
                //return "匹配成功！";
            }
        }
        [HttpPost("/sign")]
        public ActionResult<string> Sign([FromBody] SignInfo signInfo)
        {
            string sql = "insert into userm (username,password) values (@userName,@password)";
            //参数化防止sql注入
            MySqlParameter[] parameters = {
                   new MySqlParameter("@userName", MySqlDbType.VarChar,255),
                   new MySqlParameter("@password", MySqlDbType.VarChar,255)
                };
            parameters[0].Value = signInfo.username;
            parameters[1].Value = signInfo.password;
            SqlHelper.ExecuteSql(sql, parameters);
            return "注册成功!";
        }
    }
}
