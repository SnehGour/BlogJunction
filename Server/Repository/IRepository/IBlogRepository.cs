using Server.Models;

namespace Server.Repository.IRepository
{
    public interface IBlogRepository
    {
        public ICollection<Blog> GetAllBlogs();
        public bool AddBlog(Blog blog);
        public bool UpdateBlog(Blog blog,int Id);
        public bool RemoveBlog(int Id);
        public bool Save();
    }
}