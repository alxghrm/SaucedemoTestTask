namespace SaucedemoTestTask.TestData.Checkout
{
    public class CheckoutUsers
    {
        public static IEnumerable<TestCaseData> GetUserValues()
        {
            // Values are : firstName, lastName, postalCode
            yield return new TestCaseData("test", "user", "12345").SetName("User Checkout");
        }
    }
}
