﻿using System.Web;
using System.Web.Mvc;

namespace Examen_II_programacion_II
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
