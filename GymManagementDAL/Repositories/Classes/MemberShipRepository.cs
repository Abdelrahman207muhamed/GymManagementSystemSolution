using GymManagementDAL.Data.Contexts;
using GymManagementDAL.Entities;
using GymManagementDAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementDAL.Repositories.Classes
{
    public class MemberShipRepository : IMemberShipRepository
    {
        private readonly GymDbContext _dbContext;

        public MemberShipRepository(GymDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Add(MemberShip memberShip)
        {
            _dbContext.MemberShips.Add(memberShip);
            return _dbContext.SaveChanges();
        }

        public int Delete(MemberShip memberShip)
        {
            _dbContext.MemberShips.Remove(memberShip);
            return _dbContext.SaveChanges();
        }

        public IEnumerable<MemberShip> GetAll() => _dbContext.MemberShips.ToList();

        public MemberShip? GetById(int Id) => _dbContext.MemberShips.Find(Id);

        public int Update(MemberShip memberShip)
        {
            _dbContext.MemberShips.Update(memberShip);
            return _dbContext.SaveChanges();
        }
    }
}
