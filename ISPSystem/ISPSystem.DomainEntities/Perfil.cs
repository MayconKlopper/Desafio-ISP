

namespace ISPSystem.DomainEntities
{
    public class Perfil
    {
        public int ID { get; set; }
        public string Descricao { get; set; }
        public int Pontuacao { get; set; }

        #region Relacionamentos

        public Participante Participante { get; set; }
        public Carteira Carteira { get; set; }

        #endregion
    }
}
