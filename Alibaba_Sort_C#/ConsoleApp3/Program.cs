using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace AlibabaSort
{
    internal class Program
    {

        static void Main(string[] args)
        {
            string[] enter = Console.ReadLine().Split(' ');
            int items = int.Parse(enter[0]);
            int can_take = int.Parse(enter[1]);
            int[] arr = Console.ReadLine().Split(' ').Select(s => int.Parse(s)).ToArray();
            //items = 4 ; can_take = 3  arr == 7


            Console.WriteLine(Gold_Item(can_take, arr));
        }

        static int Gold_Item(int x, int[]z)
        {
            //4 3 2 1
            // 3 = 4 3 2
            int gold = z.OrderByDescending(c  => c).Take(x).Sum(c=> c);
            return gold;
        }
    }
}
