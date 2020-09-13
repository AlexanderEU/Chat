using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.SignalR;

namespace Chat
{
    public class ChatHub:Hub
    {
        public async Task Send(string message, string userName)
        {
            await Clients.All.SendAsync("Send", message, userName);
        }
    }
}
