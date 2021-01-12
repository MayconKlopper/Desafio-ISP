using System;
using System.Collections.Generic;
using System.Text;

namespace ISPSystem.DomainEntities.Models.Response
{
    public class SolicitacaoModel
    {
        public string Descricao { get; set; }
        public int? Status { get; set; }

        public static implicit operator SolicitacaoModel(Solicitacao solicitacao)
        {
            if (solicitacao == null)
            {
                return null;
            }

            var solicitacaoModel = new SolicitacaoModel();
            solicitacaoModel.Descricao = solicitacao?.Descricao;
            solicitacaoModel.Status = solicitacao?.Status;

            return solicitacaoModel;
        }
    }
}
