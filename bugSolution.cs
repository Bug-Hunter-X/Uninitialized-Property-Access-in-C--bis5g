public class ExampleClass
{
    public int MyProperty { get; set; } = 0; // Solution: Initialize property

    public ExampleClass() //Or you can initialize in constructor
    {
        MyProperty = 10; 
    }

    public void MyMethod()
    {
        Console.WriteLine(MyProperty); // Now it's initialized
    }
}