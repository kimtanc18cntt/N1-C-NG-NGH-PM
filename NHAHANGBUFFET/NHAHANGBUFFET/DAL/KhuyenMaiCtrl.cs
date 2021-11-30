using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
namespace NHAHANGBUFFET.DAL
{
    class KhuyenMaiCtrl
    {
        public static DataSet FillDataSet_getKhuyenMaiByIdKM(string _idKM)
        {
            try
            {
                BLL.KhuyenMaiMod km = new BLL.KhuyenMaiMod(_idKM);
                return km.FillDataSet_getKuyenMaiByIdKM();
            }
            catch
            {
                return null;
            }
        }

        public static int InsertKhuyenMai(string _idKM, string _noiDung, string _dienGiai, string _doiTuong)
        {
            try
            {
                BLL.KhuyenMaiMod _khuyenmai = new BLL.KhuyenMaiMod(_idKM, _noiDung, _dienGiai, _doiTuong);
                return _khuyenmai.InsertKhuyenMai();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdateKhuyenMai(string _idKM, string _noiDung, string _dienGiai, string _doiTuong)
        {
            try
            {
                BLL.KhuyenMaiMod _khuyenmai = new BLL.KhuyenMaiMod(_idKM, _noiDung, _dienGiai, _doiTuong);
                return _khuyenmai.UpdateKhuyenMai();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteKhuyenMai(string _idKM)
        {
            try
            {
                BLL.KhuyenMaiMod _khuyenmai = new BLL.KhuyenMaiMod(_idKM);
                return _khuyenmai.DeleteKhuyenMai();
            }
            catch
            {
                return 0;
            }
        }
    }
}
