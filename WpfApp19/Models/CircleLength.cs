using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF19.Models
{
    static class CircleLength
    {
        public static double Add(double r) => Math.Round((2 * Math.PI * r), 2);
    }
}