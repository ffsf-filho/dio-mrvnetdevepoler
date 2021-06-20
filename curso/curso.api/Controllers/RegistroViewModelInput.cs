﻿using System.ComponentModel.DataAnnotations;

namespace curso.api.Controllers
{
    public class RegistroViewModelInput
    {
        [Required(ErrorMessage ="O Login é obrigatório")]
        public string Login { get; set; }
        [Required(ErrorMessage ="O E-mail é obrigatório")]
        public string Email { get; set; }
        [Required(ErrorMessage ="A senha é obrigatória")]
        public string Senha { get; set; }

    }
}