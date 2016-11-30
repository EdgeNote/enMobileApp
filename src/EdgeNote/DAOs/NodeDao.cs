using System;
using EdgeNote.Library.Objects;
using LiteDB;

namespace EdgeNote.UI.Daos
{
    public class NodeDao : AbstractVersionedDao<Node>
    {
        public NodeDao(LiteDatabase _db)
            : base(_db)
        {
        }

        public override string CollectionName
        {
            get
            {
                return "Node";
            }
        }

        public override void BuildIndexes()
        {

        }
    }
}
