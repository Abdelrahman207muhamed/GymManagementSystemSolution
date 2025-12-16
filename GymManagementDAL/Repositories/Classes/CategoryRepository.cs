using GymManagementDAL.Data.Contexts;
using GymManagementDAL.Entities;
using GymManagementDAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementDAL.Repositories.Classes
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly GymDbContext _dbContext;

        public CategoryRepository(GymDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Add(Category category)
        {
            _dbContext.Categories.Add(category);
            return _dbContext.SaveChanges();
        }

        public int Delete(Category category)
        {
            _dbContext.Categories.Remove(category);
            return _dbContext.SaveChanges();
        }

        public IEnumerable<Category> GetAll() =>_dbContext.Categories.ToList();

        public Category? GetBuId(int Id) => _dbContext.Categories.Find(Id);

        public int Update(Category category)
        {
            _dbContext.Categories.Update(category);
            return _dbContext.SaveChanges();
        }
    }
}
