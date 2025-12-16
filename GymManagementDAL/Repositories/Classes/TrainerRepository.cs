using GymManagementDAL.Data.Contexts;
using GymManagementDAL.Entities;
using GymManagementDAL.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementDAL.Repositories.Classes
{
    public class TrainerRepository : ITrainerRepository
    {
        private readonly GymDbContext _dbContext;

        public TrainerRepository(GymDbContext dbContext)
        {
            _dbContext = dbContext;
        }
        public int Add(Trainer trainer)
        {
            _dbContext.Trainers.Add(trainer);
            return _dbContext.SaveChanges();
        }

        public int Delete(Trainer trainer)
        {
            _dbContext.Trainers.Remove(trainer);
            return _dbContext.SaveChanges();
        }

        public IEnumerable<Trainer> GetAll() => _dbContext.Trainers.ToList();

        public Trainer? GetById(int Id) => _dbContext.Trainers.Find(Id);
        public int Update(Trainer trainer)
        {
            _dbContext.Trainers.Update(trainer);
            return _dbContext.SaveChanges();
        }
    }
}
