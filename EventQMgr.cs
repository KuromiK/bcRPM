using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsLibrary1
{
    public class EventQMgr
    {
        Event? ev;
        public void suspend() { }
        private void flush() { }
        public EventQMgr ()
        {
            ev = new Event();
        }
    }
}
