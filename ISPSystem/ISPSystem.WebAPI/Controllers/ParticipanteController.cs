using ISPSystem.Domain.Services;
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
    [Route("api/participante")]
    public class ParticipanteController : ApiController
    {

        private readonly IParticipanteService participanteService;
        private readonly IParticipanteReadOnlyStorage participanteReadOnlyStorage;

        public ParticipanteController(IParticipanteReadOnlyStorage participanteReadOnlyStorage,
            IParticipanteService participanteService)
        {
            this.participanteReadOnlyStorage = participanteReadOnlyStorage;
            this.participanteService = participanteService;
        }

        // GET: api/participante
        public IList<ParticipanteDetailedModel> Get()
        {
            IList<ParticipanteDetailedModel> modelList = this.participanteReadOnlyStorage.Get()
                .Select(participante => (ParticipanteDetailedModel)participante)
                .ToList();

            return modelList;
        }

        // GET: api/participante?ID=1
        public ParticipanteDetailedModel Get(int ID)
        {
            ParticipanteDetailedModel model = this.participanteReadOnlyStorage.GetWithRelationShip(ID);

            return model;
        }

        // PUT: api/participante/1
        public void Put(int id, [FromBody]string value)
        {

        }
    }
}
