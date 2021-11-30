using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NHAHANGBUFFET.BLL
{
    class ThuChiMod
    {
        protected string IdThuChi { get; set; }
        protected string TenThuChi { get; set; }
        protected DateTime Ngay { get; set; }
        protected float Thu { get; set; }
        protected float Chi { get; set; }


        public ThuChiMod(string _IdThuChi)
        {
            IdThuChi = _IdThuChi;
        }

        public ThuChiMod() { }
        public ThuChiMod(string _idThuChi, string _tenThuChi, DateTime _ngay, float _thu, float _chi)
        {
            IdThuChi = _idThuChi;
            TenThuChi = _tenThuChi;
            Ngay = _ngay;
            Thu = _thu;
            Chi = _chi;

        }
        //khai báo them sua xoa
        public int InsertThuChi()
        {

            int i = 0;
            string[] paras = new string[5] { "@IdThuChi","@TenThuChi", "@Ngay","@Thu","@chi" };
            object[] values = new object[5] { IdThuChi, TenThuChi, Ngay, Thu, Chi };
            i = BLL.connection.Excute_Sql("spInsertThuChi", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateThuChi()
        {

            int i = 0;
            string[] paras = new string[5] { "@IdThuChi", "@TenThuChi", "@Ngay", "@Thu", "@chi" };
            object[] values = new object[5] { IdThuChi, TenThuChi, Ngay, Thu, Chi };
            i = BLL.connection.Excute_Sql("spUpdateThuChi", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int DeleteThuChi()
        {

            int i = 0;
            string[] paras = new string[1] { "@IdThuChi" };
            object[] values = new object[1] { IdThuChi };
            i = BLL.connection.Excute_Sql("spDeleteThuChi", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetThuChi()
        {
            return BLL.connection.FillDataSet("spgetThuChi", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getThuChiByIdThuChi()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdThuChi" };
            object[] values = new object[1] { IdThuChi };
            ds = BLL.connection.FillDataSet("spgetThuChiByIdThuChi", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
