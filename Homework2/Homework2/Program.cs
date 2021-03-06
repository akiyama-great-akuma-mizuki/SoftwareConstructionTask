using System;
using System.Collections;
namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("现在开始分解因数，请输入一个正整数(不超过1E+6):");

            while (true)
            {
                try
                {
                    int num = Convert.ToInt32( Console.ReadLine());
                    if (num <= 1)
                        Console.WriteLine($"{num}不能分解!");
                    else if (num > 1E+6)
                        Console.WriteLine($"{num}太大！");
                    else
                    {
                        ArrayList primeList = new Program().getPrimeNums(num);
                        Console.WriteLine(new Program().divide(num, 0, ref primeList));
                    }
                }
                catch (Exception e)
                {
                    Console.WriteLine("输入错误！");
                }
                Console.WriteLine("是否继续？Y/N");
                if (Convert.ToChar(Console.ReadLine()) != 'Y')
                    break;
                Console.WriteLine("现在开始分解因数，请输入一个正整数(不超过1E+6):");

            }
            Console.WriteLine("感谢使用！");
        }
        public String divide(int num,int deep,ref ArrayList primes)
        {
            String str = "";
            if (num == 0 || deep >= primes.Count)
                return str;
            while(num % (int)primes[deep] == 0) {
                str += primes[deep];
                str += " ";
                num /= (int)primes[deep];
            }
            return str + divide(num, deep + 1, ref primes);

        }
        public ArrayList getPrimeNums(int num)
        {

            ArrayList primes = new ArrayList();
            primes.Add(2);
            for(int i = 3;i <= num/2 + 1; i++)
            {
                bool isprime = true;
                for(int j = 2; j <= Math.Pow(i, 0.5); j++)
                {
                    if (i % j == 0)
                        isprime = false;
                }
                if (isprime) 
                    primes.Add(i);
            }
            return primes;
        }

    }
}
