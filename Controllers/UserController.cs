using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TPC_Challenge.DTO;
using TPC_Challenge.Models;

namespace TPC_Challenge.Controllers
{
    public class UserController : Controller
    {
        private readonly DataContext _dataContext;

        public UserController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult CadastroPage()
        {
            return View();
        }

        public IActionResult LoginPage()
        {
            return View();
        }

        public IActionResult PerfilPage(Users user)
        {

            ViewBag.User = user;
            ViewBag.Pontos = _dataContext.Pontos.FirstOrDefault(p => p.PontosID == 1);
            ViewBag.Credit = _dataContext.Credits.FirstOrDefault(c => c.CreditID == 2);
            return View();
        }

        public IActionResult EfetuarCadastro(CadastroDTO request)
        {
            var user = _dataContext.Users.FirstOrDefault(x => x.EmailUsuario == request.EmailUsuario);
            if (user != null)
            {
                return BadRequest("Usuário já existe!");
            }
            Users newUser = new Users
            {
                NomeUsuario = request.NomeUsuario,
                SobrenomeUsuario = request.SobrenomeUsuario,
                EmailUsuario = request.EmailUsuario,
                SenhaUsuario = request.SenhaUsuario,
                TelefoneUsuario = request.TelefoneUsuario,
                EnderecoUsuario = request.EnderecoUsuario,
                NumeroEndereco = request.NumeroEndereco,
                ComplementoEndereco = request.ComplementoEndereco
            };
            _dataContext.Add(newUser);
            _dataContext.SaveChanges();
            return RedirectToAction("LoginPage");
        }

        public IActionResult EfetuarLogin(LoginDTO request)
        {
            var userLogin = _dataContext.Users.FirstOrDefault(x => x.EmailUsuario == request.EmailUsuario);
            if (userLogin == null)
            {
                return BadRequest("E-mail não cadastrado!");
            }
            if (userLogin.SenhaUsuario != request.SenhaUsuario)
                {
                return BadRequest("Senha inválida!");
            }
            return RedirectToAction("PerfilPage", userLogin);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
