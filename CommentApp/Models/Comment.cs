using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CommentApp.Models
{
    public class Comment
    {
        public List<CommentModels> listComments = new List<CommentModels>();

        public Comment()
        {
            listComments.Add(new CommentModels
            {
                id = listComments.Count + 1,
                name = "Rian",
                comment = "Pretty well",
                insert = DateTime.Now
            });
            listComments.Add(new CommentModels
            {
                id = listComments.Count + 1,
                name = "Toby",
                comment = "Pretty fine",
                insert = DateTime.Now
            });
            listComments.Add(new CommentModels
            {
                id = listComments.Count + 1,
                name = "Ruan",
                comment = "Thats Ok",
                insert = DateTime.Now
            });
        }
        public void InsertComment(CommentModels commentModel)
        {
            listComments.Add(commentModel);
        }

        public CommentModels GetComment(int id)
        {
            CommentModels _commentModel = null;

            foreach (CommentModels _comment in listComments)
                if (_comment.id == id)
                    _commentModel = _comment;

            return _commentModel;
        }

        public void DeleteComment(int id)
        {
            foreach (CommentModels _comment in listComments)
            {
                if (_comment.id == id)
                {
                    listComments.Remove(_comment);

                    break;
                }
            }
        }
    }

    
}