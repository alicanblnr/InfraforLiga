using System;

namespace LigaCore.Models
{
    [Serializable]
    public class Message
    {
        public string Value { get; }

        public Message(string value)
        {
            Value = value;
        }
    }
}
