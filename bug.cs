public class ExampleClass
{
    public int MyProperty { get; set; }

    public void MyMethod()
    {
        // Accessing a property that hasn't been initialized yet
        Console.WriteLine(MyProperty); // Bug: Uninitialized property
    }
}