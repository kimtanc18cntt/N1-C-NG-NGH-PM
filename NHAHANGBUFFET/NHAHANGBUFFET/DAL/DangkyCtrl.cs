using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHAHANGBUFFET.DAL
{
    class DangkyCtrl
    {
        public static int Insertdangnhap(string _user, string _pass )
        {
            try
            {
                BLL.Dangkymod dangky = new BLL.Dangkymod(_user, _pass);
                
                return dangky.Dangky();
            }
            catch
            {
                return 0;
            }
        }
    }
}
