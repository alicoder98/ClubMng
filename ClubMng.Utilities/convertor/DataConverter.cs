﻿using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMng.Utilities.convertor
{
    public static class DataConverter
    {
        
        public static string Toshamsi(this DateTime dateTime)
        {
            PersianCalendar pc = new PersianCalendar();
            return pc.GetYear(dateTime) + "/"+pc.GetMonth(dateTime).ToString("00")+"/"+pc.GetDayOfMonth(dateTime).ToString("00");
        }
    }
}