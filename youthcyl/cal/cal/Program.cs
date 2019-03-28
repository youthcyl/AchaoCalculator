using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
using System.Data;
using System.IO;

namespace cal
{
    public class Program
    {
        static void Main(string[] args)
        {
            Cal();
        }
        public static void Cal()
        {
            Console.Write("请输入出题数目:");
            int n = Convert.ToInt32(Console.ReadLine());
            Random rdm = new Random();//产生随机数
            for (int m = 0; m < n; m++)
            {
                int i = rdm.Next(2, 4);
                if (i == 2)//判断操作符个数
                {
                    int num1 = rdm.Next(101);
                    int num2 = rdm.Next(101);
                    int num3 = rdm.Next(101);
                    int a = rdm.Next(0, 4);
                    int b = rdm.Next(0, 4);
                    double flag = Result1(num1, num2, num3, a, b);
                    if (flag == 0)
                    {
                        m--;//重新产生算式
                    }
                }
                if (i == 3)
                {
                    int num1 = rdm.Next(101);
                    int num2 = rdm.Next(101);
                    int num3 = rdm.Next(101);
                    int num4 = rdm.Next(101);
                    int x = rdm.Next(0, 4);
                    int y = rdm.Next(0, 4);
                    int z = rdm.Next(0, 4);
                    double flag = Result2(num1, num2, num3, num4, x, y, z);
                    if (flag == 0)
                    {
                        m--;
                    }
                }
            }
        }
        public static double Result1(int num1, int num2, int num3, int x, int y)
        {
            string filename = @"E:\C语言学习资料\calculator.txt";
            double flag = 1;
            DataTable dt = new DataTable();
            string[] oper = { "+", "-", "*", "/" };
            double result1 = Convert.ToDouble(dt.Compute(num1.ToString() + oper[x] + num2.ToString() + oper[y] + num3.ToString(), ""));//计算算式结果
            if ((result1 % 2 != 0 && result1 % 2 != 1) || result1 < 0)//判断结果是否为小数或小于零
            {
                flag = 0;

            }
            else
            {
                Console.WriteLine("{0} {1} {2} {3} {4} = {5} ", num1, oper[x], num2, oper[y], num3, result1);
                string file = num1.ToString() + oper[x] + num2.ToString() + oper[y] + num3.ToString() + "=" + result1.ToString() + "\r\n";
                File.AppendAllText(filename, file, Encoding.Default);//输出到文件
            }
            return flag;
        }
        public static double Result2(int num1, int num2, int num3, int num4, int x, int y, int z)
        {
            string filename = @"E:\C语言学习资料\calculator.txt";
            double flag = 1;
            DataTable dt = new DataTable();
            string[] oper = { "+", "-", "*", "/" };
            double result2 = Convert.ToDouble(dt.Compute(num1.ToString() + oper[x] + num2.ToString() + oper[y] + num3.ToString() + oper[z] + num4.ToString(), ""));
            if ((result2 % 2 != 0 && result2 % 2 != 1) || result2 < 0)
            {
                flag = 0;

            }
            else
            {
                Console.WriteLine("{0} {1} {2} {3} {4} {5} {6} = {7} ", num1, oper[x], num2, oper[y], num3, oper[z], num4, result2);
                string file = num1.ToString() + oper[x] + num2.ToString() + oper[y] + num3.ToString() + oper[z] + num4.ToString() + "=" + result2.ToString() + "\r\n";
                File.AppendAllText(filename, file, Encoding.Default);


            }
            return flag;
        }
    }
}
