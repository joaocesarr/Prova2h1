using AutoMapper;
using Revisao.Domain.ViewModels;
using Revisao.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.AutoMapper
{
	public class ApplicationToDomain : Profile
	{
		public ApplicationToDomain()
		{

			CreateMap<MegaViewModel, DocumentosMega>()
			   .ConstructUsing(q => new documentomega(q.Nome, q.Numeromega, q.PrimeiroGanhador, q.SegundoGanhador, q.TerceiroGanhador,q.Texto));

			

        }
	}
}
