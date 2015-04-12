using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaSharingGuest
{
    public class NewsFeed
    {
        public int MessageDisplayTime { get; set; }
        List<Reaction> Messages { get; set; }

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
        public void UpdateMessages()
        {
            //SELECT all Reactions where mediaID = 0;
        }

        public List<string> ReturnNewsFeedMessages()
        {
            List<string> NewsFeedMessages = new List<string>();
            foreach (Reaction message in Messages)
            {
                NewsFeedMessages.Add(message.Creator.Name +": " + message.Content);
            }
            return NewsFeedMessages;
        }
    }
}
