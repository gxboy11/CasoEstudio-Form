using CasoEstudio_Form.Application.Contracts;
using CasoEstudio_Form.Domain.InputModels;
using CasoEstudio_Form.Domain.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CasoEstudio_Form.Controllers
{
    public class LoginController : Controller
    {
        private readonly ILogger<LoginController> _logger;
        private readonly IUsuarioService _service;
        public LoginController(ILogger<LoginController> logger, IUsuarioService service)
        {
            _logger = logger;
            _service = service;
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult IniciarSesion(UsuarioExistente model)
        {
            if (ModelState.IsValid)
            {

                if (_service.IsCredentialValid(model.nombreUsuario, model.passwordUsuario))
                {
                    return RedirectToAction("Index", "Home");
                }
                else
                {
                    ModelState.AddModelError(string.Empty, "Credenciales inválidas. Por favor, inténtelo de nuevo.");
                }
            }
            return View("Index");
        }



        [HttpGet]
        public ActionResult Registro()
        {
            return View(new NuevoUsuario());
        }

        [HttpPost]
        public IActionResult Registro(NuevoUsuario newUsuario)
        {
            if (ModelState.IsValid)
            {
                if (!_service.Insert(newUsuario))
                {
                    ModelState.AddModelError(string.Empty, "Usuario no pudo ser ingresado");
                }
                else
                {
                    return RedirectToAction("Index");
                }
            }
            return View(newUsuario);
        }
    }
}
