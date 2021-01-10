using ISPSystem.Domain.Storages;
using ISPSystem.EF.Connections;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Text;

namespace ISPSystem.EF.Contexts
{
    public class BaseContext<Entity> : IBaseStorage<Entity>
        where Entity : class
    {
        protected readonly Connection connection;

        public BaseContext(Connection connection)
        {
            this.connection = connection;
        }

        public void Insert(Entity obj)
        {
            this.Insert(obj);
        }

        public void Delete(Entity obj)
        {
            this.connection.Remove(obj);
        }

        public void Update(Entity item, params Expression<Func<Entity, object>>[] expressions)
        {
            var x = this.connection.Attach(item);
            foreach (var expression in expressions)
            {
                x.Property(expression).IsModified = true;
            }
        }

        public int SaveChanges()
        {
            return this.connection.SaveChanges();
        }
    }
}
