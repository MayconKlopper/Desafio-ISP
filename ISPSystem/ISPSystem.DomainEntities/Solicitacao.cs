

namespace ISPSystem.DomainEntities
{
    public class Solicitacao
    {
        public int ID { get; set; }
        public int ParticipanteID { get; set; }
        public string Descricao { get; set; }
        public int Status { get; set; }
        public int CarteiraID { get; set; }
        public int PerfilID { get; set; }

        #region Relacionamentos

        public Participante Participante { get; set; }

        #endregion
    }
}
