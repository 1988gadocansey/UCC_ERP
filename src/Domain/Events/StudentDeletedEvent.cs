namespace UCC_ERP.Domain.Events;

public class StudentDeletedEvent: DomainEvent
{
    public StudentDeletedEvent(Student student)
    {
        Student = student;
    }
    public Student Student { get; }
}