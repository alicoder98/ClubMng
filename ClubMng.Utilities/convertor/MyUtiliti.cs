using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClubMng.Utilities.convertor
{
    public static class MyUtiliti
    {

        public static int difrenc(List<int> date, List<int> date2)
        {
            int daysOfY = 0;
            int daysOfM = 0;
            int dayOfD = 0;
            int toataldays = 0;
            int smaller = 0;
            int biger = 0;
            if (date[1] == date2[1])
            {
                biger = smaller = date2[1];
            }
            else if (date[1] > date2[1])
            {
                biger = date[1];
                smaller = date2[1];
            }
            else if (date[1] < date2[1])
            {
                biger = date2[1];
                smaller = date[1];
            }
            if (smaller != biger)
            {
                for (int i = smaller; i < biger; i++)
                {
                    if (i >= 1 && i <= 6)
                    {
                        daysOfM += 31;
                    }
                    else if (i > 6 && i <= 12)
                    {
                        daysOfM += 30;
                    }

                }
            }

            daysOfY = date[0] - date2[0];
            if (daysOfY < 0)
                daysOfY *= -1;

            dayOfD = date[2] - date2[2];
            if (dayOfD < 0)
                dayOfD *= -1;
            toataldays = daysOfY + daysOfM + dayOfD;

            return toataldays;
        }
    }
}
