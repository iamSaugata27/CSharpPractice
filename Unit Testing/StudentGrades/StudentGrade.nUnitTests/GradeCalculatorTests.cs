using NUnit.Framework;
using StudentGrades;

namespace StudentGrade.nUnitTests
{
    public class GradeCalculatorTests
    {
        private GradeCalculator _gradeCalculator { get; set; }
        [SetUp]
        public void Setup()
        {
            _gradeCalculator = new GradeCalculator();
        }

        [Test]
        public void GetGradeByPercentage_EqualTest()
        {
            // Assign
            var percentage = 92;

            // Act
            var grade = _gradeCalculator.GetGradeByPercentage(percentage);

            // Assert
            Assert.AreSame("B", grade);

        }
    }
}