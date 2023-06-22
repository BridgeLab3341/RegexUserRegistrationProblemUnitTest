using RegexUserRegistrationProblemUnitTest;

namespace UserTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenUserFirstName_WhenAnalyze_ShouldReturnValid()
        {
            string first = "Somu";
            UserValidation user=new UserValidation();
            string result = user.FirstName(first);
            Assert.AreEqual(result,"Valid");
        }
    }
}