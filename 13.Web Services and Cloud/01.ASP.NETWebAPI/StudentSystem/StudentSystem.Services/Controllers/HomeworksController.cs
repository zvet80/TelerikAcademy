namespace StudentSystem.Services.Controllers
{
    using System.Linq;
    using System.Web.Http;
    using Data;
    using Models;
    using StudentSystem.Models;    

    public class HomeworksController : ApiController
    {
        private IStudentsSystemData db;

        public HomeworksController()
            : this(new StudentsSystemData())
        {
        }

        public HomeworksController(IStudentsSystemData data)
        {
            this.db = data;
        }

        public IHttpActionResult Get()
        {
            return this.Ok(
                this.db
                .Homeworks
                .All()
                .ToList());
        }

        public IHttpActionResult Get(int id)
        {
            var homework =
                this.db
                .Homeworks
                .All()
                .FirstOrDefault(h => h.Id == id);

            if (homework == null)
            {
                return this.NotFound();
            }

            return this.Ok(homework);
        }

        public IHttpActionResult Post(HomeworkRequestModel homework)
        {
            if (!this.ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var homeworkToPost = new Homework()
            {
                StudentIdentification = homework.StudentId,
                CourseId = homework.CourseId,
                TimeSent = homework.TimeSent
            };

            this.db.Homeworks.Add(homeworkToPost);
            this.db.SaveChanges();

            return this.Ok(homework);
        }

        public IHttpActionResult Put(int id, HomeworkRequestModel homework)
        {
            if (!ModelState.IsValid)
            {
                return this.BadRequest(this.ModelState);
            }

            var homeworkToUpdate =
                this.db
                .Homeworks
                .All()
                .FirstOrDefault(h => h.Id == id);

            homeworkToUpdate.StudentIdentification = homework.StudentId;
            homeworkToUpdate.CourseId = homework.CourseId;
            homeworkToUpdate.TimeSent = homework.TimeSent;

            this.db.SaveChanges();

            return this.Ok();
        }

        public IHttpActionResult Delete(int id)
        {
            var homework =
                this.db
                .Homeworks
                .All()
                .FirstOrDefault(h => h.Id == id);

            if (homework == null)
            {
                return this.NotFound();
            }

            this.db.Homeworks.Delete(homework);
            this.db.SaveChanges();
            return this.Ok();
        }
    }
}