using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UCC_ERP.Domain.Entities;

namespace UCC_ERP.Infrastructure.Persistence.Configurations;

public class CalenderConfiguration:IEntityTypeConfiguration<Calender>
{
    public void Configure(EntityTypeBuilder<Calender> builder)
    {
        builder.Ignore(e => e.DomainEvents);
    }
}