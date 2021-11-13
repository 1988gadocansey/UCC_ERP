namespace UCC_ERP.Domain.Events;

public class StudentCreatedEvent: DomainEvent
{
    public StudentCreatedEvent(Student student)
    {
        Student = student;
    }

    private Student Student { get; }
}