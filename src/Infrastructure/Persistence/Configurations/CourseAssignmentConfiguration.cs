using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UCC_ERP.Domain.Entities;

namespace UCC_ERP.Infrastructure.Persistence.Configurations;

public class CourseAssignmentConfiguration:IEntityTypeConfiguration<CourseAssignment>
{
    public void Configure(EntityTypeBuilder<CourseAssignment> builder)
    {
        builder.Ignore(e => e.DomainEvents);
    }
}