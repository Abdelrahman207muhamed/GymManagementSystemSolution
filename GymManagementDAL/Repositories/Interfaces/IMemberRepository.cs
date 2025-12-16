using GymManagementDAL.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementDAL.Repositories.Interfaces
{
    public interface IMemberRepository
    {
        //GetAll
        IEnumerable<Member> GetAll();
        //GetById
        Member? GetById(int Id);
        //Add
        int Add(Member member);
        //Update
        int Update(Member member);
        //Delete
        int Delete(int Id);
    }
}
