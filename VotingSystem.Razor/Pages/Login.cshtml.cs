using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;
using VotingSystem.Razor.Data;

namespace VotingSystem.Razor.Pages
{
    public class Login : PageModel
    {
        [BindProperty]
        public string Username { get; set; }

        [BindProperty]
        public string Password { get; set; }
            public string ErrorMessage { get; set; }
        private readonly ApplicationDbContext _context;
        public Login(ApplicationDbContext context)
        {
            _context = context;
        }
        public void OnGet()
        {
        }
        public IActionResult OnPost()
        {
            var user = _context.Candidate.FirstOrDefault(uo => uo.Username == Username);
            if (user == null)
            {
                var user1 = _context.Voter.FirstOrDefault(uo => uo.Username == Username);
                if (user1 == null)
                {
                    return RedirectToPage("Index");
                }
                else
                {
                    if (user1.Password == Password)
                    {
                        return RedirectToPage("Voter");
                    }
                    else
                    {
                        ErrorMessage = "Incorrect Password";
                        return Page();
                    }

                }
            }
            else
            {
                if(user.Password == user.Password){
                return RedirectToPage("Candidate");
                }
                  else
                    {
                        ErrorMessage = "Incorrect Password";
                        return Page();
                    }

            }
        }
    }
}