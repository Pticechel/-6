using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Runtime.Serialization.Formatters;

namespace lab6
{
    class Graf
    {
        private double x1, x2, y2, y1, length;
        public void Load()
        {
            x1 = Convert.ToDouble(Console.ReadLine());
            y1 = Convert.ToDouble(Console.ReadLine());
            x2 = Convert.ToDouble(Console.ReadLine());
            y2 = Convert.ToDouble(Console.ReadLine());
        }

        public override string ToString()
        {
            length = Math.Abs(Math.Pow(x2 - x1, 2) - Math.Pow(y2 - y1, 2));
            return $"Расстояние от а до b = {length.ToString()} ";
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
#if !DEBUG
            TextWriter save_out = Console.Out;
            TextReader save_in = Console.In;
            var new_out = new StreamWriter(@"output.txt");
            var new_in = new StreamReader(@"input.txt");
            Console.SetOut(new_out);
            Console.SetIn(new_in);
#endif

            Graf x = new Graf();

            x.Load();
            Console.WriteLine(x.ToString());

#if !DEBUG
            Console.SetOut(save_out);
            new_out.Close();
            Console.SetIn(save_in);
            new_in.Close();
#else
            Console.ReadKey();
#endif
        }

    }
}