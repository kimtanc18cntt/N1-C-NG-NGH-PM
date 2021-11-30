using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NHAHANGBUFFET.DAL
{
    class ThucDonCtrl
    {
        public static DataSet FillDataSet_getThucDonByIdThucDon(string _idThucDon)
        {
            try
            {
                BLL.ThucDonMod tdon = new BLL.ThucDonMod(_idThucDon);
                return tdon.FillDataSet_getThucDonByIdThucDon();
            }
            catch
            {
                return null;
            }
        }

        public static int InsertThucDon(string _idThucDon, string _tenLoaiThucDon, string _tenThucDon, string _donViTinh, float _soLuongTon, float _donGiaTon, float _tonToiThieu, string _trangThai)
        {
            try
            {
                BLL.ThucDonMod _tdon = new BLL.ThucDonMod(_idThucDon, _tenLoaiThucDon, _tenThucDon, _donViTinh,_soLuongTon,_donGiaTon, _tonToiThieu, _trangThai);
                return _tdon.InsertThucDon();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdateThucDon(string _idThucDon, string _tenLoaiThucDon, string _tenThucDon, string _donViTinh, float _soLuongTon, float _donGiaTon, float _tonToiThieu, string _trangThai)
        {
            try
            {
                BLL.ThucDonMod _tdon = new BLL.ThucDonMod(_idThucDon, _tenLoaiThucDon, _tenThucDon, _donViTinh, _soLuongTon, _donGiaTon, _tonToiThieu, _trangThai);
                return _tdon.UpdateThucDon();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteThucDon(string _idThucDon)
        {
            try
            {
                BLL.ThucDonMod _tdon = new BLL.ThucDonMod(_idThucDon);
                return _tdon.DeleteThucDon();
            }
            catch
            {
                return 0;
            }
        }
    }
}
