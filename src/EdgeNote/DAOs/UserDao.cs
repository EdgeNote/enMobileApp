using System;
using EdgeNote.Library.Objects;

namespace EdgeNote.UI.Daos
{
    public class UserDao : AbstractVersionedDao<User>
    {
        public UserDao(LiteDatabase _db) : base(_db)
        {
        }

        public override string CollectionName
        {
            get
            {
                return "User";
            }
        }

        public override void BuildIndexes()
        {
        }
    }
}
