
namespace PeopLost.Core.Domain.Pictures
{
    public partial class Picture:BaseEntity
    {

        public Picture()
        {

        }
        /// <summary>
        /// Gets or sets the people picture mime type
        /// </summary>
        public string MimeType { get; set; }

        /// <summary>
        /// Gets or sets the people image in bit
        /// </summary>
        public byte[] Binary { get; set; }
    }
}
