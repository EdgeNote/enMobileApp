using System;
using System.Collections.Generic;

namespace EdgeNote.Library.Objects
{
    public class SyncSet
    {
        public SyncSet()
        {
            Items = new List<SyncItem>();
        }

        public Guid UserId { get; set; }

        public DateTime SyncDateTime { get; set; }

        public List<SyncItem> Items { get; set; }
    }
}
