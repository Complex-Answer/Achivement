using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace asdf
{
    class MyHelper
    {

        public static void FindMinNum(int[] ints)
        {
            int min = ints[0];
            for (int i = 0; i < ints.Length; i++)
            {

                if (ints[i] < min)
                {
                    min = ints[i];
                }


            }
            Console.WriteLine($"{min}(이)가 가장 작은 숫자입니다");
        }

        public static void CountUpperCaseLetters(string upper)
        {
            int a = 0;
            for (int i = 0; i < upper.Length; i++)
            {
                if (char.IsUpper(upper[i]))
                {
                    a++;
                }
            }
            Console.WriteLine($"{a}개만큼 대문자가 있습니다");
        }
        

    }




}
