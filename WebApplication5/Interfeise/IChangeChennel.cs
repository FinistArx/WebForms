using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WebApplication5
{
    public interface IChangeChennel
    {
        int Chennel
        {
            get;
            set;
        }

        void NextChennel();
        void PreviusChennel();
    }
}
