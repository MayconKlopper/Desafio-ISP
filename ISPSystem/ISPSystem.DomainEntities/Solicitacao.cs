

namespace ISPSystem.DomainEntities
{
    public class Solicitacao
    {
        public int ID { get; set; }
        public int ParticipanteID { get; set; }
        public int Status { get; set; }

        #region Relacionamentos

        public Participante Participante { get; set; }

        #endregion
    }
}
