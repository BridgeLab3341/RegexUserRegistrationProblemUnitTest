using RegexUserRegistrationProblemUnitTest;

namespace UserTestProject
{
    [TestClass]
    public class UnitTest1
    {
        UserValidation user = new UserValidation();
        [TestMethod]
        public void GivenUserFirstName_WhenAnalyze_ShouldReturnValid()
        {
            string first = "Soma";           
            string result = user.FirstName(first);
            Assert.AreEqual(result,"Valid");
        }
        [TestMethod]
        public void GivenUserLastName_WhenAnalyze_ShouldReturnValid()
        {
            string last = "Shekar";
            string result = user.LastName(last);
            Assert.AreEqual(result, "Valid");
        }
    }
}