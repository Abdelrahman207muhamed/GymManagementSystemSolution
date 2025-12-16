using GymManagementDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementDAL.Repositories.Interfaces
{
    public interface IPlanRepository
    {
        //GetAll
        IEnumerable<Plan> GetAll();
        //GetById
        Plan? GetById(int Id);
        //Add
        int Add(Plan plan);
        //Update
        int Update(Plan plan);
        //Delete
        int Delete(Plan plan);
    }
}
