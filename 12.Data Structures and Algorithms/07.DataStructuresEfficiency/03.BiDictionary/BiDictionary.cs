namespace _03.BiDictionary
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Wintellect.PowerCollections;

    public class BiDictionary<TKey1, TKey2, TValue> : MultiDictionary<Tuple<TKey1, TKey2>, TValue>
    {
        public BiDictionary(bool allowDuplicates)
            : base(allowDuplicates)
        {
        }

        public ICollection<TValue> this[TKey1 key1, TKey2 key2]
        {
            get { return base[Tuple.Create(key1, key2)]; }
            set { base[Tuple.Create(key1, key2)] = value; }
        }

        public void Add(TKey1 key1, TKey2 key2, TValue value)
        {
            base.Add(Tuple.Create(key1, key2), value);
        }

        public void Remove(TKey1 key1, TKey2 key2, TValue value)
        {
            base.Remove(Tuple.Create(key1, key2), value);
        }

        public bool ContainsKey(TKey1 key1, TKey2 key2)
        {
            return base.ContainsKey(Tuple.Create(key1, key2));
        }

        public List<TValue> FindByFirstKey(TKey1 key1)
        {
            return this.FindAll(x => x.Key.Item1.Equals(key1)).SelectMany(x => x.Value).ToList();
        }

        public List<TValue> FindBySecondKey(TKey2 key2)
        {
           return this.FindAll(x => x.Key.Item2.Equals(key2)).SelectMany(x => x.Value).ToList();
        }

        public List<TValue> FindByBothKeys(TKey1 key1, TKey2 key2)
        {
            return this.FindAll(x => x.Key.Item1.Equals(key1) && x.Key.Item2.Equals(key2)).SelectMany(x => x.Value).ToList();
        }
    }
}
