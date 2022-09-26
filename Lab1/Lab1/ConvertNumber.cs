using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1
{
    internal class ConvertNumber
    {
        public int ConvertFrom10TO8(int num)
        {
            int i = 1;
            int resault = num % 8;
            int tmp = num / 8;
            while (tmp >= 1)
            {
                resault += tmp % 8 * (int)Math.Pow(10, i);
                tmp /= 8;
                i++;
            } 
            return resault;
        }
    }
}
