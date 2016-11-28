using System;
using LiteDB;
using EdgeNote.Library.Objects;
using System.Collections.Generic;
using System.Linq;

namespace EdgeNote.Library.Daos
{
    public abstract class AbstractDao<T> : IDisposable where T : AbstractObject, new()
    {
        private LiteDatabase m_Database;
        protected LiteCollection<T> m_Collection;

        public abstract string CollectionName { get; }

        public abstract void BuildIndexes();

        protected AbstractDao(LiteDatabase _database)
        {
            m_Database = _database;

            BuildCollection();
        }

        private void BuildCollection()
        {
            m_Collection = m_Database.GetCollection<T>(CollectionName);
            BuildIndexes();
        }

        private void Insert(T _item)
        {
            m_Collection.Insert(_item);
        }

        private void Update(T _item)
        {
            m_Collection.Update(_item);
        }

        /// <summary>
        /// Persists then publishes
        /// </summary>
        /// <param name="_item">Item.</param>
        public void Persist(Guid _userId, T _item)
        {
            DateTime now = DateTime.Now;

            if (_item.Id.Equals(Guid.Empty))
            {
                throw new ArgumentException("Empty Guid not allowed");
            }

            T existing = Get(_item.Id);
            _item.VersionGuid = Guid.NewGuid();

            if (existing == null)
            {
                _item.CreatedById = _userId;
                _item.CreatedOn = now;
                _item.ModifiedById = _userId;
                _item.ModifiedOn = now;

                Insert(_item);
            } else {
                _item.ModifiedById = _userId;
                _item.ModifiedOn = now;

                Update(_item);
            }
        }

        /// <summary>
        /// This method bipasses publishing
        /// </summary>
        /// <param name="_item">Item.</param>
        public void PersistDirect(T _item)
        {
            if (_item.Id.Equals(Guid.Empty))
            {
                throw new ArgumentException("Empty Guid not allowed");
            }

            T existing = Get(_item.Id);

            if (existing == null)
            {
                Insert(_item);
            } else {
                Update(_item);
            }
        }

        public T Get(Guid _id)
        {
            Query query = Query.EQ("_id", _id);
            return m_Collection.FindOne(query);
        }

        public List<T> GetAll()
        {
            IEnumerable<T> items = m_Collection.FindAll();
            return items.ToList();
        }

        public void Delete(Guid _userId, Guid _id)
        {
            T item = Get(_id);

            if (item != null
                && !item.Deleted)
            {
                item.Deleted = true;
                item.ModifiedOn = DateTime.UtcNow;
                item.ModifiedById = _userId;

                Update(item);
            }
        }

        public void Dispose()
        {
            m_Collection = null;
            m_Database = null;
        }

        protected List<T> GetChildren(Guid _parentGuid)
        {
            Query query = Query.EQ("ParentId", _parentGuid);
            return m_Collection.Find(query).ToList();
        }
    }
}

