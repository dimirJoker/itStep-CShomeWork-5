namespace HomeWork5
{
    internal class MyList<T>
    {
        private T[] _array = new T[0]; // create
        public T Read(int index) // read method
        {
            return _array[index];
        }
        public T this[int index] // read access
        {
            get
            {
                return _array[index];
            }
        }
        public void Add(T value) // add
        {
            T[] tmp = new T[_array.Length + 1];

            for (var i = 0; i < _array.Length; i++)
            {
                tmp[i] = _array[i];
            }
            tmp[tmp.Length - 1] = value;
            _array = tmp;
        }
        public void Shuffle() // shuffle
        {
            var random = new System.Random();

            for (var i = 0; i < _array.Length; i++)
            {
                var rInd = random.Next(_array.Length);
                (_array[i], _array[rInd]) = (_array[rInd], _array[i]);
            }
        } 
        public void Remove(int index) // delete
        {
            T[] tmp = new T[_array.Length - 1];

            for (var i = 0; i < _array.Length; i++)
            {
                if (i != index)
                {
                    tmp[i] = _array[i];
                }
            }
            _array = tmp;
        }
    }
}