﻿using System.Web;
using System.Web.Mvc;

namespace MusicApp_Aug2017
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}