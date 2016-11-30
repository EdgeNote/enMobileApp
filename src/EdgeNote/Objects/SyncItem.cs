using System;
namespace EdgeNote.Library.Objects
{
    public class SyncItem
    {
        public string ObjectType { get; set; }

        public Guid ItemId { get; set; }

        public Guid VersionGuid { get; set; }

        public string SerializedObject { get; set; }
    }
}
