using System.Collections.ObjectModel;
using System.Diagnostics.CodeAnalysis;

namespace MSEssentials.UI.Common.MVVM
{
    public class ObservableDictionary<TKey, TValue> : ObservableCollection<ObservableKeyValuePair<TKey, TValue>>, IDictionary<TKey, TValue>, IEnumerable<ObservableKeyValuePair<TKey, TValue>>
    {
        public ICollection<TKey> Keys => Items.Select(p => p.Key).ToList();
        public ICollection<TValue> Values => Items.Select(p => p.Value).ToList();
        public bool IsReadOnly => false;

        
        public TValue this[TKey key]
        {
            get => !TryGetValue(key, out TValue result) ? throw new ArgumentException("Key not found") : result;
            set
            {
                if (ContainsKey(key))
                {
                    GetKeyValuePairByTheKey(key).Value = value;
                }
                else
                {
                    Add(key, value);
                }
            }
        }

        
        public ObservableDictionary()
        { }

        public ObservableDictionary(IDictionary<TKey, TValue> dictionary)
        {
            foreach (KeyValuePair<TKey, TValue> pair in dictionary)
            {
                Add(pair);
            }
        }

        
        public void Add(KeyValuePair<TKey, TValue> item) => Add(item.Key, item.Value);
        public void Add(TKey key, TValue value)
        {
            if (ContainsKey(key))
            {
                throw new ArgumentException("The dictionary already contains the key");
            }
            Add(new ObservableKeyValuePair<TKey, TValue>(key, value));
        }

        public bool Contains(KeyValuePair<TKey, TValue> item)
        {
            ObservableKeyValuePair<TKey, TValue> pair = GetKeyValuePairByTheKey(item.Key);
            if (Equals(pair, default(ObservableKeyValuePair<TKey, TValue>)))
            {
                return false;
            }
            return Equals(pair.Value, item.Value);
        }

        public bool ContainsKey(TKey key)
        {
            ObservableKeyValuePair<TKey, TValue> pair = ((ObservableCollection<ObservableKeyValuePair<TKey, TValue>>)this).FirstOrDefault((i) => Equals(key, i.Key));

            return !Equals(default(ObservableKeyValuePair<TKey, TValue>), pair);
        }

        public void CopyTo(KeyValuePair<TKey, TValue>[] array, int arrayIndex) => 
            throw new NotImplementedException();

        public bool Remove(KeyValuePair<TKey, TValue> item)
        {
            ObservableKeyValuePair<TKey, TValue> pair = GetKeyValuePairByTheKey(item.Key);
            if (Equals(pair, default(ObservableKeyValuePair<TKey, TValue>)))
            {
                return false;
            }
            if (!Equals(pair.Value, item.Value))
            {
                return false;
            }
            return Remove(pair);
        }
        
        public bool Remove(TKey key)
        {
            List<ObservableKeyValuePair<TKey, TValue>> remove = ((ObservableCollection<ObservableKeyValuePair<TKey, TValue>>)this).Where(pair => Equals(key, pair.Key)).ToList();
            foreach (ObservableKeyValuePair<TKey, TValue> pair in remove)
            {
                Remove(pair);
            }
            return remove.Count > 0;
        }

        public bool TryGetValue(TKey key, [MaybeNullWhen(false)] out TValue value)
        {
            value = default;
            var pair = GetKeyValuePairByTheKey(key);
            if (Equals(pair, default(ObservableKeyValuePair<TKey, TValue>)))
            {
                return false;
            }
            value = pair.Value;
            return true;
        }

        IEnumerator<KeyValuePair<TKey, TValue>> IEnumerable<KeyValuePair<TKey, TValue>>.GetEnumerator() => 
            ((ObservableCollection<ObservableKeyValuePair<TKey, TValue>>)this).Select(i => new KeyValuePair<TKey, TValue>(i.Key, i.Value)).GetEnumerator();

        
        private ObservableKeyValuePair<TKey, TValue> GetKeyValuePairByTheKey(TKey key) => 
            ((ObservableCollection<ObservableKeyValuePair<TKey, TValue>>)this).FirstOrDefault(i => i.Key.Equals(key));
    }
}
