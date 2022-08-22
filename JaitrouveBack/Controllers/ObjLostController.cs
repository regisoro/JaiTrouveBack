using JaitrouveBack.Services;

namespace JaitrouveBack.Controllers
{
    public class ObjLostController
    {
        private readonly IRepository repository;
        public ObjLostController(IRepository repository)
        {
            this.repository = repository;
        }
    }
}
