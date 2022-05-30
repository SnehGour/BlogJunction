using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Server.Data;
using Server.Models;
using Server.Repository.IRepository;

namespace Server.Repository
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _db;
        public CategoryRepository(ApplicationDbContext db)
        {
            _db = db;
        }

        public bool AddCategory(Categories category)
        {
            _db.categories.Add(category);
            return Save();
        }

        public ICollection<Categories> GetAllCategory()
        {
            return _db.categories.ToList();
        }

        public bool RemoveCategory(int id)
        {
            var obj = _db.categories.FirstOrDefault(x=>x.CategoryId == id);
            if(obj !=null)
            {
                _db.categories.Remove(obj);
            }
            return Save();
        }

        public bool Save()
        {
            return _db.SaveChanges() == 0 ? true : false; 
        }

        public bool UpdateCategory(Categories category, int id)
        {
            var obj = _db.categories.FirstOrDefault(x=>x.CategoryId == id);
            if(obj!=null)
            {
                obj.CategoryName = category.CategoryName;
            }
            return Save();
        }
    }
}