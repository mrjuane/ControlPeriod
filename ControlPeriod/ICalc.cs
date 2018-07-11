using System;

namespace ControlPeriod
{
    public interface ICalc
    {
        DateTime GetDateEndFreeDays();
        DateTime GetDateEndPeriod();
        DateTime GetDatePossiblePeriod();
        DateTime GetOvalDate();
    }
}