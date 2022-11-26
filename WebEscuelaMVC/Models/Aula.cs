using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;
using WebEscuelaMVC.Validation;

namespace WebEscuelaMVC.Models
{
    [Table("Aula")]
    public class Aula
    {
        [Key]
        public int AulaId { get; set; }

        [Required]
        [Column("int")]
        [CheckValidNumber]

        public int Numero { get; set; }
        [Required]
        [Column(TypeName ="varchar")]
        [StringLength(50)]
        public string Estado { get; set; }
    }
}