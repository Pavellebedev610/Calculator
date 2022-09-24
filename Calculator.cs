using System;
using System.Collections.Generic;
using System.Text;

namespace kod
{
    class Calculator
    {
        public decimal Calculate(string expreshion)
        {
            var Numbers = ParsString(expreshion);
            decimal s = 0;
            for (var i = 0; i < Numbers.Length; i++)
            {
                s = s + Numbers[i];
            }
            return s;
        }
        private decimal[] ParsString(string expreshion)
        {
            var g = expreshion.Split("+");
            var resault = new List<decimal>();
            for (var i = 0; i < g.Length; i++)
            {
                if (g[i].Contains("-"))
                {
                    resault.AddRange(ParsStringSigned(g[i]));
                }
                else
                {
                    var peremenaya = decimal.Parse(g[i]);
                    resault.Add(peremenaya);
                }
            }
            return resault.ToArray();
        }

        private decimal[] ParsStringSigned(string expreshion)
        {
            var minus = 1;
            var g = expreshion.Split("-");
            var resault = new List<decimal>();
            for (var i = 0; i < g.Length; i++)
            {
                if (g[i].Length == 0)
                {
                    minus = -1;
                    continue;

                }
                var peremenaya = decimal.Parse(g[i]) * minus;
                resault.Add(peremenaya);
                minus = -1;
            }
            return resault.ToArray();
        }
    }
}
