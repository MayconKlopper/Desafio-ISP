

using System.Collections.Generic;

namespace ISPSystem.DomainEntities
{
    public class Carteira
    {
        public int ID { get; set; }
        public int PerfilID { get; set; }
        public string Composicao { get; set; }
        public string Descricao { get; set; }

        #region Relacionamentos

        public Participante Participante { get; set; }
        public Perfil Perfil { get; set; }
        public ICollection<Rentabilidade> Rentabilidades { get; set; }

        #endregion
    }
}
