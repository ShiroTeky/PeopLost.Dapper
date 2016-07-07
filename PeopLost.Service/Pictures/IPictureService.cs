
using PeopLost.Core.Domain.Pictures;
namespace PeopLost.Service.Pictures
{
    public partial interface IPictureService
    {
        /// <summary>
        /// Deletes a  image
        /// </summary>
        /// <param name="image">Picture</param>
        void DeletePicture(Picture image);

        /// <summary>
        /// Gets a news
        /// </summary>
        /// <param name="pictureId">The picture identifier</param>
        /// <returns>Picture</returns>
        Picture GetPictureById(int PictureId);

        

        /// <summary>
        /// Inserts a picture item
        /// </summary>
        /// <param name="news">Picture</param>
        void InsertPicture(Picture image);

        /// <summary>
        /// Updates the picture item
        /// </summary>
        /// <param name="picture">Picture item</param>
        void UpdatePicture(Picture picture);

        
      
    }
}
