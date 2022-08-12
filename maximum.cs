using System;
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
        public static float MaximumFloat(float num4, float num5, float num6)
        {

            if (num4.CompareTo(num5) > 0 && num4.CompareTo(num6) > 0 ||

                num4.CompareTo(num5) >= 0 && num4.CompareTo(num6) > 0 ||

                num4.CompareTo(num5) > 0 && num4.CompareTo(num6) >= 0)
            {
                return num4;
            }
            if (num5.CompareTo(num4) > 0 && num5.CompareTo(num6) > 0 ||

                num5.CompareTo(num4) >= 0 && num5.CompareTo(num6) > 0 ||

                num5.CompareTo(num4) > 0 && num5.CompareTo(num6) >= 0)
            {
                return num5;
            }
            if (num6.CompareTo(num4) > 0 && num6.CompareTo(num5) > 0 ||

                num6.CompareTo(num4) >= 0 && num6.CompareTo(num5) > 0 ||

                num6.CompareTo(num4) > 0 && num6.CompareTo(num6) >= 0)
            {
                return num6;
            }
            throw new Exception("num4,num5 and num6 are same");
        }
        public static string MaximumStringNumber(string firstString, string secondString, string thirdString)
        {

            if (firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) > 0 ||

                firstString.CompareTo(secondString) >= 0 && firstString.CompareTo(thirdString) > 0 ||

                firstString.CompareTo(secondString) > 0 && firstString.CompareTo(thirdString) >= 0)
            {
                return firstString;
            }
            if (secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) > 0 ||

                secondString.CompareTo(firstString) >= 0 && secondString.CompareTo(thirdString) > 0 ||

                secondString.CompareTo(firstString) > 0 && secondString.CompareTo(thirdString) >= 0)
            {
                return secondString;
            }
            if (thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) > 0 ||

                thirdString.CompareTo(firstString) >= 0 && thirdString.CompareTo(secondString) > 0 ||

                thirdString.CompareTo(firstString) > 0 && thirdString.CompareTo(secondString) >= 0)
            {
                return thirdString;
            }
            throw new Exception("firstNumber,secondNumber and thirdNumber are same");
        }
    }
}
