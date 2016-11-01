//https://leetcode.com/problems/two-sum/
//Accepted, low performance :\
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Two_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0,-3,4,5,12,33,54,29};
            int target = 30;

            int[] ans = TwoSum(nums,target);

            Console.Read();
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            int remain = 0;

            for (int i = 0; i < nums.Length;i++ )
            {
                remain = target - nums[i];
                for (int j = 0; j < nums.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (nums[j] == remain)
                    {
                        return new int[] { i, j };
                    }
                }
            }

            return new int[] { nums.Length, nums.Length };
        }
    }
}
