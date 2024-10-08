﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Domain.Enum;

namespace Domain.Entity.Colaborador
{
    public class Colaborador
    {
        public Guid Id { get; set; }
        public string? Nome { get; set; }
        public DateTime? Data_nascimento { get; set; }
        public string? Cpf { get; set; }
        public string? Endereco { get; set; }
        public SexoEnum Sexo { get; set; }
        public string? Telefone { get; set; }
        public string? Email { get; set; }
        public DateTime Data_admissao { get; set; } = DateTime.Now.Date;
        public string? Cargo { get; set; }
        
        [Column(TypeName = "decimal(18,2)")]
        public decimal? Salario { get; set; }
        public DepartamentoEnum Departamento { get; set; }
        public bool Status { get; set; } = true;
    }
}
