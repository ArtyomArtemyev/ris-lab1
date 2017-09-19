using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    public class Checker
    {
        public static Boolean checkIsInt(string enterLine)
        {
            int checkObject = 0;
            try
            {
                checkObject = int.Parse(enterLine);
            }
            catch (System.FormatException)
            {
                return false;
            }
            if (checkObject > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
