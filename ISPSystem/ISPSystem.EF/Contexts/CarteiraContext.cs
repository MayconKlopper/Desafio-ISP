using ISPSystem.Domain.Storages;
using ISPSystem.DomainEntities;
using ISPSystem.EF.Connections;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ISPSystem.EF.Contexts
{
    public class CarteiraContext : BaseContext<Carteira>, ICarteiraReadOnlyStorage
    {
        public CarteiraContext(Connection connection) : base(connection)
        {

        }

        public IList<Carteira> Get()
        {
            return this.connection.Carteira
                    .AsNoTracking()
                    .ToList();
        }
    }
}
