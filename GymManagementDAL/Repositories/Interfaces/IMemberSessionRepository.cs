using GymManagementDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementDAL.Repositories.Interfaces
{
    public interface IMemberSessionRepository
    {
        IEnumerable<MemberSession> GetAll();
        MemberSession? GetById(int Id);
        int Add(MemberSession memberSession);
        int Update(MemberSession memberSession);
        int Delete(MemberSession memberSession);
    }
}
