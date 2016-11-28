using System;
using LiteDB;

namespace EdgeNote.Library.Objects
{
    public abstract class AbstractObject
    {
        [BsonId]
        public Guid Id { get; set; }

        /// <summary>
        /// The date and time the edge was created in db
        /// </summary>
        /// <value>The created on.</value>
        public DateTime CreatedOn { get; set; }

        /// <summary>
        /// UserId of the user that created the record.
        /// </summary>
        /// <value>The created by identifier.</value>
        public Guid CreatedById { get; set; }

        /// <summary>
        /// The date and time the edge was last modified.
        /// </summary>
        /// <value>The modified on.</value>
        public DateTime ModifiedOn { get; set; }

        /// <summary>
        /// UserId of the user that last modified the record.
        /// </summary>
        /// <value>The modified by identifier.</value>
        public Guid ModifiedById { get; set; }

        /// <summary>
        /// Indicates that the record has been deleted.
        /// </summary>
        /// <value><c>true</c> if deleted; otherwise, <c>false</c>.</value>
        public bool Deleted { get; set; }

        /// <summary>
        /// Gets or sets the version GUID.
        /// </summary>
        /// <value>The version GUID.</value>
        public Guid VersionGuid { get; set; }
    }
}
