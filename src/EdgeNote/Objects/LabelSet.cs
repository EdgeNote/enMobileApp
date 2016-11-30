using System;
using System.Collections.Generic;

namespace EdgeNote.Library.Objects
{
    public class LabelSet : AbstractVersionedObject
    {
        public LabelSet()
        {
            Labels = new List<Guid>();
        }

        public string Name { get; set; }

        public List<Guid> Labels { get; set; }
    }
}
