using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Model;

namespace libDM_DoiTuong
{
    public class classDM_DoiTuong
    {
        public static bool Add_DoiTuong(Model.DM_DoiTuong dt)
        {
            using (SSOFTEntities sse = new SSOFTEntities())
            {
                try
                {
                    sse.DM_DoiTuong.Add(dt);
                    sse.SaveChanges();
                    return true;
                }
                catch
                {
                    return false;
                }
            }
        }
    }
}
