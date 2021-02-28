using System;

namespace CsharpHomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("欢迎使用控制台计算器");

            while (true)
            {
                Console.WriteLine("请输入表达式，例如：\n2\n+\n3\n");
                try
                {
                    int num1 = Convert.ToInt32(Console.ReadLine());
                    if (num1 == 'Q')
                        break;
                    char op = Convert.ToChar(Console.ReadLine());
                    int num2 = Convert.ToInt32(Console.ReadLine());

                    switch (op)
                    {
                        case '+':
                            Console.WriteLine($"{num1} {op} {num2} = {num1 + num2}");
                            break;
                        case '-':
                            Console.WriteLine($"{num1} {op} {num2} = {num1 - num2}");
                            break;
                        case '*':
                            Console.WriteLine($"{num1} {op} {num2} = {num1 * num2}");
                            break;
                        case '/':
                            Console.WriteLine($"{num1} {op} {num2} = {num1 / num2}");
                            break;
                        default:
                            Console.WriteLine("符号格式错误!(+ - * / only)");
                            break;

                    }
                    Console.WriteLine("继续吗？(Y/N)");
                    if (Convert.ToChar(Console.ReadLine()) != 'Y')
                        break;
                }
                catch (FormatException E)
                {
                    Console.WriteLine("输入格式错误");
                }
            }
            Console.WriteLine("谢谢使用");
        }
    }
}
