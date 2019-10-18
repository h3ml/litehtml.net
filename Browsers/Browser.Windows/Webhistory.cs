using System.Collections.Generic;

namespace Browser.Windows
{
    public class Webhistory
    {
        List<string> _items = new List<string>();
        int _current_item = 0;

        public int length => _items.Count;
        public string this[int index] => index < _items.Count ? _items[index] : null;

        public void url_opened(string url)
        {
            if (_items.Count != 0)
            {
                if (_current_item != _items.Count - 1)
                {
                    if (_current_item > 0 && _items[_current_item - 1] == url)
                        _current_item--;
                    else if (_current_item < _items.Count - 1 && _items[_current_item + 1] == url)
                        _current_item++;
                    else
                    {
                        //_items.RemoveRange(_current_item + 1, 999);
                        _items.Add(url);
                        _current_item = _items.Count - 1;
                    }
                }
                else
                {
                    if (_current_item > 0 && _items[_current_item - 1] == url)
                        _current_item--;
                    else
                    {
                        _items.Add(url);
                        _current_item = _items.Count - 1;
                    }
                }
            }
            else
            {
                _items.Add(url);
                _current_item = _items.Count - 1;
            }
        }

        public bool back(out string url)
        {
            url = null;
            if (_items.Count == 0) return false;
            if (_current_item > 0)
            {
                url = _items[_current_item - 1];
                return true;
            }
            return false;
        }

        public bool forward(out string url)
        {
            url = null;
            if (_items.Count == 0) return false;
            if (_current_item < _items.Count - 1)
            {
                url = _items[_current_item + 1];
                return true;
            }
            return false;
        }
    }
}
