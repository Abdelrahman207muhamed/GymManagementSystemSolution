using GymManagementDAL.Data.Contexts;
using GymManagementDAL.Entities;
using GymManagementDAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementDAL.Repositories.Classes
{
    public class SessionRepository : ISessionRepository
    {
        private readonly GymDbContext _dbContext;

        public SessionRepository(GymDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Add(Session session)
        {
            _dbContext.Sessions.Add(session);
            return _dbContext.SaveChanges();
        }
        public int Delete(Session session)
        {
            _dbContext.Sessions.Update(session);
            return _dbContext.SaveChanges();
        }

        public IEnumerable<Session> GetAll() => _dbContext.Sessions.ToList();

        public Session? GetBuId(int Id) => _dbContext.Sessions.Find(Id);
        public int Update(Session session)
        {
            _dbContext.Sessions.Update(session);
            return _dbContext.SaveChanges();
        }
    }
}
