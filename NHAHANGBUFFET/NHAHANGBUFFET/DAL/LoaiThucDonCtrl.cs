using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NHAHANGBUFFET.DAL
{
    class LoaiThucDonCtrl
    {
        public static DataSet FillDataSet_getLoaithucDonByIdLoaiThucDon(string _idLoaiThucDon)
        {
            try
            {
                BLL.LoaiThucDonMod  ltd = new BLL.LoaiThucDonMod (_idLoaiThucDon);
                return ltd.FillDataSet_getLoaiThucDonByIdLoaiThucDon();
            }
            catch
            {
                return null;
            }
        }

        public static int InsertLoaiThucDon(string _idLoaiThucDon, string _ten, string _dienGiai, string _trangThai)
        {
            try
            {
                BLL.LoaiThucDonMod _loaithucdon = new BLL.LoaiThucDonMod (_idLoaiThucDon, _ten, _dienGiai, _trangThai);
                return _loaithucdon.InsertLoaiThucDon();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdateLoaiThucDon(string _idLoaiThucDon, string _ten, string _dienGiai, string _trangThai)
        {
            try
            {
                BLL.LoaiThucDonMod _loaithucdon = new BLL.LoaiThucDonMod(_idLoaiThucDon, _ten, _dienGiai, _trangThai);
                return _loaithucdon.UpdateLoaiThucDon();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteLoaiThucDon(string _idLoaiThucDon)
        {
            try
            {
                BLL.LoaiThucDonMod  _loaithucdon = new BLL.LoaiThucDonMod (_idLoaiThucDon);
                return _loaithucdon.DeleteLoaiThucDon();
            }
            catch
            {
                return 0;
            }
        }
    }
}
