using System.Collections.Generic;

namespace ISPSystem.DomainEntities
{
    public class Participante
    {
        public int ID { get; set; }
        public int? CarteiraID { get; set; }
        public int? PerfilID { get; set; }
        public int Idade { get; set; }
        public string Nome { get; set; }

        #region Relacionamentos

        public Carteira Carteira { get; set; }
        public Perfil Perfil { get; set; }
        public ICollection<Solicitacao> Solicitacoes { get; set; }

        #endregion
    }
}
