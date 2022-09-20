namespace Student.Tests;

public class StudentTests
{
    [Fact]
    public void Given_New_Student_get_status()
    {
        // Given
        Student student = new Student{Id = 1, GivenName = "John", Surname = "Doe", StartDate = DateTime.Now.AddDays(1), EndDate = DateTime.Now.AddDays(2), GraduationDate = DateTime.Now.AddDays(3)};

        // When
        var status = student.status;

        // Then
        Assert.Equal(Student.Status.New, status);
    }

    [Fact]
    public void Given_New_Student_Get_Status_Active()
    {
        // Given
        Student student = new Student{Id = 1, GivenName = "John", Surname = "Doe", StartDate = DateTime.Now.AddDays(-1), EndDate = DateTime.Now.AddDays(2), GraduationDate = DateTime.Now.AddDays(3)};
        // When
        var status = student.status;
        // Then
        Assert.Equal(Student.Status.Active, status);
    }

    [Fact]
    public void Given_New_Student_Get_Status_Gratuated()
    {
        // Given
        Student student = new Student{Id = 1, GivenName = "John", Surname = "Doe", StartDate = DateTime.Now.AddDays(-3), EndDate = DateTime.Now.AddDays(-1), GraduationDate = DateTime.Now.AddDays(-2)};
        // When
        var status = student.status;
        // Then
        Assert.Equal(Student.Status.Graduated, status);
    }

    [Fact]
    public void Given_New_Student_Get_Status_Dropout()
    {
        // Given
        Student student = new Student{Id = 1, GivenName = "John", Surname = "Doe", StartDate = DateTime.Now.AddDays(-3), EndDate = DateTime.Now.AddDays(-2), GraduationDate = DateTime.Now.AddDays(1)};
        // When
        var status = student.status;
        // Then
        Assert.Equal(Student.Status.Dropout, status);
    }

    [Fact]
    public void Given_new_student_get_a_string_repesentation()
    {
        // Given
        Student student = new Student{Id = 1, GivenName = "John", Surname = "Doe", StartDate = DateTime.Now.AddDays(1), EndDate = DateTime.Now.AddDays(2), GraduationDate = DateTime.Now.AddDays(3)};
        // When
        string result = student.ToString();
        // Then
        Assert.Equal($"Id: 1, GivenName: John, Surname: Doe, status: New, StartDate: {DateTime.Now.AddDays(1)}, EndDate: {DateTime.Now.AddDays(2)}, GraduationDate: {DateTime.Now.AddDays(3)}", result);
    }
}