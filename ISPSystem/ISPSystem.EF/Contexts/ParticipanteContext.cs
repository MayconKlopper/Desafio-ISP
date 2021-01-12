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

        public IList<Participante> Get()
        {
            return this.connection.Participante
                       .AsNoTracking()
                       .ToList();
        }

        public Participante Get(int ID)
        {
            return this.connection.Participante
                       .AsNoTracking()
                       .FirstOrDefault(participante => participante.ID == ID);
        }

        public Participante GetWithRelationShip(int ID)
        {
            return this.connection.Participante
                       .Include(participante => participante.Carteira)
                        .ThenInclude(carteira => carteira.Rentabilidades)
                       .Include(participante => participante.Perfil)
                       .AsNoTracking()
                       .FirstOrDefault(participante => participante.ID == ID);
        }

        public IList<Solicitacao> GetSolicitacoes(int participanteID)
        {
            return this.connection.Solicitacao
                    .AsNoTracking()
                    .Where(solicitacao => solicitacao.ParticipanteID == participanteID)
                    .ToList();
        }

        public void Insert(Solicitacao solicitacao)
        {
            this.connection.Solicitacao.Add(solicitacao);
        }

        public IList<Questao> GetQuestionario()
        {
            return this.connection.Questao
                    .AsNoTracking()
                    .ToList();
        }

        public Perfil GetPerfilWithRelationShip(int pontuation)
        {
            return this.connection.Perfil
                    .Include(perfil => perfil.Carteiras)
                        .ThenInclude(carteira => carteira.Rentabilidades)
                    .AsNoTracking()
                    .OrderByDescending(perfil => perfil.Pontuacao)
                    .FirstOrDefault(perfil => pontuation >= perfil.Pontuacao);
        }
    }
}
