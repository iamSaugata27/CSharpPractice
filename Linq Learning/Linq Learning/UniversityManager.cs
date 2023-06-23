using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linq_Learning
{
    internal class UniversityManager
    {
        public List<University> Universities;
        public List<Student> Students;

        public UniversityManager()
        {
            Universities = new List<University>();
            Students = new List<Student>();

            Universities.Add(new University { Id = 1, Name = "Oxford" });
            Universities.Add(new University { Id = 2, Name = "Standford" });

            Students.Add(new Student { Id = 1, Name = "Hanta", Gender = "Male", Age = 24, UniversityId = 1 });
            Students.Add(new Student { Id = 2, Name = "Katty", Gender = "FeMale", Age = 22, UniversityId = 1 });
            Students.Add(new Student { Id = 3, Name = "Bunty", Gender = "FeMale", Age = 23, UniversityId = 2 });
            Students.Add(new Student { Id = 4, Name = "Gampii", Gender = "FeMale", Age = 24, UniversityId = 2 });
            Students.Add(new Student { Id = 5, Name = "Bantu", Gender = "Male", Age = 25, UniversityId = 2 });
        }

        public void MaleStudents()
        {
            IEnumerable<Student> maleStudents = from student in Students where student.Gender == "Male" select student;
            Console.WriteLine("Male Students:");
            foreach (Student stu in maleStudents)
            {
                stu.Print();
            }
        }

        public void FeMaleStudents()
        {
            IEnumerable<Student> femaleStudents = from student in Students where student.Gender == "FeMale" select student;
            Console.WriteLine("FeMale Students:");
            foreach (Student stu in femaleStudents)
            {
                stu.Print();
            }
        }

        public void SortStudentByAge()
        {
            var sortedStudents = from studnent in Students orderby studnent.Age select studnent;
            Console.WriteLine("Students Sorted by Age:");
            foreach (var stu in sortedStudents)
            {
                stu.Print();
            }
        }

        public void AllStudentFromStandford()
        {
            var studentsFromStandford = from student in Students join university in Universities on student.UniversityId equals university.Id where university.Name == "Standford" select student;
            Console.WriteLine("Students from Standford University");
            foreach (var stud in studentsFromStandford)
            {
                stud.Print();
            }
        }

        public void AllStudentsFromSameUniversity(int uid)
        {
            var allStudents = from student in Students where student.UniversityId == uid select student;
            Console.WriteLine("All the Students from same University:");
            foreach (Student stu in allStudents)
            {
                stu.Print();
            }
        }

        public void StudentWithUniversityNameCollection()
        {
            var studentWithUniversity = from student in Students join university in Universities 
                                        on student.UniversityId equals university.Id orderby student.Name 
                                        select new { StudentName = student.Name, UniversityName = university.Name};
            Console.WriteLine("Student Name With their respective University Name:");
            foreach (var studUni in studentWithUniversity)
            {
                Console.WriteLine($"Student {studUni.StudentName} from University {studUni.UniversityName}");
            }
        }
    }
}
