using System;

namespace Value_ReferenceType
{
    class Program
    {
        static void Main(string[] args)
        {
            int num1 = 5;
            int num2 = 3;
            num1 = num2;
            num2 = 100;
            //num1 =3

            int[] nums = new int[] { 1, 3, 5 };
            int[] nums2 = new int[] { 100, 200, 300 };
            nums = nums2;
            nums2[0] = 999;
            //nums[0] = 999
        }
    }
}