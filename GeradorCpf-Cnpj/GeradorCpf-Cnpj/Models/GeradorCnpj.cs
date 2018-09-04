using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace GeradorCpf_Cnpj.Models
{
    public class GeradorCnpj
    {
        [Required]
       
        public string Cnpj { get; set; }
    }
}