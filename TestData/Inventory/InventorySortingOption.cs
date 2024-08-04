namespace SaucedemoTestTask.TestData.Inventory
{
    public class InventorySortingOption
    {
        public static IEnumerable<TestCaseData> GetSortOptions()
        {
            yield return new TestCaseData("az").SetName("Sort by Name A to Z");
            yield return new TestCaseData("za").SetName("Sort by Name Z to A");
            yield return new TestCaseData("lohi").SetName("Sort by Price Low to Hi");
            yield return new TestCaseData("hilo").SetName("Sort by Price Hi to Low");
        }
    }
}
