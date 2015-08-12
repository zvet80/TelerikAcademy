
namespace _03.RangeExceptions
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        private T start;
        private T end;

        public InvalidRangeException(T start, T end)
        {
            this.Start = start;
            this.End = end;
        }

        public T Start { get; set; }
        public T End { get; set; }

        public override string Message
        {
            get
            {
                return string.Format("The value is out of the range ({0}:{1})", this.Start, this.End);
            }
        }
    }
}
