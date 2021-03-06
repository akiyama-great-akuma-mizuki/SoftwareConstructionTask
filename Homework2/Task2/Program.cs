using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("请输入一个整数数组，用空格隔开");
            string input = Console.ReadLine();
            char[] ch = { ' ' };
            string[] strs = input.Split(ch, StringSplitOptions.RemoveEmptyEntries);
            int[] nums = new int[strs.Length];
            for(int i = 0; i < strs.Length; i++)
            {
                nums[i] = Convert.ToInt32(strs[i]);
            }
            Console.WriteLine("最大值：" + getMax(nums) + " 最小值：" + getMin(nums) +
                " 平均值:" + getAverage(nums) + " 和：" + getSum(nums));
        }
        public static int getMax(int[] nums)
        {
            int temp = nums[0];
            foreach (int i in nums)
            {
                if (i > temp)
                    temp = i;
            }
            return temp;
        }
        public static int getMin(int[] nums)
        {
            int temp = nums[0];
            foreach (int i in nums)
            {
                if (i < temp)
                    temp = i;
            }
            return temp;
        }
        public static double getAverage(int[] nums)
        {
            return  getSum(nums) / nums.Length;
        }
        public static int getSum(int [] nums)
        {
            int sum = 0;
            foreach(int i in nums)
            {
                sum += i;
            }
            return sum;
        }
    }
    
}
