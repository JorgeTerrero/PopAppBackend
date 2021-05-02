using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PopApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PopApp.Data.Model.Config
{
    class ContainerConfiguration : IEntityTypeConfiguration<Container>
    {
        public void Configure(EntityTypeBuilder<Container> builder)
        {
            builder.HasData(
                 
                    new Container
                    {
                        Id = 1,
                        Type = "Dry van (Contenedor seco)",
                        Capacity = 32.96m,
                        Payload = 38600,
                        Height = 2.3241m,
                        Lenght = 5.7912m,
                        Width = 2.1717m,
                        IsActive = true
                    },
                    new Container
                    {
                        Id = 2,
                        Type = "Reefer (Contenedor refigerado)",
                        Capacity = 26.90m,
                        Payload = 38100,
                        Height = 2.286m,
                        Lenght = 5.1816m,
                        Width = 2.15265m,
                        IsActive = true
                    },
                    new Container
                    {
                        Id = 3,
                        Type = "Open top",
                        Capacity = 31.88m,
                        Payload = 38100,
                        Height = 2.3241m,
                        Lenght = 5.7912m,
                        Width = 2.1717m,
                        IsActive = true
                    },
                    new Container
                    {
                        Id = 4,
                        Type = "Flat rack",
                        Capacity = 0,
                        Payload = 45250,
                        Height = 2.0574m,
                        Lenght = 11.8872m,
                        Width = 2.4384m,
                        IsActive = true
                    },
                    new Container
                    {
                        Id = 5,
                        Type = "High Cube",
                        Capacity = 2700,
                        Payload = 45200,
                        Height = 2.4384m,
                        Lenght = 12.0015m,
                        Width = 2.2479m,
                        IsActive = true
                    },
                    new Container
                    {
                        Id = 6,
                        Type = "Open side",
                        Capacity = 3200,
                        Payload = 42600,
                        Height = 6.096m,
                        Lenght = 8.3045m,
                        Width = 2.4025m,
                        IsActive = true
                    },
                    new Container
                    {
                        Id = 7,
                        Type = "Tank",
                        Capacity = 32.96m,
                        Payload = 38600,
                        Height = 2.3241m,
                        Lenght = 5.7912m,
                        Width = 2.1717m,
                        IsActive = true
                    },
                    new Container
                    {
                        Id = 8,
                        Type = "Flexi-Tank",
                        Capacity = 32.96m,
                        Payload = 38600,
                        Height = 2.3241m,
                        Lenght = 5.7912m,
                        Width = 2.1717m,
                        IsActive = true
                    }
                ) ;
        }
    }
}
