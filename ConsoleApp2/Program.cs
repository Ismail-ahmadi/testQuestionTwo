public class MyGenericClass<T>
{
    private T item;

    public MyGenericClass(T item)
    {
        this.item = item;
    }

    public T GetItem()
    {
        return item;
    }
}
public class Program
{
    static void Main(string[] args)
    {
        MyGenericClass<int> MyGenericClassName = new MyGenericClass<int>(42);
        int item1 = MyGenericClassName.GetItem(); // item1 will be 42
        Console.WriteLine(item1); 

        MyGenericClass<string> MyGenericClassName2 = new MyGenericClass<string>("hello");
        string item2 = MyGenericClassName2.GetItem(); // item2 will be "hello"
        Console.WriteLine(item2);

    }
}
