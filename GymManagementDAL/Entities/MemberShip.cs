using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementDAL.Entities
{
    public class MemberShip :BaseEntity
    {  
        //StartDate = CreatedAt Of BaseEntity
        public DateTime EndDate { get; set; }
        //Read Only Property 
        public string Status //=> Computed Property 
        {
            get
            {
                if (EndDate >= DateTime.Now)
                    return "Expired";
                else
                    return "Active";
            }
        }

        public int MemberId { get; set; }
        public Member Member { get; set; } = null!;

        public int PlanId { get; set; } 
        public Plan Plan { get; set; } = null!; 
    }
}
