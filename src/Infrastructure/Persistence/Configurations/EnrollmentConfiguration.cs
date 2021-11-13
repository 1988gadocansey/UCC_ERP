using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UCC_ERP.Domain.Entities;

namespace UCC_ERP.Infrastructure.Persistence.Configurations;

public class EnrollmentConfiguration:IEntityTypeConfiguration<Enrollment>
{
    public void Configure(EntityTypeBuilder<Enrollment> builder)
    {
        builder.Ignore(e => e.DomainEvents);
    }
}