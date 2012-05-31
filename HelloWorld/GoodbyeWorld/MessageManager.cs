using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace GoodbyeWorld
{
    public class MessageManager
    {
        public string Message { get; set; }
        
        static void Main(string[] args)
        {
            var p = new MessageManager();
            p.Message = "Hello cruel world.";
        }

        public void Say(string message)
        {
            if (string.IsNullOrEmpty(message))
                return;
            Message = message;
        }

        public string Transform()
        {
            return Char.ToUpper(Message[0]).ToString() + Message.Substring(1).ToLower();
        }
    }
}