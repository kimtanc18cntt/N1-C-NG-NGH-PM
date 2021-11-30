using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NHAHANGBUFFET.DAL
{
    class BanCtrl
    {
        public static DataSet FillDataSet_getBanByIdBan(string _idBan)
        {
            try
            {
                BLL.BanMod ban = new BLL.BanMod(_idBan);
                return ban.FillDataSet_getBanByIdBan();
            }
            catch
            {
                return null;
            }
        }

        public static int InsertBan(string _idBan, string _tenKhuVuc, string _tenBan, string _dienGiai, string _trangThai)
        {
            try
            {
                BLL.BanMod _ban = new BLL.BanMod(_idBan, _tenKhuVuc,_tenBan, _dienGiai, _trangThai);
                return _ban.InsertBan();
            }
            catch
            {
                return 0;
            }
        }
        public static int UpdateBan(string _idBan, string _tenKhuVuc, string _tenBan, string _dienGiai, string _trangThai)
        {
            try
            {
                BLL.BanMod _ban = new BLL.BanMod(_idBan, _tenKhuVuc, _tenBan, _dienGiai, _trangThai);
                return _ban.UpdateBan();
            }
            catch
            {
                return 0;
            }
        }
        public static int DeleteBan(string _idBan)
        {
            try
            {
                BLL.BanMod _ban = new BLL.BanMod(_idBan);
                return _ban.DeleteBan();
            }
            catch
            {
                return 0;
            }
        }
    }
}
