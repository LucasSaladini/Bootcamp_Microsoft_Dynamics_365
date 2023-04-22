using Properties_Methods_Constructors.Models;

Person p1 = new Person("Lucas", "Saladini");

// p1.Name = "Lucas";
// p1.Surname = "Saladini";
// p1.Age = 29;
// p1.Introduce();


Person p2 = new Person("Eduardo", "Neves Queiroz");

Course englishCourse = new Course();

englishCourse.Name = "Inglês";
englishCourse.Students = new List<Person>();

englishCourse.AddStudent(p1);
englishCourse.AddStudent(p2);

englishCourse.ListStudents();