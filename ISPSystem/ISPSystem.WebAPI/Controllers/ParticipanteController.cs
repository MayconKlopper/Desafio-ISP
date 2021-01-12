using ISPSystem.Domain.Services;
using ISPSystem.Domain.Storages;
using ISPSystem.DomainEntities.Models.Request;
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

        // GET: api/participante/getSolicitacao?participanteID=1
        [Route("api/participante/getSolicitacao")]
        [HttpGet]
        public IList<SolicitacaoModel> GetSolicitacao(int participanteID)
        {
            IList<SolicitacaoModel> modelList = this.participanteReadOnlyStorage.GetSolicitacoes(participanteID)
                                                    .Select(solicitacao => (SolicitacaoModel)solicitacao)
                                                    .ToList();

            return modelList;
        }

        // POST: api/participante/CalculatePerfil
        [Route("api/participante/calculatePerfil")]
        [HttpPost()]
        public PerfilDetailedModel CalculatePerfil([FromBody]int pontuation)
        {
            PerfilDetailedModel perfil = this.participanteReadOnlyStorage.GetPerfilWithRelationShip(pontuation);

            return perfil;
        }

        // POST: api/participante/CreateSolicitacao
        [Route("api/participante/createSolicitacao")]
        [HttpPost()]
        public HttpResponseMessage CreateSolicitacao(CreateSolicitacaoModel createSolicitacaoModel)
        {
            this.participanteService.CreateSolicitacao(createSolicitacaoModel);

            return new HttpResponseMessage(HttpStatusCode.Created);
        }
    }
}
