using System;
namespace EdgeNote.Library.Objects
{
    public class Property : AbstractVersionedObject
    {
        public Guid NodeId { get; set; }

        public Guid LabelId { get; set; }

        public string Value { get; set; }
    }
}
