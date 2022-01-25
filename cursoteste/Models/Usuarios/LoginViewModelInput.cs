using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace cursoteste.Models.Usuarios
{
    public class LoginViewModelInput
    {
        [Required(ErrorMessage = "Login obrigatorio")]
        public string Login { get; set;  }

        [Required(ErrorMessage = "Senha obrigatoria")]
        public string Senha { get; set;  }
    }
}
