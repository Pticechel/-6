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
            length = Math.Pow(x1-x2,2)-Math.Pow(y1-y2,2);
            return $"Расстояние от а до b = {length.ToString()} ";
        }
    }
}