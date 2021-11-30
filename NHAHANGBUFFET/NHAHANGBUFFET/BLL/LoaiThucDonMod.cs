using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NHAHANGBUFFET.BLL
{
    class LoaiThucDonMod
    {
        protected string IdLoaiThucDon { get; set; }
        protected string Ten { get; set; }
        protected string DienGiai { get; set; }
        protected string TrangThai { get; set; }
        public LoaiThucDonMod(string _IdLoaiThucDon)
        {
            IdLoaiThucDon = _IdLoaiThucDon;
        }

        public LoaiThucDonMod() { }
        public LoaiThucDonMod(string _idLoaiThucDon, string _ten, string _dienGiai, string _trangThai)
        {
            this.IdLoaiThucDon = _idLoaiThucDon;
            this.Ten = _ten;
            this.DienGiai = _dienGiai;
            this.TrangThai = _trangThai;
        }


        //khai báo them sua xoa
        public int InsertLoaiThucDon()
        {

            int i = 0;
            string[] paras = new string[4] { "@IdLoaiThucDon", "@TenLoaiThucDon", "@DienGiai", "@TrangThai" };
            object[] values = new object[4] { IdLoaiThucDon, Ten, DienGiai, TrangThai };
            i = BLL.connection.Excute_Sql("spInsertLoaiThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateLoaiThucDon()
        {

            int i = 0;
            string[] paras = new string[4] { "@IdLoaiThucDon", "@TenLoaiThucDon", "@DienGiai", "@TrangThai" };
            object[] values = new object[4] { IdLoaiThucDon, Ten, DienGiai, TrangThai };
            i = BLL.connection.Excute_Sql("spUpdateLoaiThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int DeleteLoaiThucDon()
        {

            int i = 0;
            string[] paras = new string[1] { "@IdLoaiThucDon" };
            object[] values = new object[1] { IdLoaiThucDon };
            i = BLL.connection.Excute_Sql("spDeleteLoaiThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetLoaiThucDon()
        {
            return BLL.connection.FillDataSet("spgetLoaiThucDon", CommandType.StoredProcedure);
        }
        public static DataSet getTenLoaiThucDon()
        {
            return BLL.connection.FillDataSet("spgetTenLoaiThucDon", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getLoaiThucDonByIdLoaiThucDon()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdLoaiThucDon" };
            object[] values = new object[1] { IdLoaiThucDon };
            ds = BLL.connection.FillDataSet("spgetLoaiThucDonByIdLoaiThucDon", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
