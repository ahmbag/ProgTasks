using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task0302
{
    interface INachrichtenEmpfänger
    {
        // Übergabe einer neuen Nachricht
        void EmpfangeNachricht(string nachricht);
    }

}
