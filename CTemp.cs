using System;

namespace TempUnit_convert
{
    class CTemp : Temp_list
    {
        public CTemp(Temp x):base()
        {
            _temp = x;
            _temp.attach(this);
        }
        public override void update()
        {
            int f = _temp.STATE;
            f -= 32;
            f *= 5;
            f /= 9;
            Console.WriteLine("F To C : "+f);
        }
    }
}