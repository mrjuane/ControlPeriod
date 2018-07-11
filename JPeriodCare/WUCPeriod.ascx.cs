using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace PeriodCare
{
    public partial class WUCPeriod : System.Web.UI.UserControl
    {
        Calendar objCalendar = new Calendar();
        ControlPeriod.ICalcGB objCalc = null;
       
        public DateTime objdate
        {
            get => (DateTime)ViewState["date"];
            set
            {
                if (value != null)
                { ViewState["date"] = value; }
                else
                { throw new NotSupportedException(); }
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!Page.IsPostBack)
            {
                this.objdate = DateTime.Now;
            }
            this.objCalc = new ControlPeriod.Calc(this.objdate);

            objCalendar.SelectionChanged += ObjCalendar_SelectionChanged;
            objCalendar.DayRender += ObjCalendar_DayRender;
            this.Controls.Add(objCalendar);
        }
        
        private void ObjCalendar_DayRender(object sender, DayRenderEventArgs e)
        {
            if ((e.Day.Date >= this.objdate.Date) && (e.Day.Date <= objCalc.GetDatePossiblePeriod().Date))
            {
                if ((e.Day.Date <= objCalc.GetDateEndFreeDays().Date) || ((e.Day.Date > objCalc.GetPosibleBoy().Date) && (e.Day.Date <= objCalc.GetDateEndPeriod().Date)))
                {
                    e.Cell.BackColor = System.Drawing.Color.LightGreen;
                }
                else if ((e.Day.Date > objCalc.GetDateEndFreeDays().Date) && (e.Day.Date <= objCalc.GetPosibleGril().Date))
                {
                    e.Cell.BackColor = System.Drawing.Color.LightPink;
                    e.Cell.ForeColor = System.Drawing.Color.Black;
                }
                else if ((e.Day.Date > objCalc.GetOvalDate().Date) && (e.Day.Date <= objCalc.GetPosibleBoy().Date))
                {
                    e.Cell.BackColor = System.Drawing.Color.LightBlue;
                    e.Cell.ForeColor = System.Drawing.Color.Black;
                }
                else if (e.Day.Date == objCalc.GetOvalDate().Date)
                {
                    e.Cell.Text = "Oval Day";
                    e.Cell.BackColor = System.Drawing.Color.Red;
                    e.Cell.ForeColor = System.Drawing.Color.White;
                }
                else if ((e.Day.Date >= objCalc.GetDateEndPeriod().Date) && (e.Day.Date <= objCalc.GetDatePossiblePeriod().Date))
                {
                    e.Cell.BackColor = System.Drawing.Color.LightSalmon;
                    e.Cell.ForeColor = System.Drawing.Color.White;

                }

            }
        }

        private void ObjCalendar_SelectionChanged(object sender, EventArgs e)
        {
            objdate = this.objCalendar.SelectedDate;
            // this.objCalendar.SelectedDate = DateTime.Now;
            this.objCalc = new ControlPeriod.Calc(this.objdate);
            //  this.objCalendar.TemplateControl          // throw new NotImplementedException();
        }
    }
}