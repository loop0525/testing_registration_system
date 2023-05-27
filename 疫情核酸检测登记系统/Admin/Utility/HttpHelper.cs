using Admin.Models;
using Nancy.Json;
using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Admin.Utility
{
    public class HttpHelper
    {
        //查询请求
        public static async Task<DataTable> Search(SearchInfo searchInfo)
        {
            var json = JsonConvert.SerializeObject(searchInfo);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var url = "http://localhost:5227/search";
            using var client = new HttpClient();
            var response = await client.PostAsync(url, data);
            string result = response.Content.ReadAsStringAsync().Result;

            DataTable res = JsonToDT(result);
            return res;
        }
        //身份证号验证请求
        public static async Task<DataTable> Proof(ProofInfo proofInfo)
        {
            var json = JsonConvert.SerializeObject(proofInfo);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var url = "http://localhost:5227/proofcarId";
            using var client = new HttpClient();
            var response = await client.PostAsync(url, data);
            string result = response.Content.ReadAsStringAsync().Result;

            DataTable res = JsonToDT(result);
            return res;
        }
        //确认信息登记
        public static async Task<string> CheckReg(CheckRegInfo checkRegInfo)
        {
            var json = JsonConvert.SerializeObject(checkRegInfo);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var url = "http://localhost:5227/checkreg";
            using var client = new HttpClient();
            var response = await client.PostAsync(url, data);
            string result = response.Content.ReadAsStringAsync().Result;

            //DataTable res = JsonToDT(result);
            return result;
        }
        //登录
        public static async Task<DataTable> Login(LoginInfo loginInfo)
        {
            var json = JsonConvert.SerializeObject(loginInfo);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var url = "http://localhost:5227/login";
            using var client = new HttpClient();
            var response = await client.PostAsync(url, data);
            string result = response.Content.ReadAsStringAsync().Result;

            DataTable res = JsonToDT(result);
            return res;
        }
        //验证用户名是否存在
        public static async Task<DataTable> Proofusername(ProofUsername proofUsername)
        {
            var json = JsonConvert.SerializeObject(proofUsername);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var url = "http://localhost:5227/proofusername";
            using var client = new HttpClient();
            var response = await client.PostAsync(url, data);
            string result = response.Content.ReadAsStringAsync().Result;

            DataTable res = JsonToDT(result);
            return res;
        }
        //确认注册
        public static async Task<string> Sign(SignInfo signInfo)
        {
            var json = JsonConvert.SerializeObject(signInfo);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var url = "http://localhost:5227/sign";
            using var client = new HttpClient();
            var response = await client.PostAsync(url, data);
            string result = response.Content.ReadAsStringAsync().Result;

            //DataTable res = JsonToDT(result);
            return result;
        }
        //登记个人信息
        public static async Task<string> RegUser(UserInfo userInfo)
        {
            var json = JsonConvert.SerializeObject(userInfo);
            var data = new StringContent(json, Encoding.UTF8, "application/json");
            var url = "http://localhost:5227/reguser";
            using var client = new HttpClient();
            var response = await client.PostAsync(url, data);
            string result = response.Content.ReadAsStringAsync().Result;

            //DataTable res = JsonToDT(result);
            return result;
        }


        /// <summary>
        /// 将json转换为DataTable
        /// </summary>
        /// <param name="strJson">得到的json</param>
        /// <returns></returns>
        public static DataTable JsonToDT(string strJson)
        {
            //转换json格式
            strJson = strJson.Replace(",\"", "*\"").Replace("\":", "\"#").ToString();
            //取出表名   
            var rg = new Regex(@"(?<={)[^:]+(?=:\[)", RegexOptions.IgnoreCase);
            string strName = rg.Match(strJson).Value;
            DataTable tb = null;
            //去除表名   
            strJson = strJson.Substring(strJson.IndexOf("[") + 1);
            strJson = strJson.Substring(0, strJson.IndexOf("]"));

            //获取数据   
            rg = new Regex(@"(?<={)[^}]+(?=})");
            MatchCollection mc = rg.Matches(strJson);
            for (int i = 0; i < mc.Count; i++)
            {
                string strRow = mc[i].Value;
                string[] strRows = strRow.Split('*');

                //创建表   
                if (tb == null)
                {
                    tb = new DataTable();
                    tb.TableName = strName;
                    foreach (string str in strRows)
                    {
                        var dc = new DataColumn();
                        string[] strCell = str.Split('#');

                        if (strCell[0].Substring(0, 1) == "\"")
                        {
                            int a = strCell[0].Length;
                            dc.ColumnName = strCell[0].Substring(1, a - 2);
                        }
                        else
                        {
                            dc.ColumnName = strCell[0];
                        }
                        tb.Columns.Add(dc);
                    }
                    tb.AcceptChanges();
                }

                //增加内容   
                DataRow dr = tb.NewRow();
                for (int r = 0; r < strRows.Length; r++)
                {
                    dr[r] = strRows[r].Split('#')[1].Trim().Replace("，", ",").Replace("：", ":").Replace("\"", "");
                }
                tb.Rows.Add(dr);
                tb.AcceptChanges();
            }

            return tb;
        }
    }

}
