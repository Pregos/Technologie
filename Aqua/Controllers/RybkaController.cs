using Aqua.Models;
using Microsoft.AspNetCore.Mvc;

namespace Aqua.Controllers
{
    public class RybkaController : Controller
    {
        private IRybkaRepository repository;

        public RybkaController(IRybkaRepository repo) => repository = repo;

        public ViewResult List() => View(repository.Rybki);
    }
}
