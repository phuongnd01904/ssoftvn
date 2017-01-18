using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Model;
using libDM_DoiTuong;

namespace ssoftvn2017.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult themmoidoituong(FormCollection fc)
        {
            Model.DM_DoiTuong dt = new Model.DM_DoiTuong();
            dt.ID = Guid.NewGuid();
            dt.LoaiDoiTuong = 0;
            dt.LaCaNhan = true;
            dt.ID_NhomDoiTuong = new Guid("9C8C0D4B-49E3-4304-9BB3-E43C05F44B0E");
            dt.MaDoiTuong = fc["txtMaDoiTuong"];
            dt.TenDoiTuong = fc["txtTenDoiTuong"];
            dt.ChiaSe = true;
            dt.TheoDoi = true;
            dt.NgayNhap = DateTime.Now;
            dt.UserTao = "ADMIN";
            bool result = classDM_DoiTuong.Add_DoiTuong(dt);
            return Json(result, JsonRequestBehavior.DenyGet);
        }

    }
}
