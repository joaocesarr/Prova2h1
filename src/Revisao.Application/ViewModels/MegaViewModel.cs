using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Revisao.Application.ViewModels
{
    public class MegaViewModel
    {
        [MinLength(3, ErrorMessage = "Minimo 3 Caracteres.")]
        [MaxLength(255, ErrorMessage = "Maximo 255 Caracteres.")]
        [Required(ErrorMessage = "Nome Obrigatorio.")]
        public string Nome { get;  set; }

        [Required(ErrorMessage = "Pelo menos 2 numeros")]
        public string Numeromega { get;  set; }

        [Required(ErrorMessage = "Numero do ganhador e:")]
        public int PrimeiroGanhador { get;  set; }

        [Required(ErrorMessage = "Numero do ganhador e:\"")]
        public string SegundoGanhador { get;  set; }

        [Required(ErrorMessage = "Numero do ganhador e:\"")]
        public string TerceiroGanhador { get;  set; }

        
        public int Idade { get;  set; }

        [MinLength(1, ErrorMessage = "Minimo 1 Caracteres.")]
        [MaxLength(500, ErrorMessage = "Maximo 500 Caracteres.")]
        [Required(ErrorMessage = "Texto Obrigatorio.")]
        public string Texto { get;  set; }
    }
}
