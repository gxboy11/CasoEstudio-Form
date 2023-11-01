using Microsoft.AspNetCore.Mvc;
using CasoEstudio_Form.Application.Services;
using CasoEstudio_Form.Domain.InputModels.Publicaciones;
using CasoEstudio_Form.Application.Contracts;

public class ComentariosController : Controller
{
    private readonly IPublicacionService _publicacionService;

    public ComentariosController(IPublicacionService publicacionService)
    {
        _publicacionService = publicacionService;
    }

    public IActionResult Index()
    {
        var publicaciones = _publicacionService.GetAll();
        return View(publicaciones);
    }

    [HttpGet]
    public IActionResult Create()
    {
        return View();
    }

    [HttpPost]
    public IActionResult Create(NuevaPublicacion nuevaPublicacion)
    {
        if (ModelState.IsValid)
        {
            bool success = _publicacionService.Post(nuevaPublicacion);
            if (success)
            {
                return RedirectToAction("Index");
            }
        }
        return View(nuevaPublicacion);
    }

    [HttpGet]
    public IActionResult Edit(int id)
    {
        var publicacion = _publicacionService.Get(id);
        if (publicacion == null)
        {
            return NotFound();
        }
        return View(publicacion);
    }

    [HttpPost]
    public IActionResult Edit(PublicacionExistente publicacionExistente)
    {
        if (ModelState.IsValid)
        {
            bool success = _publicacionService.Update(publicacionExistente);
            if (success)
            {
                return RedirectToAction("Index");
            }
        }
        return View(publicacionExistente);
    }

    public IActionResult Delete(int id)
    {
        bool success = _publicacionService.Delete(id);
        if (success)
        {
            return RedirectToAction("Index");
        }
        return NotFound();
    }

    [HttpGet]
    public IActionResult Respond(int idParent)
    {
        var parentComment = _publicacionService.Get(idParent);

        if (parentComment == null)
        {
            return NotFound();
        }

        var respuestaModel = new NuevaPublicacion
        {
            idParent = idParent
        };

        return View(respuestaModel);
    }

    [HttpPost]
    public IActionResult Respond(NuevaPublicacion nuevaPublicacion)
    {
        if (ModelState.IsValid)
        {
            bool success = _publicacionService.Post(nuevaPublicacion);
            if (success)
            {
                return RedirectToAction("Index");
            }
        }

        return View(nuevaPublicacion);
    }

}
