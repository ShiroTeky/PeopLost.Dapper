
using PeopLost.Core.Domain.Pictures;
using PeopLost.Core.Domain.Members;

namespace PeopLost.Service.Members
{
    public partial interface IMemberService
    {
        /// <summary>
        /// Deletes a  member
        /// </summary>
        /// <param name="Member">Member</param>
        public virtual void DeleteMember(Member Member);

        /// <summary>
        /// Gets a member
        /// </summary>
        /// <param name="MemberId">The Member identifier</param>
        /// <returns>Member</returns>
        public virtual Member GetMemberById(int MemberId);

        /// <summary>
        /// Inserts a Member item
        /// </summary>
        /// <param name="news">Member</param>
        public virtual void InsertMember(Member Member);

        /// <summary>
        /// Updates the Member item
        /// </summary>
        /// <param name="Member">Member item</param>
        public virtual void UpdateMember(Member Member);
      
    }
}
