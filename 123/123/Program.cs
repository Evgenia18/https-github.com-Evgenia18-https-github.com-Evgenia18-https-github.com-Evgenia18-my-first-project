using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace zxc
{
    internal class qwe
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите число: ");
            int n = Convert.ToInt32(Console.ReadLine());

            int result;
            if (n > 123)
                result = Math.Abs((n - 123) * 3);
            else
                result = Math.Abs(123 - n);
            Console.WriteLine(result);
        }
    }
}
