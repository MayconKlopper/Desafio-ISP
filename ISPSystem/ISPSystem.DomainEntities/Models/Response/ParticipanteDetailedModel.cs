using System.Collections.Generic;
using System.Linq;

namespace ISPSystem.DomainEntities.Models.Response
{
    public class ParticipanteDetailedModel
    {
        public string Nome { get; set; }
        public int Idade { get; set; }
        public string CarteiraComposicao { get; set; }
        public string CarteiraDescricao { get; set; }
        public IList<RentabilidadeDetailedModel> Rentabilidades { get; set; }
        public string Perfil { get; set; }

        public static implicit operator ParticipanteDetailedModel(Participante participante)
        {
            if (participante == null)
            {
                return null;
            }

            var participanteDetailedModel = new ParticipanteDetailedModel();
            participanteDetailedModel.Nome = participante.Nome;
            participanteDetailedModel.Idade = participante.Idade;
            participanteDetailedModel.CarteiraComposicao = participante?.Carteira?.Composicao;
            participanteDetailedModel.CarteiraDescricao = participante?.Carteira?.Descricao;
            participanteDetailedModel.Rentabilidades = participante?.Carteira?.Rentabilidades.Select(Rentabilidade => (RentabilidadeDetailedModel)Rentabilidade)
                                                                                             .ToList();
            participanteDetailedModel.Perfil = participante?.Perfil?.Descricao;

            return participanteDetailedModel;
        }
    }
}
