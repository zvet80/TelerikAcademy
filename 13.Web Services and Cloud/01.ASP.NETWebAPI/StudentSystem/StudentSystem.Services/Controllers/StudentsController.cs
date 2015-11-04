namespace StudentSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Data;
    using Models;
    using StudentSystem.Models;

    public class StudentsController : ApiController
    {
        private IStudentsSystemData db;

        public StudentsController()
            : this(new StudentsSystemData())
        {
        }

        public StudentsController(IStudentsSystemData data)
        {
            this.db = data;
        }

        public IHttpActionResult Get()
        {
            return this.Ok(
                this.db
                .Students
                .All()
                .ToList());
        }

        public IHttpActionResult Get(int id)
        {
            var student =
                this.db
                .Students
                .All()
                .FirstOrDefault(s => s.StudentIdentification == id);

            if (student == null)
            {
                return this.NotFound();
            }

            return this.Ok(student);
        }

        public IHttpActionResult Post(StudentRequestModel student)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var studentToPost = new Student()
            {
                FirstName = student.FirstName,
                LastName = student.LastName
            };

            this.db.Students.Add(studentToPost);
            this.db.SaveChanges();

            return this.Ok(student);
        }

        public IHttpActionResult Put(int id, [FromBody]StudentRequestModel student)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var studentToUpdate =
                this.db
                .Students
                .All()
                .FirstOrDefault(s => s.StudentIdentification == id);

            studentToUpdate.FirstName = student.FirstName;
            studentToUpdate.LastName = student.LastName;

            this.db.SaveChanges();

            return this.Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var student =
                this.db
                .Students
                .All()
                .FirstOrDefault(s => s.StudentIdentification == id);

            if (student == null)
            {
                return this.NotFound();
            }

            this.db.Students.Delete(student);
            this.db.SaveChanges();
            return this.Ok();
        }
    }
}