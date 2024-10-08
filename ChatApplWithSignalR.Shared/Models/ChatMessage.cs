using static System.Runtime.InteropServices.JavaScript.JSType;

namespace ChatApplWithSignalR.Models
{
    public class ChatMessage
    {
        public string Username { get; set; }
        public string Message { get; set; }
        public bool IsSentByUser { get; set; }



    }
    
}
