[TestClass]
public class testCollection{
    [TestMethod]
public void test()
{
    var possibleRolls = new possibleRolls();
    var testList = newList<int> {5, 1, 2, 4, 3, 6};
    var expectedList = new List<int> {1,2,3,4,5,6};
    Assert.AreEqual(expectedList, testList)
}
[TestMethod]
public void test2()
{
    var possibleRolls = new possibleRolls();
    var testList = newList<int> {6,2,1,3,5,4};
    var expectedList = new List<int> {1,2,3,4,5,6};
    Assert.AreEqual(expectedList, testList)
}
[TestMethod]
public void test3()
{
    var possibleRolls = new possibleRolls();
    var testList = newList<int> {1,3,4,2,6,5};
    var expectedList = new List<int> {1,2,3,4,5,6};
    Assert.AreEqual(expectedList, testList)
}
}
