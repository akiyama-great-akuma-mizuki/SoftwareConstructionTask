using System;
using System.Collections;
namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            bool[] nums = new bool[101]; //初始化为0，假设全素数
            new Program().getPrimeNums(nums, 100);
            Console.WriteLine("2-100之间的素数：");
            for (int i = 2; i <= 100;i++)
            {
                if (!nums[i])
                    Console.WriteLine(i);
            }
            
        }
        public void getPrimeNums(bool[] nums,int range)
        {
            for(int i = 2; i <= range / i; i++)
            {
                if(!nums[i])
                {
                    //如果是素数，则它的倍数都不为素数
                    for(int j = 2 * i; j <= range; j += i)
                    {
                        nums[j] = true;
                    }
                }
            }
        }    
    }
    
}
