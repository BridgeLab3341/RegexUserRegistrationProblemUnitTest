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
        [TestMethod]
        public void GivenUserEmail_WhenAnalyze_ShouldReturnValid()
        {
            string email = "abc.xyz@bl.co.in";
            string result = user.Email(email);
            Assert.AreEqual(result, "Valid");
        }
        [TestMethod]
        public void GivenUserPhoneNumber_WhenAnalyze_ShouldReturnValid()
        {
            string PhoneNumber = "91 9933772634";
            string result=user.MobileNumber(PhoneNumber);
            Assert.AreEqual(result, "Valid");
        }
        [TestMethod]
        public void GivenUserPasswordRule1_WhenAnalyze_ShouldReturnValid()
        {
            string password1 = "13161316";
            string result=user.Password_Rule1(password1);
            Assert.AreEqual(result, "Valid");
        }
        [TestMethod]
        public void GivenUserPasswordRule2_WhenAnalyze_ShouldReturnValid()
        {
            string password2 = "Somu3411";
            string result = user.Password_Rule2(password2);
            Assert.AreEqual(result, "Valid");
        }
    }
}