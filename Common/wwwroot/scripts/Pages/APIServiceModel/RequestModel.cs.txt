using System.Collections.Generic;

namespace BlazorDemos.Model
{
    public class RequestModel
    {
        public string model { get; set; }
        public List<MessageModel> messages { get; set; }
        public int maxtoken { get; set; }
    }

    public class MessageModel
    {
        public string role { get; set; }
        public string content { get; set; }
    }
}
