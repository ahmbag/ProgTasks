using System;

namespace Task17A
{
    internal class MyLinkedQueue
    {
        private Entry _head;
        private Entry _tail;

        public Entry GetEntry() => _head;
        public Entry GetTail() => _tail;

        public void SetHead(Entry entry) => _head = entry;
        public void SetTail(Entry entry) => _tail = entry;

        public bool IsEmpty() => _head == null && _tail == null;
        public void Enqueue(Entry entry) {
            if (_head == null)
            {
                //Schlange leer, neuer entry ist erster und letzter 
                SetHead(entry);
                SetTail(entry);
                return;
            }
            //Alter letzter bekommt als next neuen entry, neuer entry wird letzter
            _tail.SetNext(entry);
            SetTail(entry);
        }

        public void Print()
        {
            if (IsEmpty()) 
            { 
                Console.WriteLine("Warteschlange ist leer"); 
                return; 
            }

            //springe vom head über alle nächsten, bis kein nächster vorhanden ist
            Entry entry = _head;
            int c = 1;
            while (entry != null)
            {
                Console.WriteLine("{0}. {1}", c, entry.GetName());
                entry = entry.GetNext();
                c++;
            }
        }

        public void Dequeue()
        {
            if (IsEmpty()) {
                Console.WriteLine("Warteschlange ist leer");
                return;
            }
            
            //head wird durch seinen nächsten ersetzt, und wenn sein nächster auch null ist, dann ist _tail auch null
            Console.WriteLine("{0}: Anliegen wurde bearbeitet und aus der Warteschlange entfernt", _head.GetName());
            SetHead(_head.GetNext());
            if (_head == null) SetTail(null);
        }
    }
}
