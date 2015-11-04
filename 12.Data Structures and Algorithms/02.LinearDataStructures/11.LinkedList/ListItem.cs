﻿namespace _11.LinkedList
{
    public class ListItem<T>
    {
        public ListItem(T value, ListItem<T> nextItem)
        {
            this.Value = value;
            this.NextItem = nextItem;
        }

        public T Value { get; set; }

        public ListItem<T> NextItem { get; set; }
    }
}
