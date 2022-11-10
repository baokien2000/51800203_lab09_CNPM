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

        [TestMethod]
        public void Student_Add_false_must_return_False()
        {
            StudentService.StudentService service = new StudentService.StudentService();
            StudentService.Student S1 = new Student() { Id = 1, Name = "Student", Age = 18, Score = 10 };
            StudentService.Student S2 = new Student() { Id = 1, Name = "Student", Age = 18, Score = 10 };
            service.addStudent(S1);
            bool test = service.addStudent(S2);

            Assert.IsFalse(test);
        }
        [TestMethod]
        public void Student_mustAdd_when_didnot_exist()
        {
            StudentService.StudentService service = new StudentService.StudentService();
            StudentService.Student S1 = new Student() { Id = 1, Name = "Student", Age = 18, Score = 10 };
            StudentService.Student S2 = new Student() { Id = 1, Name = "Student", Age = 18, Score = 10 };
            service.addStudent(S1);
            bool test = service.addStudent(S2);

            Assert.IsFalse(test);
        }


        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void passingNullParemeter()
        {
            StudentService.StudentService service = new StudentService.StudentService();
            bool excep = false;
            try
            {
                service.addStudent(null);
            }
            catch(NullReferenceException e)
            {
                excep = true;
            }
            Assert.IsTrue(excep);
        }

        [TestMethod]
        public void Add_success()
        {
            StudentService.StudentService service = new StudentService.StudentService();
            StudentService.Student S1 = new Student() { Id = 1, Name = "Student", Age = 18, Score = 10 };
            bool status = service.addStudent(S1);
            int length = service.size();
            Assert.IsTrue(status);
            Assert.AreEqual(1,length);

        }

        

        [TestMethod]
        public void getStudentAt_mustIN_1_to_n_1()
        {
            StudentService.StudentService service = new StudentService.StudentService();
            StudentService.Student S1 = new Student() { Id = 1, Name = "Student", Age = 18, Score = 10 };
            service.addStudent(S1);
            bool excep = false;
            try
            {
                service.getStudentAt(0);
            }
            catch (NullReferenceException e)
            {
                excep = true;
            }
            Assert.IsTrue(excep);
        }
        [TestMethod]
                         

        public void getStudentAt_mustIN_return_right_message()
        {
            StudentService.StudentService service = new StudentService.StudentService();
            StudentService.Student S1 = new Student() { Id = 1, Name = "Student", Age = 18, Score = 10 };
            service.addStudent(S1);
            String mess = "Index 0 is not available in this array";
            try
            {
                service.getStudentAt(0);
            }
            catch (NullReferenceException e)
            {
                SystemException excep = e;
                Assert.AreEqual(excep, mess);

            }
        }


        public void getStudentAt_return_right_student()
        {
            StudentService.StudentService service = new StudentService.StudentService();
            StudentService.Student S1 = new Student() { Id = 1, Name = "Student", Age = 18, Score = 10 };
            service.addStudent(S1);
            Student a = service.getStudentAt(0);
            Assert.AreEqual(S1, a);
  
        }
    }
}