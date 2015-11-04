namespace _11.LinkedList
{
    using System;
    using System.Collections;

    public class LinkedList<T>
    {
        public LinkedList()
        {
            this.FirstElement = null;
        }

        public ListItem<T> FirstElement { get; set; }
    }
}
