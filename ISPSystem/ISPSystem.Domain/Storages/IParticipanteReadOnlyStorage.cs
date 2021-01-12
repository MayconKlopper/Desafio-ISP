using ISPSystem.DomainEntities;
using System.Collections.Generic;

namespace ISPSystem.Domain.Storages
{
    public interface IParticipanteReadOnlyStorage
    {
        IList<Participante> Get();
        Participante Get(int ID);
        Participante GetWithRelationShip(int ID);
        IList<Solicitacao> GetSolicitacoes(int participanteID);
    }
}
