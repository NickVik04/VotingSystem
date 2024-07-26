using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VotingSystem.Razor.Models
{
    public class Voter
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        public string UserRole { get; set; }
        public string Username { get; set; }
        [Required]
        [MinLength(8)]
        public string Password { get; set; }

    }
}