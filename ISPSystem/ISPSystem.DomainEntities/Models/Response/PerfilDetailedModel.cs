using System.Collections.Generic;
using System.Linq;

namespace ISPSystem.DomainEntities.Models.Response
{
    public class PerfilDetailedModel
    {
        public int? ID { get; set; }
        public string Descricao { get; set; }
        public IList<CarteiraDetailedModel> Carteiras { get; set; }

        public static implicit operator PerfilDetailedModel(Perfil perfil)
        {
            if (perfil == null)
            {
                return null;
            }

            var perfilDetailedModel = new PerfilDetailedModel();
            perfilDetailedModel.ID = perfil?.ID;
            perfilDetailedModel.Descricao = perfil?.Descricao;
            perfilDetailedModel.Carteiras = perfil?.Carteiras.Select(carteira => (CarteiraDetailedModel)carteira)
                                                             .ToList();

            return perfilDetailedModel;
        }
    }
}
