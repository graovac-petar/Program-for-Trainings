using System;

namespace Common
{
    public class UserException : Exception
    {
        public string Message;
        public UserException(string message)
        {
            Message = message;
        }
    }
}
