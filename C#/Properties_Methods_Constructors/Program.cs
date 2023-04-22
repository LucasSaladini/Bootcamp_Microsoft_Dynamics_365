using Properties_Methods_Constructors.Models;

Person p1 = new Person();

// p1.Name = "Lucas";
// p1.Surname = "Saladini";
// p1.Age = 29;
// p1.Introduce();

p1.Name = "Lucas";
p1.Surname = "Saladini";

Person p2 = new Person();
p2.Name = "Eduardo";
p2.Surname = "Neves Queiroz";

Course englishCourse = new Course();

englishCourse.Name = "Inglês";
englishCourse.Students = new List<Person>();

englishCourse.AddStudent(p1);
englishCourse.AddStudent(p2);

englishCourse.ListStudents();