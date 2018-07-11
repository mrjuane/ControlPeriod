using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ControlPeriod;
namespace TestPeriodCalc
{
    [TestFixture]
    public class TestClass
    {
        ICalc objCalc = new Calc(DateTime.Now);
        [Test]
        public void TestMethod()
        {
            // TODO: Add your test code here
            Assert.Pass("Your first passing test");
        }
        [Test]
        public void TestGetDateEndPeriod()
        {
          Assert.True(  objCalc.GetDateEndPeriod().Date == DateTime.Now.AddDays(GeneralConst.TOTAL_PRERIOD_DAYS).Date);
        }

        [Test]
        public void GetDateEndFreeDays()
        {
            Assert.True(objCalc.GetDateEndFreeDays().Date == DateTime.Now.AddDays(GeneralConst.TOTAL_FREE_DAYS).Date);
        }
        [Test]
        public void GetDatePossiblePeriod()
        {
            Assert.True(objCalc.GetDatePossiblePeriod().Date 
                == 
                DateTime.Now.AddDays(GeneralConst.TOTAL_PRERIOD_DAYS + GeneralConst.TOTAL_DAYS_FOR_NEXT_PERIOD).Date
                );
        }

    }
}
