﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Max_values_using_Generics
{
    public class maximum
    {
        public static int MaximumInteger(int num1, int num2, int num3)
        {

            if (num1.CompareTo(num2) > 0 && num1.CompareTo(num3) > 0 ||

                num1.CompareTo(num2) >= 0 && num1.CompareTo(num3) > 0 ||

                num1.CompareTo(num2) > 0 && num1.CompareTo(num3) >= 0)
            {
                return num1;
            }
            if (num2.CompareTo(num1) > 0 && num2.CompareTo(num3) > 0 ||

                num2.CompareTo(num1) >= 0 && num2.CompareTo(num3) > 0 ||

                num2.CompareTo(num1) > 0 && num2.CompareTo(num3) >= 0)
            {
                return num2;
            }
            if (num3.CompareTo(num1) > 0 && num3.CompareTo(num2) > 0 ||

                num3.CompareTo(num1) >= 0 && num3.CompareTo(num2) > 0 ||

                num3.CompareTo(num1) > 0 && num3.CompareTo(num2) >= 0)
            {
                return num3;
            }
            throw new Exception("num1,num2 and num3 are same");
        }
    }
}
