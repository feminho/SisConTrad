using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SisConTrad.Core.Model
{
    public class Project
    {
        public Project()
        {
        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [DisplayName("Nome do projeto")]
        public string ProjectName { get; set; }

        [DisplayName("Código do projeto")]
        public string ProjectCode { get; set; }

        [DisplayName("Notas")]
        public string Notes { get; set; }

        [DisplayName("Forma de pagamento")]
        public string PaymentMode { get; set; }

        [DisplayName("Recibo")]
        public string Receipt { get; set; }

        [DisplayName("Valor total das traduções")]
        public decimal TotalTranslationsValue { get; set; }

        [DisplayName("Disconto")]
        public decimal Discount { get; set; }

        [DisplayName("Total")]
        public decimal TotalValue { get; set; }

        [DisplayName("Data de criação")]
        public DateTime CreatedOn { get; set; }

        public int ClientId { get; set; }

        [Required]
        [DisplayName("Cliente")]
        public Client Client { get; set; }

        public ICollection<Translation> Translations { get; set; }


    }
}
