using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LiftIt.Models
{
    public class ContactEmailModel
    {
        [Required]
        public string UserName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        public string MessageType { get; set; }

        [Required]
        [DataType(DataType.Text)]
        public string Message { get; set; }
    }
}
