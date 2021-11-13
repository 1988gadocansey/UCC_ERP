using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UCC_ERP.Domain.Entities;

namespace UCC_ERP.Infrastructure.Persistence.Configurations;

public class CourseConfiguration:IEntityTypeConfiguration<Course>
{
    public void Configure(EntityTypeBuilder<Course> builder)
    {
        builder.Ignore(e => e.DomainEvents);
    }
}