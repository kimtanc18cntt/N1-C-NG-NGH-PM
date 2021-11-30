using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NHAHANGBUFFET.DAL
{
    class GoiMonCtrl
    {
        public static DataSet FillDataSet_getGoiMonByIdBan(string _idBan)
        {
            try
            {
                BLL.GoiMonMod gmon = new BLL.GoiMonMod(_idBan);
                return gmon.FillDataSet_getGoiMonByIdBan();
            }
            catch
            {
                return null;
            }
        }

        public static int InSertGoiMon(string _idBan, string _TenThucDon, decimal _DonGiaTon, int _SoLuong, DateTime _ThoiGian, decimal _ThanhTien)
        {
            try
            {
                BLL.GoiMonMod _goiMon = new BLL.GoiMonMod(_idBan, _TenThucDon, _DonGiaTon, _SoLuong, _ThoiGian, _ThanhTien);
                return _goiMon.InsertGoiMon();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdateGoiMon(string _idBan, string _tenThucDon, decimal _donGiaTon, int _soLuong, DateTime _thoiGian, decimal _thanhTien)
        {
            try
            {
                BLL.GoiMonMod _goimon = new BLL.GoiMonMod(_idBan, _tenThucDon, _donGiaTon, _soLuong, _thoiGian, _thanhTien);
                return _goimon.UpdateGoiMon();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteGoiMon(string _idBan)
        {
            try
            {
                BLL.GoiMonMod _goimon = new BLL.GoiMonMod(_idBan);
                return _goimon.DeleteGoiMon();
            }
            catch
            {
                return 0;
            }
        }

        internal static object FillDataSet_getGoiMonByIdBan(object idBan)
        {
            throw new NotImplementedException();
        }
    }
}
