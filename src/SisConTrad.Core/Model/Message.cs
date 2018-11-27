using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SisConTrad.Core.Model
{
    public class Message
    {
        public Message()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [DisplayName("Mensagem")]
        public string MessageText { get; set; }

        [DisplayName("Data de criação")]
        public DateTime CreatedOn { get; set; }

        public int ClientId { get; set; }

        [Required]
        [DisplayName("Cliente")]
        public Client Client { get; set; }

    }
}
