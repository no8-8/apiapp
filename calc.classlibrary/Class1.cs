using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace calc.classlibrary
{
    public class calc1
    {




        public int Average(int[] nums)
        {
            int total = 0;
            foreach (var num in nums)
            {
                total += num;
            }
            return total / nums.Count();

        }
        public int Smallest(int[] nums)
        {
            int small = nums[0];
            foreach (var num in nums)
            {
                if (num < small)
                {
                    small = num;
                }
            }
            return small;
        }
        public int Largest(int[] nums)
        {
            int large = nums[0];
            foreach (var num in nums)
            {
                if (num > large)
                {
                    large = num;

                }

            }
            return large;

        }
    }
}