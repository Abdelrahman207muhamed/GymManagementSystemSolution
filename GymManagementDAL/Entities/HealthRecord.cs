using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementDAL.Entities
{
    public class HealthRecord:BaseEntity
    {
        //1-1 RelationShips With Member [Shared PK]
        public decimal Height { get; set; }
        public decimal Wieght { get; set; }
        public string BloodType { get; set; } = null!; //Can Make It AS Enum 
        public string? Note { get; set; }
    }
}
