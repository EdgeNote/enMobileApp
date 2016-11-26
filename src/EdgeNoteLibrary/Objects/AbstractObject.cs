using System;
using LiteDB;

namespace EdgeNote.Library.Objects
{
    public abstract class AbstractObject
    {
        [BsonId]
        public Guid Id { get; set; }
    }
}
