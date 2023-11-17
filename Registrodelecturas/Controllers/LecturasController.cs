using Microsoft.AspNetCore.Mvc;
using Registrodelecturas.Models;
using Registrodelecturas.Repositories;
using System.Security.Cryptography.Xml;

namespace Registrodelecturas.Controllers
{
        [Route("api/{controller}")]
        [ApiController]
    public class LecturasController : Controller
    {
        private GenericRepository<Lecturas> LecturasRepository;
        private LecturasespContext context;
        public LecturasController(LecturasespContext context)
        {
            this.context = context;
            LecturasRepository = new GenericRepository<Lecturas>(context);

        }
        [HttpGet]
        public IActionResult Get(int id)
        {
            LecturasRepository = new GenericRepository<Lecturas>(context);
            var lecturas = LecturasRepository.GetByID(id);
            if (lecturas==null)
            {
                return NotFound();
            }

            return Ok(lecturas);    
        }
        //public IActionResult Post(Lecturas lecturas)
        //{
        //    LecturasRepository = new GenericRepository<Lecturas>(context);
               //validacion
        //}
    }
}
