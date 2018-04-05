using System;

namespace TempUnit_convert
{
    class Program
    {
        static void Main(string[] args)
        {
            Temp tmp1 = new Temp();
            new CTemp(tmp1);
            new KTemp(tmp1);
            Console.WriteLine("First change : 212");
            tmp1.STATE = 212;
            Console.WriteLine("Second change : 230");
            tmp1.STATE = 230;
            Console.ReadKey();
        }
    }
}