﻿using System.Web;
using System.Web.Mvc;

namespace Task2_ProductsInfo_Dynamic_List
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
