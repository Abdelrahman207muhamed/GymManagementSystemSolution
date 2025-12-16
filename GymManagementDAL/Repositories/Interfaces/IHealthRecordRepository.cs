using GymManagementDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementDAL.Repositories.Interfaces
{
    public interface IHealthRecordRepository
    {
        //GetAll
        IEnumerable<HealthRecord> GetAll();
        //GetById
        HealthRecord? GetById(int Id);
        //Add
        int Add(HealthRecord healthRecord);
        //Update
        int Update(HealthRecord healthRecord);
        //Delete
        int Delete(HealthRecord healthRecord);
    }
}
