using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellMessenger.Messenger
{
    class Message
    {

        public User User { get; set; }
        public string Text { get; set; }
        public DateTime Time { get; set; }

        public Message(string username, string message)
        {
            User = new User() { Name = username };
            Text = message;
            Time = DateTime.Now;
        }
    }
}
