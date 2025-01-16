public class ExampleClass
{
    public int MyProperty { get; set; }

    // Constructor to initialize the property
    public ExampleClass(int initialValue)
    {
        MyProperty = initialValue; 
    }

    public void MyMethod()
    {
        //MyProperty is guaranteed to have a value now.
        int value = MyProperty * 2;
    }
}