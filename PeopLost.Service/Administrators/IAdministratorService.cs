using PeopLost.Core.Domain.Administrators;
using System;


namespace PeopLost.Service.Administrators
{
    public partial interface IAdministratorService
    {
        /// <summary>
        /// Deletes a  Administrator
        /// </summary>
        /// <param name="Administrator">Administrator</param>
        public virtual void DeleteAdministrator(Administrator Administrator);

        /// <summary>
        /// Gets a Administrator
        /// </summary>
        /// <param name="AdministratorId">The Administrator identifier</param>
        /// <returns>Administrator</returns>
        public virtual Administrator GetAdministratorById(int AdministratorId);

        /// <summary>
        /// Inserts a Administrator item
        /// </summary>
        /// <param name="Administrator">Administrator</param>
        public virtual void InsertAdministrator(Administrator Administrator);

        /// <summary>
        /// Updates the Administrator item
        /// </summary>
        /// <param name="Administrator">Administrator item</param>
        public virtual void UpdateAdministrator(Administrator Administrator);
        
    }
}
