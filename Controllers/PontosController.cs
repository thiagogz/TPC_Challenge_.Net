using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TPC_Challenge.DTO;

namespace TPC_Challenge.Controllers
{
    public class PontosController : Controller
    {
        private readonly DataContext _dataContext;

        public PontosController(DataContext dataContext)
        {
            _dataContext = dataContext;
        } 

        public IActionResult Pontos()
        {
            return View();
        }

        public IActionResult VerPontos(int id)
        {
            var pontos = _dataContext.Pontos.Find(id);
            if (pontos == null)
            {
                return BadRequest("Pontos não encontrados!");
            }
            return (IActionResult)pontos;
        }

        public IActionResult AdicionarPontos(PontosDTO request)
        {
            Pontos newPontos = new Pontos
            {
                ValorPontos = request.ValorPontos,
                DataCredito = request.DataCredito,
                DataExpiracao = request.DataExpiracao,
                StatusPontos = '1'
            };
            _dataContext.Add(newPontos);
            _dataContext.SaveChanges();
            return RedirectToAction("Index", "Home");
        }

        public IActionResult UpdatePontos(int id, PontosDTO request)
        {
            var getPontos = _dataContext.Pontos.Find(id);

            getPontos.ValorPontos = request.ValorPontos != null ? request.ValorPontos : getPontos.ValorPontos;
            getPontos.DataCredito = request.DataCredito != null ? request.DataCredito : getPontos.DataCredito;
            getPontos.DataExpiracao = request.DataExpiracao != null ? request.DataExpiracao : getPontos.DataExpiracao;
            getPontos.StatusPontos = request.StatusPontos != null ? request.StatusPontos : getPontos.StatusPontos;

            _dataContext.Pontos.Update(getPontos);
            _dataContext.SaveChanges();

            return RedirectToAction("PerfilPage");
        }

        public IActionResult DeletePontos(int id)
        {
            var getPontos = _dataContext.Pontos.Find(id);
            getPontos.StatusPontos = '0';

            _dataContext.Pontos.Update(getPontos);
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
