using Newtonsoft.Json;
using Revisao.Domain.ViewModels;
using Revisao.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Revisao.Data.Providers.MongoDB.Interfaces;
using AutoMapper;
using Revisao.Data.Providers.MongoDB.Collections;


namespace Revisao.Data.Repositories
{
    public class MegaSenaRepository : MegaRepository
    {

        private readonly IMongoRepository<DocumentoCartaCollection> _megaRepository;
        private readonly IMapper _mapper;

        public MegaSenaRepository(IMongoRepository<DocumentoCartaCollection> MegaRepository, IMapper mapper)
        {
            _megaRepository = MegaRepository;
            _mapper = mapper;
        }
        public async Task Adicionar(DocumentosMega documentosMega)
        {
            await _megaRepository.InsertOneAsync(_mapper.Map<DocumentoCartaCollection>(_megaRepository));
        }
        public IEnumerable<DocumentosMega> ObterTodos()
        {
            var categoriaList = _megaRepository.FilterBy(filter => true);
            return _mapper.Map<IEnumerable<DocumentosMega>>(categoriaList);
        }

        public IEnumerable<DocumentosMega> RegistrarJogo()
        {
            var categoriaList = _megaRepository.FilterBy(filter => true);
            return _mapper.Map<IEnumerable<DocumentosMega>>(categoriaList);
        }

       
    }
}
