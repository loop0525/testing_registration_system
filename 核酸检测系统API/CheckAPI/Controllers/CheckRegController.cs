using CheckAPI.Models;
using CheckAPI.Utility;
using Microsoft.AspNetCore.Mvc;
using MySql.Data.MySqlClient;
using MySqlX.XDevAPI.Common;
using Nancy.Json;
using System.Collections;
using System.Data;
using System.Drawing;

namespace CheckAPI.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CheckRegController : Controller
    {
        [HttpPost("/proofcarId")]
        public ActionResult<string> ProofCarId([FromBody] ProofInfo proofInfo)
        {

            string sql = "select name from User where carId=@carId";
            //参数化防止sql注入
            MySqlParameter[] parameters = {
                   new MySqlParameter("@carId", MySqlDbType.VarChar,255)
                };
            parameters[0].Value = proofInfo.carId;
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

        [HttpPost("/checkreg")]
        public ActionResult<string> CheckReg([FromBody] CheckRegInfo checkRegInfo)
        {
            string sql = "insert into checkinfo (carId,date,result) values (@carId,@date,@result)";
            //参数化防止sql注入
            MySqlParameter[] parameters = {
                   new MySqlParameter("@carId", MySqlDbType.VarChar,255),
                   new MySqlParameter("@date", MySqlDbType.DateTime,255),
                   new MySqlParameter("@result", MySqlDbType.VarChar,255)
                };
            parameters[0].Value = checkRegInfo.carId;
            parameters[1].Value = checkRegInfo.date;
            parameters[2].Value = checkRegInfo.result;
            SqlHelper.ExecuteSql(sql, parameters);

            return "登记成功！";
        }
    }
}
