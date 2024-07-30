using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace VotingSystem.Razor.Pages
{
    public class Candidate : PageModel
    {
        private readonly ILogger<Candidate> _logger;

        public Candidate(ILogger<Candidate> logger)
        {
            _logger = logger;
        }

        public void OnGet()
        {
        }
    }
}