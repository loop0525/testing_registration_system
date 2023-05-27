using CheckAPI.Models;
using CheckAPI.Utility;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using System.Reflection;
using System.Xml.Linq;

namespace CheckAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : Controller
    {
        [HttpPost("/reguser")]
        public ActionResult<string> Index([FromBody] UserInfo userInfo)
        {
            string sql = "insert into user (name,gender,carId,phone,addr,unit,other) values (@name,@gender,@carId,@phone,@addr,@unit,@other)";
            //参数化防止sql注入
            MySqlParameter[] parameters = {
                   new MySqlParameter("@name", MySqlDbType.VarChar,255),
                   new MySqlParameter("@gender", MySqlDbType.VarChar,255),
                   new MySqlParameter("@carId", MySqlDbType.VarChar,255),
                   new MySqlParameter("@phone", MySqlDbType.VarChar,255),
                   new MySqlParameter("@addr", MySqlDbType.VarChar,255),
                   new MySqlParameter("@unit", MySqlDbType.VarChar,255),
                   new MySqlParameter("@other", MySqlDbType.VarChar,255)
                };
            parameters[0].Value = userInfo.name;
            parameters[1].Value = userInfo.gender;
            parameters[2].Value = userInfo.carId;
            parameters[3].Value = userInfo.phone;
            parameters[4].Value = userInfo.addr;
            parameters[5].Value = userInfo.unit;
            parameters[6].Value = userInfo.other;
            SqlHelper.ExecuteSql(sql, parameters);

            return "登记成功！";
        }
    }
}
