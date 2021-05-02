using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PopApp.Core.Entities;
using System;

namespace PopApp.Data.Model.Config
{
    public class FreightConfiguration : IEntityTypeConfiguration<Freight>
    {
        public void Configure(EntityTypeBuilder<Freight> builder)
        {
            builder.HasData(
                    new Freight
                    {
                        Id = 1,
                        Code = "CR0001",
                        Type = "loose load",
                        Description = "individual merchandise is transported such as bales, packages, sacks, boxes, etc.",
                        IsActive = true
                    },
                    new Freight
                    {
                        Id= 2,
                        Code = "CR0002",
                        Type = "unitized load",
                        Description = "when the merchandise is placed in individual items such as boxes, packages or other elements grouped in pre-line, pallets, containers.",
                        IsActive = true
                    },
                    new Freight
                    {
                        Id =3,
                        Code = "CR003",
                        Type = "solid bulks",
                        Description = "are generally stored in tanks",

                    },
                    new Freight
                    {
                        Id = 4,
                        Code = "CR004",
                        Type = "liquid bulk",
                        Description = "are transported in tank wagons and pipelines."
                    },
                    new Freight
                    {
                        Id = 5,
                        Code = "CR005",
                        Type = "perishable load",
                        Description = "are the loads that need refrigeration, preservatives, vacuum bag etc."
                    }, new Freight
                    {
                        Id = 6,
                        Code = "CR006",
                        Type = "dangerous load",
                        Description = "loads with highly dangerous"
                    } ,
                    new Freight
                    {
                        Id = 7,
                        Code = "CR007",
                        Type = "fragile load",
                        Description = "loads with highly fragility"
                    }
                );
        }
    }
}
