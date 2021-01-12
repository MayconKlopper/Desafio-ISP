

namespace ISPSystem.DomainEntities.Models.Request
{
    public class CreateSolicitacaoModel
    {
        public string newPerfil { get; set; }
        public int newPerfilID { get; set; }
        public string newCarteira { get; set; }
        public int newCarteiraID { get; set; }
        public int participanteID { get; set; }
    }
}
