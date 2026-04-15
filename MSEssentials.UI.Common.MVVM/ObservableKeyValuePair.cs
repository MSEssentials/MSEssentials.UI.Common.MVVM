using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MSEssentials.UI.Common.MVVM
{
    public class ObservableKeyValuePair<TKey, TValue> : INotifyPropertyChanged
    {
        private TKey _key;
        private TValue _value;

        
        public TKey Key
        {
            get => _key;
            set
            {
                _key = value;
                NotifyPropertyChanged(nameof(Key));
            }
        }
        public TValue Value
        {
            get => _value;
            set
            {
                _value = value;
                NotifyPropertyChanged(nameof(Value));
            }
        }
        

        public ObservableKeyValuePair() : this(default, default)
        { }

        public ObservableKeyValuePair(TKey key, TValue value)
        {
            _key = key;
            _value = value;
        }

        
        private void NotifyPropertyChanged(string name) => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

        
        public event PropertyChangedEventHandler? PropertyChanged;
    }
}
