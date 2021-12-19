using DatingApp.Shared.Domin;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DatingApp.Server.Areas.configuration.entity
{
    public class LocationSeedConfiguration : IEntityTypeConfiguration<Location>
    {
        public void Configure(EntityTypeBuilder<Location> builder)
        {
            builder.HasData(
                new Location
                {
                    Id = 1,
                    Location_Gps = "Black",
                },
                    new Location
                    {
                        Id = 2,
                        Location_Gps = "Blue",
                        
                    }
                );
        }
    }
}