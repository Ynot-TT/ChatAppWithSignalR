using Ganss.Xss;
using Microsoft.AspNetCore.SignalR;

namespace ChatApplWithSignalR.Hubs
{
    public class ChatHub:Hub
    {

        public async Task SendMessage(string username, string message, DateTime date)
        {
            var sanitizer = new HtmlSanitizer();
            string sanitizedUsername = sanitizer.Sanitize(username);
            string sanitizedMessage = sanitizer.Sanitize(message);
            await Clients.All.SendAsync("ReceiveMessage", sanitizedUsername, sanitizedMessage, date);
        }
    }
}
