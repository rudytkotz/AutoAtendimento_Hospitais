using System.ComponentModel.DataAnnotations;

namespace AutoAtendimento_Hospitais.Models
{
    public class Pessoa
    {
        [Required(ErrorMessage = "O campo Nome é obrigatorio")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "O campo CPF é obrigatorio")]
        [StringLength(11,ErrorMessage = "O campo CPF tem mais de 11 caracteres")]
        public string CPF { get; set; }
        
        [Required(ErrorMessage = "O campo Data de nascimento é obrigatorio")]
        public DateTime Data_Nascimento { get; set; }
        
        public string Endereço { get; set; }
        
        public string CEP { get; set; }
        
        public string Telefone { get; set; }
        
        public string RG { get; set; }
        
        public string Carteira_Plano { get; set; }



    }
}
