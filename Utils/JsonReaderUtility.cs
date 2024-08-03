namespace SaucedemoTestTask.Utils
{
    public class JsonReaderUtility
    {
        public string ReadJsonFile(string filePath)
        {
            string jsonFilePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, filePath);
            return File.ReadAllText(jsonFilePath);
        }
    }
}