using Ganss.Xss;
using Microsoft.AspNetCore.SignalR;

namespace ChatApplWithSignalR.Hubs
{
    public class ChatHub:Hub
    {

        public async Task SendMessage(string username, string message, DateTime date)
        {
            var sanitizeMessage = new HtmlSanitizer();
            await Clients.All.SendAsync("ReceiveMessage", username, message, date);
        }
    }
}
