using StudentService;

namespace TestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void getLetterScore_must_return_A()
        {
            StudentService.Student S1 = new Student() { Id = 1, Name = "Student", Age = 18, Score = 10 };
            char Test = S1.getLetterScore();
            Assert.AreEqual(Test, 'A');
        }
        [TestMethod]
        public void getLetterScore_must_return_B()
        {
            StudentService.Student S1 = new Student() { Id = 1, Name = "Student", Age = 18, Score = 7.1 };
            char Test = S1.getLetterScore();
            Assert.AreEqual(Test, 'B');
        }
        [TestMethod]
        public void getLetterScore_must_return_C()
        {
            StudentService.Student S1 = new Student() { Id = 1, Name = "Student", Age = 18, Score = 6.1 };
            char Test = S1.getLetterScore();
            Assert.AreEqual(Test, 'C');
        }
        [TestMethod]
        public void getLetterScore_must_return_D()
        {
            StudentService.Student S1 = new Student() { Id = 1, Name = "Student", Age = 18, Score = 3.6 };
            char Test = S1.getLetterScore();
            Assert.AreEqual(Test, 'D');
        }
        [TestMethod]
        public void getLetterScore_must_return_E()
        {
            StudentService.Student S1 = new Student() { Id = 1, Name = "Student", Age = 18, Score = 0 };
            char Test = S1.getLetterScore();
            Assert.AreEqual(Test, 'E');
        }

    }
}