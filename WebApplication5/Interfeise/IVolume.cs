using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication5.Interfeise
{
    interface IVolume
    {
        int Volume
        {
            get;
            set;
        }

        void DecreaseVolume();
        void IncreaseVolume();

    }
}
