using Microsoft.VisualStudio.TestTools.UnitTesting;
using Palindrome;

namespace PalindromeTest
{
    [TestClass]
    public class TestPalindrome
    {
        CheckPalindrome cp = new CheckPalindrome();
        [TestMethod]
        [DataRow("ana")]
        [DataRow("nurses run")]
        [DataRow("racecaR")]
        [DataRow("1221")]

        public void TestIfPalindrome(string s)
        {
            //Arrange
           
            //Act
            bool check = cp.palindrome(s);
            //Assert
            Assert.IsTrue(check);

        }
    }
}
