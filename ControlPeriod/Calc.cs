using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ControlPeriod
{
   public class Calc : ICalcGB
    {
        
        private DateTime DateInitPeriod;

        public Calc(DateTime initPreriod)
        {
            this.DateInitPeriod = initPreriod;
        }

        public DateTime GetDateEndPeriod()
        {
            return this.DateInitPeriod.AddDays(GeneralConst.TOTAL_PRERIOD_DAYS);
        }

        public DateTime GetDateEndFreeDays()
        {
            return this.DateInitPeriod.AddDays(GeneralConst.TOTAL_FREE_DAYS);
        }

        public DateTime GetDatePossiblePeriod()
        {
            return this.DateInitPeriod.AddDays(GeneralConst.TOTAL_PRERIOD_DAYS + GeneralConst.TOTAL_DAYS_FOR_NEXT_PERIOD);
        }

        public DateTime GetOvalDate()
        {
            return this.DateInitPeriod.AddDays(GeneralConst.OV_DAY);
        }

        public DateTime GetPosibleGril()
        {
            return this.GetDateEndFreeDays().AddDays(GeneralConst.TOTAL_POSSIBLE_GRIL);
        }

        public DateTime GetPosibleBoy()
        {
            return this.GetOvalDate().AddDays(GeneralConst.TOTAL_POSSIBLE_BOY);
        }
    }
}
