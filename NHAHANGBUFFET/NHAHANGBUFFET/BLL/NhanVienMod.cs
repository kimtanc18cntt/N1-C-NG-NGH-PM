using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NHAHANGBUFFET.BLL
{
    class NhanVienMod
    {
        protected string IdNhanVien { get; set;  }
        protected string HoTenNV { get; set; }
        protected string ChucVuNV { get; set; }
        protected DateTime NgaySinhNV { get; set; }
        protected string GioiTinhNV { get; set; }
        protected string DienThoatNV { get; set; }
        protected string EmailNV { get; set; }
        protected string DiaChiNV { get; set; }

        public NhanVienMod(string _IdNhanVien)
        {
            IdNhanVien = _IdNhanVien;
        }

        public NhanVienMod() { }
        public NhanVienMod(string _idNhanVien, string _hoNhanVien,string _ChucVuNhanVien,DateTime _ngaysinhNhanVien, string _gioitinhNhanVien, string _dienthoaiNhanVien, string _emailNhanVien, string _diachiNhanVien)
        {
            IdNhanVien = _idNhanVien;
            HoTenNV = _hoNhanVien;
            ChucVuNV = _ChucVuNhanVien;
            NgaySinhNV = _ngaysinhNhanVien;
            GioiTinhNV = _gioitinhNhanVien;
            DienThoatNV = _dienthoaiNhanVien;
            EmailNV = _emailNhanVien;
            DiaChiNV = _diachiNhanVien;
            
        }
        //khai báo them sua xoa
        public int InsertNhanVien()
        {
            
            int i = 0;
            string[] paras = new string[8] { "@IdNhanVien", "@HoTen", "@ChucVu", "@NgaySinh", "@GioiTinh", "@Dienthoai", "@Email", "@DiaChi" };
            object[] values = new object[8] { IdNhanVien, HoTenNV, ChucVuNV, NgaySinhNV, GioiTinhNV, DienThoatNV, EmailNV, DiaChiNV };
            i = BLL.connection.Excute_Sql("spInsertNhanVien", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateNhanVien()
        {
            int i = 0;
            string[] paras = new string[8] { "@IdNhanVien", "@HoTen", "@ChucVu", "@NgaySinh", "@GioiTinh", "@Dienthoai", "@Email", "@DiaChi" };
            object[] values = new object[8] { IdNhanVien, HoTenNV, ChucVuNV, NgaySinhNV, GioiTinhNV, DienThoatNV, EmailNV, DiaChiNV };
            i = BLL.connection.Excute_Sql("spUpdateNhanVien", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int DeleteNhanVien()
        {
            int i = 0;
            string[] paras = new string[1] { "@IdNhanVien"};
            object[] values = new object[1] { IdNhanVien};
            i = BLL.connection.Excute_Sql("spDeleteNhanVien", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetNhanVien ()
        {
            return BLL.connection.FillDataSet("spgetNhanVien", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getNhanVienByIdNhanVien()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdNhanVien" };
            object[] values = new object[1] { IdNhanVien };
            ds = BLL.connection.FillDataSet("spgetNhanVienByIdNhanVien", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        public DataSet FillDataSet_getSearchNVbyId()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdNhanVien" };
            object[] values = new object[1] { IdNhanVien };
            ds = BLL.connection.FillDataSet("spSearchNVByIdNV", CommandType.StoredProcedure, paras, values);
            return ds;
        }             
        public DataSet FillDataSet_FindNVByTen()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@HoTen" };
            object[] values = new object[1] { IdNhanVien };
            ds = BLL.connection.FillDataSet("spSearchNVByTenDayDu", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
