using ISPSystem.DomainEntities;
using System.Collections.Generic;

namespace ISPSystem.Domain.Storages
{
    public interface ICarteiraReadOnlyStorage
    {
        Carteira Get(int ID);
        Carteira GetWithRelationShip(int ID);
        IList<Carteira> Get();
        IList<Carteira> GetWithRelationShip();

        IList<Rentabilidade> GetRentabilidade(int carteiraID);
    }
}
