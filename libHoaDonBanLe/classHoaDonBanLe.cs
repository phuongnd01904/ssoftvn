using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace libHoaDonBanLe
{
    public class classHoaDonBanLe
    {
        //Thêm mới hóa đơn bán lẻ
        public static bool Add_HoaDonBanLe(HoaDonBanLe hdbl)
        {
            return false;
        }

        //Cập nhật hóa đơn bán lẻ
        public static bool Update_HoaDonBanLe(HoaDonBanLe hdbl)
        {
            return false;
        }

        //Xóa hóa đơn
        public static bool Delete_HoaDonBanLe(Guid id)
        {
            return false;
        }

        //Lấy danh sách hóa đơn bán lẻ theo thời gian
        public static List<HoaDonBanLe> GetList_HoaDonBanLe(DateTime from, DateTime to)
        {
            return new List<HoaDonBanLe>();
        }

        //Lấy danh sách hóa đơn bán lẻ theo đơn vị
        public static List<HoaDonBanLe> GetList_HoaDonBanLe(Guid iddonvi)
        {
            return new List<HoaDonBanLe>();
        }
    }
}
