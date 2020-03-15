using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using SQLite;

namespace SemensHelperCore
{
    [Table("Notes")]
    public class Notes
    {
        [Column("text")]
        public string text { get; set; }

        [Column("StartDate")]

        // The actual column definition, as seen in SQLite
        public string StartDate_raw { get; set; }

        [PrimaryKey, Column("guid")]
        public string guid
        { get; set; }

        public Notes()
        {

        }
        public Notes(string text)
        {
            this.text = text;
            this.guid = GuidGenerator.generete_guid();
            this.StartDate_raw = DateTime.Now.ToString();
        }
    }
}
