using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication5.Device;

namespace WebApplication5
{
    public class Boiler : Temperature
    {
        private int max;
        private int min;
        private int temp;

        internal Boiler(bool state, int max, int min, int temp)
            : base(max, min, temp)
           
        {
            this.temp = temp;
            this.max = max;
            this.min = min;
        }


        public override string ToString()
        {

            return "Котел : состояние: " + " температура:" + " " + Temp;
        }
    }
}