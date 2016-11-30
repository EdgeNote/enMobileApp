using System;
using EdgeNote.Library.Objects;
using LiteDB;

namespace EdgeNote.UI.Daos
{
    public class LabelSetDao : AbstractVersionedDao<LabelSet>
    {
        public LabelSetDao(LiteDatabase _db)
            : base(_db)
        {
        }

        public override string CollectionName
        {
            get
            {
                return "LabelSet";
            }
        }

        public override void BuildIndexes()
        {

        }
    }
}
