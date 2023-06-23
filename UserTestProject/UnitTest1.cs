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
        [TestMethod]
        public void GivenUserPasswordRule3_WhenAnalyze_ShouldReturnValid()
        {
            string password3 = "SOMUu3411";
            string result = user.Password_Rule3(password3);
            Assert.AreEqual(result, "Valid");
        }
        [TestMethod]
        public void GivenUserPasswordSpacialChar_WhenAnalyze_ShouldReturnValid()
        {
            string pass_Special = "Somu@3411";
            string result = user.Password_SpecialChar(pass_Special);
            Assert.AreEqual(result, "Valid");
        }
        [TestMethod]
        public void GivenUserAllEmails_WhenAnalyze_ShouldReturnValid()
        {

            string[] arr = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc111@abc.com", "abc-100@abc.net", " abc.100@abc.com.au", "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com", "abc@.com.my", "abc123@gmail.a", "abc123@.com", "abc123@.com.com", ".abc@abc.com", "abc()*@gmail.com", "abc..2002@gmail.com", "abc.@gmail.com", "bc@abc@gmail.com", "abc@%*.com", "abc@gmail.com.1a", "abc@gmail.com.aa.au" };
            string result = user.AllMail(arr);
            for(int i=0; i<arr.Length; i++)
            {
                if(result=="Valid")
                {
                    Assert.AreEqual(result, "Valid");
                }
                else
                {
                    Assert.AreEqual(result, "InValid");
                }
            }
            
        }
    }
}