using Admin.Utility;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Admin.Models
{
    public class CkeckInfo
    {
        public int Id { get; set; }
        public string carId { get; set; }
        public string data { get; set; }
        public string result { get; set; }

        public static DataSet GetAll()
        {
            return SqlHelper.GetDataSet("select * from checkInfo");
        }
    }
}
