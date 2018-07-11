using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPeriod
{
   public interface ICalcGB : ICalc
    {
        DateTime GetPosibleGril();
        DateTime GetPosibleBoy();
    }
}
