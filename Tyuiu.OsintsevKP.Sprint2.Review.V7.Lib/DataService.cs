using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using tyuiu.cources.programming.interfaces.Sprint2;

namespace Tyuiu.OsintsevKP.Sprint2.Review.V7.Lib
{
    public class DataService : ISprint2Task7V7
    {
        public bool CheckDotInShadedArea(double x, double y)
        {
            if (x <= 0)
            {
                if ((y <= 2 - Math.Pow(x, 2) && (y >= x))) return true;
                else return false;
            }
            else if (x > 0)
            {
                if ((Math.Pow(x, 2) <= 2 - y) && (y >= 0)) return true;
                else return false;
            }
            else return false;
        }
    }
}
