using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication5.Device;
using WebApplication5.Interfeise;

namespace WebApplication5.Device
{
    public class Fridge : Temperature, IOpenClose
    {
        private int max;
        private int min;
        private int temp;
        private bool openclose;

        internal Fridge(bool state, int max, int min, int temp, bool openclose)
            : base(max, min, temp)
        {
            this.temp = temp;
            this.max = max;
            this.min = min;
            this.state = state;
            this.openclose = openclose;
        }

        public bool OpenClose
        {
            get
            {
                return openclose;
            }
            set
            {
                openclose = value;
            }

        }
        public void OpCl()
        {
            openclose = !openclose;
        }

        public override string ToString()
        {
            return "Холодильник - состояние: " ;
        }
    }
}