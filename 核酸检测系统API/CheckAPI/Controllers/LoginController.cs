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
    public class LoginController : Controller
    {
        [HttpPost("/login")]
        public ActionResult<string> Login([FromBody] LoginInfo loginInfo)
        {
            string sql = "select u.username,u.password from userM u WHERE u.username=@userName";
            //参数化防止sql注入
            MySqlParameter[] parameters = {
                   new MySqlParameter("@userName", MySqlDbType.VarChar,255)};
            parameters[0].Value = loginInfo.username;

            DataSet dataset = SqlHelper.GetDataSet(sql, parameters);
            DataTable dt = dataset.Tables[0];

            //DataTable转Json
            JavaScriptSerializer jss = new JavaScriptSerializer();
            ArrayList dic = new ArrayList();
            //判断输入密码是否匹配
            if (dt != null)
            {
                if (dt.Rows[0][1].ToString()==loginInfo.password) {

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
                }
                else {
                }
            }
            //DataTable转Json
            //序列化  
            return jss.Serialize(dic);
        }
    }
}
