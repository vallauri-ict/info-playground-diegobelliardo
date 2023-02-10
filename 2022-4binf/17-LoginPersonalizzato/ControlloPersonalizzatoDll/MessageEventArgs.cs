using System;

namespace ControlloPersonalizzatoDll
{
    public class MessageEventArgs : EventArgs
    {
        public string MessageError { get; }
        public MessageEventArgs(string messageError)
        {
            MessageError = messageError;
        }
    }
}