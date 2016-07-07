using PeopLost.Core.Data;
using PeopLost.Core.Domain.Maps;

namespace PeopLost.Service.Maps
{
    public partial class globalGeoService: IglobalGeoService
    {
        IRepository<globalGeo> globalgeoRepository;

        public globalGeoService(IRepository<globalGeo> globalgeoRepository)
        {
            this.globalgeoRepository = globalgeoRepository;
        }

        public virtual void DeleteglobalGeo(globalGeo globalGeo)
        {
            globalgeoRepository.Delete(globalGeo);
        }

        public virtual globalGeo GetglobalGeoById(int globalGeoId)
        {
            return globalgeoRepository.GetById(globalGeoId);
        }

        public virtual void InsertglobalGeo(globalGeo globalGeo)
        {
            globalgeoRepository.Insert(globalGeo);
        }

        public virtual void UpdateglobalGeo(globalGeo globalGeo)
        {
            globalgeoRepository.Update(globalGeo);
        }
    }
}
