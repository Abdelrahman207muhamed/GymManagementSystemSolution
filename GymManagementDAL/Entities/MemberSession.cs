using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementDAL.Entities
{
    public class MemberSession :BaseEntity
    {
        //BookingDate = CreatedAT Of BaseEntity 
        public bool IsAttended { get; set; }    
        public int MemberId { get; set; }   //FK
        public Member Member { get; set; } = null!;
        public int SessionId { get; set; }  
        public Session Session { get; set; } = null!;
    }
}
