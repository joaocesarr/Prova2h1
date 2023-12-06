using Revisao.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Domain.Interfaces
{
    public interface IMegasenaRepository
    {
        public IEnumerable<DocumentosMega> ObterTodos();
        Task Adicionar(DocumentosMega documentosMega);

        public IEnumerable<DocumentosMega> RegistrarJogo();
        Task Registrar(DocumentosMega documentosMega);

    }
}
