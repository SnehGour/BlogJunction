using Server.Data;
using Server.Models;
using Server.Repository.IRepository;

namespace Server.Repository
{
    public class BlogRepositroy : IBlogRepository
    {
        private readonly ApplicationDbContext _db;
        public BlogRepositroy(ApplicationDbContext db)
        {
            _db = db;
        }
        public bool AddBlog(Blog blog)
        {
            _db.blogs.Add(blog);
            return Save();
        }

        public ICollection<Blog> GetAllBlogs()
        {
            return _db.blogs.ToList();
        }

        public bool RemoveBlog(int Id)
        {
            var blog = _db.blogs.FirstOrDefault(x => x.Id == Id);
            if (blog != null)
            {
                _db.blogs.Remove(blog);
                return Save();
            }
            return false;
        }

        public bool Save()
        {
            return _db.SaveChanges() >= 0 ? true : false;
        }

        public bool UpdateBlog(Blog blog, int Id)
        {
            var obj = _db.blogs.FirstOrDefault(x => x.Id == Id);
            if (obj != null)
            {
                obj.Body = blog.Body;
                obj.Category = blog.Category;
                obj.Title = blog.Title;
                obj.User = blog.User;
            
                return Save();
            }
            return false;
        }
    }
}