using ISPSystem.Domain.Storages;
using ISPSystem.DomainEntities;
using ISPSystem.EF.Connections;

using System.Collections.Generic;
using System.Linq;

using Microsoft.EntityFrameworkCore;

namespace ISPSystem.EF.Contexts
{
    public class ParticipanteContext : BaseContext<Participante>, IParticipanteStorage, IParticipanteReadOnlyStorage
    {
        public ParticipanteContext(Connection connection) : base(connection)
        {

        }

        public IList<Solicitacao> GetSolicitacoes(int ID)
        {
            return this.connection.Solicitacao
                    .AsNoTracking()
                    .Where(solicitacao => solicitacao.ParticipanteID == ID)
                    .ToList();
        }

        public void Insert(Solicitacao solicitacao)
        {
            this.connection.Solicitacao.Add(solicitacao);
        }
    }
}
