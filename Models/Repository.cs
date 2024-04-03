namespace basics.Models
{
    public class Repository
    {
        private static readonly List<Course> _courses = new();

        static Repository()
        {
            _courses = new List<Course>()
            {
             new Course(){ Id=1 , Title = "aspnet kursu denemesi",Description = "güzel kurs", Image="1.jpeg",
             Tags = new string[] {"aspnet","kurs","test"},
             isActive = true,
             isHome = true
             },
             new Course(){ Id=2 , Title = "php kursu",Description = "güzel kurs 2",Image="2.png",Tags = new string[] {"aspnet","kurs","test"},
             isActive = true,
             isHome = true},
             new Course(){ Id=3 , Title = "python kursu",Description = "güzel kurs 3",Image="3.png",
             isActive = true,
             isHome = true}
            };
        }

        public static List<Course> Courses
        {
            get
            {
                return _courses;
            }
        }

        public static Course? GetById(int? id)
        {
            return _courses.FirstOrDefault(c => c.Id == id);
        }

    }
}