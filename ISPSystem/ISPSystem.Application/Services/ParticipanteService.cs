using ISPSystem.Domain.Services;
using ISPSystem.Domain.Storages;
using ISPSystem.DomainEntities;
using ISPSystem.DomainEntities.Enums;
using ISPSystem.DomainEntities.Models.Request;
using System;
using System.Linq;

namespace ISPSystem.Application.Services
{
    public class ParticipanteService : IParticipanteService
    {
        private readonly IParticipanteReadOnlyStorage participanteReadOnlyStorage;
        private readonly IParticipanteStorage participanteStorage;

        public ParticipanteService(IParticipanteReadOnlyStorage participanteReadOnlyStorage,
            IParticipanteStorage participanteStorage)
        {
            this.participanteReadOnlyStorage = participanteReadOnlyStorage;
            this.participanteStorage = participanteStorage;
        }

        public void CreateSolicitacao(CreateSolicitacaoModel createSolicitacaoModel)
        {
            var newSolicitacao = new Solicitacao();
            newSolicitacao.ParticipanteID = createSolicitacaoModel.participanteID;
            newSolicitacao.PerfilID = createSolicitacaoModel.newPerfilID;
            newSolicitacao.CarteiraID = createSolicitacaoModel.newCarteiraID;
            newSolicitacao.Status = (int)StatusEnum.pendente;
            newSolicitacao.Descricao = $"Solicitação de alteração de Perfil para {createSolicitacaoModel.newPerfil} e Carteira para {createSolicitacaoModel.newCarteira}";

            this.participanteStorage.Insert(newSolicitacao);
            this.participanteStorage.SaveChanges();
        }

        public void UpdatePerfil(Participante participante)
        {
            var solicitacaoList = this.participanteReadOnlyStorage.GetSolicitacoes(participante.ID);
            var solicitacaoAprovada = solicitacaoList.OrderByDescending(solicitacao => solicitacao.ID)
                                        .FirstOrDefault(solicitacao => solicitacao.Status == (int)StatusEnum.aprovada);

            participante.CarteiraID = solicitacaoAprovada.CarteiraID;
            participante.PerfilID = solicitacaoAprovada.PerfilID;
            this.participanteStorage.Update(participante, a => a.CarteiraID, b => b.PerfilID);
            this.participanteStorage.SaveChanges();
        }
    }
}
