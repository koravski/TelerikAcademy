namespace Problem03RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        // Constant
        private const string ErrorMessage = "The value is out of range.";

        // Constructor
        public InvalidRangeException(T start, T end)
            : base(ErrorMessage)
        {
            this.Start = start;
            this.End = end;
        }

        // Properties
        public T Start { get; private set; }

        public T End { get; private set; } 
    }
}