using Microsoft.AspNetCore.Mvc;
using Server.Models;

namespace Server.Repository.IRepository
{
    public interface ICategoryRepository
    {
       bool AddCategory(Categories category);
       bool UpdateCategory(Categories category,int id);
       bool RemoveCategory(int id);
       ICollection<Categories> GetAllCategory();

       bool Save();
    }
}