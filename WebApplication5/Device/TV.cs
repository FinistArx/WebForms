using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using WebApplication5.Device;
using WebApplication5.Interfeise;

namespace WebApplication5
{
    public class TV : AbstractDevice, IVolume, IChangeChennel
    {
        private int chennel;
        private int volume;

        public TV(bool state, int chennel, int volume)
        {
            this.volume = volume;
            this.chennel = chennel;
        }
                
        public int Chennel
        {
            get
            {
                return chennel;
            }
            set
            {
                chennel = value;
            }
        }
       
        public int Volume
        {
            get
            {
                return volume;
            }
            set
            {
                volume = value;
            }
        }

        public void NextChennel()
        {
            if (Chennel < 200)
            {
                Chennel++;
            }
        }

        public void PreviusChennel()
        {
            if (Chennel > 0)
            {
                Chennel--;
            }
        }

        public void DecreaseVolume()
        {
            if (Volume > 0)
            {
                Volume--;
            }
        }

        public void IncreaseVolume()
        {
            if (Volume < 100)
            {
                Volume++;
            }
        }
        
        public override string ToString()
        {

            return "Телевизор - состояние: ";
        }
    }
}