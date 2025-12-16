using GymManagementDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementDAL.Repositories.Interfaces
{
    public interface ICategoryRepository
    {
        IEnumerable<Category> GetAll();
        Category? GetBuId(int Id);
        int Add(Category category);
        int Update(Category category);
        int Delete(Category category);
    }
}
