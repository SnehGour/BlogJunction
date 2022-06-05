using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Server.Data;
using Server.Models;
using Server.Repository.IRepository;

namespace Server.Controllers
{
    public class BlogController : BaseApiController
    {
        private readonly IBlogRepository _blogRepo;
        public BlogController(IBlogRepository blogRepo)
        {
            _blogRepo = blogRepo;
        }

        [HttpGet]
        public ActionResult GetAllBlogs()
        {
            var obj = _blogRepo.GetAllBlogs();
            return Ok(obj);
        }
        [HttpPost]
        public ActionResult AddBlogs([FromBody] Blog blog)
        {
            if(ModelState.IsValid)
            {
                _blogRepo.AddBlog(blog);
                return Ok(blog);
            }
            return ValidationProblem();
        }
    }
}