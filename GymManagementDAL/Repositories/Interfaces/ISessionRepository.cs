using GymManagementDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementDAL.Repositories.Interfaces
{
    public interface ISessionRepository
    {
        IEnumerable<Session> GetAll();
        Session? GetBuId(int Id);
        int Add(Session session);
        int Update(Session session);
        int Delete(Session session);
    }
}
