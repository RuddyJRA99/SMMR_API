using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SMMR.ETL;
using SMMR.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SMMR.Controllers
{
    [Route("/api/[controller]/[action]")]
    [ApiController]
    public class AuthController : ControllerBase
    {
        public string Index()
        {
            return "AuthController";
        }

        [HttpPost]
        public string Register([FromForm] userRegister model)
        {
            bool response = new UserModel().register(model);
            return response ? "registro exitoso" : "Registro fallido";
        }

        [HttpPost]
        public ActionResult Login([FromForm] userLogin model)
        {
            try
            {
                string response = new UserModel().login(model);
                //List<string> propiedades = model.GetType().GetProperties().Select(x => x.Name).ToList<string>();
                //propiedades.ForEach(x => model.GetType().);
                return Ok(response);
            }
            catch (ArgumentNullException e)
            {
                return BadRequest("Error desconocido: " + e.Message);
            }
            catch (Exception e)
            {
                return BadRequest("Error desconocido: " + e.Message );
            }
        }
    }
}
