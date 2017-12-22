using System;

namespace BehaviorConverter.Exceptions
{
    public class InvalidBehaviorFileException : Exception
    {
        public InvalidBehaviorFileException(string message)
            : base(message) { }
    }
}
