using PeopLost.Core.Data;
using PeopLost.Core.Domain.Pictures;

namespace PeopLost.Service.Pictures
{
    public partial class PictureService: IPictureService
    {
        IRepository<Picture> pictureRepository;

        public PictureService(IRepository<Picture> pictureRepository)
        {
            this.pictureRepository = pictureRepository;
        }

        public virtual void DeletePicture(Picture image)
        {
            pictureRepository.Delete(image);
        }

        public virtual Picture GetPictureById(int PictureId)
        {
            return pictureRepository.GetById(PictureId);
        }

        public virtual void InsertPicture(Picture image)
        {
            pictureRepository.Insert(image);
        }

        public virtual void UpdatePicture(Picture picture)
        {
            pictureRepository.Update(picture);
        }
    }
}
