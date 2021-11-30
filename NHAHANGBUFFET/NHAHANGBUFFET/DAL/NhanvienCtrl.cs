using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NHAHANGBUFFET.DAL
{
    class NhanvienCtrl
    {
        public static DataSet FillDataSet_getNhanVienByIdNhanVien(string _idNhanVien)
        {
            try
            {
                BLL.NhanVienMod nvien = new BLL.NhanVienMod(_idNhanVien);
                return nvien.FillDataSet_getNhanVienByIdNhanVien();

            }
            catch
            {
                return null;
            }
        }
        public static DataSet FillDataSet_getSearchNVbyId(string _idNhanVien)
        {
            try
            {
                BLL.NhanVienMod nvien = new BLL.NhanVienMod(_idNhanVien);
                return nvien.FillDataSet_getSearchNVbyId();

            }
            catch
            {
                return null;
            }
        }
        public static DataSet FillDataSet_FindNVByTen(string _hotenNhanVien)
        {
            try
            {
                BLL.NhanVienMod nvien = new BLL.NhanVienMod(_hotenNhanVien);
                return nvien.FillDataSet_FindNVByTen();

            }
            catch
            {
                return null;
            }
        }
        // Method Add
        public static int InSertNhanVien(string _idNhanVien, string _hotenNhanVien, string _ChucVuNhanVien, DateTime _ngaysinhNhanVien, string _giotinhNhanVien, string _dienthotenaiNhanVien, string _emailNhanVien, string _diachiNhanVien)
        {
            try
            {
                BLL.NhanVienMod _nhanVien = new BLL.NhanVienMod(_idNhanVien, _hotenNhanVien, _ChucVuNhanVien, _ngaysinhNhanVien, _giotinhNhanVien, _dienthotenaiNhanVien, _emailNhanVien, _diachiNhanVien);
                return _nhanVien.InsertNhanVien();
            }
            catch
            {
                return 0;
            }
        }
        // Method Update
        public static int UpdateNhanVien(string _idNhanVien, string _hotenNhanVien, string _ChucVuNhanVien, DateTime _ngaysinhNhanVien, string _giotinhNhanVien, string _dienthotenaiNhanVien, string _emailNhanVien, string _diachiNhanVien)
        {
            try
            {
                BLL.NhanVienMod _nhanVien = new BLL.NhanVienMod(_idNhanVien, _hotenNhanVien, _ChucVuNhanVien, _ngaysinhNhanVien, _giotinhNhanVien, _dienthotenaiNhanVien, _emailNhanVien, _diachiNhanVien);
                return _nhanVien.UpdateNhanVien();
            }
            catch
            {
                return 0;
            }

        }
        // Method Delete
        public static int DeleteNhanVien(string _idNhanVien)
        {
            try
            {
                BLL.NhanVienMod _nhanVien = new BLL.NhanVienMod(_idNhanVien);
                return _nhanVien.DeleteNhanVien();
            }
            catch
            {
                return 0;
            }

        }
    }
}
