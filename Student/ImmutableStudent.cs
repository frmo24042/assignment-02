namespace Student;

public record ImmutableStudent
{
    public enum Status { New, Active, Dropout, Graduated }
    public int Id { get; init; }
    public string GivenName { get; init; }
    public string Surname { get; init; }
    public Status status { get => GetStatus();}
    public DateTime StartDate { get; init; }
    public DateTime EndDate { get; init; }
    public DateTime GraduationDate { get; init; }

    public ImmutableStudent(int id, string givenName, string surname, DateTime startDate, DateTime endDate, DateTime graduationDate)
    {
        Id = id;
        GivenName = givenName;
        Surname = surname;
        StartDate = startDate;
        EndDate = endDate;
        GraduationDate = graduationDate;
    }

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