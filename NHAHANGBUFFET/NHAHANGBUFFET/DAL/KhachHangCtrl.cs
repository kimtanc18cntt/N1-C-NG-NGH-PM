using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NHAHANGBUFFET.DAL
{
    class KhachHangCtrl
    {
        public static DataSet FillDataSet_getKhachHangByIdKH(string _idKH)
        {
            try
            {
                BLL.KhachHangMod kh = new BLL.KhachHangMod(_idKH);
                return kh.FillDataSet_getKhachHangByIdKH();
            }
            catch
            {
                return null;
            }
        }

        public static int InsertKhachHang(string _idKH, string _tenKH, string _dienThoai, string _email, string _diaChi, string _dacQuyen)
        {
            try
            {
                BLL.KhachHangMod _khachhang = new BLL.KhachHangMod(_idKH,_tenKH,_dienThoai,_email,_diaChi,_dacQuyen);
                return _khachhang.InsertKhachHang();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdateKhachHang(string _idKH, string _tenKH, string _dienThoai, string _email, string _diaChi, string _dacQuyen)
        {
            try
            {
                BLL.KhachHangMod _khachhang = new BLL.KhachHangMod(_idKH, _tenKH, _dienThoai, _email, _diaChi, _dacQuyen);
                return _khachhang.UpdateKhachHang();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteKhachHang(string _idKH)
        {
            try
            {
                BLL.KhachHangMod _khachhang = new BLL.KhachHangMod(_idKH);
                return _khachhang.DeleteKhachHang();
            }
            catch
            {
                return 0;
            }
        }
    }
}
