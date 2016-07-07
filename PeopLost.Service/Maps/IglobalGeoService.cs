

using PeopLost.Core.Domain.Maps;
namespace PeopLost.Service.Maps
{
    public partial interface IglobalGeoService
    {
        /// <summary>
        /// Deletes a  globalGeo
        /// </summary>
        /// <param name="globalGeo">globalGeo</param>
        public virtual void DeleteglobalGeo(globalGeo globalGeo);

        /// <summary>
        /// Gets a globalGeo
        /// </summary>
        /// <param name="globalGeoId">The globalGeo identifier</param>
        /// <returns>globalGeo</returns>
        public virtual globalGeo GetglobalGeoById(int globalGeoId);

        /// <summary>
        /// Inserts a globalGeo item
        /// </summary>
        /// <param name="globalGeo">globalGeo</param>
        public virtual void InsertglobalGeo(globalGeo globalGeo);

        /// <summary>
        /// Updates the globalGeo item
        /// </summary>
        /// <param name="globalGeo">globalGeo item</param>
        public virtual void UpdateglobalGeo(globalGeo globalGeo);
    }
}
