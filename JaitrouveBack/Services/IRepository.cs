using JaitrouveBack.Entities;

namespace JaitrouveBack.Services
{
    public interface IRepository
    {
        List<ObjLost> GetAllObjLost();
        ObjLost GetObjLostById(long Id);
    }
}
