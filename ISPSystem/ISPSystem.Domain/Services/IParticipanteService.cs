using ISPSystem.DomainEntities;
using ISPSystem.DomainEntities.Models.Request;

namespace ISPSystem.Domain.Services
{
    public interface IParticipanteService
    {
        void CreateSolicitacao(CreateSolicitacaoModel createSolicitacaoModel);
        void UpdatePerfil(Participante participante);
    }
}
