using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SisConTrad.Core.Model
{
    public class Translation
    {
        public Translation()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [DisplayName("Tipo de projeto")]
        public string ProjectType { get; set; }

        [Required]
        [DisplayName("Arquivo a ser traduzido")]
        public string FileToBeTranslate { get; set; }

        [DisplayName("Valor da tradução")]
        public decimal TranslationValue { get; set; }

        [DisplayName("Arquivo traduzido")]
        public string TranslatedFile { get; set; }

        [DisplayName("Arquivo traduzido")]
        public bool IsUrgentTranslations { get; set; }

        public int Step { get; set; }

        public int ProjectId { get; set; }

        [Required]
        [DisplayName("Projeto")]
        public Project Project { get; set; }
    }
}
