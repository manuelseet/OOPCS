using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPCS_Revision
{
class Email: Item, ISyncable
{
    private string title;
    private string content;
    private string from;

    public Email(string title, string content, string from)
    {
        this.title = title;
        this.content = content;
        this.from = from;
    }

    public string GetSyncString()
    {
            string syncstr = $"EM*{id}*{title}*{from}*{content}";
        return syncstr;
    }
}
}
