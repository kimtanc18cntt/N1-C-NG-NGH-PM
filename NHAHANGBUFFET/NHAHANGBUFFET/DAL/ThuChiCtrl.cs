using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NHAHANGBUFFET.DAL
{
    class ThuChiCtrl
    {
        public static DataSet FillDataSet_getThuChiByIdThuChi(string _idThuChi)
        {
            try
            {
                BLL.ThuChiMod tc = new BLL.ThuChiMod(_idThuChi);
                return tc.FillDataSet_getThuChiByIdThuChi();
            }
            catch
            {
                return null;
            }
        }

        public static int InsertThuChi(string _idThuChi, string _tenThuChi, DateTime _ngay, float _thu, float _chi)
        {
            try
            {
                BLL.ThuChiMod _thuchi = new BLL.ThuChiMod(_idThuChi, _tenThuChi, _ngay, _thu, _chi);
                return _thuchi.InsertThuChi();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdateThuChi(string _idThuChi, string _tenThuChi, DateTime _ngay, float _thu, float _chi)
        {
            try
            {
                BLL.ThuChiMod _thuchi = new BLL.ThuChiMod(_idThuChi, _tenThuChi, _ngay, _thu, _chi);
                return _thuchi.UpdateThuChi();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteThuChi(string _idThuChi)
        {
            try
            {
                BLL.ThuChiMod _thuchi = new BLL.ThuChiMod(_idThuChi);
                return _thuchi.DeleteThuChi();
            }
            catch
            {
                return 0;
            }
        }
    }
}
