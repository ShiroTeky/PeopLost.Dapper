using PeopLost.Core.Domain.Comments;
using PeopLost.Core.Domain.Alertes;

namespace PeopLost.Service.Alertes
{
    public partial interface IAlertService
    {

        /// <summary>
        /// Deletes a  Alert
        /// </summary>
        /// <param name="Alert">Alert</param>
        public virtual void DeleteAlert(Alert Alert);

        /// <summary>
        /// Gets a Alert
        /// </summary>
        /// <param name="AlertId">The Alert identifier</param>
        /// <returns>Alert</returns>
        public virtual Alert GetAlertById(int AlertId);

        /// <summary>
        /// Inserts a Alert item
        /// </summary>
        /// <param name="Alert">Alert</param>
        public virtual void InsertAlert(Alert Alert);

        /// <summary>
        /// Updates the Alert item
        /// </summary>
        /// <param name="Alert">Alert item</param>
        public virtual void UpdateAlert(Alert Alert);

    }
}
