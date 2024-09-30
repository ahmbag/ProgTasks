namespace Task17A
{
    internal class Entry
    {
        private string _name;
        private Entry _next;

        public Entry(string name, Entry next = null)
        {
            _name = name;
            _next = next;
        }

        public string GetName() => _name;
        public Entry GetNext() => _next;

        public void SetNext(Entry e) { _next = e; }
    }
}
