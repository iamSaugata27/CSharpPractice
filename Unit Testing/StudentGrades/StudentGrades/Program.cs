// See https://aka.ms/new-console-template for more information

using StudentGrades;

var gradeCalculator = new GradeCalculator();

Console.WriteLine("Enter percentage:");
var percentage = Convert.ToInt32(Console.ReadLine());

var grade = gradeCalculator.GetGradeByPercentage(percentage);

Console.WriteLine($"Student grade: {grade}");
