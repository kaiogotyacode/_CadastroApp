using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace ValidationApp.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "O campo nome deve ser preenchido.")]
        public string Nome { get; set; }

        public string Email { get; set; }

        [Range(0,150,ErrorMessage ="Este campo deve conter números entre 0 à 150")]
        public int Idade { get; set; }

        [StringLength(20, MinimumLength = 9, ErrorMessage = "O campo Telefone deve conter entre 9 à 20 caracteres")]
        public string  Telefone { get; set; }

        [StringLength(16,MinimumLength = 6, ErrorMessage ="A senha deve conter entre 6 à 16 caracteres")]
        public string  Senha { get; set; }

        [Compare("Senha", ErrorMessage ="As senhas não conferem!")]
        public string  C_Senha { get; set; }
    }
}