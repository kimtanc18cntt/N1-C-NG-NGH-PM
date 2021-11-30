using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NHAHANGBUFFET.BLL
{
    class Dangkymod
    {
        protected string user { get; set; }
        protected string pass { get; set; }
        public Dangkymod(string _user, string _pass)
        {
            this.user = _user;
            this.pass = _pass;

        }
        public int Dangky()
        {

            int i = 0;
            string[] para = new string[2] { "@IdDangNhap", "@MatKhau" };
            object[] value = new object[2] { user, pass};
            i = BLL.connection.Excute_Sql("Dangky", CommandType.StoredProcedure, para, value);
            return i;
        }
    }
}
