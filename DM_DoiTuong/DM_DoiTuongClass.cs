using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace DM_DoiTuong
{
    public class DM_DoiTuongClass
    {
        public static bool Add_DoiTuong(Model.DM_DoiTuong dt)
        {
            using (SSOFTEntities sse = new Model.SSOFTEntities())
            {
                try
                {
                    sse.DM_DoiTuong.Add(dt);
                    sse.SaveChanges();
                    return true;
                }
                catch (Exception ex)
                {
                    string error = ex.Message;
                    return false;
                }
            }
        }
    }
}
