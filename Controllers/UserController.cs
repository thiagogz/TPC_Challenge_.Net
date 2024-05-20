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

        public IActionResult UpdatePerfil(int id, UpdateDTO request)
        {
            var getUser = _dataContext.Users.Find(id);

            getUser.NomeUsuario = request.NomeUsuario != null ? request.NomeUsuario : getUser.NomeUsuario;
            getUser.SobrenomeUsuario = request.SobrenomeUsuario != null ? request.SobrenomeUsuario : getUser.SobrenomeUsuario;
            getUser.EmailUsuario = request.EmailUsuario != null ? request.EmailUsuario : getUser.EmailUsuario;
            getUser.SenhaUsuario = request.SenhaUsuario != null ? request.SenhaUsuario : getUser.SenhaUsuario;
            getUser.TelefoneUsuario = request.TelefoneUsuario != null ? request.TelefoneUsuario : getUser.TelefoneUsuario;
            getUser.EnderecoUsuario = request.EnderecoUsuario != null ? request.EnderecoUsuario : getUser.EnderecoUsuario;
            getUser.NumeroEndereco = (int)(request.NumeroEndereco != null ? request.NumeroEndereco : getUser.NumeroEndereco);
            getUser.ComplementoEndereco = request.ComplementoEndereco != null ? request.ComplementoEndereco : getUser.ComplementoEndereco;

            _dataContext.Users.Update(getUser);
            _dataContext.SaveChanges();

            return RedirectToAction("PerfilPage");
        }

        public IActionResult DeletePerfil(int id)
        {
            var getUser = _dataContext.Users.Find(id);
            getUser.CadastroAtivo = 'N';

            _dataContext.Users.Update(getUser);
            _dataContext.SaveChanges();

            return RedirectToAction("Index", "Home");
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
