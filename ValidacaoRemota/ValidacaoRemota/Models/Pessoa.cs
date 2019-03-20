using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ValidacaoRemota.Models
{
    public class Pessoa
    {
        public int PessoaId { get; set; }

        [Remote("UsuarioExisteAsync", "Pessoas")]
        public string Nome { get; set; }

        public int Idade { get; set; }
    }
}
