using ChatApplWithSignalR.Models;
using Ganss.Xss;
using Microsoft.AspNetCore.SignalR;

namespace ChatApplWithSignalR.Hubs
{
    public class ChatHub:Hub
    {
        public async Task SendMessage(string username, string message)
        {
            var sanitizer = new HtmlSanitizer();
            //Sanitize username and message to prevent XSS
            string sanitizedUsername = sanitizer.Sanitize(username);
            string sanitizedMessage = sanitizer.Sanitize(message);
             
            //Sends the sanitized message to client except sender
            await Clients.Others.SendAsync("ReceiveMessage", sanitizedUsername, sanitizedMessage);
        }
    }
}
