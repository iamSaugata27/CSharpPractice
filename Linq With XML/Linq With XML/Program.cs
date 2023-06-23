﻿using System;
using System.Linq;
using System.Xml.Linq;

namespace Linq_With_XML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //We simply apply our Student-Structure to XML. 
            string studentsXML =
                        @"<Students>
                            <Student>
                                <Name>Toni</Name>
                                <Age>21</Age>
                                <University>Yale</University>
                                <Semester>6</Semester>
                            </Student>
                            <Student>
                                <Name>Carla</Name>
                                <Age>17</Age>
                                <University>Yale</University>
                                <Semester>1</Semester>
                            </Student>
                            <Student>
                                <Name>Leyla</Name>
                                <Age>19</Age>
                                <University>Beijing Tech</University>
                                <Semester>3</Semester>
                            </Student>
                            <Student>
                                <Name>Frank</Name>
                                <Age>25</Age>
                                <University>Beijing Tech</University>
                                <Semester>10</Semester>
                            </Student>
                        </Students>";

            //XDocument studentsXdoc = new XDocument();
            var studentsXdoc = XDocument.Parse(studentsXML);
            var students = from student in studentsXdoc.Descendants("Student")
                           select new
                           {
                               StudentName = student.Element("Name").Value,
                               StudentAge = student.Element("Age").Value,
                               UniversityName = student.Element("University").Value,
                               Semester=student.Element("Semester").Value
                           };
            foreach (var student in students)
            {
                Console.WriteLine($"Student {student.StudentName} with Age {student.StudentAge} from university {student.UniversityName} is in his/her Semester {student.Semester}");
            }

            var sortedStudents = from student in students orderby student.StudentAge select student;
            Console.WriteLine("Students by sorting with their Ages:");
            foreach (var student in sortedStudents)
            {
                Console.WriteLine($"Student {student.StudentName} with Age {student.StudentAge} from university {student.UniversityName} is in his/her Semester {student.Semester}");
            }
        }
    }
}
