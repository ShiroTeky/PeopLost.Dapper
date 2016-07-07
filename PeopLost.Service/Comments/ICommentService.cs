
using PeopLost.Core.Domain.Comments;


namespace PeopLost.Service.Comments
{
    public partial interface ICommentService
    {
        /// <summary>
        /// Deletes a  Comment
        /// </summary>
        /// <param name="Comment">Comment</param>
        public virtual void DeleteComment(Comment Comment);

        /// <summary>
        /// Gets a Comment
        /// </summary>
        /// <param name="CommentId">The Comment identifier</param>
        /// <returns>Comment</returns>
        public virtual Comment GetCommentById(int CommentId);

        /// <summary>
        /// Inserts a Comment item
        /// </summary>
        /// <param name="Comment">Comment</param>
        public virtual void InsertComment(Comment Comment);

        /// <summary>
        /// Updates the Comment item
        /// </summary>
        /// <param name="Comment">Comment item</param>
        public virtual void UpdateComment(Comment Comment);
    }
}
