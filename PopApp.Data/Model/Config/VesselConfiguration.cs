using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PopApp.Core.Entities;

namespace PopApp.Data.Model.Config
{
    public class VesselConfiguration : IEntityTypeConfiguration<Vessel>
    {
        public void Configure(EntityTypeBuilder<Vessel> builder)
        {
            builder.HasData(
                new Vessel
                {
                    Id = 1,
                    Name = "Ancla",
                    Flag = "Corea del Norte",
                    Code = "MID112000",
                    Imo = "IMO1122334",
                    Slora = 33400,
                    Arrival = "Corea del Norte",
                    IsActive = true
                },
                new Vessel
                {
                    Id = 2,
                    Name = "Simon Peel",
                    Flag = "Antillas Neerlandesas",
                    Code = "MID113000",
                    Imo = "IMO2233445",
                    Slora = 27602,
                    Arrival = "",
                    IsActive = true
                },
                new Vessel
                {
                    Id = 3,
                    Name = "Tempestad",
                    Flag = "Bermudas",
                    Code = "MID114000",
                    Imo = "IMO5566778",
                    Slora = 22731,
                    Arrival = "Bermudas",
                    IsActive = true
                },
                new Vessel
                {
                    Id = 4,
                    Name = "Zafiro",
                    Flag = "Islas Caimán",
                    Code = "MID115000",
                    Imo = "IMO2244661",
                    Slora = 39800,
                    Arrival = "Islas Caimán",
                    IsActive = true
                },
                new Vessel
                {
                    Id = 5,
                    Name = "Calypso",
                    Flag = "Seychelles",
                    Code = "MID116000",
                    Imo = "IMO6677889",
                    Slora = 40000,
                    Arrival = "Seychelles",
                    IsActive = true
                }
           );
        }
    }
}
