using System.Collections.Generic;

namespace TempUnit_convert
{
    class Temp
    {
        private List<Temp_list> abc = new List<Temp_list>();
        private int state;
        public int STATE{ get { return state; } set { state = value; notifyallabc(); }  }

        public void attach(Temp_list xyz)
        {
            abc.Add(xyz);
        }

        public void notifyallabc()
        {
            foreach (var item in abc)
            {
                item.update();
            }
        }
    }
}