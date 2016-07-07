using System;
using PeopLost.Core.Domain.Administrators;
using PeopLost.Core.Data;

namespace PeopLost.Service.Administrators
{
    public virtual class AdministratorService: IAdministratorService
    {
        IRepository<Administrator> adminRepository;

        public AdministratorService(IRepository<Administrator> adminRepository)
        {
            this.adminRepository = adminRepository;
        }

        public virtual void DeleteAdministrator(Administrator Administrator)
        {
            adminRepository.Delete(Administrator);
        }

        public virtual Administrator GetAdministratorById(int AdministratorId)
        {
            return adminRepository.GetById(AdministratorId);
        }

        public virtual void InsertAdministrator(Administrator Administrator)
        {
            adminRepository.Insert(Administrator);
        }

        public virtual void UpdateAdministrator(Administrator Administrator)
        {
            adminRepository.Update(Administrator);
        }
    }
}
