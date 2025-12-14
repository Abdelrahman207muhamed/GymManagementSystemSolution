using GymManagementDAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementDAL.Data.Configurations
{
    public class MemberConfiguration :GymUserConfiguration<Member> ,IEntityTypeConfiguration<Member> 
    {
        //Hidding
        public new void Configure(EntityTypeBuilder<Member> builder)
        {
            builder.Property(X => X.CreatedAt)
                .HasColumnName("JoinDtae")
                .HasDefaultValueSql("GetDate()");

            base.Configure(builder); //نفذت نفس الكونفجريشن اللي في الجيم يوزر هنا وفي الترينر
                 
        }
    }
}
