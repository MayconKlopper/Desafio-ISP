using ISPSystem.DomainEntities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ISPSystem.Domain.Storages
{
    public interface IParticipanteStorage : IBaseStorage<Participante>
    {
        void Insert(Solicitacao solicitacao);
    }
}
