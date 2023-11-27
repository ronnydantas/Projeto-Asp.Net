using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using System.Xml.Linq;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.EntityFrameworkCore;
using WebTest.Model;
using WebTest.ViewModels;

namespace WebTest.Pages
{
    public class RegisterModel : PageModel
    {
        private readonly UserManager<ApplicationUser> userManager;
        private readonly SignInManager<ApplicationUser> signInManager;
        private readonly AuthDbContext _dbContext;

        [BindProperty]
        public Register Model { get; set; }
        public class Register
        {
            [Required]
            [Display(Name = "Email Address")]
            [EmailAddress]
            public string Email { get; set; }

            [Display(Name = "Nome do Usuário")]
            public string Nome { get; set; }

            [Display(Name = "Cargo")]
            public string Cargo { get; set; }

            [Required]
            [DataType(DataType.Password)]
            public string Password { get; set; }

            [Compare("Password", ErrorMessage = "As senhas não conferem.")]
            [DataType(DataType.Password)]
            [Display(Name = "Confirme sua Senha")]
            public string ConfirmPassword { get; set; }

            [Display(Name = "Salario")]
            public int Salario { get; set; }

            public string Cpf { get; set; }
            public string Genero { get; set; }

            [Display(Name = "Telefone")]
            public string Telefone { get; set; }

            [Display(Name = "Endereço")]
            public string Endereco { get; set; }

            [Display(Name = "Horario de Trabalho")]
            public string HorarioTrabalho { get; set; }

            [Display(Name = "Jornada Semanal")]
            public int JornadaSemanal { get; set; }

            [Display(Name = "Banco")]
            public string Banco { get; set; }

            [Display(Name = "Agência")]
            public int Agencia { get; set; }

            [Display(Name = "Conta")]
            public int Conta { get; set; }
            public string Situacao { get; set; }
            public string INSS { get; set; }

            public string PIS { get; set; }

            [DataType(DataType.Date)]
            [Display(Name = "Data de Nascimento")]
            public DateTime DataNascimento { get; set; }

            [Display(Name = "Carteira de Trabalho")]
            public string CarteiraTrabalho { get; set; }

            [Display(Name = "RG")]
            public string RG { get; set; }
        }

        public RegisterModel(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signInManager, AuthDbContext dbContext)
        {
            this.userManager = userManager;
            this.signInManager = signInManager;
            _dbContext = dbContext;
        }


        public void OnGet()
        {
        }

        public async Task<ActionResult> OnPostAsync()
        {
            if (ModelState.IsValid)
            {
                var user = new ApplicationUser()
                {
                    UserName = Model.Email,
                    Email = Model.Email,
                    Nome = Model.Nome,
                    Cargo = Model.Cargo,
                    Salario = Model.Salario,
                    Cpf = Model.Cpf,
                    Genero = Model.Genero,
                    Telefone = Model.Telefone,
                    Endereco = Model.Endereco,
                    HorarioTrabalho = Model.HorarioTrabalho,
                    JornadaSemanal = Model.JornadaSemanal,
                    Banco = Model.Banco,
                    Agencia = Model.Agencia,
                    Conta = Model.Conta,
                    Situacao = "Ativo",
                    INSS = Model.INSS,
                    PIS = Model.PIS,
                    DataNascimento = Model.DataNascimento,
                    CarteiraTrabalho = Model.CarteiraTrabalho,
                    RG = Model.RG,
                };

                var result = await userManager.CreateAsync(user, Model.Password);
                if (result.Succeeded)
                {
                    var salario = new Pagamentos
                    {
                        SalarioBruto = Model.Salario,
                        SalarioLiquido = Model.Salario,
                        NomeUsuario = user.Nome,
                    };

                    _dbContext.Pagamentos.Add(salario);
                    await _dbContext.SaveChangesAsync();

                    await signInManager.SignInAsync(user, false);
                    return RedirectToPage("Admin");
                }

                foreach (var error in result.Errors)
                {
                    ModelState.AddModelError("", error.Description);
                }
            }

            return Page();
        }
    }
}