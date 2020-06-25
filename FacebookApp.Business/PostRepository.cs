using FacebookApp.Business.Contracts;
using FacebookApp.Data.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FacebookApp.Business
{
    public class PostRepository : GenericRepository<Post>, IPostRepository
    {
        private readonly FacebookAppDbContext _DbContext;

        public PostRepository(FacebookAppDbContext context) :base(context)
        {
            this._DbContext = context;
        }
        
        IEnumerable<Post> IPostRepository.GetPostWithCommentsAndLikes(int postId)
        {
            return _DbContext.Posts
                .Include(p => p.Comments)
                .Include(p=>p.Likes)
                .Where(p => p.UserId == postId);
        }
    }
}
