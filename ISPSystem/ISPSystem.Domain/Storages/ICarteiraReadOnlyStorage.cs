using ISPSystem.DomainEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPSystem.Domain.Storages
{
    public interface ICarteiraReadOnlyStorage
    {
        IList<Carteira> Get();
    }
}
