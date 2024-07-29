using System.Drawing;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding.Binders;
using Microsoft.AspNetCore.Mvc.RazorPages;
using VotingSystem.Razor.Data;
using VotingSystem.Razor.Models;

namespace VotingSystem.Razor.Pages;

public class IndexModel : PageModel
{
    [BindProperty]
    public string Name { get; set; }

    [BindProperty]
    public string Role { get; set; }

    [BindProperty]
    public string Username { get; set; }

    [BindProperty]
    public string Password { get; set; }
    // private readonly ILogger<IndexModel> _logger;

    // public IndexModel(ILogger<IndexModel> logger)
    // {
    //     _logger = logger;
    // }

    private readonly ApplicationDbContext _context;
    public IndexModel(ApplicationDbContext context){
        _context = context;
    }

    public void OnGet()
    {

    }

    public void OnPost()
    {   
        if(ModelState.IsValid && Role =="Candidate"){
            var candidate = new Candidate
            {
                Name = Name,
                UserRole = Role,
                Username = Username,
                Password = Password
            };

            _context.Candidate.Add(candidate);
            _context.SaveChanges();
        }

            else if(ModelState.IsValid && Role =="Voter"){
            var voter = new Voter
            {
                Name = Name,
                UserRole = Role,
                Username = Username,
                Password = Password
            };

            _context.Voter.Add(voter);
            _context.SaveChanges();
        }   


    }
}
