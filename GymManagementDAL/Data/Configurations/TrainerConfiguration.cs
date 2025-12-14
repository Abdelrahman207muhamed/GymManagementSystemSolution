using GymManagementDAL.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace GymManagementDAL.Data.Configurations
{
    public class TrainerConfiguration :GymUserConfiguration<Trainer> ,IEntityTypeConfiguration<Trainer>
    {
        //Hidding
        public new void Configure(EntityTypeBuilder<Trainer> builder)
        {
            builder.Property(X => X.CreatedAt)
               .HasColumnName("HireDate")
               .HasDefaultValueSql("GetDate()");
            base.Configure(builder); //نفذت نفس الكونفيجرشن اللي في الجيم يوزر هنا وفي الميمبر
        }
    }
}
