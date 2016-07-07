
using PeopLost.Core.Domain.Maps;
namespace PeopLost.Service.Maps
{
    public partial interface IPersonPointGeoService
    {
        /// <summary>
        /// Deletes a  PersonPointGeo
        /// </summary>
        /// <param name="PersonPointGeo">PersonPointGeo</param>
        public virtual void DeletePersonPointGeo(PersonPointGeo PersonPointGeo);

        /// <summary>
        /// Gets a PersonPointGeo
        /// </summary>
        /// <param name="PersonPointGeoId">The PersonPointGeo identifier</param>
        /// <returns>PersonPointGeo</returns>
        public virtual PersonPointGeo GetPersonPointGeoById(int PersonPointGeoId);

        /// <summary>
        /// Inserts a PersonPointGeo item
        /// </summary>
        /// <param name="PersonPointGeo">PersonPointGeo</param>
        public virtual void InsertPersonPointGeo(PersonPointGeo PersonPointGeo);

        /// <summary>
        /// Updates the PersonPointGeo item
        /// </summary>
        /// <param name="PersonPointGeo">PersonPointGeo item</param>
        public virtual void UpdatePersonPointGeo(PersonPointGeo PersonPointGeo);
    }
}
