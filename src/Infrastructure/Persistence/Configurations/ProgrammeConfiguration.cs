using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UCC_ERP.Domain.Entities;

namespace UCC_ERP.Infrastructure.Persistence.Configurations;

public class ProgrammeConfiguration:IEntityTypeConfiguration<Programme>
{
    public void Configure(EntityTypeBuilder<Programme> builder)
    {
        builder.Ignore(e => e.DomainEvents);
    }
}