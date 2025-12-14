using GymManagementDAL.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementDAL.Entities
{
    public class Trainer:GymUser
    {
        //HiringDate = CreateAt Of BaseEntity
        public Specialties Specialties { get; set; }
        public ICollection<Session> TrainerSessions { get; set; } = null!;

    }
}
