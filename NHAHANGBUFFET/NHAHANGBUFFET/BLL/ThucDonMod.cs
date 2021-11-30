using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NHAHANGBUFFET.BLL
{
    class ThucDonMod
    {
        protected string IdThucDon { get; set; }
        protected string TenLoaiThucDon { get; set; }
        protected string TenThucDon { get; set; }
        protected string DonViTinh { get; set; }
        protected float SoLuongTon { get; set; }
        protected float DonGiaTon { get; set; }
        protected float TonToiThieu { get; set; }
        protected string TrangThai { get; set; }
        public ThucDonMod(string _IdThucDon)
        {
            IdThucDon = _IdThucDon;
        }

        public ThucDonMod() { }
        public ThucDonMod(string _idThucDon, string _tenLoaiThucDon, string _tenThucDon, string _donViTinh, float _soLuongTon, float _donGiaTon, float _tonToiThieu, string _trangThai)
        {
            this.IdThucDon = _idThucDon;
            this.TenLoaiThucDon = _tenLoaiThucDon;
            this.TenThucDon = _tenThucDon;
            this.DonViTinh = _donViTinh;
            this.SoLuongTon = _soLuongTon;
            this.DonGiaTon = _donGiaTon;
            this.TonToiThieu = _tonToiThieu;
            this.TrangThai = _trangThai;
        }


        //khai báo them sua xoa
        public int InsertThucDon()
        {

            int i = 0;
            string[] paras = new string[8] { "@IdThucDon", "@TenLoaiThucDon", "@TenThucDon", "@DonViTinh", "@SoLuongTon", "@DonGiaTon", "@TonToiThieu", "@TrangThai" };
            object[] values = new object[8] { IdThucDon, TenLoaiThucDon, TenThucDon, DonViTinh, SoLuongTon,DonGiaTon,TonToiThieu, TrangThai };
            i = BLL.connection.Excute_Sql("spInsertThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateThucDon()
        {

            int i = 0;
            string[] paras = new string[8] { "@IdThucDon", "@TenLoaiThucDon", "@TenThucDon", "@DonViTinh", "@SoLuongTon", "@DonGiaTon", "@TonToiThieu", "@TrangThai" };
            object[] values = new object[8] { IdThucDon, TenLoaiThucDon, TenThucDon, DonViTinh, SoLuongTon, DonGiaTon, TonToiThieu, TrangThai };
            i = BLL.connection.Excute_Sql("spUpdateThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int DeleteThucDon()
        {

            int i = 0;
            string[] paras = new string[1] { "@IdThucDon" };
            object[] values = new object[1] { IdThucDon };
            i = BLL.connection.Excute_Sql("spDeleteThucDon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetThucDon()
        {
            return BLL.connection.FillDataSet("spgetThucDon", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetThucDonNotTTT()
        {
            return BLL.connection.FillDataSet("spgetThucDonNotTTT", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getThucDonByIdThucDon()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdThucDon" };
            object[] values = new object[1] { IdThucDon };
            ds = BLL.connection.FillDataSet("spgetThucDonByIdThucDon", CommandType.StoredProcedure, paras, values);
            return ds;
        }
    }
}
