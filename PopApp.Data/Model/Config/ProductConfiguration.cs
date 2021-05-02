using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using PopApp.Core.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace PopApp.Data.Model.Config
{
    public class ProductConfiguration : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                   new Product
                   {
                       Id = 1,
                       Category = "Granel",
                       Name = "Azucar" ,
                       description = "se utiliza para multi proposito en la cocina." ,
                       ContainerType = 3,
                       IsActive = true
                   },
                   new Product
                   {
                       Id = 2,
                       Category = "Granel",
                       Name = "Trigo" ,
                       description = "Es un cereal que se utiliza mucho en la cocina." ,
                       ContainerType = 3,
                       IsActive = true
                   },
                   new Product
                   {
                       Id = 3,
                       Category = "Granel",
                       Name = "Soya" ,
                       description = "Es por tanto una buena fuente de proteína vegetal, de vitaminas y de minerales.",
                       ContainerType = 3,
                       IsActive = true
                   },
                   new Product
                   {
                       Id = 4,
                       Category = "Granel liquido",
                       Name = "Cerveza" ,
                       description = "Es una bebida alcohólica, no destilada, de sabor amargo, que se fabrica con granos de cebada.",
                       ContainerType = 4,
                       IsActive = true
                   },
                   new Product
                   {
                       Id = 5,
                       Category = "Granel liquido",
                       Name = "Leche" ,
                       description = "Bebida nutritiva de alta importancia." ,
                       ContainerType = 4,
                       IsActive = true
                   },
                   new Product
                   {
                       Id = 6,
                       Category = "Perecible",
                       Name = "Mariscos" ,
                       description = "Animal marino usado para la gastronomia." ,
                       ContainerType = 5,
                       IsActive = true
                   },
                   new Product
                   {
                       Id = 7,
                       Category = "Fragil",
                       Name = "Plastico" ,
                       description = "Material para hacer varios productos." ,
                       ContainerType = 8,
                       IsActive = true
                   },
                   new Product
                   {
                       Id = 8,
                       Category = "Peligro",
                       Name = "Quimicos" ,
                       description = "objectos de alta peligrosidad para la salud." ,
                       ContainerType = 6,
                       IsActive = true
                   }
                   
                );
        }
    }
}
