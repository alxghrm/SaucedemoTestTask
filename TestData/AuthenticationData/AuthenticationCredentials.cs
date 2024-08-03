using Newtonsoft.Json;
using SaucedemoTestTask.Models;
using SaucedemoTestTask.Utils;

namespace SaucedemoTestTask.TestData.AuthenticationData
{
    public class AuthenticationCredentials
    {
        public static IEnumerable<TestCaseData> CredentialsDataSource()
        {
            JsonReaderUtility jsonReaderUtility = new JsonReaderUtility();

            var contents = jsonReaderUtility.ReadJsonFile("TestData//AuthenticationData//Credentials.json");
            var credentials = JsonConvert.DeserializeObject<List<AuthenticationModel>>(contents);
            var testCases = new List<TestCaseData>();

            foreach (var test in credentials)
            {
                var testCase = new TestCaseData(test);
                testCases.Add(testCase);
            }

            return testCases;
        }
    }
}