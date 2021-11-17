namespace UCC_ERP.Domain.Events;

public class CollegeCreatedEvent: DomainEvent
{
    public CollegeCreatedEvent(College college)
    {
        College = college;
    }

    private College College { get; }
}