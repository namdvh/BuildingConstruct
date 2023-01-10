﻿using Data.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Data.Configuration
{
    public class CartConfiguration : IEntityTypeConfiguration<Cart>
    {
        public void Configure(EntityTypeBuilder<Cart> builder)
        {
            builder.ToTable("Carts");

            builder.HasKey(x => new { x.UserID, x.ProductID });



            builder.HasOne(x => x.User).WithMany(x => x.Carts).HasForeignKey(x => x.UserID);
            builder.HasOne(x => x.Products).WithMany(x => x.Carts).HasForeignKey(x => x.ProductID);
        }
    }
}