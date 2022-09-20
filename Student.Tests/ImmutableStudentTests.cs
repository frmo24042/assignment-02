namespace Student.Tests;

public class ImmutableStudentTests
{
    [Fact]
    public void Given_Two_Equal_Students_Then_Status_Equals_True()
    {
        // Given
        ImmutableStudent student1 = new ImmutableStudent(1, "John", "Doe", DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), DateTime.Now.AddDays(3));
        ImmutableStudent student2 = new ImmutableStudent(1, "John", "Doe", DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), DateTime.Now.AddDays(3));
        // When
        bool result = student1.GetStatus().Equals(student2.GetStatus());
        // Then
        Assert.True(result);
    }

    [Fact]
    public void Given_New_Student_Returns_String()
    {
        // Given
        ImmutableStudent student = new ImmutableStudent(1, "John", "Doe", DateTime.Now.AddDays(1), DateTime.Now.AddDays(2), DateTime.Now.AddDays(3));
        // When
        string result = student.ToString();
        // Then
        Assert.Equal($"Id: 1, GivenName: John, Surname: Doe, status: New, StartDate: {DateTime.Now.AddDays(1)}, EndDate: {DateTime.Now.AddDays(2)}, GraduationDate: {DateTime.Now.AddDays(3)}", result);
    }


}