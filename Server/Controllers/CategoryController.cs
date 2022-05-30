using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore.Metadata.Internal;
using Server.Data;
using Server.Models;
using Server.Repository.IRepository;

namespace Server.Controllers
{
    public class CategoryController : BaseApiController
    {
        private readonly ICategoryRepository _categoryRepo;
        public CategoryController(ICategoryRepository categoryRepo)
        {
            _categoryRepo = categoryRepo;
        }
        [HttpPost]
        public ActionResult AddCategory([FromBody] Categories category){
        
            if(!ModelState.IsValid)
            {
                return ValidationProblem();
            }
            var obj =  _categoryRepo.AddCategory(category);
            return Ok(category);
        }

        [HttpGet]
        public ActionResult GetAllCategory()
        {
            var categoryList = _categoryRepo.GetAllCategory();
            return Ok(categoryList);
        }
    }
}