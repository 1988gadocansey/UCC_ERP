namespace UCC_ERP.Domain.Events;

public class StudentRegisteredEvent: DomainEvent
{
    public StudentRegisteredEvent(Student student)
    {
        Student = student;
    }

    public Student Student { get; }
}