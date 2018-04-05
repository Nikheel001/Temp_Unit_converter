using System;

namespace TempUnit_convert
{
    class KTemp : Temp_list
    {
        public KTemp(Temp x):base()
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
            double k = f+273.15;
            Console.WriteLine("F To K : " + k);
        }
    }
}