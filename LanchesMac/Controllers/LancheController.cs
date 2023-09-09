using LanchesMac.Repositories.Interfaces;
using LanchesMac.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace LanchesMac.Controllers
{
    public class LancheController : Controller
    {
        private readonly ILancheRepository _lancheRepository;
        public LancheController(ILancheRepository lancheRepository)
        {
            _lancheRepository = lancheRepository;
        }

        public IActionResult List()
        {
            //var lanches = _lancheRepository.Lanches;
            //return View(lanches);
            var lanchesLisViewModel = new LancheListViewModel();
            lanchesLisViewModel.Lanches = _lancheRepository.Lanches;
            lanchesLisViewModel.CategoriaAtual = "Categoria Atual";

            return View(lanchesLisViewModel);
        }
    }
}