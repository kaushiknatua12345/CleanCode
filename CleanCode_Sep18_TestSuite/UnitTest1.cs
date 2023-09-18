using CleanCode_Sep18_Repository;

namespace CleanCode_Sep18_TestSuite
{

    //AAA Pattern
    public class Tests
    {
        private EmployeeRepository employeeRepository;
        public Tests() 
        { 
            //Arrange
        employeeRepository = new EmployeeRepository();
        }

        [Test]
        [TestCase(1001,"sam@123",ExpectedResult =true)]
        [TestCase(1002, "joe@123", ExpectedResult = true)]        
        public bool LoginCheck_Success(int id,string password)
        {
            //Act
            bool actualResult = employeeRepository.Login(id, password);
            return actualResult;
        }

        [Test]
        [TestCase(1234, "abc@123", ExpectedResult = false)]
        public bool LoginCheck_ForFailure(int id, string password)
        {
            bool actualResult = employeeRepository.Login(id, password);
            return actualResult;
        }
    }
}