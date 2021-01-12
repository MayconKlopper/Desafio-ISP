using ISPSystem.Domain.Storages;
using ISPSystem.DomainEntities.Models.Response;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;

namespace ISPSystem.WebAPI.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]
    [Route("api/carteira")]
    public class CarteiraController : ApiController
    {
        private readonly ICarteiraReadOnlyStorage carteiraReadOnlyStorage;

        public CarteiraController(ICarteiraReadOnlyStorage carteiraReadOnlyStorage)
        {
            this.carteiraReadOnlyStorage = carteiraReadOnlyStorage;
        }

        // GET: api/participante
        public IList<CarteiraDetailedModel> Get()
        {
            IList<CarteiraDetailedModel> modelList = this.carteiraReadOnlyStorage.GetWithRelationShip()
                .Select(carteira => (CarteiraDetailedModel)carteira)
                .ToList();

            return modelList;
        }

        // GET: api/carteira?ID={ID}
        public CarteiraDetailedModel Get(int ID)
        {
            CarteiraDetailedModel model = this.carteiraReadOnlyStorage.GetWithRelationShip(ID);

            return model;
        }

        // GET: api/carteira?ID={ID}
        public IList<RentabilidadeDetailedModel> GetRentabilidade(int carteiraID)
        {
            IList<RentabilidadeDetailedModel> modelList = this.carteiraReadOnlyStorage.GetRentabilidade(carteiraID)
                .Select(rentabilidade => (RentabilidadeDetailedModel)rentabilidade)
                .ToList();

            return modelList;
        }
    }
}
