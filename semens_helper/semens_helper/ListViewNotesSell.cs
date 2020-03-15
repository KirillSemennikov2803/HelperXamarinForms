using System;
using System.Collections.Generic;
using System.Text;

namespace semens_helper
{
    class ListViewNotesSell
    {
        public string title{ get; set; }
        public string subtitle { get; set; }
        public ListViewNotesSell(string title, string subtitle)
        {
            this.title = title;
            this.subtitle = subtitle;
        }
    }
}
