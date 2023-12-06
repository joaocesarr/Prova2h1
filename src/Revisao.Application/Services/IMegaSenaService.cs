using AutoMapper;
using Revisao.Domain.ViewModels;
using Revisao.Application.Interfaces;
using Revisao.Application.ViewModels;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.Services
{
    public class MegaSenaService : IMegaSenaRepository
    {
        private readonly MegaSenaService _megaRepository;
        private IMapper _mapper;

        public MegaSenaService(IMegaRepository cartaRepository, IMapper mapper)
        {
            _megaRepository = cartaRepository;
            _mapper = mapper;
        }
        public async Task Adicionar(MegaSenaViewModel MegaViewModel)
        {
            var novaCarta = _mapper.Map<DocumentosMega>(MegaViewModel);
            _megaRepository.Adicionar(MegaSena);
        }
        public IEnumerable<MegaViewModel> ObterTodos()
        {
            return _mapper.Map<IEnumerable<MegaViewModel>>(_megaRepository.ObterTodos());
        }
        public IEnumerable<MegaViewModel> RegistrarJogo()
        {
            return _mapper.Map<IEnumerable<MegaViewModel>>(_megaRepository.RegistrarJogo());
        }
    }
}
