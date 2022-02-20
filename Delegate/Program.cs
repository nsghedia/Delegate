namespace Program;
class Program
{
    public delegate void AddNumsDelegate(int a, int b);
    public delegate string HelloDelegate(string s);

    public static void Main(string[] args)
    {
        Program p = new Program();
        p.AddNums(2, 3); // Call method by way 1

        string str = Program.Hello("Neha"); // Call method by way 2
        Console.WriteLine(str);

        // Call method by way 3 (Delegate)
        AddNumsDelegate addNumsDelegate = new AddNumsDelegate(p.AddNums);
        addNumsDelegate(2, 3); // way 1

        // Call method by way 3 (Delegate)
        HelloDelegate helloDelegate = new HelloDelegate(Program.Hello);
        helloDelegate.Invoke("Neha"); // way 2

        Console.ReadLine();
    }
    public void AddNums(int a, int b)
    {
        Console.WriteLine(a + b);
    }
    public static string Hello(string str)
    {
        return "Hello" + str;
    }
}