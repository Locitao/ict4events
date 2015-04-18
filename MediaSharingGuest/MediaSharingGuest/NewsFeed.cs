using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    public class NewsFeed
    {
        List<Reaction> messages = new List<Reaction>();
        public int MessageDisplayTime { get; set; }

        Select select = new Select();
        List<Reaction> Messages
        {
            get { return messages; }
            set { messages = value; }
        }
        public NewsFeed()
        {

        }

        public void AddMessage(Reaction message)
        {
            Messages.Add(message);
        }

        public void DeleteMessage()
        {

        }
        public void UpdateMessages(Reaction reaction)
        {
            messages.Add(reaction);
        }
    }
}
