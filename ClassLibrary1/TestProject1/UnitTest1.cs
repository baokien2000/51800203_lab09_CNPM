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


    }
}