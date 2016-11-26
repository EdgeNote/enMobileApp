using System;
using System.Collections.Generic;

namespace EdgeNote.Library.Objects
{
    public class LabelSet : AbstractObject
    {
        public LabelSet()
        {
            Labels = new List<Guid>();
        }

        public string Name { get; set; }

        public List<Guid> Labels { get; set; }
    }
}
