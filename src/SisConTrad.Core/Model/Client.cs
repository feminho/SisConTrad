using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace SisConTrad.Core.Model
{
    public class Client
    {
        public Client()
        {

        }

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }

        [Required]
        [DisplayName("Nome")]
        public string Name { get; set; }
        public string Email { get; set; }
        public string WhatsApp { get; set; }
        public bool IsActive { get; set; }

        public ICollection<Project> Projects { get; set; }
        public ICollection<Message> Messages { get; set; }

    }
}
