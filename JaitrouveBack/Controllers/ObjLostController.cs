using JaitrouveBack.Entities;
using Microsoft.AspNetCore.Cors;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace JaitrouveBack.Controllers
{   
    [EnableCors("CorsPolicy")]

    [Route("api/Objt")]
 
    public class ObjtController : ControllerBase
    {
        //injection dependancies par controller;en faisant la modif de la classe appelée
        //dans les paramètres du constructeur. 
        private readonly ApplicationDbContext context;
        public ObjtController(ApplicationDbContext context)
        {
            this.context = context;
        }
        //ActionResult<ObjLost> permet de retourner soit le type contenu dans les crochets,
        //soit une autre action comme "notFound()", IActionResult permet de retourner toute action et tous les types
        //à condition que le type soit dans "OK()". exemple: return Ok(objLost).


        [HttpGet]
        //le retour d'une methode async doit etre de type Task<> ou Task<T> ou void 
        public async Task<ActionResult<List<Objt>>> Get()
        {
            //on retourne tous les Objt de la table Objets
            return await context.Objets.ToListAsync();
             
        }
        //Id:long, pour éviter qu'une valeur autre qu'un nombre n'entre dans le controller (astuce de sécurité)
        [HttpGet("{Id:long}")]
        public ActionResult<Objt> Get(long Id)
        {
            throw new NotImplementedException();
        }

        [HttpPost]
        public async Task<ActionResult> Post([FromForm] ObjtDTO Obj)
        {
            var guid= Guid.NewGuid().ToString();
            var filePath = @"C:\Temp\Damien\"+ guid;

            if(!Directory.Exists(filePath))
                Directory.CreateDirectory(filePath);

            if(Obj.Image != null)
            {
                filePath = Path.Combine(filePath, Obj.Image.FileName);
                using (var stream = System.IO.File.Create(filePath))
                Obj.Image.CopyTo(stream);
            }
            Objt objet;
            objet = new Objt()
            {
                Venue = Obj.Venue,
                Date = Obj.Date,
                Title = Obj.Title,
                PhoneNumber = Obj.PhoneNumber,
                Category = Obj.Category,
                IsFounded = Obj.IsFounded,
                FirstName = Obj.FirstName,
                LastName = Obj.LastName,
                EmailAdress = Obj.EmailAdress,
                Description = Obj.Description,

            };

            //après modifiaction d'une base de données, toujours faire un saveChange,
            //sinon la modif ne sera pas prise en compte
            context.Objets.Add(objet);
            await context.SaveChangesAsync();
            return Ok();
        }
    }

 }

