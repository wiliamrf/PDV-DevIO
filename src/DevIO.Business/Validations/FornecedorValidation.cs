﻿using DevIO.Business.Models;
using DevIO.Business.Validations.Documentos;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DevIO.Business.Validations
{
    public class FornecedorValidation:AbstractValidator<Fornecedor>
    {
        public FornecedorValidation()
        {
            RuleFor(f => f.Nome)
                .NotEmpty().WithMessage("O campo {PropertyName} precisa ser fornecido")
                .Length(2, 100).WithMessage("O campo {PropertyName} precisa ter entre {MinLength} e {MaxLength} caracteres");

            When(f => f.TipoFornecedor == TipoFornecedor.PessoaFisica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(CpfValidacao.TamanhoCpf).
                WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e  foi fornecido {PropetyValue");
                RuleFor(f=>CpfValidacao.Validar(f.Documento)).Equal(true)
                .WithMessage("O documento é inválido");
            });


            When(f => f.TipoFornecedor == TipoFornecedor.PessoaJuridica, () =>
            {
                RuleFor(f => f.Documento.Length).Equal(CnpjValidacao.TamanhoCnpj).
                WithMessage("O campo Documento precisa ter {ComparisonValue} caracteres e  foi fornecido {PropetyValue");
                RuleFor(f => CnpjValidacao.Validar(f.Documento)).Equal(true)
                .WithMessage("O documento é inválido");
            });




        }
    }
}
