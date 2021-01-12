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

        public IList<Carteira> GetWithRelationShip()
        {
            return this.connection.Carteira
                    .Include(carteira => carteira.Rentabilidades)
                    .AsNoTracking()
                    .ToList();
        }

        public Carteira Get(int ID)
        {
            return this.connection.Carteira
                    .AsNoTracking()
                    .FirstOrDefault(carteira => carteira.ID == ID);
        }

        public Carteira GetWithRelationShip(int ID)
        {
            return this.connection.Carteira
                    .Include(carteira => carteira.Rentabilidades)
                    .AsNoTracking()
                    .FirstOrDefault(carteira => carteira.ID == ID);
        }

        public IList<Rentabilidade> GetRentabilidade(int carteiraID)
        {
            return this.connection.Rentabilidade
                    .AsNoTracking()
                    .Where(rentabilidade => rentabilidade.CarteiraID == carteiraID)
                    .ToList();
        }
    }
}
