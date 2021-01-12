using System.Collections.Generic;
using System.Linq;

namespace ISPSystem.DomainEntities.Models.Response
{
    public class CarteiraDetailedModel
    {
        public string Descricao { get; set; }
        public string Composicao { get; set; }
        public IList<RentabilidadeDetailedModel> Rentabilidades { get; set; }

        public static implicit operator CarteiraDetailedModel(Carteira carteira)
        {
            if (carteira == null)
            {
                return null;
            }

            var carteiraDetailedModel = new CarteiraDetailedModel();
            carteiraDetailedModel.Descricao = carteira?.Descricao;
            carteiraDetailedModel.Composicao = carteira?.Composicao;
            carteiraDetailedModel.Rentabilidades = carteira?.Rentabilidades.Select(Rentabilidade => (RentabilidadeDetailedModel)Rentabilidade)
                                                                           .ToList();

            return carteiraDetailedModel;
        }
    }
}
