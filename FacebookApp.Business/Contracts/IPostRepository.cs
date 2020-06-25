using FacebookApp.Data.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace FacebookApp.Business.Contracts
{
    interface IPostRepository
    {
        //IEnumerable<Post> GetUserComments(int userId);
        IEnumerable<Post> GetPostWithCommentsAndLikes(int postId);
   
    }
}
