using System;
using EdgeNote.Library.Objects;

namespace EdgeNote.UI.Daos
{
    public class EdgeDao : AbstractVersionedDao<Edge>
    {
        public EdgeDao(LiteDatabase _db) 
            : base(_db) 
        {
        }

        public override string CollectionName
        {
            get
            {
                return "Edge";
            }
        }

        public override void BuildIndexes()
        {
            
        }
    }
}
