using System.ComponentModel.DataAnnotations;

namespace PaperUniasselvi.Models
{
    public class CadastroDeEntidades
    {

        public int id { get; set; }

        [Required( ErrorMessage = "Forneça um registro" )]
        public string registro { get; set; }
        [Required( ErrorMessage = "Forneça um cnpj" )]
        public string cnpj { get; set; }
        [Required( ErrorMessage = "Forneça um email" )]
        public string email { get; set; }
        [Required( ErrorMessage = "Forneça um telefone" )]
        public string telefone { get; set; }

        public DateTime dataDaAtualizacao { get; set; } = DateTime.Now;

    }
}
