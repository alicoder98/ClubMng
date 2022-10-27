using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMng.Utilities.convertor
{
    public static class DateEditor
    {


        public static List<int> convertToStandard(this string date)
        {
            int i = 2;
            string[] datesplit;
            List<int> datelist = new List<int>();
            string utfstr = "";
            int days = 0;
            int mounth = 0;
            int year = 0;
            var utf8bytes = Encoding.UTF8.GetBytes(date);
            var win1252Bytes = Encoding.Convert(Encoding.UTF8, Encoding.ASCII, utf8bytes);
            for (int k = 0; k < utf8bytes.Length; k++)
            {
                char c = (char)win1252Bytes[k];
                utfstr += c;
            }
            datesplit = utfstr.Split('/');
            days = int.Parse(datesplit[2]);
            mounth = int.Parse(datesplit[1]);
            year = int.Parse(datesplit[0]);
            datelist.Add(year);
            datelist.Add(mounth);
            datelist.Add(days);

            return datelist;

        }





    }
}
