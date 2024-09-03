using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace VetCare_BackEnd.Models
{
    [Table("roles")]
    public class Role
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(100, ErrorMessage = "The input is too long")]
        [MinLength(3, ErrorMessage = "The input is too short")]
        public required string Name { get; set; }

        // Navigation properties
        public ICollection<User>? Users { get; set; }

    }
}