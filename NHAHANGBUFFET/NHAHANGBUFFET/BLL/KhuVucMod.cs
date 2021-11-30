using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NHAHANGBUFFET.BLL
{
    class KhuVucMod
    {
        protected string IdKhuVuc{ get; set; }
        protected string TenKhuVuc { get; set; }
        protected string DienGiai { get; set; }
        protected string TrangThai { get; set; }
        public KhuVucMod(string _IdKhuVuc)
        {
            IdKhuVuc = _IdKhuVuc;
        }

        public KhuVucMod() { }
        public KhuVucMod(string _idKhuVuc, string _tenKhuVuc, string _dienGiai, string _trangThai)
        {
            this.IdKhuVuc = _idKhuVuc;
            this.TenKhuVuc = _tenKhuVuc;
            this.DienGiai = _dienGiai;
            this.TrangThai = _trangThai;
        } 

        
        //khai báo them sua xoa
        public int InsertKhuVuc()
        {

            int i = 0;
            string[] paras = new string[4] { "@IdKhuVuc", "@TenKhuVuc", "@DienGiai", "@TrangThai" };
            object[] values = new object[4] { IdKhuVuc, TenKhuVuc, DienGiai, TrangThai};
            i = BLL.connection.Excute_Sql("spInsertKhuVuc", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateKhuVuc()
        {

            int i = 0;
            string[] paras = new string[4] { "@IdKhuVuc", "@TenKhuVuc", "@DienGiai", "@TrangThai" };
            object[] values = new object[4] { IdKhuVuc, TenKhuVuc, DienGiai, TrangThai };
            i = BLL.connection.Excute_Sql("spUpdateKhuVuc", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int DeleteKhuVuc()
        {

            int i = 0;
            string[] paras = new string[1] { "@IdKhuVuc" };
            object[] values = new object[1] { IdKhuVuc };
            i = BLL.connection.Excute_Sql("spDeleteKhuVuc", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetKhuVuc()
        {
            return BLL.connection.FillDataSet("spgetKhuVuc", CommandType.StoredProcedure);
        }
        public static DataSet getTenKhuVuc()
        {
            return BLL.connection.FillDataSet("spgetTenKhuVuc", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getKhuVucByIdKhuVuc()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdKhuVuc" };
            object[] values = new object[1] { IdKhuVuc };
            ds = BLL.connection.FillDataSet("spgetKhuVucByIdKhuVuc", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
