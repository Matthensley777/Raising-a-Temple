﻿using System.Web;
using System.Web.Mvc;

namespace Raising_a_Temple
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
