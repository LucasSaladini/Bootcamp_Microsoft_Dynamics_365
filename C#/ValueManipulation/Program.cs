using ValueManipulation.Models;

Person p1 = new Person(name: "Lucas", surname: "Saladini");

Person p2 = new Person(name: "Eduardo", surname: "Neves Queiroz");

Course englishCourse = new Course();

englishCourse.Name = "Inglês";
englishCourse.Students = new List<Person>();

englishCourse.AddStudent(p1);
englishCourse.AddStudent(p2);

englishCourse.ListStudents();