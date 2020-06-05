using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eComApi.Classes
{
    public class QueryParameters
    {
        private const int _maxSize = 100;
        private int _size = 50;
        private int _page = 1;

        public int Page { get { return _page; } set { _page = value; } }
        public int Size
        {
            get
            {
                return _size;
            }
            set
            {
                _size = Math.Min(_maxSize, value);
            }
        }
    }
}
