﻿using System.Web;
using System.Web.Mvc;

namespace PRC_GSMU_BS
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
