namespace Student;
public class Student
{
    public enum Status { New, Active, Dropout, Graduated }
    public int Id { get; init; }
    public string GivenName { get; set; }
    public string Surname { get; set; }
    public Status status { get => GetStatus();}
    public DateTime StartDate { get; set; }
    public DateTime EndDate { get; set; }
    public DateTime GraduationDate { get; set; }

    public Status GetStatus()
    {
        if (StartDate > DateTime.Now)
        {
            return Status.New;
        }
        else if (EndDate > DateTime.Now)
        {
            return Status.Active;
        }
        else if (GraduationDate > DateTime.Now)
        {
            return Status.Dropout;
        }
        else
        {
            return Status.Graduated;
        }
    }

    public override string ToString() => $"{nameof(Id)}: {Id}, {nameof(GivenName)}: {GivenName}, {nameof(Surname)}: {Surname}, {nameof(status)}: {status}, {nameof(StartDate)}: {StartDate}, {nameof(EndDate)}: {EndDate}, {nameof(GraduationDate)}: {GraduationDate}";

}
