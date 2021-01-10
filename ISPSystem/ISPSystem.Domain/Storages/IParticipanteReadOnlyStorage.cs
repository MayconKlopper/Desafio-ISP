using ISPSystem.DomainEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPSystem.Domain.Storages
{
    public interface IParticipanteReadOnlyStorage
    {
        IList<Solicitacao> GetSolicitacoes(int ID);
    }
}
