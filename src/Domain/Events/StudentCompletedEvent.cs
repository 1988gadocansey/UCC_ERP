namespace UCC_ERP.Domain.Events;

public class StudentCompletedEvent: DomainEvent
{
    public StudentCompletedEvent(Student student)
    {
        Student = student;
    }

    public Student Student { get; }
}