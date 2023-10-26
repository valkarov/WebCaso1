using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebCaso1.Entities;
using WebCaso1.Models;

namespace WebCaso1.Controllers
{
    public class RegistroController : Controller
    {
        EstudianteModel estudianteModel = new EstudianteModel();


        [HttpGet]
        public ActionResult RegistroMatricula()
        {
            return View();
        }

        [HttpPost]
        [ActionName("RegistroMatricula")]
        public ActionResult RegistroMatriculaPost(EstudianteEntidad entidad)
        {
            estudianteModel.RegistroMatricula(entidad);
            return View("RegistroMatricula");
        }

    }
}