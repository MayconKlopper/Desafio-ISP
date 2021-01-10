

namespace ISPSystem.DomainEntities
{
    public class Rentabilidade
    {
        public int ID { get; set; }
        public int CarteiraID { get; set; }
        public int Ano { get; set; }
        public string Mes { get; set; }

        #region Relacionamentos

        public Carteira Carteira { get; set; }

        #endregion
    }
}
