using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.VisualBasic;

namespace VotingSystem.Razor.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string UserRole { get; set; }

    }
}