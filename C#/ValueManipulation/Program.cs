using ValueManipulation.Models;

Person p1 = new Person(name: "Lucas", surname: "Saladini");

Person p2 = new Person(name: "Eduardo", surname: "Neves Queiroz");

Course englishCourse = new Course();

englishCourse.Name = "Inglês";
englishCourse.Students = new List<Person>();

englishCourse.AddStudent(p1);
englishCourse.AddStudent(p2);

englishCourse.ListStudents();



string number1 = "10";
string number2 = "20";

int number3 = 10;
int number4 = 20;

string number5 = "10";
int number6 = 20;

string result = number1 + number2; //concat
int result1 = number3 + number4; //sum
string result3 = number5 + number6; //concat

Console.WriteLine(result);
Console.WriteLine(result1);
Console.WriteLine(result3);