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
        
    }
}