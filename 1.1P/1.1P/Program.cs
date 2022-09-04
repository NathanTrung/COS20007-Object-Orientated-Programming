public class MainClass
{
    public static void Main(string[] args)
    {
        MainClass main = new MainClass();
        main.TestMethod("Wilma");
    }

    public void TestMethod(string a)
    {
        Console.WriteLine(a + "Smith");
    }
}