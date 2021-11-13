using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UCC_ERP.Domain.Entities;

namespace UCC_ERP.Infrastructure.Persistence.Configurations;

public class StudentConfiguration :IEntityTypeConfiguration<Student>
{
    

    public void Configure(EntityTypeBuilder<Student> builder)
    {
        builder.Ignore(e => e.DomainEvents);

        builder.Property(t => t.Email)
            .HasMaxLength(200)
            .IsRequired();
    }
}