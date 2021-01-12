

namespace ISPSystem.DomainEntities.Models.Response
{
    public class RentabilidadeDetailedModel
    {
        public int? Ano { get; set; }
        public string Mes { get; set; }
        public decimal? Porcentagem { get; set; }

        public static implicit operator RentabilidadeDetailedModel(Rentabilidade rentabilidade)
        {
            if (rentabilidade == null)
            {
                return null;
            }

            var rentabilidadeDetailedModel = new RentabilidadeDetailedModel();
            rentabilidadeDetailedModel.Ano = rentabilidade?.Ano;
            rentabilidadeDetailedModel.Mes = rentabilidade?.Mes;
            rentabilidadeDetailedModel.Porcentagem = rentabilidade?.Porcentagem;

            return rentabilidadeDetailedModel;
        }
    }
}
