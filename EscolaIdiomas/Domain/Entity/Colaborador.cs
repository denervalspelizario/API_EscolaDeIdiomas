using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using Domain.Enum;

namespace Domain.Entity
{
    public class Colaborador
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome do colaborador é obrigatório.")]
        [StringLength(50, MinimumLength = 2, ErrorMessage = "Tamanho do nome e sobrenome invalidos.")]
        [RegularExpression(@"^[A-Z][a-zA-Z]*(\s[A-Z][a-zA-Z]*)*$", ErrorMessage = "Cada palavra do nome ou sobrenome devem começar com uma letra maiúscula e conter apenas letras.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "A data de nascimento do colaborador é obrigatório.")]
        public DateTime? Data_nascimento { get; set; }

        [Required(ErrorMessage = "O cpf do colaborador é obrigatório.")]
        [RegularExpression(@"^\d{11}$", ErrorMessage = "O CPF deve conter exatamente 11 dígitos, sem espaços ou -.")]
        public string? Cpf { get; set; }

        [Required(ErrorMessage = "O endereço do colaborador é obrigatório.")]
        [StringLength(200, ErrorMessage = "O endereço não pode ter mais de 200 caracteres.")]
        public string? Endereco { get; set; }

        [Required]
        public SexoEnum Sexo { get; set; }

        [Required(ErrorMessage = "O telefone do colaborador é obrigatório.")]
        [RegularExpression(@"^\(\d{2}\)\d{4,5}-\d{4}$", ErrorMessage = "O telefone deve estar no formato (XX)XXXXX-XXXX ou (XX)XXXX-XXXX.")]
        public string? Telefone { get; set; }

        [Required(ErrorMessage = "O email do colaborador é obrigatório.")]
        [EmailAddress(ErrorMessage = "O endereço de e-mail não é válido.")]
        public string? Email { get; set; }
        
        public DateTime Data_admissao { get; set; } = DateTime.Now.Date;

        [Required]
        public string? Cargo { get; set; }

        [Required(ErrorMessage = "O valor salarial do colaborador é obrigatório.")]
        public decimal? Salario { get; set; }
        public DepartamentoEnum Departamento { get; set; }
        
        
        public bool Status { get; set; } = true;
    }
}
