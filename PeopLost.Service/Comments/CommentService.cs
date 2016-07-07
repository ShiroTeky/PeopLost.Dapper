using System;
using PeopLost.Core.Domain.Comments;
using PeopLost.Core.Data;

namespace PeopLost.Service.Comments
{
    public partial class CommentService:ICommentService
    {
        IRepository<Comment> commentRepository;

        public CommentService(IRepository<Comment> commentRepository)
        {
            this.commentRepository = commentRepository;
        }

        public virtual void DeleteComment(Comment Comment)
        {
            commentRepository.Delete(Comment);
        }

        public virtual Comment GetCommentById(int CommentId)
        {
            return commentRepository.GetById(CommentId);
        }

        public virtual void InsertComment(Comment Comment)
        {
            commentRepository.Insert(Comment);
        }

        public virtual void UpdateComment(Comment Comment)
        {
            commentRepository.Update(Comment);
        }
    }
}
