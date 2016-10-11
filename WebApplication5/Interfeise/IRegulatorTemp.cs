using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication5.Interfeise
{
    public interface IRegulatorTemp
    {

        int Temp
        {
            get;
            set;
        }

        void IncreaseTemp();

        void DecreaseTemp();
    }
}
