using System;
using EdgeNote.Library.Objects;

namespace EdgeNote.UI.Daos
{
    public class LabelDao : AbstractVersionedDao<Label>
    {
        public LabelDao(LiteDatabase _db) 
            : base(_db)
        {
        }

        public override string CollectionName
        {
            get
            {
                return "Label";
            }
        }

        public override void BuildIndexes()
        {
            
        }
    }
}
