
using System;
using PeopLost.Core.Domain.Alertes;
using PeopLost.Core.Data;


namespace PeopLost.Service.Alertes
{
    public partial class AlertService: IAlertService
    {
        IRepository<Alert> alertRepository;


        public virtual void DeleteAlert(Alert Alert)
        {
            alertRepository.Delete(Alert);
        }

        public virtual Alert GetAlertById(int AlertId)
        {
            return alertRepository.GetById(AlertId);
        }

        public virtual void InsertAlert(Alert Alert)
        {
            alertRepository.Insert(Alert);
        }

        public virtual void UpdateAlert(Alert Alert)
        {
            alertRepository.Update(Alert);
        }
    }
}
