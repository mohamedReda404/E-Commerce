using Ecommerce.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Text;

namespace Ecommerce.Infrastructure.Confgurations
{
    internal class UserConfigurations : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(e => e.Email).IsRequired();
            builder.Property(e => e.PasswordHash).IsRequired();
            builder.Property(e => e.UserName).IsRequired();
        }
    }
}
