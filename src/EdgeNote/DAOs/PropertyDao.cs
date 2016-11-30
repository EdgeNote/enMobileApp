using System;
using EdgeNote.Library.Objects;
using LiteDB;

namespace EdgeNote.UI.Daos
{
    public class PropertyDao : AbstractVersionedDao<Property>
    {
        public PropertyDao(LiteDatabase _db)
            : base(_db)
        {
        }

        public override string CollectionName
        {
            get
            {
                return "Property";
            }
        }

        public override void BuildIndexes()
        {

        }
    }
}
