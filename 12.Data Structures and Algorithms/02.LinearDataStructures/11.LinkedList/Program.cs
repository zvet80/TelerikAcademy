namespace _11.LinkedList
{
    /*11.Implement the data structure linked list.
    Define a class ListItem<T> that has two fields: value (of type T) and NextItem (of type ListItem<T>).
    Define additionally a class LinkedList<T> with a single field FirstElement (of type ListItem<T>).*/

    using System;

    class Program
    {
        static void Main()
        {
            LinkedList<int> list = new LinkedList<int>();
            ListItem<int> second = new ListItem<int>(7, null);
            list.FirstElement = new ListItem<int>(5, second);
            ListItem<int> item = list.FirstElement;

            while (item != null)
            {
                Console.WriteLine(item.Value);
                item = item.NextItem;
            }
        }
    }
}
