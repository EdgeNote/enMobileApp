using System;
using LiteDB;

namespace EdgeNote.Library.Objects
{
    public class AbstractObject
    {
        [BsonId]
        public Guid Id { get; set; }
    }
}
