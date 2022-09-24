using System;

namespace kod
{
    class Program
    {
        static void Main(string[] args)
        {
            var calculate = new Calculator();
            var resault = calculate.Calculate("-21+11");
            Console.WriteLine(resault);
        }
    }
}
