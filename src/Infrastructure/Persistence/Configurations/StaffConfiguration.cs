using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UCC_ERP.Domain.Entities;

namespace UCC_ERP.Infrastructure.Persistence.Configurations;

public class StaffConfiguration:IEntityTypeConfiguration<Staff>
{
    public void Configure(EntityTypeBuilder<Staff> builder)
    {
        builder.Ignore(e => e.DomainEvents);
    }
}