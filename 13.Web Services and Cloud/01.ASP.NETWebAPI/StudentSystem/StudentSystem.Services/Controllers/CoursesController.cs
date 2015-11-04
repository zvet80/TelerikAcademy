namespace StudentSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Data;
    using Models;
    using StudentSystem.Models;    

    public class CoursesController : ApiController
    {
        private IStudentsSystemData db;

        public CoursesController()
            : this(new StudentsSystemData())
        {
        }

        public CoursesController(IStudentsSystemData data)
        {
            this.db = data;
        }

        public IHttpActionResult Get()
        {
            return this.Ok(
                this.db
                .Courses
                .All()
                .ToList());
        }

        public IHttpActionResult Get(int id)
        {
            var course =
                this.db
                .Courses
                .All()
                .FirstOrDefault(c => c.Id == id);

            if (course == null)
            {
                return this.NotFound();
            }

            return this.Ok(course);
        }

        public IHttpActionResult Post(CourseRequestModel course)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var courseToPost = new Course()
            {
                Name = course.Name,
                Description = course.Description
            };

            this.db.Courses.Add(courseToPost);
            this.db.SaveChanges();

            return this.Ok(course);
        }

        public IHttpActionResult Put(int id, CourseRequestModel course)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var courseToUpdate =
                this.db
                .Courses
                .All()
                .FirstOrDefault(c => c.Id == id);

            courseToUpdate.Name = course.Name;
            courseToUpdate.Description = course.Description;

            this.db.SaveChanges();

            return this.Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var course =
                this.db
                .Courses
                .All()
                .FirstOrDefault(c => c.Id == id);

            if (course == null)
            {
                return this.NotFound();
            }

            this.db.Courses.Delete(course);
            this.db.SaveChanges();
            return this.Ok();
        }
    }
}