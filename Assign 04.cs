/*04 Generics
Test your Knowledge
1. Describe the problem generics address.
    Generics can address safety problem and unwanted boxing when using object.

2. How would you create a list of strings, using the generic List class?
    List<T>

3.How many generic type parameters does the Dictionary class have?
    Two: TKey and TValue.

4.True/False.When a generic class has multiple type parameters, they must all match.
    FALSE

5. What method is used to add items to a List object?
    List.Add() Method

6. Name two methods that cause items to be removed from a List.
    List.Remove() or List.RemoveAt().

7. How do you indicate that a class has a generic type parameter?
    A generic type is declared by specifying a type parameter in an angle brackets after a type name -- <T>

8. True/False. Generic classes can only have one generic type parameter.
    FALSE

9. True/False. Generic type constraints limit what can be used for the generic type.
    TRUE
    
10. True/False. Constraints let you use the methods of the thing you are constraining to.
    TRUE
*/

/*Practice working with Generics
1. Create a custom Stack class MyStack<T> that can be used with any data type which has following methods：
    1.int Count()
    2.T Pop()
    3.Void Push()

public class MyStack<T> 
{
    public int Count { get; }
    public T Pop(T a)
    {
        return a;
    }
    public void Push(T a)
    {
        Console.WriteLine(a);
    }
}

2.Create a Generic List data structure MyList<T> that can store any data type.Implement the following methods：
    1.void Add (T element)
    2.T Remove(int index)
    3.bool Contains(T element)
    4.void Clear()
    5.void InsertAt(T element, int index)
    6.void DeleteAt(int index)
    7.T Find(int index)

public class MyList<T>
{
    List<T> Mylist =  new List<T>();
     public void Add(T a)
    {
        Mylist.Add(a);
    }
    public T Remove(int i)
    {
        return Mylist[i];
    }
    public bool Contains(T a)
    {
        return Mylist.Contains(a);
    }
    public void Clear()
    {
        Mylist.Clear();
    }
    public void InsertAt(T a, int i) 
    { 
        Mylist[i] = a; 
    }
    public void DeleteAt(int i)
    {
        Mylist.RemoveAt(i);
    }
    public T Find(int i)
    {
        T a = Mylist[i];
        return a;
    }
}

3.Implement a GenericRepository<T> class that implements IRepository<T> interface that will have common /CRUD/ operations 
so that it can work with any data source such as SQL Server, Oracle, In-Memory Data etc. 
Make sure you have a type constraint on T were it should be of reference type and can be of type Entity 
which has one property called Id. IRepository<T> should have following methods：
    1. void Add(T item)
    2. void Remove(T item)
    3.Void Save()
    4.IEnumerable < T > GetAll()
    5.T GetById(int id) */
public interface IRepository<T> where T: class
{
    void Add(T item);
    void Remove(T item);
    void Save();
    IEnumerable<T> GetAll();
    T GetById (int id);
}

public class Person
{
    public int Id { get; set; }
    public string Name { get; set; }
}

public class GenericRepository : IRepository<Person>
{
    List<Person> list = new List<Person> ();
    public void Add(Person id)
    {
        list.Add (id);
    }

    public IEnumerable<Person> GetAll()
    {
        return list;
    }

    public Person GetById(int id)
    {
        for (int i = 0; i < list.Count; i++)
        {
            if (list[i].Id == id)
            {
                return list[i];
            }
        }
        return null;
    }

    public void Remove(Person id)
    {
        list.Remove(id);
    }

    public void Save()
    {
        Console.WriteLine();
    }

}
