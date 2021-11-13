using UCC_ERP.Application.Common.Interfaces;

namespace UCC_ERP.Infrastructure.Services;

public class DateTimeService : IDateTime
{
    public DateTime Now => DateTime.Now;
}
