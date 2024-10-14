using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using RegistroPessoa.Models;

namespace RegistroPessoa.Pages
{
    public class IndexModel : PageModel
    {
        [BindProperty]
        public required Usuario Usuario { get; set; }

        public void OnGet()
        {
        }

        public IActionResult OnPostRegistrar()
        {
            if (ModelState.IsValid)
            {
                // Aqui é para salvar o usuário em um banco de dados.
                return RedirectToPage("/Sucesso");
            }
            return Page();
        }
    }
}

