using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TPC_Challenge.DTO;

namespace TPC_Challenge.Controllers
{
    public class CreditController : Controller
    {
        private readonly DataContext _dataContext;

        public CreditController(DataContext dataContext)
        {
            _dataContext = dataContext;
        }

        public IActionResult Credit()
        {
            return View();
        }

        public IActionResult VerCreditos(int id)
        {
            var creditos = _dataContext.Credits.Find(id);
            if (creditos == null)
            {
                return BadRequest("Pontos não encontrados!");
            }
            return (IActionResult)creditos;
        }

        public IActionResult AdicionarCreditos(CreditDTO request)
        {
            Credit newCreditos = new Credit
            {
                ValorCredito = request.ValorCredito,
                DataCredito = request.DataCredito,
                DataExpiracao = request.DataExpiracao,
                StatusCredito = '1'
            };
            _dataContext.Add(newCreditos);
            _dataContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult UpdateCreditos(int id, CreditDTO request)
        {
            var getCreditos = _dataContext.Credits.Find(id);

            getCreditos.ValorCredito = request.ValorCredito != null ? request.ValorCredito : getCreditos.ValorCredito;
            getCreditos.DataCredito = request.DataCredito != null ? request.DataCredito : getCreditos.DataCredito;
            getCreditos.DataExpiracao = request.DataExpiracao != null ? request.DataExpiracao : getCreditos.DataExpiracao;
            getCreditos.StatusCredito = request.StatusCredito != null ? request.StatusCredito : getCreditos.StatusCredito;

            _dataContext.Credits.Update(getCreditos);
            _dataContext.SaveChanges();

            return RedirectToAction("PerfilPage");
        }

        public IActionResult DeleteCreditos(int id)
        {
            var getCreditos = _dataContext.Credits.Find(id);
            getCreditos.StatusCredito = '0';

            _dataContext.Credits.Update(getCreditos);
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
