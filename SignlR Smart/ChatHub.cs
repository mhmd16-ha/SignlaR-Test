using Microsoft.AspNet.SignalR;
using Microsoft.AspNet.SignalR.Hubs;
using SignlR_Smart.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SignlR_Smart
{
    [HubName("chat")]
    public class ChatHub : Hub
    {
        
            public void sendMessage(Message m)
            {
            //db save
            Clients.All.newMessage(m);

            Chat db = new Chat();
            //Message message = new Message
            //{
            //    name = name,
            //    message = mess,
            //    date = DateTime.Now
            //};
            //db.Messages.Add(message);
            m.date = DateTime.Now;
            db.Messages.Add(m);
            db.SaveChanges();
            }
        public void joinMember(string gname,string name)
        {
            Groups.Add(Context.ConnectionId, gname);
            Clients.OthersInGroup(gname).newMember(name, gname);
        }
        public void sendGroup(string gname, string message, string name)
        {
            //save db

            Clients.Group(gname).group(name, message,gname);
        }

    }
}