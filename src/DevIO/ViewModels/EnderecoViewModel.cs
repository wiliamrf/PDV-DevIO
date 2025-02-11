﻿using DevIO.Business.Models;
using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace DevIO.ViewModels
{
    public class EnderecoViewModel
    {


        [Key]
        public Guid Id { get; set; }


        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(200, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        
        public string Logradouro { get; set; }

        
        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
       
        public string Numero { get; set; }

        public string Complemento { get; set; }

        
        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(8, ErrorMessage = "O campo {0} precisa ter {1} caracteres", MinimumLength = 8)]
        
        public string Cep { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        
        public string Bairro { get; set; }
       
        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(100, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        
        public string Cidade { get; set; }
        
        [Required(ErrorMessage = "O campo {0} é Obrigatório")]
        [StringLength(50, ErrorMessage = "O campo {0} precisa ter entre {2} e {1} caracteres", MinimumLength = 2)]
        
        public string Estado { get; set; }

        /* EF Reelation */
        [HiddenInput]
        public Guid FornecedorId { get; set; }
      
    }
}
