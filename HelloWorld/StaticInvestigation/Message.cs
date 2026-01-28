using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticInvestigation
{
    class Message
    {
        public string Title {  get; set; }
        public string Text { get; set; }

        public static int count = 0;

        public Message(string title, 
            string text)
        {
            Title = title;
            Text = text;
            count++;
        }
    }
}
