using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NHAHANGBUFFET.BLL
{
    class KhachHangMod
    {
        protected string IdKH { get; set; }
        protected string TenKH { get; set; }
        protected string DienThoai { get; set; }
        protected string Email { get; set; }
        protected string DiaChi { get; set; }
        protected string DacQuyen { get; set; }
        public KhachHangMod(string _IdKH)
        {
            IdKH= _IdKH;
        }

        public KhachHangMod() { }
        public KhachHangMod(string _idKH, string _tenKH, string _dienThoai, string _email, string _diaChi, string _dacQuyen)
        {
            this.IdKH = _idKH;
            this.TenKH = _tenKH;
            this.DienThoai = _dienThoai;
            this.Email = _email;
            this.DiaChi = _diaChi;
            this.DacQuyen = _dacQuyen;

        }


        //khai báo them sua xoa
        public int InsertKhachHang()
        {

            int i = 0;
            string[] paras = new string[6] { "@IdKhachHang", "@TenKhachHang", "@DienThoai", "@Email", "@DiaChi", "@DacQuyen" };
            object[] values = new object[6] { IdKH, TenKH, DienThoai, Email, DiaChi, DacQuyen };
            i = BLL.connection.Excute_Sql("spInsertKhachHang", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateKhachHang()
        {

            int i = 0;
            string[] paras = new string[6] { "@IdKhachHang", "@TenKhachHang", "@DienThoai", "@Email", "@DiaChi", "@DacQuyen" };
            object[] values = new object[6] { IdKH, TenKH, DienThoai, Email, DiaChi, DacQuyen };
            i = BLL.connection.Excute_Sql("spUpdateKhachHang", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int DeleteKhachHang()
        {

            int i = 0;
            string[] paras = new string[1] { "@IdKhachHang" };
            object[] values = new object[1] { IdKH };
            i = BLL.connection.Excute_Sql("spDeleteKhachHang", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetKhachHang()
        {
            return BLL.connection.FillDataSet("spgetKhachHang", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getKhachHangByIdKH()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdKhachHang" };
            object[] values = new object[1] { IdKH };
            ds = BLL.connection.FillDataSet("spgetKhachHangByIdKhachHang", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
