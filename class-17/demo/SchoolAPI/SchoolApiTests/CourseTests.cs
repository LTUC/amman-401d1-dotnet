using SchoolAPI.Models;
using SchoolAPI.Models.Services;
using System;
using System.Threading.Tasks;
using Xunit;

namespace SchoolApiTests
{

  public class CourseTests : Mock
  {
    //protected async Task<Course> CreateAndSaveTestCourse()
    //{
    //  var course = new Course { CourseCode = "test", TechnologyId = 1 };
    //  _db.Courses.Add(course);
    //  await _db.SaveChangesAsync();
    //  Assert.NotEqual(0, course.Id); // Sanity check
    //  return course;
    //}

    [Fact]
    public async void TestUpdatingCourse()
    {
      Course course = (Course)CreateAndSaveTestCourse().Result;
      string OldCourseCode = course.CourseCode;
      course.CourseCode = "updated test value";
      var CourseService = new CourseService(_db);
      course = await CourseService.UpdateCourse(course.Id, course);
      course = CourseService.GetCourse(course.Id).Result;
      Assert.NotEqual(OldCourseCode, course.CourseCode);
    }

    [Fact]
    public async void TestEnrollingStudent()
    {
      Course course = (Course)CreateAndSaveTestCourse().Result;
      Student student = (Student)CreateAndSaveTestStudent().Result;
      var CourseService = new CourseService(_db);

      await CourseService.AddStudent(course.Id, student.Id);
      course = CourseService.GetCourse(course.Id).Result;

      Assert.Contains(course.Enrollments, e => e.StudentId == student.Id);
    }
    [Fact]
    public async void TestDeletingCourse()
    {
      Course course = (Course)CreateAndSaveTestCourse().Result;
      int id = course.Id;
      var CourseService = new CourseService(_db);
      await CourseService.Delete(id);
      course = await CourseService.GetCourse(id);
      Assert.Null(course);
    }

  }

}
