using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeradorCpf_Cnpj.Models
{
    public class GeradorCpf
    {   
        [Required]
        [MaxLength(14)]
        [MinLength(11)]
        public string  Cpf { get; set; }
    }
}