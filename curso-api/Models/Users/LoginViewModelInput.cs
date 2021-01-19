﻿using System.ComponentModel.DataAnnotations;

namespace curso_api.Models.Users
{
    public class LoginViewModelInput
    {
        [Required(ErrorMessage = "The field user is required.")]
        public string Login { get; set; }
        [Required(ErrorMessage = "The field password is required.")]
        public string Senha { get; set; }

    }
}
