namespace SwinAdventureTests;
using NUnit.Framework;
using SwinAdventure;

public class IdentifiableObjectTest
{
    private IdentifiableObject testObject;
    private string[] holder = new[] { "Fred", "Bob" };
    private IdentifiableObject empty;
    private string[] emptiness = new string[] { };
    

    [SetUp]
    public void Setup()
    {
        testObject = new IdentifiableObject(holder);
        empty = new IdentifiableObject(emptiness);
    }

    [Test]
    public void TestAreYou()
    {
        Assert.IsTrue(testObject.AreYou("bob"));
    }
    [Test]
    public void TestNotAreYou()
    {
        Assert.IsFalse(testObject.AreYou("Wilma"));
    }
    [Test]
    public void TestCaseSensitive()
    {
        Assert.IsTrue(testObject.AreYou("FRED"));
        Assert.IsTrue(testObject.AreYou("bOB"));
    }
    [Test]
    public void TestFirstID()
    {
        Assert.That(testObject.FirstID, Is.EqualTo("Fred"));
        Assert.That(testObject.FirstID, Is.Not.EqualTo("Wilma"));
    }
    [Test]
    public void TestNoIDS()
    {
        Assert.That(empty.FirstID, Is.EqualTo(""));
    }
    public void TestAddID()
    {
        testObject.AddIdentifier("Wilma");
        Assert.IsTrue(testObject.AreYou("Bob"));
        Assert.IsTrue(testObject.AreYou("Fred"));
        Assert.IsTrue(testObject.AreYou("Wilma"));
    }
}