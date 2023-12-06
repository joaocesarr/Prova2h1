using AutoMapper;
using Revisao.Data.Providers.MongoDB.Collections;
using Revisao.Domain.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Data.AutoMapper
{
    public class CollectionToDomain : Profile
    {
        public CollectionToDomain()
        {
            CreateMap<DocumentoCartaCollection, DocumentosMega>()
               .ConstructUsing(q => new DocumentosMega(q.Nome, q.Rua, q.Numero, q.Bairro, q.Cidade, q.Estado, q.Idade, q.Texto));
        }
    }
}
