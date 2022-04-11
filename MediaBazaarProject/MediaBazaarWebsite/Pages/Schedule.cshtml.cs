using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace MediaBazaarWebsite.Pages
{
    public class ScheduleModel : PageModel
    {

       
        public Dictionary<string, List<DateTime>> daysPerWeekDay = new Dictionary<string, List<DateTime>>();
        public void OnGet()
        {
             List<DateTime> month = new List<DateTime>();

            int year = DateTime.Today.Year;
      
            int daysInMonth = DateTime.DaysInMonth(year, DateTime.Today.Month);
            for (int i = 1; i <= daysInMonth; i++)
            {
                DateTime day = new DateTime(DateTime.Today.Year, DateTime.Today.Month, i);
                month.Add(day);
            }

            daysPerWeekDay.Add("Monday", new List<DateTime>());
            daysPerWeekDay.Add("Tuesday", new List<DateTime>());
            daysPerWeekDay.Add("Wednesday", new List<DateTime>());
            daysPerWeekDay.Add("Thursday", new List<DateTime>());
            daysPerWeekDay.Add("Friday", new List<DateTime>());
            daysPerWeekDay.Add("Saturday", new List<DateTime>());
            daysPerWeekDay.Add("Sunday", new List<DateTime>());


            foreach (DateTime day in month)
            {
                string weekDay = day.ToString("dddd");
                if (daysPerWeekDay.ContainsKey(weekDay))
                {
                    daysPerWeekDay[weekDay].Add(day);
                }
            }

            //daysPerWeekDay = daysPerWeekDay.OrderBy(x => x.Key).ToDictionary(x => x.Key, x => x.Value);

        }
    }
}
