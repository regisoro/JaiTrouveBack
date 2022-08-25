using JaitrouveBack.Entities;
using JaitrouveBack.Services;
using Microsoft.AspNetCore.Mvc;

namespace JaitrouveBack.Controllers
{
    [Route("api/ObjLost")]
 
    public class ObjLostController : ControllerBase
    {
        private readonly IRepository repository;
        public ObjLostController(IRepository repository)
        {
            this.repository = repository;
        }
        //ActionResult<ObjLost> permet de retourner soit le type contenu dans les crochets,
        //soit une autre action comme "notFound()", IActionResult permet de retourner toute action et tous les types
        //à condition que le type soit dans "OK()". exemple: return Ok(objLost).
        [HttpGet]
        public ActionResult<List<ObjLost>> Get()
        {
            return repository.GetAllObjLost();
             
        }

        [HttpGet("{Id:long}")]
        public ActionResult<ObjLost> Get(long Id)
        {
            var objLost = repository.GetObjLostById(Id);
            if(objLost == null)
            {
                return NotFound();
            }
            return objLost;
        }
    }
}
