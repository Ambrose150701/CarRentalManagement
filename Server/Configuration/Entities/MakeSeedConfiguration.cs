using System;
using CarRentalManagement.Shared.Domain;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CarRentalManagement.Server.Configuration.Entities
{
    public class MakeSeedConfiguration : IEntityTypeConfiguration<Make>
    {
        public void Configure(Microsoft.EntityFrameworkCore.Metadata.Builders.EntityTypeBuilder<Make> builder)
        {
            builder.HasData(
             new Make
             {
                 Id = 1,
                 Name = "BMW",
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 Updatedby = "System"
             },

             new Make
             {
                 Id = 2,
                 Name = "Toyota",
                 DateCreated = DateTime.Now,
                 DateUpdated = DateTime.Now,
                 CreatedBy = "System",
                 Updatedby = "System"
             }
        );
        }

        public void Configure(EntityTypeBuilder<Model> builder)
        {
            throw new NotImplementedException();
        }

    }
}
