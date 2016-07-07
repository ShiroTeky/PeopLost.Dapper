
using PeopLost.Core.Data;
using PeopLost.Core.Domain.Maps;
using System;
namespace PeopLost.Service.Maps
{
    public partial class PersonPointGeoService:IPersonPointGeoService
    {
        IRepository<PersonPointGeo> pointgeoRepository;

        public PersonPointGeoService(IRepository<PersonPointGeo> pointgeoRepository)
        {
            this.pointgeoRepository = pointgeoRepository;
        }

        /// <summary>
        /// Deletes a  PersonPointGeo
        /// </summary>
        /// <param name="PersonPointGeo">PersonPointGeo</param>
        public virtual void DeletePersonPointGeo(PersonPointGeo PersonPointGeo)
        {
            pointgeoRepository.Delete(PersonPointGeo);
        }

        /// <summary>
        /// Gets a PersonPointGeo
        /// </summary>
        /// <param name="PersonPointGeoId">The PersonPointGeo identifier</param>
        /// <returns>PersonPointGeo</returns>
        public virtual PersonPointGeo GetPersonPointGeoById(int PersonPointGeoId)
        {
            return pointgeoRepository.GetById(PersonPointGeoId);
        }

        /// <summary>
        /// Inserts a PersonPointGeo item
        /// </summary>
        /// <param name="PersonPointGeo">PersonPointGeo</param>
        public virtual void InsertPersonPointGeo(PersonPointGeo PersonPointGeo)
        {
            pointgeoRepository.Insert(PersonPointGeo);
        }

        /// <summary>
        /// Updates the PersonPointGeo item
        /// </summary>
        /// <param name="PersonPointGeo">PersonPointGeo item</param>
        public virtual void UpdatePersonPointGeo(PersonPointGeo PersonPointGeo)
        {
            pointgeoRepository.Update(PersonPointGeo);
        }
    }
}
