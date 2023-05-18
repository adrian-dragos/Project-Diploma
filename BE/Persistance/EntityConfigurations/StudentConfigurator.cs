﻿using Domain.Entities;
using Domain.Enums;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Persistence.EntityConfigurations
{
    internal class StudentConfigurator : IEntityTypeConfiguration<Student>
    {
        public void Configure(EntityTypeBuilder<Student> builder)
        {
            builder.HasData(GetStudents());
        }

        private IReadOnlyCollection<Student> GetStudents()
        {
            var now = DateTime.UtcNow;
            var createdBy = "System Seeding";

            var students = new List<Student>()
            {
                new Student
                {
                    Id = 1,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    IdentityId = 1,
                    GearType = CarGear.Manual
                },
                new Student
                {
                    Id = 2,
                    CreatedAt = now,
                    CreatedBy = createdBy,
                    IdentityId = 7,
                    GearType = CarGear.Manual
                }
            };
            return students;
        }
    }
}
