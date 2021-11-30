using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NHAHANGBUFFET.BLL
{
    class KhuyenMaiMod
    {
        protected string IdKM { get; set; }
        protected string NoiDung { get; set; }
        protected string DienGiai { get; set; }
        protected string DoiTuong { get; set; }
        public KhuyenMaiMod(string _IdKM)
        {
            IdKM = _IdKM;
        }

        public KhuyenMaiMod() { }
        public KhuyenMaiMod(string _idKM, string _noiDung, string _dienGiai, string _doiTuong)
        {
            this.IdKM = _idKM;
            this.NoiDung = _noiDung;
            this.DienGiai = _dienGiai;
            this.DoiTuong = _doiTuong;
        }


        //khai báo them sua xoa
        public int InsertKhuyenMai()
        {

            int i = 0;
            string[] paras = new string[4] { "@IdKM", "@NoiDung", "@DienGiai", "@DoiTuong" };
            object[] values = new object[4] { IdKM, NoiDung, DienGiai, DoiTuong };
            i = BLL.connection.Excute_Sql("spInsertKhuyenMai", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateKhuyenMai()
        {

            int i = 0;
            string[] paras = new string[4] { "@IdKM", "@NoiDung", "@DienGiai", "@DoiTuong" };
            object[] values = new object[4] { IdKM, NoiDung, DienGiai, DoiTuong };
            i = BLL.connection.Excute_Sql("spUpdateKhuyenMai", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int DeleteKhuyenMai()
        {

            int i = 0;
            string[] paras = new string[1] { "@IdKM" };
            object[] values = new object[1] { IdKM };
            i = BLL.connection.Excute_Sql("spDeleteKhuyenMai", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetKhuyenMai()
        {
            return BLL.connection.FillDataSet("spgetKhuyenMai", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getKuyenMaiByIdKM()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdKM" };
            object[] values = new object[1] { IdKM };
            ds = BLL.connection.FillDataSet("spgetKhuyenMaiByIdKM", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
