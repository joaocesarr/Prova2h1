using Revisao.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Interfaces
{
    public interface IMegasenaService
    {
       public IEnumerable<MegaViewModel> ObterTodos();
       Task Adicionar(MegaSenaViewModel MegaSenaViewModel);
        public IEnumerable<MegaViewModel> RegistrarJogo();
        Task Registrar(MegaSenaViewModel MegaSenaViewModel);
    }
}


