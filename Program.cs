using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Snake
{
    class Program
    {
        static void Main(string[] args)
        {
            Point p1 = new Point() { x = 1, y = 3, sym = '*' };
            p1.Draw();

            Point p2 = new Point() { x = 4, y = 5, sym = '#' };
            p2.Draw();

            Console.ReadLine();
        }
    }
}
