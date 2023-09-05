using Application.Repository;
using Domain;
using Persistence.Context;
using System.Collections.Generic;
using System.Linq;

namespace Persistence.Repository
{
    public class StudentLectureRepository : Repository<StudentLecture>, IStudentLectureRepository
    {
        private readonly OracleContext _context;

        public StudentLectureRepository(OracleContext context) : base(context)
        {
            _context = context;
        }

        public IQueryable<dynamic> StudenLecture(int id)
        {
            var query = from lecture in _context.Lectures
                join studentLecture in _context.StudentLectures
                    on lecture.Id equals studentLecture.LectureId
                where studentLecture.StudetId == id 
                select new
                {
                    LectureName = lecture.Name,
                    LectureSummester=lecture.Semester,
                    LectureSucces=studentLecture.Succesful
                   
                };

            return query;
        }
    }
}