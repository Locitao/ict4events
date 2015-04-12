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
            //SELECT all Reactions where mediaID = 0;
        }

        public List<string> ReturnNewsFeedMessages()
        {
            List<string> NewsFeedMessages = new List<string>();
            foreach (Reaction message in messages)
            {
                NewsFeedMessages.Add(message.Creator.Name +": " + message.Content);
            }
            return NewsFeedMessages;
        }
    }
}
