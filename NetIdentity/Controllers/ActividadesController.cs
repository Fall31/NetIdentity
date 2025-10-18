using AspNetCoreGeneratedDocument;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace NetIdentity.Controllers
{
    
    public class ActividadesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //vista->controlador->modelo
        //modelo->controlador->vista
        //vista->controlador
        [Authorize(Policy = "menoresEdad")]
        [Authorize(Policy = "EsMasculino")] 
        public IActionResult Deportes()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        [Authorize(Policy = "EsNo-Binario")]
        public IActionResult Tareas()
        {
            return View();
        }
    }

}
