using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Revision
{
    class Event: Item, ISyncable
    {
        private string title;
        private string date;
        public Event(string title, DateTime date)
        {
            this.title = title;
            this.date = date.ToString("dd/mm/yy, HH:MM");
        }

        public string GetSyncString()
        {
            return $"CO*{id}*{title}*{date}";
        }
    }
}
