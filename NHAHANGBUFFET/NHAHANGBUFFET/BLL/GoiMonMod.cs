using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace NHAHANGBUFFET.BLL
{
    class GoiMonMod
    {
        protected string IdBan { get; set; }
        protected string TenThucDon { get; set; }
        protected decimal DonGiaTon { get; set; }
        protected int SoLuong { get; set; }
        protected DateTime ThoiGian { get; set; }
        protected decimal ThanhTien { get; set; }
        public GoiMonMod(string _IdBan)
        {
            IdBan = _IdBan;
        }

        public GoiMonMod() { }
        public GoiMonMod(string _idBan, string _tenThucDon, decimal _donGiaTon, int _soLuong, DateTime _thoiGian, decimal _thanhTien)
        {
            this.IdBan = _idBan;
            this.TenThucDon = _tenThucDon;
            this.DonGiaTon = _donGiaTon;
            this.SoLuong = _soLuong;
            this.ThoiGian = _thoiGian;
            this.ThanhTien = _thanhTien;
        }


        //khai báo them sua xoa
        public int InsertGoiMon()
        {

            int i = 0;
            string[] paras = new string[6] { "@IdBan", "@TenThucDon", "@DonGiaTon", "@SoLuong", "ThoiGian", "ThanhTien" };
            object[] values = new object[6] { IdBan, TenThucDon, DonGiaTon, SoLuong, ThoiGian, ThanhTien};
            i = BLL.connection.Excute_Sql("spInsertGoiMon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public int UpdateGoiMon()
        {

            int i = 0;
            string[] paras = new string[6] { "@IdBan", "@TenThucDon", "@DonGiaTon", "@SoLuong", "ThoiGian", "ThanhTien" };
            object[] values = new object[6] { IdBan, TenThucDon, DonGiaTon, SoLuong, ThoiGian, ThanhTien };
            i = BLL.connection.Excute_Sql("spUpdateGoiMon", CommandType.StoredProcedure, paras, values);
            return i;
        }

        public int DeleteGoiMon()
        {

            int i = 0;
            string[] paras = new string[1] { "@IdBan" };
            object[] values = new object[1] { IdBan };
            i = BLL.connection.Excute_Sql("spDeleteGoiMon", CommandType.StoredProcedure, paras, values);
            return i;
        }
        public static DataSet FillDataSetGoiMon()
        {
            return BLL.connection.FillDataSet("spgetGoiMon", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetDanhSachBan_GoiMon()
        {
            return BLL.connection.FillDataSet("spgetDanhSachBan_GoiMon", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSetDanhSachBan_ChuaGoiMon()
        {
            return BLL.connection.FillDataSet("spgetDanhSachBan_ChuaGoiMon", CommandType.StoredProcedure);
        }
        public DataSet FillDataSet_getGoiMonByIdBan()
        {
            DataSet ds = new DataSet();
            string[] paras = new string[1] { "@IdBan" };
            object[] values = new object[1] { IdBan };
            ds = BLL.connection.FillDataSet("spgetGoiMonByIdBan", CommandType.StoredProcedure, paras, values);
            return ds;
        }
        //public  DataSet FillDataSet_SumThanhTien()
        //{
            //return BLL.connection.FillDataSet("spgetSumThanhTien", CommandType.StoredProcedure);
        //}
        public static DataSet FillDataSet_getTenThucDon()
        {
            return BLL.connection.FillDataSet("spgetTenThucDon", CommandType.StoredProcedure);
        }
        public static DataSet FillDataSet_getIdBan()
        {
            return BLL.connection.FillDataSet("spgetBan", CommandType.StoredProcedure);
        }
        //public DataSet static FillDataSet_getMonDaGoi()
        //{
        //    return BLL.connection.FillDataSet("spXemGoiMon", CommandType.StoredProcedure);
        //}
        public static DataSet FillDataset_getDonGiaThucDon()
        {
            DataSet ds = new DataSet();
            try
            {
                ds= BLL.connection.FillDataSet("spgetThucDon", CommandType.StoredProcedure);
            }
            catch
            {    }
            return ds;
        }

    }
}
