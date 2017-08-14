using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MvcEventCalendar.Models
{
    public class Event
    {
        public string Name { get; set; }
        public string StartDate { get; set; }
        public string EndDate { get; set; }
        public string ThemeColor { get; set; }
        public bool IsFullDay { get; set; }
    }
}