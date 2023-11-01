using CasoEstudio_Form.Application.Contracts;
using CasoEstudio_Form.Domain.ViewModels;
using CasoEstudio_Form.Domain.InputModels.Usuarios;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using CasoEstudio_Form.Application.Services;
using CasoEstudio_Form.Domain.DTOs.Usuarios;

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
                int userId = _service.GetUserByCredentials(model.nombreUsuario, model.passwordUsuario);

                if (_service.IsCredentialValid(model.nombreUsuario, model.passwordUsuario))
                {
                    HttpContext.Session.SetInt32("idUser", userId);
                    HttpContext.Session.SetString("username", model.nombreUsuario);
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
